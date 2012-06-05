namespace MCLaborAdmin
{
    partial class WorkSiteMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSiteMainForm));
            this.workSiteDataGridView = new System.Windows.Forms.DataGridView();
            this.workSiteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workSiteMainCloseBtn = new System.Windows.Forms.Button();
            this.workSiteMainEditBtn = new System.Windows.Forms.Button();
            this.workSiteMainAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workSiteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workSiteDataGridView
            // 
            this.workSiteDataGridView.AllowUserToAddRows = false;
            this.workSiteDataGridView.AllowUserToDeleteRows = false;
            this.workSiteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workSiteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workSiteId,
            this.refCode,
            this.workSiteName});
            this.workSiteDataGridView.Location = new System.Drawing.Point(12, 12);
            this.workSiteDataGridView.Name = "workSiteDataGridView";
            this.workSiteDataGridView.ReadOnly = true;
            this.workSiteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workSiteDataGridView.Size = new System.Drawing.Size(310, 232);
            this.workSiteDataGridView.TabIndex = 0;
            // 
            // workSiteId
            // 
            this.workSiteId.HeaderText = "workSiteId";
            this.workSiteId.Name = "workSiteId";
            this.workSiteId.ReadOnly = true;
            this.workSiteId.Visible = false;
            // 
            // refCode
            // 
            this.refCode.HeaderText = "Ref Code";
            this.refCode.Name = "refCode";
            this.refCode.ReadOnly = true;
            // 
            // workSiteName
            // 
            this.workSiteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workSiteName.HeaderText = "Work Site Name";
            this.workSiteName.Name = "workSiteName";
            this.workSiteName.ReadOnly = true;
            // 
            // workSiteMainCloseBtn
            // 
            this.workSiteMainCloseBtn.Location = new System.Drawing.Point(220, 265);
            this.workSiteMainCloseBtn.Name = "workSiteMainCloseBtn";
            this.workSiteMainCloseBtn.Size = new System.Drawing.Size(102, 33);
            this.workSiteMainCloseBtn.TabIndex = 6;
            this.workSiteMainCloseBtn.Text = "Close";
            this.workSiteMainCloseBtn.UseVisualStyleBackColor = true;
            this.workSiteMainCloseBtn.Click += new System.EventHandler(this.workSiteMainCloseBtn_Click);
            // 
            // workSiteMainEditBtn
            // 
            this.workSiteMainEditBtn.Location = new System.Drawing.Point(112, 265);
            this.workSiteMainEditBtn.Name = "workSiteMainEditBtn";
            this.workSiteMainEditBtn.Size = new System.Drawing.Size(102, 33);
            this.workSiteMainEditBtn.TabIndex = 5;
            this.workSiteMainEditBtn.Text = "Edit";
            this.workSiteMainEditBtn.UseVisualStyleBackColor = true;
            this.workSiteMainEditBtn.Click += new System.EventHandler(this.workSiteMainEditBtn_Click);
            // 
            // workSiteMainAddBtn
            // 
            this.workSiteMainAddBtn.Location = new System.Drawing.Point(12, 265);
            this.workSiteMainAddBtn.Name = "workSiteMainAddBtn";
            this.workSiteMainAddBtn.Size = new System.Drawing.Size(94, 33);
            this.workSiteMainAddBtn.TabIndex = 4;
            this.workSiteMainAddBtn.Text = "Add";
            this.workSiteMainAddBtn.UseVisualStyleBackColor = true;
            this.workSiteMainAddBtn.Click += new System.EventHandler(this.workSiteMainAddBtn_Click);
            // 
            // WorkSiteMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.workSiteMainCloseBtn);
            this.Controls.Add(this.workSiteMainEditBtn);
            this.Controls.Add(this.workSiteMainAddBtn);
            this.Controls.Add(this.workSiteDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkSiteMainForm";
            this.Text = "MCLabor Administration - Work Site Definitions";
            this.Load += new System.EventHandler(this.WorkSiteForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSiteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.workSiteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workSiteDataGridView;
        private System.Windows.Forms.Button workSiteMainCloseBtn;
        private System.Windows.Forms.Button workSiteMainEditBtn;
        private System.Windows.Forms.Button workSiteMainAddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workSiteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn workSiteName;
    }
}