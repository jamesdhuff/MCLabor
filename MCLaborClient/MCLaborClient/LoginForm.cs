using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using MCLaborLib;

namespace MCLaborClient
{
    public partial class LoginForm : Form
    {

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string MESSAGE_ENTER_ID = "Enter your Login ID Number";
        private const string MESSAGE_SERVER_ERROR = "Server Error: See log";
        private const string MESSAGE_INVALID_LOGINID = "Enter an integer value for the Login ID";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginClearBtn_Click(object sender, EventArgs e)
        {
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
            try
            {
                this.Enabled = false;

                int loginId = -1;
                Employee emp = new Employee();

                try
                {
                    loginId = Int32.Parse(this.loginInputTxt.Text);
                }
                catch (FormatException)
                {
                    this.loginMessageTxt.ForeColor = Color.Red;
                    this.loginMessageTxt.Text = MESSAGE_INVALID_LOGINID;
                    this.loginInputTxt.Focus();
                }

                try
                {
                    LaborService.LaborServiceClient proxy = new LaborService.LaborServiceClient();
                    if (proxy.isValidLogin(loginId))
                    {
                        emp = proxy.getEmployee(loginId);

                        if (emp.IsClockedIn)
                        {
                            TimeCard currTimeCard = proxy.getLatestOpenTimeCard(emp.EmployeeId);
                            currTimeCard.Employee = emp;
                            ClockOutForm clockOutForm = new ClockOutForm(this, currTimeCard);
                            this.loginInputTxt.Text = string.Empty;
                            this.loginMessageTxt.Text = MESSAGE_ENTER_ID;
                            this.loginMessageTxt.ForeColor = Color.Black;
                            this.Hide();
                            clockOutForm.Show();
                        }
                        else
                        {
                            List<WorkSite> workSiteList = proxy.getWorkSiteList().ToList();
                            List<Job> jobList = proxy.getJobList(emp.EmployeeId).ToList();

                            ClockInForm clockInForm = new ClockInForm(this, emp, workSiteList, jobList);
                            this.loginInputTxt.Text = string.Empty;
                            this.loginMessageTxt.Text = MESSAGE_ENTER_ID;
                            this.loginMessageTxt.ForeColor = Color.Black;
                            this.Hide();
                            clockInForm.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.loginMessageTxt.ForeColor = Color.Red;
                    this.loginMessageTxt.Text = MESSAGE_SERVER_ERROR;
                    logger.Error(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());                
            }
            finally
            {
                this.Enabled = true;
            }
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
