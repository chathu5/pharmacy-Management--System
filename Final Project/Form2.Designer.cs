namespace E165243_Final_Project
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.lblSkills = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.gbStudentRegistration = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.gbParent = new System.Windows.Forms.GroupBox();
            this.gbBasicDetails = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbStudentRegistration.SuspendLayout();
            this.gbParent.SuspendLayout();
            this.gbBasicDetails.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.AutoSize = true;
            this.linkLabelExit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExit.LinkColor = System.Drawing.Color.Red;
            this.linkLabelExit.Location = new System.Drawing.Point(653, 813);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(61, 25);
            this.linkLabelExit.TabIndex = 0;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "EXIT";
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblSkills.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.Location = new System.Drawing.Point(208, 9);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(309, 45);
            this.lblSkills.TabIndex = 1;
            this.lblSkills.Text = "Skills International";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.LinkColor = System.Drawing.Color.Red;
            this.linkLabelLogout.Location = new System.Drawing.Point(12, 813);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(78, 25);
            this.linkLabelLogout.TabIndex = 2;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout\r\n";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // gbStudentRegistration
            // 
            this.gbStudentRegistration.BackColor = System.Drawing.Color.Transparent;
            this.gbStudentRegistration.Controls.Add(this.btnDelete);
            this.gbStudentRegistration.Controls.Add(this.btnClear);
            this.gbStudentRegistration.Controls.Add(this.btnUpdate);
            this.gbStudentRegistration.Controls.Add(this.btnRegister);
            this.gbStudentRegistration.Controls.Add(this.btnClose);
            this.gbStudentRegistration.Controls.Add(this.btnSearch);
            this.gbStudentRegistration.Controls.Add(this.cmbRegNo);
            this.gbStudentRegistration.Controls.Add(this.lblRegNo);
            this.gbStudentRegistration.Controls.Add(this.gbParent);
            this.gbStudentRegistration.Controls.Add(this.gbBasicDetails);
            this.gbStudentRegistration.Controls.Add(this.gbContact);
            this.gbStudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentRegistration.Location = new System.Drawing.Point(12, 58);
            this.gbStudentRegistration.Name = "gbStudentRegistration";
            this.gbStudentRegistration.Size = new System.Drawing.Size(702, 742);
            this.gbStudentRegistration.TabIndex = 3;
            this.gbStudentRegistration.TabStop = false;
            this.gbStudentRegistration.Text = "Student Registration";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(533, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(184, 40);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(121, 28);
            this.cmbRegNo.TabIndex = 7;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(87, 43);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(77, 20);
            this.lblRegNo.TabIndex = 6;
            this.lblRegNo.Text = "Reg No:";
            // 
            // gbParent
            // 
            this.gbParent.BackColor = System.Drawing.Color.Transparent;
            this.gbParent.Controls.Add(this.txtContactNumber);
            this.gbParent.Controls.Add(this.txtNIC);
            this.gbParent.Controls.Add(this.txtParentName);
            this.gbParent.Controls.Add(this.lblContact);
            this.gbParent.Controls.Add(this.lblNIC);
            this.gbParent.Controls.Add(this.lblParent);
            this.gbParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParent.Location = new System.Drawing.Point(21, 489);
            this.gbParent.Name = "gbParent";
            this.gbParent.Size = new System.Drawing.Size(662, 163);
            this.gbParent.TabIndex = 5;
            this.gbParent.TabStop = false;
            this.gbParent.Text = "Parent Details";
            // 
            // gbBasicDetails
            // 
            this.gbBasicDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbBasicDetails.Controls.Add(this.rbFemale);
            this.gbBasicDetails.Controls.Add(this.rbMale);
            this.gbBasicDetails.Controls.Add(this.dtpDOB);
            this.gbBasicDetails.Controls.Add(this.txtLastName);
            this.gbBasicDetails.Controls.Add(this.txtFirstName);
            this.gbBasicDetails.Controls.Add(this.lblGender);
            this.gbBasicDetails.Controls.Add(this.lblDOB);
            this.gbBasicDetails.Controls.Add(this.lblLname);
            this.gbBasicDetails.Controls.Add(this.lblFname);
            this.gbBasicDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasicDetails.Location = new System.Drawing.Point(21, 85);
            this.gbBasicDetails.Name = "gbBasicDetails";
            this.gbBasicDetails.Size = new System.Drawing.Size(662, 196);
            this.gbBasicDetails.TabIndex = 4;
            this.gbBasicDetails.TabStop = false;
            this.gbBasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(284, 148);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(91, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(175, 148);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(175, 108);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 27);
            this.dtpDOB.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(175, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(391, 27);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(175, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(391, 27);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(39, 148);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(82, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(39, 113);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(130, 20);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth :";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(39, 74);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(112, 20);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name :";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(39, 36);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(114, 20);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name :";
            // 
            // gbContact
            // 
            this.gbContact.BackColor = System.Drawing.Color.Transparent;
            this.gbContact.Controls.Add(this.txtHomePhone);
            this.gbContact.Controls.Add(this.txtMobilePhone);
            this.gbContact.Controls.Add(this.txtEmail);
            this.gbContact.Controls.Add(this.txtAddress);
            this.gbContact.Controls.Add(this.lblHome);
            this.gbContact.Controls.Add(this.lblMobile);
            this.gbContact.Controls.Add(this.lblEmail);
            this.gbContact.Controls.Add(this.lblAddress);
            this.gbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContact.Location = new System.Drawing.Point(21, 305);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(662, 161);
            this.gbContact.TabIndex = 4;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact Details";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(39, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 20);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email :";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(39, 129);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(134, 20);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "Mobile Phone :";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(376, 129);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(128, 20);
            this.lblHome.TabIndex = 12;
            this.lblHome.Text = "Home Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(135, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(415, 52);
            this.txtAddress.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(135, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobilePhone.Location = new System.Drawing.Point(175, 126);
            this.txtMobilePhone.MaxLength = 10;
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(152, 27);
            this.txtMobilePhone.TabIndex = 13;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePhone.Location = new System.Drawing.Point(510, 126);
            this.txtHomePhone.MaxLength = 10;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(152, 27);
            this.txtHomePhone.TabIndex = 14;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(39, 36);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(130, 20);
            this.lblParent.TabIndex = 15;
            this.lblParent.Text = "Parent Name :";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(39, 74);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(52, 20);
            this.lblNIC.TabIndex = 16;
            this.lblNIC.Text = "NIC :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(39, 112);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(157, 20);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact Number :";
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.Location = new System.Drawing.Point(183, 29);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(415, 27);
            this.txtParentName.TabIndex = 15;
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(124, 68);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(415, 27);
            this.txtNIC.TabIndex = 18;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(202, 109);
            this.txtContactNumber.MaxLength = 10;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(415, 27);
            this.txtContactNumber.TabIndex = 19;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(63, 673);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 39);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(223, 673);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(551, 673);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 673);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 852);
            this.Controls.Add(this.gbStudentRegistration);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.linkLabelExit);
            this.Name = "FrmRegistration";
            this.Text = "Student Registration-Skills International";
            this.gbStudentRegistration.ResumeLayout(false);
            this.gbStudentRegistration.PerformLayout();
            this.gbParent.ResumeLayout(false);
            this.gbParent.PerformLayout();
            this.gbBasicDetails.ResumeLayout(false);
            this.gbBasicDetails.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelExit;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.GroupBox gbStudentRegistration;
        private System.Windows.Forms.GroupBox gbBasicDetails;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.GroupBox gbParent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
    }
}