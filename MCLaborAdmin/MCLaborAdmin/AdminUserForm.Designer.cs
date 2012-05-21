namespace MCLaborAdmin
{
    partial class AdminUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserForm));
            this.adminUserSaveBtn = new System.Windows.Forms.Button();
            this.adminUserAddBtn = new System.Windows.Forms.Button();
            this.adminUserDeleteBtn = new System.Windows.Forms.Button();
            this.adminUserDataGridView = new System.Windows.Forms.DataGridView();
            this.adminUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminUserSaveBtn
            // 
            this.adminUserSaveBtn.Location = new System.Drawing.Point(187, 247);
            this.adminUserSaveBtn.Name = "adminUserSaveBtn";
            this.adminUserSaveBtn.Size = new System.Drawing.Size(70, 23);
            this.adminUserSaveBtn.TabIndex = 1;
            this.adminUserSaveBtn.Text = "Save";
            this.adminUserSaveBtn.UseVisualStyleBackColor = true;
            this.adminUserSaveBtn.Click += new System.EventHandler(this.adminUserSaveBtn_Click);
            // 
            // adminUserAddBtn
            // 
            this.adminUserAddBtn.Location = new System.Drawing.Point(12, 247);
            this.adminUserAddBtn.Name = "adminUserAddBtn";
            this.adminUserAddBtn.Size = new System.Drawing.Size(70, 23);
            this.adminUserAddBtn.TabIndex = 2;
            this.adminUserAddBtn.Text = "Add";
            this.adminUserAddBtn.UseVisualStyleBackColor = true;
            this.adminUserAddBtn.Click += new System.EventHandler(this.adminUserAddBtn_Click);
            // 
            // adminUserDeleteBtn
            // 
            this.adminUserDeleteBtn.Location = new System.Drawing.Point(100, 247);
            this.adminUserDeleteBtn.Name = "adminUserDeleteBtn";
            this.adminUserDeleteBtn.Size = new System.Drawing.Size(70, 23);
            this.adminUserDeleteBtn.TabIndex = 3;
            this.adminUserDeleteBtn.Text = "Delete";
            this.adminUserDeleteBtn.UseVisualStyleBackColor = true;
            this.adminUserDeleteBtn.Click += new System.EventHandler(this.adminUserDeleteBtn_Click);
            // 
            // adminUserDataGridView
            // 
            this.adminUserDataGridView.AllowUserToAddRows = false;
            this.adminUserDataGridView.AllowUserToDeleteRows = false;
            this.adminUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminUserId,
            this.userName,
            this.password});
            this.adminUserDataGridView.Location = new System.Drawing.Point(12, 24);
            this.adminUserDataGridView.Name = "adminUserDataGridView";
            this.adminUserDataGridView.Size = new System.Drawing.Size(244, 200);
            this.adminUserDataGridView.TabIndex = 4;
            // 
            // adminUserId
            // 
            this.adminUserId.HeaderText = "adminUserId";
            this.adminUserId.Name = "adminUserId";
            this.adminUserId.Visible = false;
            // 
            // userName
            // 
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 292);
            this.Controls.Add(this.adminUserDataGridView);
            this.Controls.Add(this.adminUserDeleteBtn);
            this.Controls.Add(this.adminUserAddBtn);
            this.Controls.Add(this.adminUserSaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUserForm";
            this.Text = "MCLabor Administration - Admin User Definitions";
            this.Load += new System.EventHandler(this.AdminUserForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUserForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.adminUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminUserSaveBtn;
        private System.Windows.Forms.Button adminUserAddBtn;
        private System.Windows.Forms.Button adminUserDeleteBtn;
        private System.Windows.Forms.DataGridView adminUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}