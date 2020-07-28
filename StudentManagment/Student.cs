using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BAL;


namespace StudentManagment
{
    public partial class Stud : Form
    {
        public Stud()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet3.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter2.Fill(this.studentDataSet3.Course);
            // TODO: This line of code loads data into the 'studentDataSet2.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.studentDataSet2.Course);
            // TODO: This line of code loads data into the 'studentDataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.studentDataSet1.Teacher);
            // TODO: This line of code loads data into the 'studentDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentDataSet.Course);



        }

        private void btnNextPer_Click(object sender, EventArgs e)
        {
            pnEducation.Visible = true;
            pnPersonalINFO.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnPersonalINFO.Visible = true;
            pnEducation.Visible = false;
            
        }

        private void btnSubbmit_Click(object sender, EventArgs e)
        {
           
            studentBAL bal = new studentBAL();
            StudentEntity st = new StudentEntity();

            st.FName = txtFName.Text;
            st.SName = txtSurname.Text;
            st.Address = txtAddress.Text;
            st.Email = txtEmail.Text;
            st.PinCode = long.Parse(txtPinCode.Text);
            st.Contact = long.Parse(txtContact.Text);
            st.StartDate = dtpStartDate.Value.Date.ToString();
            st.EndDate = dtpEndDate.Value.Date.ToString();
           // MessageBox.Show(cbCourse.SelectedValue +","+ cbTeacher.SelectedValue);
            st.CID = Convert.ToInt32(cbCourse.SelectedValue);
            st.TID = Convert.ToInt32(cbTeacher.SelectedValue);
            st.College = cbCollege.SelectedItem.ToString();
            st.Fee = double.Parse(cbFee.Text);
            st.Details = txtDetail.Text;
            
            try
            {
                var res = bal.InsertStudent(st);
                if (res > 0)
                    MessageBox.Show("Student Data Inserted and StudentId = " + res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnPersonalINFO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
