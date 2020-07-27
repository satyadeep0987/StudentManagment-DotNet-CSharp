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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        studentBAL bal = new studentBAL();
        private void button1_Click(object sender, EventArgs e)
        {
            TeacherEntity te = new TeacherEntity();
            te.Name = txtName.Text;
            te.Sbject = cbTeacher.SelectedItem.ToString();
            string q = "";
            foreach (var d in clbQualification.CheckedItems)
                q += d+",";
            te.Qualification = q;
            try
            {
                var res = bal.InsertTeacher(te);
                if (res >0)
                    MessageBox.Show("Teacher added and Teacher Id : "+res);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet3.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentDataSet3.Course);

        }
    }
}
