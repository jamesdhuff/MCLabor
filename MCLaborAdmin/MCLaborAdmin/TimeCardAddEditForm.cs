using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCLaborAdmin
{
    public partial class TimeCardAddEditForm : Form
    {
        private TimeCardReviewForm timeCardReviewForm;
        private TimeCard currTimeCard;

        public TimeCardAddEditForm(TimeCardReviewForm timeCardReviewForm, TimeCard tc)
        {
            this.timeCardReviewForm = timeCardReviewForm;
            this.currTimeCard = tc;
            InitializeComponent();
        }

        private void populateJobs()
        {

        }

        private void populateWorkSites()
        {

        }


        private void TimeCardAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.empNameTxt.Text = this.currTimeCard.Employee.FullName;
            populateJobs();
            populateWorkSites();

            //In case we're editing a time card for a Job that's no longer active for this employee, and thus isn't in the list, we'll add it to the list so it can be selected.
            bool jobNotInList = true;
            for (int i = this.jobCmbo.Items.Count; i > -1 ; i-- )
            {
                if (this.currTimeCard.Job.JobId == ((Job)this.jobCmbo.Items[i]).JobId)
                {
                    this.jobCmbo.SelectedIndex = i;
                    jobNotInList = false;
                }
            }

            if (jobNotInList && this.currTimeCard.Job.JobId != -1)
            {
                this.jobCmbo.Items.Insert(this.jobCmbo.Items.Count,this.currTimeCard.Job);
                this.jobCmbo.SelectedIndex = this.jobCmbo.Items.Count - 1;
            }

            


        }

        private void TimeCardAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timeCardReviewForm.Show();
        }
    }
}
