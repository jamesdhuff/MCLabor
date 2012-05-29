namespace MCLaborAdmin
{
    partial class EmployeeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
            this.empMainLookupCmboBox = new System.Windows.Forms.ComboBox();
            this.empMainAddBtn = new System.Windows.Forms.Button();
            this.empMainEditBtn = new System.Windows.Forms.Button();
            this.empMainOrLbl = new System.Windows.Forms.Label();
            this.empMainSelectEmpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empMainLookupCmboBox
            // 
            this.empMainLookupCmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empMainLookupCmboBox.FormattingEnabled = true;
            this.empMainLookupCmboBox.Location = new System.Drawing.Point(12, 161);
            this.empMainLookupCmboBox.MaxDropDownItems = 100;
            this.empMainLookupCmboBox.Name = "empMainLookupCmboBox";
            this.empMainLookupCmboBox.Size = new System.Drawing.Size(233, 21);
            this.empMainLookupCmboBox.TabIndex = 0;
            // 
            // empMainAddBtn
            // 
            this.empMainAddBtn.Location = new System.Drawing.Point(11, 11);
            this.empMainAddBtn.Name = "empMainAddBtn";
            this.empMainAddBtn.Size = new System.Drawing.Size(379, 60);
            this.empMainAddBtn.TabIndex = 1;
            this.empMainAddBtn.Text = "Add New Employee";
            this.empMainAddBtn.UseVisualStyleBackColor = true;
            this.empMainAddBtn.Click += new System.EventHandler(this.empMainAddBtn_Click);
            // 
            // empMainEditBtn
            // 
            this.empMainEditBtn.Location = new System.Drawing.Point(263, 161);
            this.empMainEditBtn.Name = "empMainEditBtn";
            this.empMainEditBtn.Size = new System.Drawing.Size(127, 43);
            this.empMainEditBtn.TabIndex = 2;
            this.empMainEditBtn.Text = "Edit";
            this.empMainEditBtn.UseVisualStyleBackColor = true;
            this.empMainEditBtn.Click += new System.EventHandler(this.empMainEditBtn_Click);
            // 
            // empMainOrLbl
            // 
            this.empMainOrLbl.AutoSize = true;
            this.empMainOrLbl.Location = new System.Drawing.Point(12, 101);
            this.empMainOrLbl.Name = "empMainOrLbl";
            this.empMainOrLbl.Size = new System.Drawing.Size(380, 13);
            this.empMainOrLbl.TabIndex = 3;
            this.empMainOrLbl.Text = "----------------------------------------------------------  OR ------------------" +
                "----------------------------------------";
            // 
            // empMainSelectEmpLbl
            // 
            this.empMainSelectEmpLbl.AutoSize = true;
            this.empMainSelectEmpLbl.Location = new System.Drawing.Point(12, 135);
            this.empMainSelectEmpLbl.Name = "empMainSelectEmpLbl";
            this.empMainSelectEmpLbl.Size = new System.Drawing.Size(173, 13);
            this.empMainSelectEmpLbl.TabIndex = 4;
            this.empMainSelectEmpLbl.Text = "Select an Existing Employee to Edit";
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 228);
            this.Controls.Add(this.empMainSelectEmpLbl);
            this.Controls.Add(this.empMainOrLbl);
            this.Controls.Add(this.empMainEditBtn);
            this.Controls.Add(this.empMainAddBtn);
            this.Controls.Add(this.empMainLookupCmboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Admin - Employee Definitions";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empMainLookupCmboBox;
        private System.Windows.Forms.Button empMainAddBtn;
        private System.Windows.Forms.Button empMainEditBtn;
        private System.Windows.Forms.Label empMainOrLbl;
        private System.Windows.Forms.Label empMainSelectEmpLbl;
    }
}