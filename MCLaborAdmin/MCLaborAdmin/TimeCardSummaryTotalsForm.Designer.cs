namespace MCLaborAdmin
{
    partial class TimeCardSummaryTotalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCardSummaryTotalsForm));
            this.dateRangeTxt = new System.Windows.Forms.TextBox();
            this.empNameTxt = new System.Windows.Forms.TextBox();
            this.dateRangeLbl = new System.Windows.Forms.Label();
            this.empNameLbl = new System.Windows.Forms.Label();
            this.timeCardSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.timeCardSummaryPrintBtn = new System.Windows.Forms.Button();
            this.timeCardSummaryCloseBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timeCardSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRangeTxt
            // 
            this.dateRangeTxt.BackColor = System.Drawing.SystemColors.Control;
            this.dateRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateRangeTxt.Enabled = false;
            this.dateRangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeTxt.Location = new System.Drawing.Point(364, 12);
            this.dateRangeTxt.Name = "dateRangeTxt";
            this.dateRangeTxt.Size = new System.Drawing.Size(207, 19);
            this.dateRangeTxt.TabIndex = 7;
            // 
            // empNameTxt
            // 
            this.empNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.empNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empNameTxt.Enabled = false;
            this.empNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTxt.Location = new System.Drawing.Point(77, 12);
            this.empNameTxt.Name = "empNameTxt";
            this.empNameTxt.Size = new System.Drawing.Size(207, 19);
            this.empNameTxt.TabIndex = 6;
            // 
            // dateRangeLbl
            // 
            this.dateRangeLbl.AutoSize = true;
            this.dateRangeLbl.Location = new System.Drawing.Point(290, 17);
            this.dateRangeLbl.Name = "dateRangeLbl";
            this.dateRangeLbl.Size = new System.Drawing.Size(68, 13);
            this.dateRangeLbl.TabIndex = 5;
            this.dateRangeLbl.Text = "Date Range:";
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Location = new System.Drawing.Point(12, 17);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.Size = new System.Drawing.Size(59, 13);
            this.empNameLbl.TabIndex = 4;
            this.empNameLbl.Text = "Employee: ";
            // 
            // timeCardSummaryDataGridView
            // 
            this.timeCardSummaryDataGridView.AllowUserToAddRows = false;
            this.timeCardSummaryDataGridView.AllowUserToDeleteRows = false;
            this.timeCardSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeCardSummaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.workSiteName,
            this.jobName,
            this.daysWorked,
            this.totalHours});
            this.timeCardSummaryDataGridView.Location = new System.Drawing.Point(12, 46);
            this.timeCardSummaryDataGridView.Name = "timeCardSummaryDataGridView";
            this.timeCardSummaryDataGridView.ReadOnly = true;
            this.timeCardSummaryDataGridView.Size = new System.Drawing.Size(568, 326);
            this.timeCardSummaryDataGridView.TabIndex = 8;
            // 
            // timeCardSummaryPrintBtn
            // 
            this.timeCardSummaryPrintBtn.Location = new System.Drawing.Point(12, 389);
            this.timeCardSummaryPrintBtn.Name = "timeCardSummaryPrintBtn";
            this.timeCardSummaryPrintBtn.Size = new System.Drawing.Size(123, 33);
            this.timeCardSummaryPrintBtn.TabIndex = 9;
            this.timeCardSummaryPrintBtn.Text = "Print";
            this.timeCardSummaryPrintBtn.UseVisualStyleBackColor = true;
            this.timeCardSummaryPrintBtn.Click += new System.EventHandler(this.timeCardSummaryPrintBtn_Click);
            // 
            // timeCardSummaryCloseBtn
            // 
            this.timeCardSummaryCloseBtn.Location = new System.Drawing.Point(161, 389);
            this.timeCardSummaryCloseBtn.Name = "timeCardSummaryCloseBtn";
            this.timeCardSummaryCloseBtn.Size = new System.Drawing.Size(123, 33);
            this.timeCardSummaryCloseBtn.TabIndex = 10;
            this.timeCardSummaryCloseBtn.Text = "Close";
            this.timeCardSummaryCloseBtn.UseVisualStyleBackColor = true;
            this.timeCardSummaryCloseBtn.Click += new System.EventHandler(this.timeCardSummaryCloseBtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // workSiteName
            // 
            this.workSiteName.HeaderText = "Work Site";
            this.workSiteName.Name = "workSiteName";
            this.workSiteName.ReadOnly = true;
            this.workSiteName.Width = 175;
            // 
            // jobName
            // 
            this.jobName.HeaderText = "Job";
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            this.jobName.Width = 150;
            // 
            // daysWorked
            // 
            this.daysWorked.HeaderText = "# Days Worked";
            this.daysWorked.Name = "daysWorked";
            this.daysWorked.ReadOnly = true;
            // 
            // totalHours
            // 
            this.totalHours.HeaderText = "Total Hours";
            this.totalHours.Name = "totalHours";
            this.totalHours.ReadOnly = true;
            // 
            // TimeCardSummaryTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 434);
            this.Controls.Add(this.timeCardSummaryCloseBtn);
            this.Controls.Add(this.timeCardSummaryPrintBtn);
            this.Controls.Add(this.timeCardSummaryDataGridView);
            this.Controls.Add(this.dateRangeTxt);
            this.Controls.Add(this.empNameTxt);
            this.Controls.Add(this.dateRangeLbl);
            this.Controls.Add(this.empNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeCardSummaryTotalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Administration - Time Card Summary";
            this.Load += new System.EventHandler(this.TimeCardSummaryTotalsForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCardSummaryTotalsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.timeCardSummaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateRangeTxt;
        private System.Windows.Forms.TextBox empNameTxt;
        private System.Windows.Forms.Label dateRangeLbl;
        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.DataGridView timeCardSummaryDataGridView;
        private System.Windows.Forms.Button timeCardSummaryPrintBtn;
        private System.Windows.Forms.Button timeCardSummaryCloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn workSiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHours;
    }
}