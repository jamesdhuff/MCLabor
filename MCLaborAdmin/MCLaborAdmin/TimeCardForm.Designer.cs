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
            this.chkShowTerminatedEmployees = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timeCardEmployeeCmbo
            // 
            this.timeCardEmployeeCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardEmployeeCmbo.FormattingEnabled = true;
            this.timeCardEmployeeCmbo.Location = new System.Drawing.Point(27, 65);
            this.timeCardEmployeeCmbo.Name = "timeCardEmployeeCmbo";
            this.timeCardEmployeeCmbo.Size = new System.Drawing.Size(346, 34);
            this.timeCardEmployeeCmbo.TabIndex = 0;
            // 
            // timeCardStartDatePicker
            // 
            this.timeCardStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeCardStartDatePicker.Location = new System.Drawing.Point(27, 200);
            this.timeCardStartDatePicker.Name = "timeCardStartDatePicker";
            this.timeCardStartDatePicker.Size = new System.Drawing.Size(123, 26);
            this.timeCardStartDatePicker.TabIndex = 1;
            // 
            // timeCardEndDatePicker
            // 
            this.timeCardEndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeCardEndDatePicker.Location = new System.Drawing.Point(196, 200);
            this.timeCardEndDatePicker.Name = "timeCardEndDatePicker";
            this.timeCardEndDatePicker.Size = new System.Drawing.Size(124, 26);
            this.timeCardEndDatePicker.TabIndex = 2;
            // 
            // timeCardEmployeeListLbl
            // 
            this.timeCardEmployeeListLbl.AutoSize = true;
            this.timeCardEmployeeListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardEmployeeListLbl.Location = new System.Drawing.Point(23, 39);
            this.timeCardEmployeeListLbl.Name = "timeCardEmployeeListLbl";
            this.timeCardEmployeeListLbl.Size = new System.Drawing.Size(82, 20);
            this.timeCardEmployeeListLbl.TabIndex = 3;
            this.timeCardEmployeeListLbl.Text = "Employee";
            // 
            // timeCardMessageLbl
            // 
            this.timeCardMessageLbl.AutoSize = true;
            this.timeCardMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardMessageLbl.Location = new System.Drawing.Point(12, 9);
            this.timeCardMessageLbl.Name = "timeCardMessageLbl";
            this.timeCardMessageLbl.Size = new System.Drawing.Size(361, 20);
            this.timeCardMessageLbl.TabIndex = 4;
            this.timeCardMessageLbl.Text = "Select an Employee and Date Range to Review";
            // 
            // timeCardStartDateLbl
            // 
            this.timeCardStartDateLbl.AutoSize = true;
            this.timeCardStartDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardStartDateLbl.Location = new System.Drawing.Point(23, 164);
            this.timeCardStartDateLbl.Name = "timeCardStartDateLbl";
            this.timeCardStartDateLbl.Size = new System.Drawing.Size(86, 20);
            this.timeCardStartDateLbl.TabIndex = 5;
            this.timeCardStartDateLbl.Text = "Start Date";
            // 
            // timeCardEndDateLbl
            // 
            this.timeCardEndDateLbl.AutoSize = true;
            this.timeCardEndDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardEndDateLbl.Location = new System.Drawing.Point(192, 164);
            this.timeCardEndDateLbl.Name = "timeCardEndDateLbl";
            this.timeCardEndDateLbl.Size = new System.Drawing.Size(79, 20);
            this.timeCardEndDateLbl.TabIndex = 6;
            this.timeCardEndDateLbl.Text = "End Date";
            // 
            // timeCardGoBtn
            // 
            this.timeCardGoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCardGoBtn.Location = new System.Drawing.Point(27, 263);
            this.timeCardGoBtn.Name = "timeCardGoBtn";
            this.timeCardGoBtn.Size = new System.Drawing.Size(346, 42);
            this.timeCardGoBtn.TabIndex = 7;
            this.timeCardGoBtn.Text = "Go";
            this.timeCardGoBtn.UseVisualStyleBackColor = true;
            this.timeCardGoBtn.Click += new System.EventHandler(this.timeCardGoBtn_Click);
            // 
            // chkShowTerminatedEmployees
            // 
            this.chkShowTerminatedEmployees.AutoSize = true;
            this.chkShowTerminatedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowTerminatedEmployees.Location = new System.Drawing.Point(29, 117);
            this.chkShowTerminatedEmployees.Name = "chkShowTerminatedEmployees";
            this.chkShowTerminatedEmployees.Size = new System.Drawing.Size(210, 21);
            this.chkShowTerminatedEmployees.TabIndex = 8;
            this.chkShowTerminatedEmployees.Text = "Show Terminated Employees";
            this.chkShowTerminatedEmployees.UseVisualStyleBackColor = true;
            this.chkShowTerminatedEmployees.CheckedChanged += new System.EventHandler(this.chkShowTerminatedEmployees_CheckedChanged);
            // 
            // TimeCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 323);
            this.Controls.Add(this.chkShowTerminatedEmployees);
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
            this.Text = "MCLabor Admin - Add/Edit Time Cards";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCardForm_FormClosing);
            this.Load += new System.EventHandler(this.TimeCardForm_Load);
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
        private System.Windows.Forms.CheckBox chkShowTerminatedEmployees;
    }
}