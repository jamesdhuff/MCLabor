namespace MCLaborAdmin
{
    partial class TimeCardReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCardReviewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeCardReviewEmpNameTxt = new System.Windows.Forms.TextBox();
            this.timeCardReviewDateRangeTxt = new System.Windows.Forms.TextBox();
            this.timeCardDataGridView = new System.Windows.Forms.DataGridView();
            this.laborDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCardReviewAddBtn = new System.Windows.Forms.Button();
            this.timeCardReviewEditBtn = new System.Windows.Forms.Button();
            this.timeCardReviewCloseBtn = new System.Windows.Forms.Button();
            this.timeCardReviewSummaryTotalsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeCardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Range:";
            // 
            // timeCardReviewEmpNameTxt
            // 
            this.timeCardReviewEmpNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.timeCardReviewEmpNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCardReviewEmpNameTxt.Enabled = false;
            this.timeCardReviewEmpNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardReviewEmpNameTxt.Location = new System.Drawing.Point(84, 16);
            this.timeCardReviewEmpNameTxt.Name = "timeCardReviewEmpNameTxt";
            this.timeCardReviewEmpNameTxt.Size = new System.Drawing.Size(207, 19);
            this.timeCardReviewEmpNameTxt.TabIndex = 2;
            // 
            // timeCardReviewDateRangeTxt
            // 
            this.timeCardReviewDateRangeTxt.BackColor = System.Drawing.SystemColors.Control;
            this.timeCardReviewDateRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCardReviewDateRangeTxt.Enabled = false;
            this.timeCardReviewDateRangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardReviewDateRangeTxt.Location = new System.Drawing.Point(393, 16);
            this.timeCardReviewDateRangeTxt.Name = "timeCardReviewDateRangeTxt";
            this.timeCardReviewDateRangeTxt.Size = new System.Drawing.Size(207, 19);
            this.timeCardReviewDateRangeTxt.TabIndex = 3;
            // 
            // timeCardDataGridView
            // 
            this.timeCardDataGridView.AllowUserToAddRows = false;
            this.timeCardDataGridView.AllowUserToDeleteRows = false;
            this.timeCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeCardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laborDetailId,
            this.calendarDate,
            this.jobName,
            this.workSiteName,
            this.localStartTime,
            this.localEndTime,
            this.totalHours});
            this.timeCardDataGridView.Location = new System.Drawing.Point(24, 53);
            this.timeCardDataGridView.Name = "timeCardDataGridView";
            this.timeCardDataGridView.ReadOnly = true;
            this.timeCardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeCardDataGridView.Size = new System.Drawing.Size(818, 516);
            this.timeCardDataGridView.TabIndex = 4;
            // 
            // laborDetailId
            // 
            this.laborDetailId.HeaderText = "laborDetailId";
            this.laborDetailId.Name = "laborDetailId";
            this.laborDetailId.ReadOnly = true;
            this.laborDetailId.Visible = false;
            // 
            // calendarDate
            // 
            this.calendarDate.HeaderText = "Date";
            this.calendarDate.Name = "calendarDate";
            this.calendarDate.ReadOnly = true;
            // 
            // jobName
            // 
            this.jobName.HeaderText = "Job";
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            this.jobName.Width = 125;
            // 
            // workSiteName
            // 
            this.workSiteName.HeaderText = "Work Site";
            this.workSiteName.Name = "workSiteName";
            this.workSiteName.ReadOnly = true;
            this.workSiteName.Width = 150;
            // 
            // localStartTime
            // 
            this.localStartTime.HeaderText = "Clock In Time";
            this.localStartTime.Name = "localStartTime";
            this.localStartTime.ReadOnly = true;
            this.localStartTime.Width = 150;
            // 
            // localEndTime
            // 
            this.localEndTime.HeaderText = "Clock Out Time";
            this.localEndTime.Name = "localEndTime";
            this.localEndTime.ReadOnly = true;
            this.localEndTime.Width = 150;
            // 
            // totalHours
            // 
            this.totalHours.HeaderText = "Total Hours";
            this.totalHours.Name = "totalHours";
            this.totalHours.ReadOnly = true;
            // 
            // timeCardReviewAddBtn
            // 
            this.timeCardReviewAddBtn.Location = new System.Drawing.Point(24, 586);
            this.timeCardReviewAddBtn.Name = "timeCardReviewAddBtn";
            this.timeCardReviewAddBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewAddBtn.TabIndex = 5;
            this.timeCardReviewAddBtn.Text = "Add";
            this.timeCardReviewAddBtn.UseVisualStyleBackColor = true;
            this.timeCardReviewAddBtn.Click += new System.EventHandler(this.timeCardReviewAddBtn_Click);
            // 
            // timeCardReviewEditBtn
            // 
            this.timeCardReviewEditBtn.Location = new System.Drawing.Point(186, 586);
            this.timeCardReviewEditBtn.Name = "timeCardReviewEditBtn";
            this.timeCardReviewEditBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewEditBtn.TabIndex = 6;
            this.timeCardReviewEditBtn.Text = "Edit";
            this.timeCardReviewEditBtn.UseVisualStyleBackColor = true;
            this.timeCardReviewEditBtn.Click += new System.EventHandler(this.timeCardReviewEditBtn_Click);
            // 
            // timeCardReviewCloseBtn
            // 
            this.timeCardReviewCloseBtn.Location = new System.Drawing.Point(505, 586);
            this.timeCardReviewCloseBtn.Name = "timeCardReviewCloseBtn";
            this.timeCardReviewCloseBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewCloseBtn.TabIndex = 7;
            this.timeCardReviewCloseBtn.Text = "Close";
            this.timeCardReviewCloseBtn.UseVisualStyleBackColor = true;
            this.timeCardReviewCloseBtn.Click += new System.EventHandler(this.timeCardReviewCloseBtn_Click);
            // 
            // timeCardReviewSummaryTotalsBtn
            // 
            this.timeCardReviewSummaryTotalsBtn.Location = new System.Drawing.Point(346, 586);
            this.timeCardReviewSummaryTotalsBtn.Name = "timeCardReviewSummaryTotalsBtn";
            this.timeCardReviewSummaryTotalsBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewSummaryTotalsBtn.TabIndex = 8;
            this.timeCardReviewSummaryTotalsBtn.Text = "Summary Totals";
            this.timeCardReviewSummaryTotalsBtn.UseVisualStyleBackColor = true;
            this.timeCardReviewSummaryTotalsBtn.Click += new System.EventHandler(this.timeCardReviewSummaryTotalsBtn_Click);
            // 
            // TimeCardReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 633);
            this.Controls.Add(this.timeCardReviewSummaryTotalsBtn);
            this.Controls.Add(this.timeCardReviewCloseBtn);
            this.Controls.Add(this.timeCardReviewEditBtn);
            this.Controls.Add(this.timeCardReviewAddBtn);
            this.Controls.Add(this.timeCardDataGridView);
            this.Controls.Add(this.timeCardReviewDateRangeTxt);
            this.Controls.Add(this.timeCardReviewEmpNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeCardReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Administration - Add/Edit Time Cards";
            this.Load += new System.EventHandler(this.TimeCardReviewForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCardReviewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.timeCardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeCardReviewEmpNameTxt;
        private System.Windows.Forms.TextBox timeCardReviewDateRangeTxt;
        private System.Windows.Forms.DataGridView timeCardDataGridView;
        private System.Windows.Forms.Button timeCardReviewAddBtn;
        private System.Windows.Forms.Button timeCardReviewEditBtn;
        private System.Windows.Forms.Button timeCardReviewCloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn workSiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn localStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn localEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHours;
        private System.Windows.Forms.Button timeCardReviewSummaryTotalsBtn;
    }
}