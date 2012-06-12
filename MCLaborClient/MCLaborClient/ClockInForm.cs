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
    public partial class ClockInForm : Form
    {
        private LoginForm loginForm;
        private Employee currEmp;
        private List<WorkSite> workSiteList;
        private List<Job> jobList;

        public ClockInForm(LoginForm loginForm, Employee currEmp, List<WorkSite> workSiteList, List<Job> jobList)
        {
            this.loginForm = loginForm;
            this.currEmp = currEmp;
            this.workSiteList = workSiteList;
            this.jobList = jobList;

            InitializeComponent();
        }

        private bool validateFormData()
        {
            if (this.jobCmbo.SelectedItem == null)
            {
                MessageBox.Show(this, "Please select a Job");
                return false;
            }

            if (this.workSiteCmbo.SelectedItem == null)
            {
                MessageBox.Show(this, "Please select a Work Site");
                return false;
            }
            return true;
        }

        private void clockInBtn_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                try
                {
                    TimeCard tc = new TimeCard();
                    tc.Employee = this.currEmp;
                    tc.WorkSite = (WorkSite)this.workSiteCmbo.SelectedItem;
                    tc.Job = (Job)this.jobCmbo.SelectedItem;
                    LaborService.LaborServiceClient proxy = new LaborService.LaborServiceClient();
                    proxy.doClockIn(tc);
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(this, "Server Error occurred during processing of Clock In.  See Server logs for details (i.e. Call Jim and cry for help!)", "Server Error");
                }

                this.Close();
            }
        }
        

        private void ClockInForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.empNameTxt.Text = this.currEmp.ToString();
            
            foreach (WorkSite ws in this.workSiteList)
            {
                this.workSiteCmbo.Items.Add(ws);
            }

            foreach (Job j in this.jobList)
            {
                this.jobCmbo.Items.Add(j);
            }
        }

        private void ClockInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
        }
    }
}
