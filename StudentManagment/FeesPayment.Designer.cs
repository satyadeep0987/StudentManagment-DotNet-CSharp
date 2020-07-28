namespace StudentManagment
{
    partial class FeesPayment
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
            this.components = new System.ComponentModel.Container();
            this.GbPayFee = new System.Windows.Forms.GroupBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTotalFee = new System.Windows.Forms.ComboBox();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet2 = new StudentManagment.StudentDataSet2();
            this.txtCollege = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.txtRemainingFee = new System.Windows.Forms.TextBox();
            this.txtAddFee = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFeesPaid = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFees = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFeesPaid = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new StudentManagment.StudentDataSet();
            this.lblStudentFees = new System.Windows.Forms.Label();
            this.courseTableAdapter = new StudentManagment.StudentDataSetTableAdapters.CourseTableAdapter();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new StudentManagment.StudentDataSet2TableAdapters.CourseTableAdapter();
            this.GbPayFee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbPayFee
            // 
            this.GbPayFee.Controls.Add(this.txtStudentId);
            this.GbPayFee.Controls.Add(this.btnView);
            this.GbPayFee.Controls.Add(this.label2);
            this.GbPayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPayFee.Location = new System.Drawing.Point(142, 48);
            this.GbPayFee.Name = "GbPayFee";
            this.GbPayFee.Size = new System.Drawing.Size(423, 70);
            this.GbPayFee.TabIndex = 0;
            this.GbPayFee.TabStop = false;
            this.GbPayFee.Text = "Pay Fee";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(135, 24);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 29);
            this.txtStudentId.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(288, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 36);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTotalFee);
            this.groupBox2.Controls.Add(this.txtCollege);
            this.groupBox2.Controls.Add(this.cbCourse);
            this.groupBox2.Controls.Add(this.txtRemainingFee);
            this.groupBox2.Controls.Add(this.txtAddFee);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.txtFeesPaid);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddFees);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblFeesPaid);
            this.groupBox2.Controls.Add(this.lblMobile);
            this.groupBox2.Controls.Add(this.lblCollege);
            this.groupBox2.Controls.Add(this.lblTotalFee);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Fees Detail";
            // 
            // cbTotalFee
            // 
            this.cbTotalFee.DataSource = this.courseBindingSource2;
            this.cbTotalFee.DisplayMember = "fees";
            this.cbTotalFee.Enabled = false;
            this.cbTotalFee.FormattingEnabled = true;
            this.cbTotalFee.Location = new System.Drawing.Point(114, 115);
            this.cbTotalFee.Name = "cbTotalFee";
            this.cbTotalFee.Size = new System.Drawing.Size(206, 32);
            this.cbTotalFee.TabIndex = 24;
            this.cbTotalFee.ValueMember = "CID";
            this.cbTotalFee.SelectedIndexChanged += new System.EventHandler(this.cbTotalFee_SelectedIndexChanged);
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.studentDataSet2;
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "StudentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCollege
            // 
            this.txtCollege.Location = new System.Drawing.Point(461, 113);
            this.txtCollege.Name = "txtCollege";
            this.txtCollege.Size = new System.Drawing.Size(121, 29);
            this.txtCollege.TabIndex = 23;
            this.txtCollege.TextChanged += new System.EventHandler(this.txtCollege_TextChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.DataSource = this.courseBindingSource2;
            this.cbCourse.DisplayMember = "CourseName";
            this.cbCourse.Enabled = false;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(461, 72);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 32);
            this.cbCourse.TabIndex = 22;
            this.cbCourse.ValueMember = "CID";
            // 
            // txtRemainingFee
            // 
            this.txtRemainingFee.Location = new System.Drawing.Point(461, 151);
            this.txtRemainingFee.Name = "txtRemainingFee";
            this.txtRemainingFee.ReadOnly = true;
            this.txtRemainingFee.Size = new System.Drawing.Size(121, 29);
            this.txtRemainingFee.TabIndex = 21;
            // 
            // txtAddFee
            // 
            this.txtAddFee.Location = new System.Drawing.Point(265, 196);
            this.txtAddFee.Name = "txtAddFee";
            this.txtAddFee.Size = new System.Drawing.Size(100, 29);
            this.txtAddFee.TabIndex = 20;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(461, 37);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(121, 29);
            this.txtMobile.TabIndex = 19;
            // 
            // txtFeesPaid
            // 
            this.txtFeesPaid.Location = new System.Drawing.Point(114, 151);
            this.txtFeesPaid.Name = "txtFeesPaid";
            this.txtFeesPaid.ReadOnly = true;
            this.txtFeesPaid.Size = new System.Drawing.Size(206, 29);
            this.txtFeesPaid.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 29);
            this.txtEmail.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(220, 40);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 29);
            this.txtSurname.TabIndex = 15;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(114, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 29);
            this.txtFirstName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Fee";
            // 
            // btnAddFees
            // 
            this.btnAddFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFees.Location = new System.Drawing.Point(265, 248);
            this.btnAddFees.Name = "btnAddFees";
            this.btnAddFees.Size = new System.Drawing.Size(100, 36);
            this.btnAddFees.TabIndex = 12;
            this.btnAddFees.Text = "SUBMITT";
            this.btnAddFees.UseVisualStyleBackColor = true;
            this.btnAddFees.Click += new System.EventHandler(this.btnAddFees_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Remaining Fee";
            // 
            // lblFeesPaid
            // 
            this.lblFeesPaid.AutoSize = true;
            this.lblFeesPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesPaid.Location = new System.Drawing.Point(17, 157);
            this.lblFeesPaid.Name = "lblFeesPaid";
            this.lblFeesPaid.Size = new System.Drawing.Size(80, 20);
            this.lblFeesPaid.TabIndex = 9;
            this.lblFeesPaid.Text = "Fees Paid";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(344, 43);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(83, 20);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "Mobile No.";
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(344, 118);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(62, 20);
            this.lblCollege.TabIndex = 7;
            this.lblCollege.Text = "College";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(17, 122);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(76, 20);
            this.lblTotalFee.TabIndex = 6;
            this.lblTotalFee.Text = "Total Fee";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(344, 78);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(60, 20);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "Course";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStudentFees
            // 
            this.lblStudentFees.AutoSize = true;
            this.lblStudentFees.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFees.ForeColor = System.Drawing.Color.Navy;
            this.lblStudentFees.Location = new System.Drawing.Point(281, 15);
            this.lblStudentFees.Name = "lblStudentFees";
            this.lblStudentFees.Size = new System.Drawing.Size(211, 32);
            this.lblStudentFees.TabIndex = 2;
            this.lblStudentFees.Text = "Student Fees";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.studentDataSet;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // FeesPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.lblStudentFees);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbPayFee);
            this.Name = "FeesPayment";
            this.Text = "FeesPayment";
            this.Load += new System.EventHandler(this.FeesPayment_Load);
            this.GbPayFee.ResumeLayout(false);
            this.GbPayFee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbPayFee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentFees;
        private System.Windows.Forms.TextBox txtRemainingFee;
        private System.Windows.Forms.TextBox txtAddFee;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFeesPaid;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFees;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFeesPaid;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StudentDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.TextBox txtCollege;
        private System.Windows.Forms.ComboBox cbTotalFee;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private StudentDataSet2 studentDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private StudentDataSet2TableAdapters.CourseTableAdapter courseTableAdapter1;
    }
}