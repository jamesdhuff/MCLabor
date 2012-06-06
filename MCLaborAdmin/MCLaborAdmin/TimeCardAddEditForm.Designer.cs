namespace MCLaborAdmin
{
    partial class TimeCardAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCardAddEditForm));
            this.empNameLbl = new System.Windows.Forms.Label();
            this.empNameTxt = new System.Windows.Forms.TextBox();
            this.jobCmbo = new System.Windows.Forms.ComboBox();
            this.workSiteCmbo = new System.Windows.Forms.ComboBox();
            this.jobLbl = new System.Windows.Forms.Label();
            this.workSiteLbl = new System.Windows.Forms.Label();
            this.clockInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clockInLbl = new System.Windows.Forms.Label();
            this.clockOutLbl = new System.Windows.Forms.Label();
            this.clockInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clockOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clockOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCardAddEditSaveBtn = new System.Windows.Forms.Button();
            this.timeCardAddEditCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Location = new System.Drawing.Point(21, 12);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.Size = new System.Drawing.Size(56, 13);
            this.empNameLbl.TabIndex = 0;
            this.empNameLbl.Text = "Employee:";
            // 
            // empNameTxt
            // 
            this.empNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.empNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empNameTxt.Location = new System.Drawing.Point(110, 12);
            this.empNameTxt.Name = "empNameTxt";
            this.empNameTxt.Size = new System.Drawing.Size(183, 13);
            this.empNameTxt.TabIndex = 1;
            // 
            // jobCmbo
            // 
            this.jobCmbo.FormattingEnabled = true;
            this.jobCmbo.Location = new System.Drawing.Point(110, 53);
            this.jobCmbo.Name = "jobCmbo";
            this.jobCmbo.Size = new System.Drawing.Size(225, 21);
            this.jobCmbo.TabIndex = 2;
            // 
            // workSiteCmbo
            // 
            this.workSiteCmbo.FormattingEnabled = true;
            this.workSiteCmbo.Location = new System.Drawing.Point(111, 90);
            this.workSiteCmbo.Name = "workSiteCmbo";
            this.workSiteCmbo.Size = new System.Drawing.Size(224, 21);
            this.workSiteCmbo.TabIndex = 3;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Location = new System.Drawing.Point(21, 56);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(27, 13);
            this.jobLbl.TabIndex = 4;
            this.jobLbl.Text = "Job:";
            // 
            // workSiteLbl
            // 
            this.workSiteLbl.AutoSize = true;
            this.workSiteLbl.Location = new System.Drawing.Point(21, 93);
            this.workSiteLbl.Name = "workSiteLbl";
            this.workSiteLbl.Size = new System.Drawing.Size(57, 13);
            this.workSiteLbl.TabIndex = 5;
            this.workSiteLbl.Text = "Work Site:";
            // 
            // clockInTimePicker
            // 
            this.clockInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockInTimePicker.Location = new System.Drawing.Point(238, 128);
            this.clockInTimePicker.Name = "clockInTimePicker";
            this.clockInTimePicker.Size = new System.Drawing.Size(99, 20);
            this.clockInTimePicker.TabIndex = 6;
            // 
            // clockInLbl
            // 
            this.clockInLbl.AutoSize = true;
            this.clockInLbl.Location = new System.Drawing.Point(21, 134);
            this.clockInLbl.Name = "clockInLbl";
            this.clockInLbl.Size = new System.Drawing.Size(75, 13);
            this.clockInLbl.TabIndex = 8;
            this.clockInLbl.Text = "Clock In Time:";
            // 
            // clockOutLbl
            // 
            this.clockOutLbl.AutoSize = true;
            this.clockOutLbl.Location = new System.Drawing.Point(21, 171);
            this.clockOutLbl.Name = "clockOutLbl";
            this.clockOutLbl.Size = new System.Drawing.Size(83, 13);
            this.clockOutLbl.TabIndex = 9;
            this.clockOutLbl.Text = "Clock Out Time:";
            // 
            // clockInDatePicker
            // 
            this.clockInDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clockInDatePicker.Location = new System.Drawing.Point(112, 128);
            this.clockInDatePicker.Name = "clockInDatePicker";
            this.clockInDatePicker.Size = new System.Drawing.Size(120, 20);
            this.clockInDatePicker.TabIndex = 10;
            // 
            // clockOutDatePicker
            // 
            this.clockOutDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clockOutDatePicker.Location = new System.Drawing.Point(111, 165);
            this.clockOutDatePicker.Name = "clockOutDatePicker";
            this.clockOutDatePicker.Size = new System.Drawing.Size(120, 20);
            this.clockOutDatePicker.TabIndex = 12;
            // 
            // clockOutTimePicker
            // 
            this.clockOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockOutTimePicker.Location = new System.Drawing.Point(237, 165);
            this.clockOutTimePicker.Name = "clockOutTimePicker";
            this.clockOutTimePicker.Size = new System.Drawing.Size(99, 20);
            this.clockOutTimePicker.TabIndex = 11;
            // 
            // timeCardAddEditSaveBtn
            // 
            this.timeCardAddEditSaveBtn.Location = new System.Drawing.Point(24, 219);
            this.timeCardAddEditSaveBtn.Name = "timeCardAddEditSaveBtn";
            this.timeCardAddEditSaveBtn.Size = new System.Drawing.Size(108, 31);
            this.timeCardAddEditSaveBtn.TabIndex = 13;
            this.timeCardAddEditSaveBtn.Text = "Save";
            this.timeCardAddEditSaveBtn.UseVisualStyleBackColor = true;
            // 
            // timeCardAddEditCancelBtn
            // 
            this.timeCardAddEditCancelBtn.Location = new System.Drawing.Point(148, 219);
            this.timeCardAddEditCancelBtn.Name = "timeCardAddEditCancelBtn";
            this.timeCardAddEditCancelBtn.Size = new System.Drawing.Size(108, 31);
            this.timeCardAddEditCancelBtn.TabIndex = 14;
            this.timeCardAddEditCancelBtn.Text = "Cancel";
            this.timeCardAddEditCancelBtn.UseVisualStyleBackColor = true;
            // 
            // TimeCardAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.timeCardAddEditCancelBtn);
            this.Controls.Add(this.timeCardAddEditSaveBtn);
            this.Controls.Add(this.clockOutDatePicker);
            this.Controls.Add(this.clockOutTimePicker);
            this.Controls.Add(this.clockInDatePicker);
            this.Controls.Add(this.clockOutLbl);
            this.Controls.Add(this.clockInLbl);
            this.Controls.Add(this.clockInTimePicker);
            this.Controls.Add(this.workSiteLbl);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.workSiteCmbo);
            this.Controls.Add(this.jobCmbo);
            this.Controls.Add(this.empNameTxt);
            this.Controls.Add(this.empNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeCardAddEditForm";
            this.Text = "MCLabor Administration - Add/Edit Time Cards";
            this.Load += new System.EventHandler(this.TimeCardAddEditForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCardAddEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.TextBox empNameTxt;
        private System.Windows.Forms.ComboBox jobCmbo;
        private System.Windows.Forms.ComboBox workSiteCmbo;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.Label workSiteLbl;
        private System.Windows.Forms.DateTimePicker clockInTimePicker;
        private System.Windows.Forms.Label clockInLbl;
        private System.Windows.Forms.Label clockOutLbl;
        private System.Windows.Forms.DateTimePicker clockInDatePicker;
        private System.Windows.Forms.DateTimePicker clockOutDatePicker;
        private System.Windows.Forms.DateTimePicker clockOutTimePicker;
        private System.Windows.Forms.Button timeCardAddEditSaveBtn;
        private System.Windows.Forms.Button timeCardAddEditCancelBtn;
    }
}