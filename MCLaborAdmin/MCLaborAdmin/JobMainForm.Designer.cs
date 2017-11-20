namespace MCLaborAdmin
{
    partial class JobMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobMainForm));
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.jobEditBtn = new System.Windows.Forms.Button();
            this.jobAddBtn = new System.Windows.Forms.Button();
            this.jobCloseBtn = new System.Windows.Forms.Button();
            this.chkShowInactive = new System.Windows.Forms.CheckBox();
            this.jobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AllowUserToAddRows = false;
            this.jobDataGridView.AllowUserToDeleteRows = false;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobId,
            this.jobName,
            this.refCode,
            this.description,
            this.IsActive});
            this.jobDataGridView.Location = new System.Drawing.Point(12, 12);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.ReadOnly = true;
            this.jobDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDataGridView.Size = new System.Drawing.Size(707, 537);
            this.jobDataGridView.TabIndex = 0;
            // 
            // jobEditBtn
            // 
            this.jobEditBtn.Location = new System.Drawing.Point(190, 566);
            this.jobEditBtn.Name = "jobEditBtn";
            this.jobEditBtn.Size = new System.Drawing.Size(140, 47);
            this.jobEditBtn.TabIndex = 1;
            this.jobEditBtn.Text = "Edit";
            this.jobEditBtn.UseVisualStyleBackColor = true;
            this.jobEditBtn.Click += new System.EventHandler(this.JobEditBtn_Click);
            // 
            // jobAddBtn
            // 
            this.jobAddBtn.Location = new System.Drawing.Point(12, 566);
            this.jobAddBtn.Name = "jobAddBtn";
            this.jobAddBtn.Size = new System.Drawing.Size(140, 47);
            this.jobAddBtn.TabIndex = 0;
            this.jobAddBtn.Text = "Add";
            this.jobAddBtn.UseVisualStyleBackColor = true;
            this.jobAddBtn.Click += new System.EventHandler(this.JobAddBtn_Click);
            // 
            // jobCloseBtn
            // 
            this.jobCloseBtn.Location = new System.Drawing.Point(368, 566);
            this.jobCloseBtn.Name = "jobCloseBtn";
            this.jobCloseBtn.Size = new System.Drawing.Size(140, 47);
            this.jobCloseBtn.TabIndex = 2;
            this.jobCloseBtn.Text = "Close";
            this.jobCloseBtn.UseVisualStyleBackColor = true;
            this.jobCloseBtn.Click += new System.EventHandler(this.JobCloseBtn_Click);
            // 
            // chkShowInactive
            // 
            this.chkShowInactive.Location = new System.Drawing.Point(559, 566);
            this.chkShowInactive.Name = "chkShowInactive";
            this.chkShowInactive.Size = new System.Drawing.Size(109, 47);
            this.chkShowInactive.TabIndex = 3;
            this.chkShowInactive.Text = "Show Inactive";
            this.chkShowInactive.UseVisualStyleBackColor = true;
            this.chkShowInactive.CheckedChanged += new System.EventHandler(this.ChkShowInactive_CheckedChanged);
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
            this.jobName.MaxInputLength = 50;
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            this.jobName.Width = 150;
            // 
            // refCode
            // 
            this.refCode.HeaderText = "Ref Code";
            this.refCode.MaxInputLength = 50;
            this.refCode.Name = "refCode";
            this.refCode.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.MaxInputLength = 500;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active?";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // JobMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 625);
            this.Controls.Add(this.chkShowInactive);
            this.Controls.Add(this.jobEditBtn);
            this.Controls.Add(this.jobAddBtn);
            this.Controls.Add(this.jobCloseBtn);
            this.Controls.Add(this.jobDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobMainForm";
            this.Text = "MCLabor Administration - Job Definitions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobForm_FormClosing);
            this.Load += new System.EventHandler(this.JobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.Button jobEditBtn;
        private System.Windows.Forms.Button jobAddBtn;
        private System.Windows.Forms.Button jobCloseBtn;
        private System.Windows.Forms.CheckBox chkShowInactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}