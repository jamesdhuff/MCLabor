namespace MCLaborAdmin
{
    partial class ReportMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMainForm));
            this.EMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEmployee = new MCLaborAdmin.DSEmployee();
            this.reportLbl = new System.Windows.Forms.Label();
            this.reportCmbo = new System.Windows.Forms.ComboBox();
            this.filtersGrpBox = new System.Windows.Forms.GroupBox();
            this.jobCmbo = new System.Windows.Forms.ComboBox();
            this.workSiteCmbo = new System.Windows.Forms.ComboBox();
            this.employeeCmbo = new System.Windows.Forms.ComboBox();
            this.jobLbl = new System.Windows.Forms.Label();
            this.workSiteLbl = new System.Windows.Forms.Label();
            this.empLbl = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.runBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.EMPLOYEETableAdapter = new MCLaborAdmin.DSEmployeeTableAdapters.EMPLOYEETableAdapter();
            this.DTPayRateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPayRateList = new MCLaborAdmin.DSPayRateList();
            this.DTPayRateListTableAdapter = new MCLaborAdmin.DSPayRateListTableAdapters.DTPayRateListTableAdapter();
            this.DSWorkSiteLaborSummary = new MCLaborAdmin.DSWorkSiteLaborSummary();
            this.DTWorkSiteLaborSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTWorkSiteLaborSummaryTableAdapter = new MCLaborAdmin.DSWorkSiteLaborSummaryTableAdapters.DTWorkSiteLaborSummaryTableAdapter();
            this.DSEmpLaborDetail = new MCLaborAdmin.DSEmpLaborDetail();
            this.EMP_LABOR_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMP_LABOR_DETAILTableAdapter = new MCLaborAdmin.DSEmpLaborDetailTableAdapters.EMP_LABOR_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEmployee)).BeginInit();
            this.filtersGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPayRateListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPayRateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSWorkSiteLaborSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTWorkSiteLaborSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEmpLaborDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMP_LABOR_DETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EMPLOYEEBindingSource
            // 
            this.EMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.EMPLOYEEBindingSource.DataSource = this.DSEmployee;
            // 
            // DSEmployee
            // 
            this.DSEmployee.DataSetName = "DSEmployee";
            this.DSEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportLbl
            // 
            this.reportLbl.AutoSize = true;
            this.reportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLbl.Location = new System.Drawing.Point(12, 12);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Size = new System.Drawing.Size(57, 17);
            this.reportLbl.TabIndex = 0;
            this.reportLbl.Text = "Report";
            // 
            // reportCmbo
            // 
            this.reportCmbo.FormattingEnabled = true;
            this.reportCmbo.Items.AddRange(new object[] {
            "Employee Labor Detail",
            "Work Site Labor Summary",
            "Employee Directory",
            "Pay Rate List"});
            this.reportCmbo.Location = new System.Drawing.Point(12, 41);
            this.reportCmbo.Name = "reportCmbo";
            this.reportCmbo.Size = new System.Drawing.Size(211, 21);
            this.reportCmbo.TabIndex = 1;
            this.reportCmbo.SelectedIndexChanged += new System.EventHandler(this.reportCmbo_SelectedIndexChanged);
            // 
            // filtersGrpBox
            // 
            this.filtersGrpBox.Controls.Add(this.jobCmbo);
            this.filtersGrpBox.Controls.Add(this.workSiteCmbo);
            this.filtersGrpBox.Controls.Add(this.employeeCmbo);
            this.filtersGrpBox.Controls.Add(this.jobLbl);
            this.filtersGrpBox.Controls.Add(this.workSiteLbl);
            this.filtersGrpBox.Controls.Add(this.empLbl);
            this.filtersGrpBox.Controls.Add(this.endDatePicker);
            this.filtersGrpBox.Controls.Add(this.startDatePicker);
            this.filtersGrpBox.Controls.Add(this.endDateLbl);
            this.filtersGrpBox.Controls.Add(this.startDateLbl);
            this.filtersGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersGrpBox.Location = new System.Drawing.Point(12, 108);
            this.filtersGrpBox.Name = "filtersGrpBox";
            this.filtersGrpBox.Size = new System.Drawing.Size(211, 364);
            this.filtersGrpBox.TabIndex = 2;
            this.filtersGrpBox.TabStop = false;
            this.filtersGrpBox.Text = "Filters";
            // 
            // jobCmbo
            // 
            this.jobCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobCmbo.Enabled = false;
            this.jobCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCmbo.FormattingEnabled = true;
            this.jobCmbo.Location = new System.Drawing.Point(24, 251);
            this.jobCmbo.Name = "jobCmbo";
            this.jobCmbo.Size = new System.Drawing.Size(161, 21);
            this.jobCmbo.TabIndex = 9;
            // 
            // workSiteCmbo
            // 
            this.workSiteCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workSiteCmbo.Enabled = false;
            this.workSiteCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSiteCmbo.FormattingEnabled = true;
            this.workSiteCmbo.Location = new System.Drawing.Point(24, 206);
            this.workSiteCmbo.Name = "workSiteCmbo";
            this.workSiteCmbo.Size = new System.Drawing.Size(161, 21);
            this.workSiteCmbo.TabIndex = 8;
            // 
            // employeeCmbo
            // 
            this.employeeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCmbo.Enabled = false;
            this.employeeCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCmbo.FormattingEnabled = true;
            this.employeeCmbo.Location = new System.Drawing.Point(24, 153);
            this.employeeCmbo.Name = "employeeCmbo";
            this.employeeCmbo.Size = new System.Drawing.Size(161, 21);
            this.employeeCmbo.TabIndex = 7;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Enabled = false;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(23, 235);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(24, 13);
            this.jobLbl.TabIndex = 6;
            this.jobLbl.Text = "Job";
            // 
            // workSiteLbl
            // 
            this.workSiteLbl.AutoSize = true;
            this.workSiteLbl.Enabled = false;
            this.workSiteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSiteLbl.Location = new System.Drawing.Point(19, 190);
            this.workSiteLbl.Name = "workSiteLbl";
            this.workSiteLbl.Size = new System.Drawing.Size(54, 13);
            this.workSiteLbl.TabIndex = 5;
            this.workSiteLbl.Text = "Work Site";
            // 
            // empLbl
            // 
            this.empLbl.AutoSize = true;
            this.empLbl.Enabled = false;
            this.empLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLbl.Location = new System.Drawing.Point(21, 137);
            this.empLbl.Name = "empLbl";
            this.empLbl.Size = new System.Drawing.Size(53, 13);
            this.empLbl.TabIndex = 4;
            this.empLbl.Text = "Employee";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(24, 98);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(161, 20);
            this.endDatePicker.TabIndex = 3;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(24, 43);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(161, 20);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Enabled = false;
            this.endDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLbl.Location = new System.Drawing.Point(21, 82);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(52, 13);
            this.endDateLbl.TabIndex = 1;
            this.endDateLbl.Text = "End Date";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Enabled = false;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLbl.Location = new System.Drawing.Point(21, 27);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(55, 13);
            this.startDateLbl.TabIndex = 0;
            this.startDateLbl.Text = "Start Date";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(254, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(960, 582);
            this.reportViewer1.TabIndex = 3;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(15, 555);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(99, 39);
            this.runBtn.TabIndex = 4;
            this.runBtn.Text = "Run Report";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(124, 555);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 39);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // EMPLOYEETableAdapter
            // 
            this.EMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // DTPayRateListBindingSource
            // 
            this.DTPayRateListBindingSource.DataMember = "DTPayRateList";
            this.DTPayRateListBindingSource.DataSource = this.DSPayRateList;
            // 
            // DSPayRateList
            // 
            this.DSPayRateList.DataSetName = "DSPayRateList";
            this.DSPayRateList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTPayRateListTableAdapter
            // 
            this.DTPayRateListTableAdapter.ClearBeforeFill = true;
            // 
            // DSWorkSiteLaborSummary
            // 
            this.DSWorkSiteLaborSummary.DataSetName = "DSWorkSiteLaborSummary";
            this.DSWorkSiteLaborSummary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTWorkSiteLaborSummaryBindingSource
            // 
            this.DTWorkSiteLaborSummaryBindingSource.DataMember = "DTWorkSiteLaborSummary";
            this.DTWorkSiteLaborSummaryBindingSource.DataSource = this.DSWorkSiteLaborSummary;
            // 
            // DTWorkSiteLaborSummaryTableAdapter
            // 
            this.DTWorkSiteLaborSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // DSEmpLaborDetail
            // 
            this.DSEmpLaborDetail.DataSetName = "DSEmpLaborDetail";
            this.DSEmpLaborDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EMP_LABOR_DETAILBindingSource
            // 
            this.EMP_LABOR_DETAILBindingSource.DataMember = "EMP_LABOR_DETAIL";
            this.EMP_LABOR_DETAILBindingSource.DataSource = this.DSEmpLaborDetail;
            // 
            // EMP_LABOR_DETAILTableAdapter
            // 
            this.EMP_LABOR_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // ReportMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 606);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.filtersGrpBox);
            this.Controls.Add(this.reportCmbo);
            this.Controls.Add(this.reportLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Administration - Reports";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEmployee)).EndInit();
            this.filtersGrpBox.ResumeLayout(false);
            this.filtersGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPayRateListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPayRateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSWorkSiteLaborSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTWorkSiteLaborSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEmpLaborDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMP_LABOR_DETAILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportLbl;
        private System.Windows.Forms.ComboBox reportCmbo;
        private System.Windows.Forms.GroupBox filtersGrpBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.Label workSiteLbl;
        private System.Windows.Forms.Label empLbl;
        private System.Windows.Forms.ComboBox jobCmbo;
        private System.Windows.Forms.ComboBox workSiteCmbo;
        private System.Windows.Forms.ComboBox employeeCmbo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.BindingSource EMPLOYEEBindingSource;
        private DSEmployee DSEmployee;
        private MCLaborAdmin.DSEmployeeTableAdapters.EMPLOYEETableAdapter EMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource DTPayRateListBindingSource;
        private DSPayRateList DSPayRateList;
        private MCLaborAdmin.DSPayRateListTableAdapters.DTPayRateListTableAdapter DTPayRateListTableAdapter;
        private System.Windows.Forms.BindingSource DTWorkSiteLaborSummaryBindingSource;
        private DSWorkSiteLaborSummary DSWorkSiteLaborSummary;
        private MCLaborAdmin.DSWorkSiteLaborSummaryTableAdapters.DTWorkSiteLaborSummaryTableAdapter DTWorkSiteLaborSummaryTableAdapter;
        private System.Windows.Forms.BindingSource EMP_LABOR_DETAILBindingSource;
        private DSEmpLaborDetail DSEmpLaborDetail;
        private MCLaborAdmin.DSEmpLaborDetailTableAdapters.EMP_LABOR_DETAILTableAdapter EMP_LABOR_DETAILTableAdapter;


    }
}