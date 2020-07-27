namespace StudentManagment
{
    partial class SDSAcadmey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBacadmey = new System.Windows.Forms.GroupBox();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnAddTecher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GBacadmey.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBacadmey
            // 
            this.GBacadmey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBacadmey.Controls.Add(this.button1);
            this.GBacadmey.Controls.Add(this.btnAddStudent);
            this.GBacadmey.Controls.Add(this.btnAddTecher);
            this.GBacadmey.Controls.Add(this.btnAddCourses);
            this.GBacadmey.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBacadmey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GBacadmey.Location = new System.Drawing.Point(112, 68);
            this.GBacadmey.Name = "GBacadmey";
            this.GBacadmey.Size = new System.Drawing.Size(320, 261);
            this.GBacadmey.TabIndex = 4;
            this.GBacadmey.TabStop = false;
            this.GBacadmey.Text = "SDS Acadmey";
            this.GBacadmey.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.ForeColor = System.Drawing.Color.Black;
            this.btnAddCourses.Location = new System.Drawing.Point(67, 59);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(187, 36);
            this.btnAddCourses.TabIndex = 8;
            this.btnAddCourses.Text = "Add Courses";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnAddTecher
            // 
            this.btnAddTecher.ForeColor = System.Drawing.Color.Black;
            this.btnAddTecher.Location = new System.Drawing.Point(56, 101);
            this.btnAddTecher.Name = "btnAddTecher";
            this.btnAddTecher.Size = new System.Drawing.Size(207, 43);
            this.btnAddTecher.TabIndex = 9;
            this.btnAddTecher.Text = "Add Teacher";
            this.btnAddTecher.UseVisualStyleBackColor = true;
            this.btnAddTecher.Click += new System.EventHandler(this.btnAddTecher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(61, 150);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(198, 40);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(71, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fees Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SDSAcadmey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 376);
            this.Controls.Add(this.GBacadmey);
            this.Name = "SDSAcadmey";
            this.Text = "SDS Acadmey";
            this.GBacadmey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBacadmey;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddTecher;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button button1;
    }
}

