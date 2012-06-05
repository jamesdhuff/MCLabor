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
            this.empMainAddBtn = new System.Windows.Forms.Button();
            this.empMainEditBtn = new System.Windows.Forms.Button();
            this.empMainCloseBtn = new System.Windows.Forms.Button();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empMainAddBtn
            // 
            this.empMainAddBtn.Location = new System.Drawing.Point(12, 233);
            this.empMainAddBtn.Name = "empMainAddBtn";
            this.empMainAddBtn.Size = new System.Drawing.Size(119, 43);
            this.empMainAddBtn.TabIndex = 1;
            this.empMainAddBtn.Text = "Add";
            this.empMainAddBtn.UseVisualStyleBackColor = true;
            this.empMainAddBtn.Click += new System.EventHandler(this.empMainAddBtn_Click);
            // 
            // empMainEditBtn
            // 
            this.empMainEditBtn.Location = new System.Drawing.Point(154, 233);
            this.empMainEditBtn.Name = "empMainEditBtn";
            this.empMainEditBtn.Size = new System.Drawing.Size(127, 43);
            this.empMainEditBtn.TabIndex = 2;
            this.empMainEditBtn.Text = "Edit";
            this.empMainEditBtn.UseVisualStyleBackColor = true;
            this.empMainEditBtn.Click += new System.EventHandler(this.empMainEditBtn_Click);
            // 
            // empMainCloseBtn
            // 
            this.empMainCloseBtn.Location = new System.Drawing.Point(303, 233);
            this.empMainCloseBtn.Name = "empMainCloseBtn";
            this.empMainCloseBtn.Size = new System.Drawing.Size(127, 43);
            this.empMainCloseBtn.TabIndex = 3;
            this.empMainCloseBtn.Text = "Close";
            this.empMainCloseBtn.UseVisualStyleBackColor = true;
            this.empMainCloseBtn.Click += new System.EventHandler(this.empMainCloseBtn_Click);
            // 
            // empDataGridView
            // 
            this.empDataGridView.AllowUserToAddRows = false;
            this.empDataGridView.AllowUserToDeleteRows = false;
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.refCode,
            this.name});
            this.empDataGridView.Location = new System.Drawing.Point(13, 10);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.ReadOnly = true;
            this.empDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empDataGridView.Size = new System.Drawing.Size(416, 213);
            this.empDataGridView.TabIndex = 4;
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "employeeId";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.Visible = false;
            // 
            // refCode
            // 
            this.refCode.HeaderText = "Ref Code";
            this.refCode.Name = "refCode";
            this.refCode.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 288);
            this.Controls.Add(this.empDataGridView);
            this.Controls.Add(this.empMainCloseBtn);
            this.Controls.Add(this.empMainEditBtn);
            this.Controls.Add(this.empMainAddBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 326);
            this.MinimumSize = new System.Drawing.Size(458, 326);
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCLabor Admin - Employee Definitions";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeMainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empMainAddBtn;
        private System.Windows.Forms.Button empMainEditBtn;
        private System.Windows.Forms.Button empMainCloseBtn;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}