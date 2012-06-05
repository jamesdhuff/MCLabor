using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MCLaborClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginClearBtn_Click(object sender, EventArgs e)
        {
            //LaborService.LaborServiceClient proxy = new LaborService.LaborServiceClient();
            //this.loginInputTxt.Text = proxy.GetMessage();
            this.loginInputTxt.Text = string.Empty;
        }

        private void login1Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "1";
        }

        private void login2Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "2";
        }

        private void login3Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "3";         
        }

        private void login4Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "4";            
        }

        private void login5Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "5";            
        }

        private void login6Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "6";            
        }

        private void login7Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "7";            
        }

        private void login8Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "8";            
        }

        private void login9Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "9";            
        }

        private void login0Btn_Click(object sender, EventArgs e)
        {
            this.loginInputTxt.Text += "0";            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.loginInputTxt.Focus();
            this.MinimumSize = Size;
            this.MaximumSize = Size;
            this.BringToFront();
        }
    }
}
