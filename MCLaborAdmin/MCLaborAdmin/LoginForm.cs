using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MCLaborAdmin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.loginMsgTxt.Text = "";
            if (validateLogin(this.loginUserNameTxt.Text, this.loginPasswordTxt.Text))
            {
                loadMainMenu();                
            }
            else
            {
                this.loginMsgTxt.Text = "Invalid Credentials: " + Environment.NewLine + "Check your User Name and Password";
            }
        }

        private bool validateLogin(string username, string password)
        {
            string sqlString = "SELECT userName, password FROM admin_user WHERE userName = @userName";

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.Parameters.Add(new SqlParameter("@userName", username.ToLower()));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (password == reader.GetString(1))
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }


        private void loadMainMenu()
        {
            this.loginPasswordTxt.Text = "";
            this.loginPasswordTxt.Focus();
            this.Hide();
            MainMenuForm mainMenu = new MainMenuForm(this);
            mainMenu.Show(this);
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

    }
}
