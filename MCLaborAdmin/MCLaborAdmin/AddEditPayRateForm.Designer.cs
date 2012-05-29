namespace MCLaborAdmin
{
    partial class AddEditPayRateForm
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
            this.addEditPayRateJobCmboBox = new System.Windows.Forms.ComboBox();
            this.addEditPayRateActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addEditPayRateHourlyRateTxt = new System.Windows.Forms.TextBox();
            this.addEditPayRateJobLbl = new System.Windows.Forms.Label();
            this.addEditPayRateHourlyRateLbl = new System.Windows.Forms.Label();
            this.addEditPayRateActiveLbl = new System.Windows.Forms.Label();
            this.addEditPayRateSaveBtn = new System.Windows.Forms.Button();
            this.addEditPayRateCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEditPayRateJobCmboBox
            // 
            this.addEditPayRateJobCmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEditPayRateJobCmboBox.FormattingEnabled = true;
            this.addEditPayRateJobCmboBox.Location = new System.Drawing.Point(25, 32);
            this.addEditPayRateJobCmboBox.Name = "addEditPayRateJobCmboBox";
            this.addEditPayRateJobCmboBox.Size = new System.Drawing.Size(183, 21);
            this.addEditPayRateJobCmboBox.TabIndex = 0;
            // 
            // addEditPayRateActiveCheckBox
            // 
            this.addEditPayRateActiveCheckBox.AutoSize = true;
            this.addEditPayRateActiveCheckBox.Location = new System.Drawing.Point(165, 89);
            this.addEditPayRateActiveCheckBox.Name = "addEditPayRateActiveCheckBox";
            this.addEditPayRateActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.addEditPayRateActiveCheckBox.TabIndex = 1;
            this.addEditPayRateActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addEditPayRateHourlyRateTxt
            // 
            this.addEditPayRateHourlyRateTxt.Location = new System.Drawing.Point(25, 86);
            this.addEditPayRateHourlyRateTxt.Name = "addEditPayRateHourlyRateTxt";
            this.addEditPayRateHourlyRateTxt.Size = new System.Drawing.Size(72, 20);
            this.addEditPayRateHourlyRateTxt.TabIndex = 2;
            // 
            // addEditPayRateJobLbl
            // 
            this.addEditPayRateJobLbl.AutoSize = true;
            this.addEditPayRateJobLbl.Location = new System.Drawing.Point(12, 16);
            this.addEditPayRateJobLbl.Name = "addEditPayRateJobLbl";
            this.addEditPayRateJobLbl.Size = new System.Drawing.Size(24, 13);
            this.addEditPayRateJobLbl.TabIndex = 3;
            this.addEditPayRateJobLbl.Text = "Job";
            // 
            // addEditPayRateHourlyRateLbl
            // 
            this.addEditPayRateHourlyRateLbl.AutoSize = true;
            this.addEditPayRateHourlyRateLbl.Location = new System.Drawing.Point(12, 70);
            this.addEditPayRateHourlyRateLbl.Name = "addEditPayRateHourlyRateLbl";
            this.addEditPayRateHourlyRateLbl.Size = new System.Drawing.Size(84, 13);
            this.addEditPayRateHourlyRateLbl.TabIndex = 4;
            this.addEditPayRateHourlyRateLbl.Text = "Hourly Pay Rate";
            // 
            // addEditPayRateActiveLbl
            // 
            this.addEditPayRateActiveLbl.AutoSize = true;
            this.addEditPayRateActiveLbl.Location = new System.Drawing.Point(152, 70);
            this.addEditPayRateActiveLbl.Name = "addEditPayRateActiveLbl";
            this.addEditPayRateActiveLbl.Size = new System.Drawing.Size(37, 13);
            this.addEditPayRateActiveLbl.TabIndex = 5;
            this.addEditPayRateActiveLbl.Text = "Active";
            // 
            // addEditPayRateSaveBtn
            // 
            this.addEditPayRateSaveBtn.Location = new System.Drawing.Point(25, 128);
            this.addEditPayRateSaveBtn.Name = "addEditPayRateSaveBtn";
            this.addEditPayRateSaveBtn.Size = new System.Drawing.Size(90, 26);
            this.addEditPayRateSaveBtn.TabIndex = 6;
            this.addEditPayRateSaveBtn.Text = "Save";
            this.addEditPayRateSaveBtn.UseVisualStyleBackColor = true;
            this.addEditPayRateSaveBtn.Click += new System.EventHandler(this.addEditPayRateSaveBtn_Click);
            // 
            // addEditPayRateCancelBtn
            // 
            this.addEditPayRateCancelBtn.Location = new System.Drawing.Point(118, 128);
            this.addEditPayRateCancelBtn.Name = "addEditPayRateCancelBtn";
            this.addEditPayRateCancelBtn.Size = new System.Drawing.Size(90, 26);
            this.addEditPayRateCancelBtn.TabIndex = 7;
            this.addEditPayRateCancelBtn.Text = "Cancel";
            this.addEditPayRateCancelBtn.UseVisualStyleBackColor = true;
            this.addEditPayRateCancelBtn.Click += new System.EventHandler(this.addEditPayRateCancelBtn_Click);
            // 
            // AddEditPayRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 172);
            this.Controls.Add(this.addEditPayRateCancelBtn);
            this.Controls.Add(this.addEditPayRateSaveBtn);
            this.Controls.Add(this.addEditPayRateActiveLbl);
            this.Controls.Add(this.addEditPayRateHourlyRateLbl);
            this.Controls.Add(this.addEditPayRateJobLbl);
            this.Controls.Add(this.addEditPayRateHourlyRateTxt);
            this.Controls.Add(this.addEditPayRateActiveCheckBox);
            this.Controls.Add(this.addEditPayRateJobCmboBox);
            this.Name = "AddEditPayRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Pay Rate";
            this.Load += new System.EventHandler(this.AddEditPayRateForm_Load);
            this.Shown += new System.EventHandler(this.AddEditPayRateForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPayRateForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addEditPayRateJobCmboBox;
        private System.Windows.Forms.CheckBox addEditPayRateActiveCheckBox;
        private System.Windows.Forms.TextBox addEditPayRateHourlyRateTxt;
        private System.Windows.Forms.Label addEditPayRateJobLbl;
        private System.Windows.Forms.Label addEditPayRateHourlyRateLbl;
        private System.Windows.Forms.Label addEditPayRateActiveLbl;
        private System.Windows.Forms.Button addEditPayRateSaveBtn;
        private System.Windows.Forms.Button addEditPayRateCancelBtn;
    }
}