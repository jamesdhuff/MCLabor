namespace MCLaborAdmin
{
    partial class TimeCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCardForm));
            this.timeCardEmployeeCmbo = new System.Windows.Forms.ComboBox();
            this.timeCardStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCardEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCardEmployeeListLbl = new System.Windows.Forms.Label();
            this.timeCardMessageLbl = new System.Windows.Forms.Label();
            this.timeCardStartDateLbl = new System.Windows.Forms.Label();
            this.timeCardEndDateLbl = new System.Windows.Forms.Label();
            this.timeCardGoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeCardEmployeeCmbo
            // 
            this.timeCardEmployeeCmbo.FormattingEnabled = true;
            this.timeCardEmployeeCmbo.Location = new System.Drawing.Point(26, 65);
            this.timeCardEmployeeCmbo.Name = "timeCardEmployeeCmbo";
            this.timeCardEmployeeCmbo.Size = new System.Drawing.Size(258, 21);
            this.timeCardEmployeeCmbo.TabIndex = 0;
            // 
            // timeCardStartDatePicker
            // 
            this.timeCardStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeCardStartDatePicker.Location = new System.Drawing.Point(26, 124);
            this.timeCardStartDatePicker.Name = "timeCardStartDatePicker";
            this.timeCardStartDatePicker.Size = new System.Drawing.Size(118, 20);
            this.timeCardStartDatePicker.TabIndex = 1;
            // 
            // timeCardEndDatePicker
            // 
            this.timeCardEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeCardEndDatePicker.Location = new System.Drawing.Point(166, 124);
            this.timeCardEndDatePicker.Name = "timeCardEndDatePicker";
            this.timeCardEndDatePicker.Size = new System.Drawing.Size(118, 20);
            this.timeCardEndDatePicker.TabIndex = 2;
            // 
            // timeCardEmployeeListLbl
            // 
            this.timeCardEmployeeListLbl.AutoSize = true;
            this.timeCardEmployeeListLbl.Location = new System.Drawing.Point(23, 39);
            this.timeCardEmployeeListLbl.Name = "timeCardEmployeeListLbl";
            this.timeCardEmployeeListLbl.Size = new System.Drawing.Size(53, 13);
            this.timeCardEmployeeListLbl.TabIndex = 3;
            this.timeCardEmployeeListLbl.Text = "Employee";
            // 
            // timeCardMessageLbl
            // 
            this.timeCardMessageLbl.AutoSize = true;
            this.timeCardMessageLbl.Location = new System.Drawing.Point(12, 9);
            this.timeCardMessageLbl.Name = "timeCardMessageLbl";
            this.timeCardMessageLbl.Size = new System.Drawing.Size(234, 13);
            this.timeCardMessageLbl.TabIndex = 4;
            this.timeCardMessageLbl.Text = "Select an Employee and Date Range to Review";
            // 
            // timeCardStartDateLbl
            // 
            this.timeCardStartDateLbl.AutoSize = true;
            this.timeCardStartDateLbl.Location = new System.Drawing.Point(23, 99);
            this.timeCardStartDateLbl.Name = "timeCardStartDateLbl";
            this.timeCardStartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.timeCardStartDateLbl.TabIndex = 5;
            this.timeCardStartDateLbl.Text = "Start Date";
            // 
            // timeCardEndDateLbl
            // 
            this.timeCardEndDateLbl.AutoSize = true;
            this.timeCardEndDateLbl.Location = new System.Drawing.Point(163, 99);
            this.timeCardEndDateLbl.Name = "timeCardEndDateLbl";
            this.timeCardEndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.timeCardEndDateLbl.TabIndex = 6;
            this.timeCardEndDateLbl.Text = "End Date";
            // 
            // timeCardGoBtn
            // 
            this.timeCardGoBtn.Location = new System.Drawing.Point(102, 179);
            this.timeCardGoBtn.Name = "timeCardGoBtn";
            this.timeCardGoBtn.Size = new System.Drawing.Size(110, 33);
            this.timeCardGoBtn.TabIndex = 7;
            this.timeCardGoBtn.Text = "Go";
            this.timeCardGoBtn.UseVisualStyleBackColor = true;
            // 
            // TimeCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.timeCardGoBtn);
            this.Controls.Add(this.timeCardEndDateLbl);
            this.Controls.Add(this.timeCardStartDateLbl);
            this.Controls.Add(this.timeCardMessageLbl);
            this.Controls.Add(this.timeCardEmployeeListLbl);
            this.Controls.Add(this.timeCardEndDatePicker);
            this.Controls.Add(this.timeCardStartDatePicker);
            this.Controls.Add(this.timeCardEmployeeCmbo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Administration - Add/Edit Time Cards";
            this.Load += new System.EventHandler(this.TimeCardForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCardForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox timeCardEmployeeCmbo;
        private System.Windows.Forms.DateTimePicker timeCardStartDatePicker;
        private System.Windows.Forms.DateTimePicker timeCardEndDatePicker;
        private System.Windows.Forms.Label timeCardEmployeeListLbl;
        private System.Windows.Forms.Label timeCardMessageLbl;
        private System.Windows.Forms.Label timeCardStartDateLbl;
        private System.Windows.Forms.Label timeCardEndDateLbl;
        private System.Windows.Forms.Button timeCardGoBtn;
    }
}