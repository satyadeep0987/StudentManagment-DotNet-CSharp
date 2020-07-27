namespace StudentManagment
{
    partial class Stud
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
            this.btnNextPer = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new StudentManagment.StudentDataSet1();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new StudentManagment.StudentDataSet();
            this.AddStudent = new System.Windows.Forms.Label();
            this.pnPersonalINFO = new System.Windows.Forms.Panel();
            this.lblPersonalINfo = new System.Windows.Forms.Label();
            this.courseTableAdapter = new StudentManagment.StudentDataSetTableAdapters.CourseTableAdapter();
            this.teacherTableAdapter = new StudentManagment.StudentDataSet1TableAdapters.TeacherTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCollege = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTecher = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet2 = new StudentManagment.StudentDataSet2();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnSubbmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnEducation = new System.Windows.Forms.Panel();
            this.cbFee = new System.Windows.Forms.ComboBox();
            this.courseTableAdapter1 = new StudentManagment.StudentDataSet2TableAdapters.CourseTableAdapter();
            this.studentDataSet3 = new StudentManagment.StudentDataSet3();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter2 = new StudentManagment.StudentDataSet3TableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.pnPersonalINFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            this.pnEducation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextPer
            // 
            this.btnNextPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPer.Location = new System.Drawing.Point(296, 235);
            this.btnNextPer.Name = "btnNextPer";
            this.btnNextPer.Size = new System.Drawing.Size(134, 38);
            this.btnNextPer.TabIndex = 12;
            this.btnNextPer.Text = "Next";
            this.btnNextPer.UseVisualStyleBackColor = true;
            this.btnNextPer.Click += new System.EventHandler(this.btnNextPer_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(314, 91);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(116, 20);
            this.txtContact.TabIndex = 11;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(314, 56);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(116, 20);
            this.txtPinCode.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 130);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(110, 44);
            this.txtAddress.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(110, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(110, 56);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(110, 20);
            this.txtFName.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(226, 95);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(88, 16);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact No.";
            this.lblContact.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.ForeColor = System.Drawing.Color.Black;
            this.lblPinCode.Location = new System.Drawing.Point(229, 59);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(71, 16);
            this.lblPinCode.TabIndex = 4;
            this.lblPinCode.Text = "Pin Code";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(23, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.Black;
            this.lblAdress.Location = new System.Drawing.Point(23, 146);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(66, 16);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(23, 91);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(23, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // AddStudent
            // 
            this.AddStudent.AutoSize = true;
            this.AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent.ForeColor = System.Drawing.Color.Navy;
            this.AddStudent.Location = new System.Drawing.Point(143, 36);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(193, 25);
            this.AddStudent.TabIndex = 1;
            this.AddStudent.Text = "Add New Student";
            // 
            // pnPersonalINFO
            // 
            this.pnPersonalINFO.Controls.Add(this.lblPersonalINfo);
            this.pnPersonalINFO.Controls.Add(this.btnNextPer);
            this.pnPersonalINFO.Controls.Add(this.lblName);
            this.pnPersonalINFO.Controls.Add(this.txtContact);
            this.pnPersonalINFO.Controls.Add(this.txtFName);
            this.pnPersonalINFO.Controls.Add(this.lblContact);
            this.pnPersonalINFO.Controls.Add(this.txtPinCode);
            this.pnPersonalINFO.Controls.Add(this.lblSurname);
            this.pnPersonalINFO.Controls.Add(this.txtEmail);
            this.pnPersonalINFO.Controls.Add(this.lblPinCode);
            this.pnPersonalINFO.Controls.Add(this.txtSurname);
            this.pnPersonalINFO.Controls.Add(this.txtAddress);
            this.pnPersonalINFO.Controls.Add(this.lblAdress);
            this.pnPersonalINFO.Controls.Add(this.lblEmail);
            this.pnPersonalINFO.Location = new System.Drawing.Point(12, 121);
            this.pnPersonalINFO.Name = "pnPersonalINFO";
            this.pnPersonalINFO.Size = new System.Drawing.Size(439, 276);
            this.pnPersonalINFO.TabIndex = 3;
            this.pnPersonalINFO.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPersonalINFO_Paint);
            // 
            // lblPersonalINfo
            // 
            this.lblPersonalINfo.AutoSize = true;
            this.lblPersonalINfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalINfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPersonalINfo.Location = new System.Drawing.Point(119, 16);
            this.lblPersonalINfo.Name = "lblPersonalINfo";
            this.lblPersonalINfo.Size = new System.Drawing.Size(185, 20);
            this.lblPersonalINfo.TabIndex = 13;
            this.lblPersonalINfo.Text = "Student Personal Info";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(238, 66);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(43, 16);
            this.lblFees.TabIndex = 4;
            this.lblFees.Text = "Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // cbCollege
            // 
            this.cbCollege.FormattingEnabled = true;
            this.cbCollege.Items.AddRange(new object[] {
            "LNCT",
            "LNCTS",
            "LNCTE",
            "OIEST",
            "SIST"});
            this.cbCollege.Location = new System.Drawing.Point(102, 99);
            this.cbCollege.Name = "cbCollege";
            this.cbCollege.Size = new System.Drawing.Size(121, 21);
            this.cbCollege.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "College";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(102, 146);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtpStartDate.TabIndex = 23;
            // 
            // lblTecher
            // 
            this.lblTecher.AutoSize = true;
            this.lblTecher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecher.ForeColor = System.Drawing.Color.Black;
            this.lblTecher.Location = new System.Drawing.Point(238, 102);
            this.lblTecher.Name = "lblTecher";
            this.lblTecher.Size = new System.Drawing.Size(66, 16);
            this.lblTecher.TabIndex = 13;
            this.lblTecher.Text = "Teacher";
            this.lblTecher.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // cbCourse
            // 
            this.cbCourse.DataSource = this.courseBindingSource1;
            this.cbCourse.DisplayMember = "CourseName";
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(102, 63);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 21);
            this.cbCourse.TabIndex = 15;
            this.cbCourse.ValueMember = "CID";
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.studentDataSet2;
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "StudentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTeacher
            // 
            this.cbTeacher.DataSource = this.teacherBindingSource;
            this.cbTeacher.DisplayMember = "TeacherName";
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(309, 99);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbTeacher.TabIndex = 19;
            this.cbTeacher.ValueMember = "TID";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(102, 181);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(121, 20);
            this.dtpEndDate.TabIndex = 24;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(240, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Detail";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(309, 146);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetail.Size = new System.Drawing.Size(121, 55);
            this.txtDetail.TabIndex = 22;
            // 
            // btnSubbmit
            // 
            this.btnSubbmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubbmit.Location = new System.Drawing.Point(309, 235);
            this.btnSubbmit.Name = "btnSubbmit";
            this.btnSubbmit.Size = new System.Drawing.Size(127, 38);
            this.btnSubbmit.TabIndex = 14;
            this.btnSubbmit.Text = "Submit";
            this.btnSubbmit.UseVisualStyleBackColor = true;
            this.btnSubbmit.Click += new System.EventHandler(this.btnSubbmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(119, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Eduaction Field";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(166, 235);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(115, 38);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnEducation
            // 
            this.pnEducation.Controls.Add(this.cbFee);
            this.pnEducation.Controls.Add(this.btnPrevious);
            this.pnEducation.Controls.Add(this.label5);
            this.pnEducation.Controls.Add(this.btnSubbmit);
            this.pnEducation.Controls.Add(this.txtDetail);
            this.pnEducation.Controls.Add(this.label9);
            this.pnEducation.Controls.Add(this.label1);
            this.pnEducation.Controls.Add(this.dtpEndDate);
            this.pnEducation.Controls.Add(this.cbTeacher);
            this.pnEducation.Controls.Add(this.cbCourse);
            this.pnEducation.Controls.Add(this.lblTecher);
            this.pnEducation.Controls.Add(this.dtpStartDate);
            this.pnEducation.Controls.Add(this.label2);
            this.pnEducation.Controls.Add(this.cbCollege);
            this.pnEducation.Controls.Add(this.label3);
            this.pnEducation.Controls.Add(this.lblFees);
            this.pnEducation.Controls.Add(this.label4);
            this.pnEducation.Location = new System.Drawing.Point(12, 121);
            this.pnEducation.Name = "pnEducation";
            this.pnEducation.Size = new System.Drawing.Size(439, 276);
            this.pnEducation.TabIndex = 2;
            this.pnEducation.Tag = "";
            // 
            // cbFee
            // 
            this.cbFee.DataSource = this.courseBindingSource1;
            this.cbFee.DisplayMember = "fees";
            this.cbFee.FormattingEnabled = true;
            this.cbFee.Location = new System.Drawing.Point(309, 61);
            this.cbFee.Name = "cbFee";
            this.cbFee.Size = new System.Drawing.Size(121, 21);
            this.cbFee.TabIndex = 28;
            this.cbFee.ValueMember = "CID";
            this.cbFee.SelectedIndexChanged += new System.EventHandler(this.txtFee_SelectedIndexChanged);
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // studentDataSet3
            // 
            this.studentDataSet3.DataSetName = "StudentDataSet3";
            this.studentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.studentDataSet3;
            // 
            // courseTableAdapter2
            // 
            this.courseTableAdapter2.ClearBeforeFill = true;
            // 
            // Stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 446);
            this.Controls.Add(this.pnPersonalINFO);
            this.Controls.Add(this.pnEducation);
            this.Controls.Add(this.AddStudent);
            this.Name = "Stud";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.pnPersonalINFO.ResumeLayout(false);
            this.pnPersonalINFO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            this.pnEducation.ResumeLayout(false);
            this.pnEducation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddStudent;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnNextPer;
        private System.Windows.Forms.Panel pnPersonalINFO;
        private System.Windows.Forms.Label lblPersonalINfo;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StudentDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private StudentDataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCollege;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTecher;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnSubbmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel pnEducation;
        private StudentDataSet2 studentDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private StudentDataSet2TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.ComboBox cbFee;
        private StudentDataSet3 studentDataSet3;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private StudentDataSet3TableAdapters.CourseTableAdapter courseTableAdapter2;
    }
}