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
    public partial class ClockOutForm : Form
    {
        private LoginForm loginForm;
        private TimeCard currTimeCard;

        public ClockOutForm(LoginForm loginForm, TimeCard currTimeCard)
        {
            this.loginForm = loginForm;
            this.currTimeCard = currTimeCard;            

            InitializeComponent();
        }

        private void clockOutBtn_Click(object sender, EventArgs e)
        {
            LaborService.LaborServiceClient proxy = new LaborService.LaborServiceClient();
            //proxy.ClientCredentials.UserName.UserName = "snaps";
            //proxy.ClientCredentials.UserName.Password = "ax23%%$tyTT0"; 
            try
            {
                proxy.doClockOut(this.currTimeCard);
            }
            catch (FaultException ex)
            {
                MessageBox.Show("Server Error occurred during Clock Out.  Check Server Logs for Details (i.e. call Jim and cry for help!", "Server Error");
            }
            this.Close();
        }

        private void ClockOutForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.empNameTxt.Text = this.currTimeCard.Employee.ToString();
            this.workSiteTxt.Text = this.currTimeCard.WorkSite.ToString();
            this.jobTxt.Text = this.currTimeCard.Job.ToString();
            this.clockInTimeTxt.Text = ((DateTime)this.currTimeCard.LocalStartTime).ToString();
            
        }

        private void ClockOutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
        }
    }
}
