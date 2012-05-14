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
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (validateLogin(this.loginUserNameTxt.Text, this.loginPasswordTxt.Text))
            {
                //loadMainMenu();
                this.loginMsgTxt.Text = "Login Successful";
            }
            else
            {
                this.loginMsgTxt.Text = "Invalid Credentials: Check your User Name and Password";
            }
        }

        private bool validateLogin(string username, string password)
        {
            string sqlString = "SELECT userName, password FROM admin_user WHERE lower(userName) = @userName";

            using (SqlConnection conn = DBUtils.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.Parameters.Add(new SqlParameter("@userName", username));
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
    }
}
