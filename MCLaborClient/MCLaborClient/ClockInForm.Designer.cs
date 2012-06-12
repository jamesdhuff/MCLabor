namespace MCLaborClient
{
    partial class ClockInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockInForm));
            this.empNameLbl = new System.Windows.Forms.Label();
            this.empNameTxt = new System.Windows.Forms.TextBox();
            this.workSiteLbl = new System.Windows.Forms.Label();
            this.workSiteCmbo = new System.Windows.Forms.ComboBox();
            this.jobLbl = new System.Windows.Forms.Label();
            this.jobCmbo = new System.Windows.Forms.ComboBox();
            this.clockInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLbl.Location = new System.Drawing.Point(14, 13);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.Size = new System.Drawing.Size(78, 17);
            this.empNameLbl.TabIndex = 0;
            this.empNameLbl.Text = "Employee: ";
            // 
            // empNameTxt
            // 
            this.empNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.empNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTxt.Location = new System.Drawing.Point(98, 10);
            this.empNameTxt.Name = "empNameTxt";
            this.empNameTxt.Size = new System.Drawing.Size(240, 19);
            this.empNameTxt.TabIndex = 1;
            // 
            // workSiteLbl
            // 
            this.workSiteLbl.AutoSize = true;
            this.workSiteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSiteLbl.Location = new System.Drawing.Point(11, 63);
            this.workSiteLbl.Name = "workSiteLbl";
            this.workSiteLbl.Size = new System.Drawing.Size(328, 17);
            this.workSiteLbl.TabIndex = 2;
            this.workSiteLbl.Text = "------------------   Select a Work Site   ------------------";
            // 
            // workSiteCmbo
            // 
            this.workSiteCmbo.FormattingEnabled = true;
            this.workSiteCmbo.Location = new System.Drawing.Point(12, 97);
            this.workSiteCmbo.Name = "workSiteCmbo";
            this.workSiteCmbo.Size = new System.Drawing.Size(326, 21);
            this.workSiteCmbo.TabIndex = 3;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(9, 164);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(330, 17);
            this.jobLbl.TabIndex = 4;
            this.jobLbl.Text = "----------------------   Select a Job   ----------------------";
            // 
            // jobCmbo
            // 
            this.jobCmbo.FormattingEnabled = true;
            this.jobCmbo.Location = new System.Drawing.Point(12, 197);
            this.jobCmbo.Name = "jobCmbo";
            this.jobCmbo.Size = new System.Drawing.Size(326, 21);
            this.jobCmbo.TabIndex = 5;
            // 
            // clockInBtn
            // 
            this.clockInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInBtn.Location = new System.Drawing.Point(33, 274);
            this.clockInBtn.Name = "clockInBtn";
            this.clockInBtn.Size = new System.Drawing.Size(283, 63);
            this.clockInBtn.TabIndex = 6;
            this.clockInBtn.Text = "Clock In";
            this.clockInBtn.UseVisualStyleBackColor = true;
            this.clockInBtn.Click += new System.EventHandler(this.clockInBtn_Click);
            // 
            // ClockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.clockInBtn);
            this.Controls.Add(this.jobCmbo);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.workSiteCmbo);
            this.Controls.Add(this.workSiteLbl);
            this.Controls.Add(this.empNameTxt);
            this.Controls.Add(this.empNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClockInForm";
            this.Load += new System.EventHandler(this.ClockInForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClockInForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.TextBox empNameTxt;
        private System.Windows.Forms.Label workSiteLbl;
        private System.Windows.Forms.ComboBox workSiteCmbo;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.ComboBox jobCmbo;
        private System.Windows.Forms.Button clockInBtn;
    }
}