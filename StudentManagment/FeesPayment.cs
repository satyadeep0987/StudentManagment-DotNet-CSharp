using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using EntityLayer;

namespace StudentManagment
{
    public partial class FeesPayment : Form
    {
        studentBAL bal = new studentBAL();
        StudentEntity en = new StudentEntity();
        public FeesPayment()
        {
            InitializeComponent();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeesPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet2.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.studentDataSet2.Course);
            // TODO: This line of code loads data into the 'studentDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentDataSet.Course);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                
                var r = bal.StudentProfile(int.Parse(txtStudentId.Text));
                if (r != null)
                {
                    txtFirstName.Text = r.FName;
                    txtSurname.Text = r.SName;
                    txtEmail.Text = r.Email;
                    txtMobile.Text = (r.Contact).ToString();
                    cbCourse.SelectedValue = r.CID;
                    txtCollege.Text = r.College;
                    cbTotalFee.SelectedValue = r.CID;
                    txtRemainingFee.Text = Convert.ToString(r.RemFees);
                    txtFeesPaid.Text = Convert.ToString(r.PaidFees);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTotalFee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFees_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtRemainingFee.Text) >= int.Parse(txtAddFee.Text))
                {
                    en.PaidFees = int.Parse(txtFeesPaid.Text) + int.Parse(txtAddFee.Text);
                    en.RemFees = int.Parse(txtRemainingFee.Text) - int.Parse(txtAddFee.Text);
                    en.CID = Convert.ToInt32(cbCourse.SelectedValue);
                    en.SID = int.Parse(txtStudentId.Text);

                    var res = bal.AddStudentFee(en);
                    if (res)
                        MessageBox.Show("Fee Updated");
                }
                else if (int.Parse(txtRemainingFee.Text) == 0)
                    MessageBox.Show("Total Fees Paid Succesfully No Amount Would be Charged");
                else
                    MessageBox.Show("Enter Correct Ammount Of Fee To Be Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
