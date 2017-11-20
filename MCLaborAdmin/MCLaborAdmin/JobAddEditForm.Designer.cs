namespace MCLaborAdmin
{
    partial class JobAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobAddEditForm));
            this.jobAddEditSaveBtn = new System.Windows.Forms.Button();
            this.jobAddEditNameTxt = new System.Windows.Forms.TextBox();
            this.jobAddEditNameLbl = new System.Windows.Forms.Label();
            this.jobAddEditRefCodeLbl = new System.Windows.Forms.Label();
            this.jobAddEditRefCodeTxt = new System.Windows.Forms.TextBox();
            this.jobAddEditDescriptionLbl = new System.Windows.Forms.Label();
            this.jobAddEditDescriptionTxt = new System.Windows.Forms.TextBox();
            this.jobAddEditCancelBtn = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // jobAddEditSaveBtn
            // 
            this.jobAddEditSaveBtn.Location = new System.Drawing.Point(103, 191);
            this.jobAddEditSaveBtn.Name = "jobAddEditSaveBtn";
            this.jobAddEditSaveBtn.Size = new System.Drawing.Size(111, 35);
            this.jobAddEditSaveBtn.TabIndex = 0;
            this.jobAddEditSaveBtn.Text = "Save";
            this.jobAddEditSaveBtn.UseVisualStyleBackColor = true;
            this.jobAddEditSaveBtn.Click += new System.EventHandler(this.jobAddEditSaveBtn_Click);
            // 
            // jobAddEditNameTxt
            // 
            this.jobAddEditNameTxt.Location = new System.Drawing.Point(103, 25);
            this.jobAddEditNameTxt.Name = "jobAddEditNameTxt";
            this.jobAddEditNameTxt.Size = new System.Drawing.Size(237, 20);
            this.jobAddEditNameTxt.TabIndex = 1;
            // 
            // jobAddEditNameLbl
            // 
            this.jobAddEditNameLbl.AutoSize = true;
            this.jobAddEditNameLbl.Location = new System.Drawing.Point(27, 28);
            this.jobAddEditNameLbl.Name = "jobAddEditNameLbl";
            this.jobAddEditNameLbl.Size = new System.Drawing.Size(55, 13);
            this.jobAddEditNameLbl.TabIndex = 2;
            this.jobAddEditNameLbl.Text = "Job Name";
            // 
            // jobAddEditRefCodeLbl
            // 
            this.jobAddEditRefCodeLbl.AutoSize = true;
            this.jobAddEditRefCodeLbl.Location = new System.Drawing.Point(27, 63);
            this.jobAddEditRefCodeLbl.Name = "jobAddEditRefCodeLbl";
            this.jobAddEditRefCodeLbl.Size = new System.Drawing.Size(52, 13);
            this.jobAddEditRefCodeLbl.TabIndex = 4;
            this.jobAddEditRefCodeLbl.Text = "Ref Code";
            // 
            // jobAddEditRefCodeTxt
            // 
            this.jobAddEditRefCodeTxt.Location = new System.Drawing.Point(103, 60);
            this.jobAddEditRefCodeTxt.Name = "jobAddEditRefCodeTxt";
            this.jobAddEditRefCodeTxt.Size = new System.Drawing.Size(237, 20);
            this.jobAddEditRefCodeTxt.TabIndex = 3;
            // 
            // jobAddEditDescriptionLbl
            // 
            this.jobAddEditDescriptionLbl.AutoSize = true;
            this.jobAddEditDescriptionLbl.Location = new System.Drawing.Point(27, 99);
            this.jobAddEditDescriptionLbl.Name = "jobAddEditDescriptionLbl";
            this.jobAddEditDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.jobAddEditDescriptionLbl.TabIndex = 6;
            this.jobAddEditDescriptionLbl.Text = "Description";
            // 
            // jobAddEditDescriptionTxt
            // 
            this.jobAddEditDescriptionTxt.Location = new System.Drawing.Point(103, 96);
            this.jobAddEditDescriptionTxt.Name = "jobAddEditDescriptionTxt";
            this.jobAddEditDescriptionTxt.Size = new System.Drawing.Size(237, 20);
            this.jobAddEditDescriptionTxt.TabIndex = 5;
            // 
            // jobAddEditCancelBtn
            // 
            this.jobAddEditCancelBtn.Location = new System.Drawing.Point(235, 191);
            this.jobAddEditCancelBtn.Name = "jobAddEditCancelBtn";
            this.jobAddEditCancelBtn.Size = new System.Drawing.Size(111, 35);
            this.jobAddEditCancelBtn.TabIndex = 7;
            this.jobAddEditCancelBtn.Text = "Cancel";
            this.jobAddEditCancelBtn.UseVisualStyleBackColor = true;
            this.jobAddEditCancelBtn.Click += new System.EventHandler(this.jobAddEditCancelBtn_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsActive.Location = new System.Drawing.Point(29, 136);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(0);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 9;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // JobAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 240);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.jobAddEditCancelBtn);
            this.Controls.Add(this.jobAddEditDescriptionLbl);
            this.Controls.Add(this.jobAddEditDescriptionTxt);
            this.Controls.Add(this.jobAddEditRefCodeLbl);
            this.Controls.Add(this.jobAddEditRefCodeTxt);
            this.Controls.Add(this.jobAddEditNameLbl);
            this.Controls.Add(this.jobAddEditNameTxt);
            this.Controls.Add(this.jobAddEditSaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a New Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobAddEditForm_FormClosing);
            this.Load += new System.EventHandler(this.JobAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jobAddEditSaveBtn;
        private System.Windows.Forms.TextBox jobAddEditNameTxt;
        private System.Windows.Forms.Label jobAddEditNameLbl;
        private System.Windows.Forms.Label jobAddEditRefCodeLbl;
        private System.Windows.Forms.TextBox jobAddEditRefCodeTxt;
        private System.Windows.Forms.Label jobAddEditDescriptionLbl;
        private System.Windows.Forms.TextBox jobAddEditDescriptionTxt;
        private System.Windows.Forms.Button jobAddEditCancelBtn;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}