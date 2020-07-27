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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        studentBAL bal = new studentBAL();
        
        private void button1_Click(object sender, EventArgs e)
        {
            CourseEntity cs = new CourseEntity();
            cs.Name = txtCourseName.Text;
            cs.Fees = long.Parse(txtFee.Text);
            cs.Duration = cbCourseDuration.SelectedItem.ToString();
            try
            {
                var res = bal.InsertCourse(cs);
                if (res > 0)
                    MessageBox.Show("Course Inserted and CourseId = "+res);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
