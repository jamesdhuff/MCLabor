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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMainForm));
            this.empDirectoryRptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empDirectoryRptBtn
            // 
            this.empDirectoryRptBtn.Location = new System.Drawing.Point(12, 12);
            this.empDirectoryRptBtn.Name = "empDirectoryRptBtn";
            this.empDirectoryRptBtn.Size = new System.Drawing.Size(109, 42);
            this.empDirectoryRptBtn.TabIndex = 0;
            this.empDirectoryRptBtn.Text = "Employee Directory";
            this.empDirectoryRptBtn.UseVisualStyleBackColor = true;
            this.empDirectoryRptBtn.Click += new System.EventHandler(this.empDirectoryRptBtn_Click);
            // 
            // ReportMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 262);
            this.Controls.Add(this.empDirectoryRptBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportMainForm";
            this.Text = "MCLabor Administration - Reports";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empDirectoryRptBtn;
    }
}