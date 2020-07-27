using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagment
{
    public partial class SDSAcadmey : Form
    {
        public SDSAcadmey()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Visible = true;

        }

        private void btnAddTecher_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Visible = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Stud s = new Stud();
            s.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeesPayment fp = new FeesPayment();
            fp.Visible = true;
        }
    }
}
