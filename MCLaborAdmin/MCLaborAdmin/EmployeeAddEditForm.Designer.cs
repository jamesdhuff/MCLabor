namespace MCLaborAdmin
{
    partial class EmployeeAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAddEditForm));
            this.employeeTabControl = new System.Windows.Forms.TabControl();
            this.employeeGeneralTabPage = new System.Windows.Forms.TabPage();
            this.empSsnTxt = new System.Windows.Forms.TextBox();
            this.empSsnLbl = new System.Windows.Forms.Label();
            this.empAlternatePhoneTxt = new System.Windows.Forms.TextBox();
            this.empAlternatePhoneLbl = new System.Windows.Forms.Label();
            this.empPrimaryPhoneTxt = new System.Windows.Forms.TextBox();
            this.empZipTxt = new System.Windows.Forms.TextBox();
            this.empZipLbl = new System.Windows.Forms.Label();
            this.empStateTxt = new System.Windows.Forms.TextBox();
            this.empStateLbl = new System.Windows.Forms.Label();
            this.empCityTxt = new System.Windows.Forms.TextBox();
            this.empCityLbl = new System.Windows.Forms.Label();
            this.empAddressTxt = new System.Windows.Forms.TextBox();
            this.empAddressLbl = new System.Windows.Forms.Label();
            this.empPrimaryPhoneLbl = new System.Windows.Forms.Label();
            this.empHireStatusTabPage = new System.Windows.Forms.TabPage();
            this.empTermReasonTxt = new System.Windows.Forms.TextBox();
            this.empHireStatusTermReasonLbl = new System.Windows.Forms.Label();
            this.empHireStatusStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.empHireStatusStartDateLbl = new System.Windows.Forms.Label();
            this.empHireStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.empHireStatusTermNonRehirableRadBtn = new System.Windows.Forms.RadioButton();
            this.empHireStatusTermRehirableRadBtn = new System.Windows.Forms.RadioButton();
            this.empHireStatusUnemploymentRadBtn = new System.Windows.Forms.RadioButton();
            this.empHireStatusPartTimeRadBtn = new System.Windows.Forms.RadioButton();
            this.empHireStatusFullTimeRadBtn = new System.Windows.Forms.RadioButton();
            this.employeeJobTabPage = new System.Windows.Forms.TabPage();
            this.empJobDataGridView = new System.Windows.Forms.DataGridView();
            this.empEmergencyContactTabPage = new System.Windows.Forms.TabPage();
            this.empEcRelationshipTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empEcNameTxt = new System.Windows.Forms.TextBox();
            this.empEcPhoneTxt = new System.Windows.Forms.TextBox();
            this.empEcZipTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empEcStateTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.empEcCityTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.empEcAddressTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empFirstNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.empFirstNameTxt = new System.Windows.Forms.TextBox();
            this.empMiddleNameTxt = new System.Windows.Forms.TextBox();
            this.empLastNameTxt = new System.Windows.Forms.TextBox();
            this.empRefCodeTxt = new System.Windows.Forms.TextBox();
            this.empLoginIdTxt = new System.Windows.Forms.TextBox();
            this.empSaveBtn = new System.Windows.Forms.Button();
            this.empCancelBtn = new System.Windows.Forms.Button();
            this.empNewBtn = new System.Windows.Forms.Button();
            this.jobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobRefCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hourlyPayRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTabControl.SuspendLayout();
            this.employeeGeneralTabPage.SuspendLayout();
            this.empHireStatusTabPage.SuspendLayout();
            this.empHireStatusGroupBox.SuspendLayout();
            this.employeeJobTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empJobDataGridView)).BeginInit();
            this.empEmergencyContactTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTabControl
            // 
            this.employeeTabControl.Controls.Add(this.employeeGeneralTabPage);
            this.employeeTabControl.Controls.Add(this.empHireStatusTabPage);
            this.employeeTabControl.Controls.Add(this.employeeJobTabPage);
            this.employeeTabControl.Controls.Add(this.empEmergencyContactTabPage);
            this.employeeTabControl.Location = new System.Drawing.Point(11, 154);
            this.employeeTabControl.Name = "employeeTabControl";
            this.employeeTabControl.SelectedIndex = 0;
            this.employeeTabControl.Size = new System.Drawing.Size(424, 244);
            this.employeeTabControl.TabIndex = 0;
            // 
            // employeeGeneralTabPage
            // 
            this.employeeGeneralTabPage.Controls.Add(this.empSsnTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empSsnLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empAlternatePhoneTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empAlternatePhoneLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empPrimaryPhoneTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empZipTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empZipLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empStateTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empStateLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empCityTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empCityLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empAddressTxt);
            this.employeeGeneralTabPage.Controls.Add(this.empAddressLbl);
            this.employeeGeneralTabPage.Controls.Add(this.empPrimaryPhoneLbl);
            this.employeeGeneralTabPage.Location = new System.Drawing.Point(4, 22);
            this.employeeGeneralTabPage.Name = "employeeGeneralTabPage";
            this.employeeGeneralTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeGeneralTabPage.Size = new System.Drawing.Size(416, 218);
            this.employeeGeneralTabPage.TabIndex = 0;
            this.employeeGeneralTabPage.Text = "General Information";
            this.employeeGeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // empSsnTxt
            // 
            this.empSsnTxt.Location = new System.Drawing.Point(11, 174);
            this.empSsnTxt.Name = "empSsnTxt";
            this.empSsnTxt.Size = new System.Drawing.Size(120, 20);
            this.empSsnTxt.TabIndex = 17;
            // 
            // empSsnLbl
            // 
            this.empSsnLbl.AutoSize = true;
            this.empSsnLbl.Location = new System.Drawing.Point(8, 158);
            this.empSsnLbl.Name = "empSsnLbl";
            this.empSsnLbl.Size = new System.Drawing.Size(29, 13);
            this.empSsnLbl.TabIndex = 16;
            this.empSsnLbl.Text = "SSN";
            // 
            // empAlternatePhoneTxt
            // 
            this.empAlternatePhoneTxt.Location = new System.Drawing.Point(137, 125);
            this.empAlternatePhoneTxt.Name = "empAlternatePhoneTxt";
            this.empAlternatePhoneTxt.Size = new System.Drawing.Size(120, 20);
            this.empAlternatePhoneTxt.TabIndex = 15;
            // 
            // empAlternatePhoneLbl
            // 
            this.empAlternatePhoneLbl.AutoSize = true;
            this.empAlternatePhoneLbl.Location = new System.Drawing.Point(134, 109);
            this.empAlternatePhoneLbl.Name = "empAlternatePhoneLbl";
            this.empAlternatePhoneLbl.Size = new System.Drawing.Size(93, 13);
            this.empAlternatePhoneLbl.TabIndex = 14;
            this.empAlternatePhoneLbl.Text = "Alternate Phone #";
            // 
            // empPrimaryPhoneTxt
            // 
            this.empPrimaryPhoneTxt.Location = new System.Drawing.Point(11, 125);
            this.empPrimaryPhoneTxt.Name = "empPrimaryPhoneTxt";
            this.empPrimaryPhoneTxt.Size = new System.Drawing.Size(120, 20);
            this.empPrimaryPhoneTxt.TabIndex = 13;
            // 
            // empZipTxt
            // 
            this.empZipTxt.Location = new System.Drawing.Point(247, 77);
            this.empZipTxt.Name = "empZipTxt";
            this.empZipTxt.Size = new System.Drawing.Size(77, 20);
            this.empZipTxt.TabIndex = 12;
            // 
            // empZipLbl
            // 
            this.empZipLbl.AutoSize = true;
            this.empZipLbl.Location = new System.Drawing.Point(244, 61);
            this.empZipLbl.Name = "empZipLbl";
            this.empZipLbl.Size = new System.Drawing.Size(22, 13);
            this.empZipLbl.TabIndex = 11;
            this.empZipLbl.Text = "Zip";
            // 
            // empStateTxt
            // 
            this.empStateTxt.Location = new System.Drawing.Point(185, 77);
            this.empStateTxt.Name = "empStateTxt";
            this.empStateTxt.Size = new System.Drawing.Size(56, 20);
            this.empStateTxt.TabIndex = 10;
            // 
            // empStateLbl
            // 
            this.empStateLbl.AutoSize = true;
            this.empStateLbl.Location = new System.Drawing.Point(182, 61);
            this.empStateLbl.Name = "empStateLbl";
            this.empStateLbl.Size = new System.Drawing.Size(32, 13);
            this.empStateLbl.TabIndex = 9;
            this.empStateLbl.Text = "State";
            // 
            // empCityTxt
            // 
            this.empCityTxt.Location = new System.Drawing.Point(11, 77);
            this.empCityTxt.Name = "empCityTxt";
            this.empCityTxt.Size = new System.Drawing.Size(168, 20);
            this.empCityTxt.TabIndex = 8;
            // 
            // empCityLbl
            // 
            this.empCityLbl.AutoSize = true;
            this.empCityLbl.Location = new System.Drawing.Point(8, 61);
            this.empCityLbl.Name = "empCityLbl";
            this.empCityLbl.Size = new System.Drawing.Size(24, 13);
            this.empCityLbl.TabIndex = 7;
            this.empCityLbl.Text = "City";
            // 
            // empAddressTxt
            // 
            this.empAddressTxt.Location = new System.Drawing.Point(11, 31);
            this.empAddressTxt.Name = "empAddressTxt";
            this.empAddressTxt.Size = new System.Drawing.Size(313, 20);
            this.empAddressTxt.TabIndex = 6;
            // 
            // empAddressLbl
            // 
            this.empAddressLbl.AutoSize = true;
            this.empAddressLbl.Location = new System.Drawing.Point(8, 15);
            this.empAddressLbl.Name = "empAddressLbl";
            this.empAddressLbl.Size = new System.Drawing.Size(45, 13);
            this.empAddressLbl.TabIndex = 1;
            this.empAddressLbl.Text = "Address";
            // 
            // empPrimaryPhoneLbl
            // 
            this.empPrimaryPhoneLbl.AutoSize = true;
            this.empPrimaryPhoneLbl.Location = new System.Drawing.Point(8, 109);
            this.empPrimaryPhoneLbl.Name = "empPrimaryPhoneLbl";
            this.empPrimaryPhoneLbl.Size = new System.Drawing.Size(85, 13);
            this.empPrimaryPhoneLbl.TabIndex = 0;
            this.empPrimaryPhoneLbl.Text = "Primary Phone #";
            // 
            // empHireStatusTabPage
            // 
            this.empHireStatusTabPage.Controls.Add(this.empTermReasonTxt);
            this.empHireStatusTabPage.Controls.Add(this.empHireStatusTermReasonLbl);
            this.empHireStatusTabPage.Controls.Add(this.empHireStatusStartDatePicker);
            this.empHireStatusTabPage.Controls.Add(this.empHireStatusStartDateLbl);
            this.empHireStatusTabPage.Controls.Add(this.empHireStatusGroupBox);
            this.empHireStatusTabPage.Location = new System.Drawing.Point(4, 22);
            this.empHireStatusTabPage.Name = "empHireStatusTabPage";
            this.empHireStatusTabPage.Size = new System.Drawing.Size(416, 218);
            this.empHireStatusTabPage.TabIndex = 3;
            this.empHireStatusTabPage.Text = "Hire Status";
            this.empHireStatusTabPage.UseVisualStyleBackColor = true;
            // 
            // empTermReasonTxt
            // 
            this.empTermReasonTxt.Location = new System.Drawing.Point(204, 98);
            this.empTermReasonTxt.Multiline = true;
            this.empTermReasonTxt.Name = "empTermReasonTxt";
            this.empTermReasonTxt.Size = new System.Drawing.Size(200, 64);
            this.empTermReasonTxt.TabIndex = 4;
            this.empTermReasonTxt.Visible = false;
            // 
            // empHireStatusTermReasonLbl
            // 
            this.empHireStatusTermReasonLbl.AutoSize = true;
            this.empHireStatusTermReasonLbl.Location = new System.Drawing.Point(203, 75);
            this.empHireStatusTermReasonLbl.Name = "empHireStatusTermReasonLbl";
            this.empHireStatusTermReasonLbl.Size = new System.Drawing.Size(102, 13);
            this.empHireStatusTermReasonLbl.TabIndex = 3;
            this.empHireStatusTermReasonLbl.Text = "Termination Reason";
            this.empHireStatusTermReasonLbl.Visible = false;
            // 
            // empHireStatusStartDatePicker
            // 
            this.empHireStatusStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empHireStatusStartDatePicker.Location = new System.Drawing.Point(206, 37);
            this.empHireStatusStartDatePicker.Name = "empHireStatusStartDatePicker";
            this.empHireStatusStartDatePicker.Size = new System.Drawing.Size(118, 20);
            this.empHireStatusStartDatePicker.TabIndex = 2;
            // 
            // empHireStatusStartDateLbl
            // 
            this.empHireStatusStartDateLbl.AutoSize = true;
            this.empHireStatusStartDateLbl.Location = new System.Drawing.Point(203, 19);
            this.empHireStatusStartDateLbl.Name = "empHireStatusStartDateLbl";
            this.empHireStatusStartDateLbl.Size = new System.Drawing.Size(88, 13);
            this.empHireStatusStartDateLbl.TabIndex = 1;
            this.empHireStatusStartDateLbl.Text = "Status Start Date";
            // 
            // empHireStatusGroupBox
            // 
            this.empHireStatusGroupBox.Controls.Add(this.empHireStatusTermNonRehirableRadBtn);
            this.empHireStatusGroupBox.Controls.Add(this.empHireStatusTermRehirableRadBtn);
            this.empHireStatusGroupBox.Controls.Add(this.empHireStatusUnemploymentRadBtn);
            this.empHireStatusGroupBox.Controls.Add(this.empHireStatusPartTimeRadBtn);
            this.empHireStatusGroupBox.Controls.Add(this.empHireStatusFullTimeRadBtn);
            this.empHireStatusGroupBox.Location = new System.Drawing.Point(13, 19);
            this.empHireStatusGroupBox.Name = "empHireStatusGroupBox";
            this.empHireStatusGroupBox.Size = new System.Drawing.Size(174, 143);
            this.empHireStatusGroupBox.TabIndex = 0;
            this.empHireStatusGroupBox.TabStop = false;
            this.empHireStatusGroupBox.Text = "Hire Status";
            // 
            // empHireStatusTermNonRehirableRadBtn
            // 
            this.empHireStatusTermNonRehirableRadBtn.AutoSize = true;
            this.empHireStatusTermNonRehirableRadBtn.Location = new System.Drawing.Point(14, 111);
            this.empHireStatusTermNonRehirableRadBtn.Name = "empHireStatusTermNonRehirableRadBtn";
            this.empHireStatusTermNonRehirableRadBtn.Size = new System.Drawing.Size(152, 17);
            this.empHireStatusTermNonRehirableRadBtn.TabIndex = 4;
            this.empHireStatusTermNonRehirableRadBtn.TabStop = true;
            this.empHireStatusTermNonRehirableRadBtn.Text = "Terminated - Not Rehirable";
            this.empHireStatusTermNonRehirableRadBtn.UseVisualStyleBackColor = true;
            // 
            // empHireStatusTermRehirableRadBtn
            // 
            this.empHireStatusTermRehirableRadBtn.AutoSize = true;
            this.empHireStatusTermRehirableRadBtn.Location = new System.Drawing.Point(14, 88);
            this.empHireStatusTermRehirableRadBtn.Name = "empHireStatusTermRehirableRadBtn";
            this.empHireStatusTermRehirableRadBtn.Size = new System.Drawing.Size(132, 17);
            this.empHireStatusTermRehirableRadBtn.TabIndex = 3;
            this.empHireStatusTermRehirableRadBtn.TabStop = true;
            this.empHireStatusTermRehirableRadBtn.Text = "Terminated - Rehirable";
            this.empHireStatusTermRehirableRadBtn.UseVisualStyleBackColor = true;
            // 
            // empHireStatusUnemploymentRadBtn
            // 
            this.empHireStatusUnemploymentRadBtn.AutoSize = true;
            this.empHireStatusUnemploymentRadBtn.Location = new System.Drawing.Point(15, 65);
            this.empHireStatusUnemploymentRadBtn.Name = "empHireStatusUnemploymentRadBtn";
            this.empHireStatusUnemploymentRadBtn.Size = new System.Drawing.Size(143, 17);
            this.empHireStatusUnemploymentRadBtn.TabIndex = 2;
            this.empHireStatusUnemploymentRadBtn.TabStop = true;
            this.empHireStatusUnemploymentRadBtn.Text = "Laid Off / Unemployment";
            this.empHireStatusUnemploymentRadBtn.UseVisualStyleBackColor = true;
            // 
            // empHireStatusPartTimeRadBtn
            // 
            this.empHireStatusPartTimeRadBtn.AutoSize = true;
            this.empHireStatusPartTimeRadBtn.Location = new System.Drawing.Point(15, 42);
            this.empHireStatusPartTimeRadBtn.Name = "empHireStatusPartTimeRadBtn";
            this.empHireStatusPartTimeRadBtn.Size = new System.Drawing.Size(70, 17);
            this.empHireStatusPartTimeRadBtn.TabIndex = 1;
            this.empHireStatusPartTimeRadBtn.TabStop = true;
            this.empHireStatusPartTimeRadBtn.Text = "Part Time";
            this.empHireStatusPartTimeRadBtn.UseVisualStyleBackColor = true;
            // 
            // empHireStatusFullTimeRadBtn
            // 
            this.empHireStatusFullTimeRadBtn.AutoSize = true;
            this.empHireStatusFullTimeRadBtn.Location = new System.Drawing.Point(15, 19);
            this.empHireStatusFullTimeRadBtn.Name = "empHireStatusFullTimeRadBtn";
            this.empHireStatusFullTimeRadBtn.Size = new System.Drawing.Size(67, 17);
            this.empHireStatusFullTimeRadBtn.TabIndex = 0;
            this.empHireStatusFullTimeRadBtn.TabStop = true;
            this.empHireStatusFullTimeRadBtn.Text = "Full Time";
            this.empHireStatusFullTimeRadBtn.UseVisualStyleBackColor = true;
            // 
            // employeeJobTabPage
            // 
            this.employeeJobTabPage.Controls.Add(this.empJobDataGridView);
            this.employeeJobTabPage.Location = new System.Drawing.Point(4, 22);
            this.employeeJobTabPage.Name = "employeeJobTabPage";
            this.employeeJobTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeJobTabPage.Size = new System.Drawing.Size(416, 218);
            this.employeeJobTabPage.TabIndex = 1;
            this.employeeJobTabPage.Text = "Job Assignment";
            this.employeeJobTabPage.UseVisualStyleBackColor = true;
            // 
            // empJobDataGridView
            // 
            this.empJobDataGridView.AllowUserToAddRows = false;
            this.empJobDataGridView.AllowUserToDeleteRows = false;
            this.empJobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empJobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobId,
            this.jobName,
            this.jobRefCode,
            this.activeFlag,
            this.hourlyPayRate});
            this.empJobDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.empJobDataGridView.Name = "empJobDataGridView";
            this.empJobDataGridView.Size = new System.Drawing.Size(424, 222);
            this.empJobDataGridView.TabIndex = 0;
            // 
            // empEmergencyContactTabPage
            // 
            this.empEmergencyContactTabPage.Controls.Add(this.empEcRelationshipTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.label6);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcNameTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcPhoneTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcZipTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.label8);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcStateTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.label9);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcCityTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.label10);
            this.empEmergencyContactTabPage.Controls.Add(this.empEcAddressTxt);
            this.empEmergencyContactTabPage.Controls.Add(this.label11);
            this.empEmergencyContactTabPage.Controls.Add(this.label12);
            this.empEmergencyContactTabPage.Controls.Add(this.label1);
            this.empEmergencyContactTabPage.Location = new System.Drawing.Point(4, 22);
            this.empEmergencyContactTabPage.Name = "empEmergencyContactTabPage";
            this.empEmergencyContactTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.empEmergencyContactTabPage.Size = new System.Drawing.Size(416, 218);
            this.empEmergencyContactTabPage.TabIndex = 2;
            this.empEmergencyContactTabPage.Text = "Emergency Contact Info";
            this.empEmergencyContactTabPage.UseVisualStyleBackColor = true;
            // 
            // empEcRelationshipTxt
            // 
            this.empEcRelationshipTxt.Location = new System.Drawing.Point(207, 30);
            this.empEcRelationshipTxt.Name = "empEcRelationshipTxt";
            this.empEcRelationshipTxt.Size = new System.Drawing.Size(120, 20);
            this.empEcRelationshipTxt.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Relationship";
            // 
            // empEcNameTxt
            // 
            this.empEcNameTxt.Location = new System.Drawing.Point(14, 30);
            this.empEcNameTxt.Name = "empEcNameTxt";
            this.empEcNameTxt.Size = new System.Drawing.Size(177, 20);
            this.empEcNameTxt.TabIndex = 29;
            // 
            // empEcPhoneTxt
            // 
            this.empEcPhoneTxt.Location = new System.Drawing.Point(14, 78);
            this.empEcPhoneTxt.Name = "empEcPhoneTxt";
            this.empEcPhoneTxt.Size = new System.Drawing.Size(120, 20);
            this.empEcPhoneTxt.TabIndex = 27;
            // 
            // empEcZipTxt
            // 
            this.empEcZipTxt.Location = new System.Drawing.Point(250, 174);
            this.empEcZipTxt.Name = "empEcZipTxt";
            this.empEcZipTxt.Size = new System.Drawing.Size(77, 20);
            this.empEcZipTxt.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Zip";
            // 
            // empEcStateTxt
            // 
            this.empEcStateTxt.Location = new System.Drawing.Point(188, 174);
            this.empEcStateTxt.Name = "empEcStateTxt";
            this.empEcStateTxt.Size = new System.Drawing.Size(56, 20);
            this.empEcStateTxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "State";
            // 
            // empEcCityTxt
            // 
            this.empEcCityTxt.Location = new System.Drawing.Point(14, 174);
            this.empEcCityTxt.Name = "empEcCityTxt";
            this.empEcCityTxt.Size = new System.Drawing.Size(168, 20);
            this.empEcCityTxt.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // empEcAddressTxt
            // 
            this.empEcAddressTxt.Location = new System.Drawing.Point(14, 128);
            this.empEcAddressTxt.Name = "empEcAddressTxt";
            this.empEcAddressTxt.Size = new System.Drawing.Size(313, 20);
            this.empEcAddressTxt.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Phone #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emergency Contact Name";
            // 
            // empFirstNameLbl
            // 
            this.empFirstNameLbl.AutoSize = true;
            this.empFirstNameLbl.Location = new System.Drawing.Point(11, 61);
            this.empFirstNameLbl.Name = "empFirstNameLbl";
            this.empFirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.empFirstNameLbl.TabIndex = 1;
            this.empFirstNameLbl.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reference Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login ID";
            // 
            // empFirstNameTxt
            // 
            this.empFirstNameTxt.Location = new System.Drawing.Point(15, 77);
            this.empFirstNameTxt.Name = "empFirstNameTxt";
            this.empFirstNameTxt.Size = new System.Drawing.Size(151, 20);
            this.empFirstNameTxt.TabIndex = 0;
            // 
            // empMiddleNameTxt
            // 
            this.empMiddleNameTxt.Location = new System.Drawing.Point(172, 77);
            this.empMiddleNameTxt.Name = "empMiddleNameTxt";
            this.empMiddleNameTxt.Size = new System.Drawing.Size(106, 20);
            this.empMiddleNameTxt.TabIndex = 1;
            // 
            // empLastNameTxt
            // 
            this.empLastNameTxt.Location = new System.Drawing.Point(284, 77);
            this.empLastNameTxt.Name = "empLastNameTxt";
            this.empLastNameTxt.Size = new System.Drawing.Size(151, 20);
            this.empLastNameTxt.TabIndex = 2;
            // 
            // empRefCodeTxt
            // 
            this.empRefCodeTxt.Location = new System.Drawing.Point(15, 123);
            this.empRefCodeTxt.Name = "empRefCodeTxt";
            this.empRefCodeTxt.Size = new System.Drawing.Size(151, 20);
            this.empRefCodeTxt.TabIndex = 3;
            // 
            // empLoginIdTxt
            // 
            this.empLoginIdTxt.Location = new System.Drawing.Point(172, 123);
            this.empLoginIdTxt.Name = "empLoginIdTxt";
            this.empLoginIdTxt.Size = new System.Drawing.Size(106, 20);
            this.empLoginIdTxt.TabIndex = 4;
            // 
            // empSaveBtn
            // 
            this.empSaveBtn.Location = new System.Drawing.Point(14, 10);
            this.empSaveBtn.Name = "empSaveBtn";
            this.empSaveBtn.Size = new System.Drawing.Size(137, 32);
            this.empSaveBtn.TabIndex = 6;
            this.empSaveBtn.Text = "Save";
            this.empSaveBtn.UseVisualStyleBackColor = true;
            this.empSaveBtn.Click += new System.EventHandler(this.empSaveBtn_Click);
            // 
            // empCancelBtn
            // 
            this.empCancelBtn.Location = new System.Drawing.Point(300, 10);
            this.empCancelBtn.Name = "empCancelBtn";
            this.empCancelBtn.Size = new System.Drawing.Size(137, 32);
            this.empCancelBtn.TabIndex = 7;
            this.empCancelBtn.Text = "Cancel";
            this.empCancelBtn.UseVisualStyleBackColor = true;
            this.empCancelBtn.Click += new System.EventHandler(this.empCancelBtn_Click);
            // 
            // empNewBtn
            // 
            this.empNewBtn.Location = new System.Drawing.Point(157, 10);
            this.empNewBtn.Name = "empNewBtn";
            this.empNewBtn.Size = new System.Drawing.Size(137, 32);
            this.empNewBtn.TabIndex = 8;
            this.empNewBtn.Text = "New";
            this.empNewBtn.UseVisualStyleBackColor = true;
            this.empNewBtn.Click += new System.EventHandler(this.empNewBtn_Click);
            // 
            // jobId
            // 
            this.jobId.HeaderText = "jobId";
            this.jobId.Name = "jobId";
            this.jobId.ReadOnly = true;
            this.jobId.Visible = false;
            // 
            // jobName
            // 
            this.jobName.HeaderText = "Job Name";
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            this.jobName.Width = 125;
            // 
            // jobRefCode
            // 
            this.jobRefCode.HeaderText = "Ref Code";
            this.jobRefCode.Name = "jobRefCode";
            this.jobRefCode.ReadOnly = true;
            this.jobRefCode.Width = 75;
            // 
            // activeFlag
            // 
            this.activeFlag.HeaderText = "Active";
            this.activeFlag.Name = "activeFlag";
            this.activeFlag.ReadOnly = true;
            this.activeFlag.Width = 75;
            // 
            // hourlyPayRate
            // 
            this.hourlyPayRate.HeaderText = "Hourly Pay Rate";
            this.hourlyPayRate.Name = "hourlyPayRate";
            // 
            // EmployeeAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 405);
            this.Controls.Add(this.empNewBtn);
            this.Controls.Add(this.empCancelBtn);
            this.Controls.Add(this.empSaveBtn);
            this.Controls.Add(this.empLoginIdTxt);
            this.Controls.Add(this.empRefCodeTxt);
            this.Controls.Add(this.empLastNameTxt);
            this.Controls.Add(this.empMiddleNameTxt);
            this.Controls.Add(this.empFirstNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empFirstNameLbl);
            this.Controls.Add(this.employeeTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeAddEditForm";
            this.Text = "MCLabor Administration - Employee Definitions";
            this.Load += new System.EventHandler(this.EmployeeAddEditForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.employeeTabControl.ResumeLayout(false);
            this.employeeGeneralTabPage.ResumeLayout(false);
            this.employeeGeneralTabPage.PerformLayout();
            this.empHireStatusTabPage.ResumeLayout(false);
            this.empHireStatusTabPage.PerformLayout();
            this.empHireStatusGroupBox.ResumeLayout(false);
            this.empHireStatusGroupBox.PerformLayout();
            this.employeeJobTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empJobDataGridView)).EndInit();
            this.empEmergencyContactTabPage.ResumeLayout(false);
            this.empEmergencyContactTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeTabControl;
        private System.Windows.Forms.TabPage employeeGeneralTabPage;
        private System.Windows.Forms.TabPage employeeJobTabPage;
        private System.Windows.Forms.Label empFirstNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empFirstNameTxt;
        private System.Windows.Forms.TextBox empMiddleNameTxt;
        private System.Windows.Forms.TextBox empLastNameTxt;
        private System.Windows.Forms.TextBox empRefCodeTxt;
        private System.Windows.Forms.TextBox empLoginIdTxt;
        private System.Windows.Forms.Label empPrimaryPhoneLbl;
        private System.Windows.Forms.TextBox empZipTxt;
        private System.Windows.Forms.Label empZipLbl;
        private System.Windows.Forms.TextBox empStateTxt;
        private System.Windows.Forms.Label empStateLbl;
        private System.Windows.Forms.TextBox empCityTxt;
        private System.Windows.Forms.Label empCityLbl;
        private System.Windows.Forms.TextBox empAddressTxt;
        private System.Windows.Forms.Label empAddressLbl;
        private System.Windows.Forms.TextBox empPrimaryPhoneTxt;
        private System.Windows.Forms.TextBox empAlternatePhoneTxt;
        private System.Windows.Forms.Label empAlternatePhoneLbl;
        private System.Windows.Forms.TextBox empSsnTxt;
        private System.Windows.Forms.Label empSsnLbl;
        private System.Windows.Forms.TabPage empEmergencyContactTabPage;
        private System.Windows.Forms.TextBox empEcRelationshipTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empEcNameTxt;
        private System.Windows.Forms.TextBox empEcPhoneTxt;
        private System.Windows.Forms.TextBox empEcZipTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empEcStateTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empEcCityTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox empEcAddressTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage empHireStatusTabPage;
        private System.Windows.Forms.Button empSaveBtn;
        private System.Windows.Forms.Button empCancelBtn;
        private System.Windows.Forms.Button empNewBtn;
        private System.Windows.Forms.GroupBox empHireStatusGroupBox;
        private System.Windows.Forms.RadioButton empHireStatusTermRehirableRadBtn;
        private System.Windows.Forms.RadioButton empHireStatusUnemploymentRadBtn;
        private System.Windows.Forms.RadioButton empHireStatusPartTimeRadBtn;
        private System.Windows.Forms.RadioButton empHireStatusFullTimeRadBtn;
        private System.Windows.Forms.RadioButton empHireStatusTermNonRehirableRadBtn;
        private System.Windows.Forms.Label empHireStatusStartDateLbl;
        private System.Windows.Forms.Label empHireStatusTermReasonLbl;
        private System.Windows.Forms.DateTimePicker empHireStatusStartDatePicker;
        private System.Windows.Forms.TextBox empTermReasonTxt;
        private System.Windows.Forms.DataGridView empJobDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRefCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyPayRate;
    }
}