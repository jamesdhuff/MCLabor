namespace MCLaborClient
{
    partial class ClockOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockOutForm));
            this.empNameLbl = new System.Windows.Forms.Label();
            this.empNameTxt = new System.Windows.Forms.TextBox();
            this.clockOutBtn = new System.Windows.Forms.Button();
            this.workSiteTxt = new System.Windows.Forms.TextBox();
            this.workSiteLbl = new System.Windows.Forms.Label();
            this.jobTxt = new System.Windows.Forms.TextBox();
            this.jobLbl = new System.Windows.Forms.Label();
            this.clockInTimeTxt = new System.Windows.Forms.TextBox();
            this.clockInTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLbl.Location = new System.Drawing.Point(12, 24);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.Size = new System.Drawing.Size(78, 17);
            this.empNameLbl.TabIndex = 0;
            this.empNameLbl.Text = "Employee: ";
            // 
            // empNameTxt
            // 
            this.empNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.empNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empNameTxt.Enabled = false;
            this.empNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTxt.Location = new System.Drawing.Point(40, 44);
            this.empNameTxt.Name = "empNameTxt";
            this.empNameTxt.Size = new System.Drawing.Size(240, 19);
            this.empNameTxt.TabIndex = 1;
            // 
            // clockOutBtn
            // 
            this.clockOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutBtn.Location = new System.Drawing.Point(33, 274);
            this.clockOutBtn.Name = "clockOutBtn";
            this.clockOutBtn.Size = new System.Drawing.Size(283, 63);
            this.clockOutBtn.TabIndex = 6;
            this.clockOutBtn.Text = "Clock Out";
            this.clockOutBtn.UseVisualStyleBackColor = true;
            this.clockOutBtn.Click += new System.EventHandler(this.clockOutBtn_Click);
            // 
            // workSiteTxt
            // 
            this.workSiteTxt.BackColor = System.Drawing.SystemColors.Control;
            this.workSiteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workSiteTxt.Enabled = false;
            this.workSiteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSiteTxt.Location = new System.Drawing.Point(42, 96);
            this.workSiteTxt.Name = "workSiteTxt";
            this.workSiteTxt.Size = new System.Drawing.Size(240, 19);
            this.workSiteTxt.TabIndex = 8;
            // 
            // workSiteLbl
            // 
            this.workSiteLbl.AutoSize = true;
            this.workSiteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSiteLbl.Location = new System.Drawing.Point(12, 76);
            this.workSiteLbl.Name = "workSiteLbl";
            this.workSiteLbl.Size = new System.Drawing.Size(77, 17);
            this.workSiteLbl.TabIndex = 7;
            this.workSiteLbl.Text = "Work Site: ";
            // 
            // jobTxt
            // 
            this.jobTxt.BackColor = System.Drawing.SystemColors.Control;
            this.jobTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobTxt.Enabled = false;
            this.jobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTxt.Location = new System.Drawing.Point(42, 149);
            this.jobTxt.Name = "jobTxt";
            this.jobTxt.Size = new System.Drawing.Size(240, 19);
            this.jobTxt.TabIndex = 10;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(12, 129);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(39, 17);
            this.jobLbl.TabIndex = 9;
            this.jobLbl.Text = "Job: ";
            // 
            // clockInTimeTxt
            // 
            this.clockInTimeTxt.BackColor = System.Drawing.SystemColors.Control;
            this.clockInTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clockInTimeTxt.Enabled = false;
            this.clockInTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInTimeTxt.Location = new System.Drawing.Point(44, 206);
            this.clockInTimeTxt.Name = "clockInTimeTxt";
            this.clockInTimeTxt.Size = new System.Drawing.Size(240, 19);
            this.clockInTimeTxt.TabIndex = 12;
            // 
            // clockInTimeLbl
            // 
            this.clockInTimeLbl.AutoSize = true;
            this.clockInTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInTimeLbl.Location = new System.Drawing.Point(12, 186);
            this.clockInTimeLbl.Name = "clockInTimeLbl";
            this.clockInTimeLbl.Size = new System.Drawing.Size(100, 17);
            this.clockInTimeLbl.TabIndex = 11;
            this.clockInTimeLbl.Text = "Clock In Time: ";
            // 
            // ClockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.clockInTimeTxt);
            this.Controls.Add(this.clockInTimeLbl);
            this.Controls.Add(this.jobTxt);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.workSiteTxt);
            this.Controls.Add(this.workSiteLbl);
            this.Controls.Add(this.clockOutBtn);
            this.Controls.Add(this.empNameTxt);
            this.Controls.Add(this.empNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Client - Clock Out";
            this.Load += new System.EventHandler(this.ClockOutForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClockOutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.TextBox empNameTxt;
        private System.Windows.Forms.Button clockOutBtn;
        private System.Windows.Forms.TextBox workSiteTxt;
        private System.Windows.Forms.Label workSiteLbl;
        private System.Windows.Forms.TextBox jobTxt;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.TextBox clockInTimeTxt;
        private System.Windows.Forms.Label clockInTimeLbl;
    }
}