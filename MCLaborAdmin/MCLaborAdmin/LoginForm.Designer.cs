namespace MCLaborAdmin
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginMsgTxt = new System.Windows.Forms.TextBox();
            this.loginUserNameTxt = new System.Windows.Forms.TextBox();
            this.loginPasswordTxt = new System.Windows.Forms.TextBox();
            this.loginUserNameLbl = new System.Windows.Forms.Label();
            this.loginPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.loginBtn.Location = new System.Drawing.Point(97, 112);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // loginMsgTxt
            // 
            this.loginMsgTxt.BackColor = System.Drawing.SystemColors.Control;
            this.loginMsgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginMsgTxt.Location = new System.Drawing.Point(97, 148);
            this.loginMsgTxt.Multiline = true;
            this.loginMsgTxt.Name = "loginMsgTxt";
            this.loginMsgTxt.ReadOnly = true;
            this.loginMsgTxt.Size = new System.Drawing.Size(169, 50);
            this.loginMsgTxt.TabIndex = 9;
            this.loginMsgTxt.TabStop = false;
            // 
            // loginUserNameTxt
            // 
            this.loginUserNameTxt.Location = new System.Drawing.Point(97, 41);
            this.loginUserNameTxt.Name = "loginUserNameTxt";
            this.loginUserNameTxt.Size = new System.Drawing.Size(169, 20);
            this.loginUserNameTxt.TabIndex = 0;
            // 
            // loginPasswordTxt
            // 
            this.loginPasswordTxt.Location = new System.Drawing.Point(97, 75);
            this.loginPasswordTxt.Name = "loginPasswordTxt";
            this.loginPasswordTxt.Size = new System.Drawing.Size(169, 20);
            this.loginPasswordTxt.TabIndex = 1;
            this.loginPasswordTxt.UseSystemPasswordChar = true;
            // 
            // loginUserNameLbl
            // 
            this.loginUserNameLbl.AutoSize = true;
            this.loginUserNameLbl.Location = new System.Drawing.Point(21, 44);
            this.loginUserNameLbl.Name = "loginUserNameLbl";
            this.loginUserNameLbl.Size = new System.Drawing.Size(60, 13);
            this.loginUserNameLbl.TabIndex = 4;
            this.loginUserNameLbl.Text = "User Name";
            // 
            // loginPasswordLbl
            // 
            this.loginPasswordLbl.AutoSize = true;
            this.loginPasswordLbl.Location = new System.Drawing.Point(21, 78);
            this.loginPasswordLbl.Name = "loginPasswordLbl";
            this.loginPasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.loginPasswordLbl.TabIndex = 5;
            this.loginPasswordLbl.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 210);
            this.Controls.Add(this.loginPasswordLbl);
            this.Controls.Add(this.loginUserNameLbl);
            this.Controls.Add(this.loginPasswordTxt);
            this.Controls.Add(this.loginUserNameTxt);
            this.Controls.Add(this.loginMsgTxt);
            this.Controls.Add(this.loginBtn);
            this.Name = "LoginForm";
            this.Text = "MCLabor Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginMsgTxt;
        private System.Windows.Forms.TextBox loginUserNameTxt;
        private System.Windows.Forms.TextBox loginPasswordTxt;
        private System.Windows.Forms.Label loginUserNameLbl;
        private System.Windows.Forms.Label loginPasswordLbl;
    }
}

