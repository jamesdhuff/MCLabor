using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCLaborAdmin
{
    public partial class AddEditPayRateForm : Form
    {
        EmployeeAddEditForm parentForm;
        PayRate currPayRate;
        bool isEdit;
        List<Job> alreadyAssignedJobList;

        public AddEditPayRateForm(EmployeeAddEditForm parentForm, PayRate currPayRate, bool isEdit)
        {
            this.parentForm = parentForm;
            this.currPayRate = currPayRate;
            this.isEdit = isEdit;
            InitializeComponent();
        }

        public AddEditPayRateForm(EmployeeAddEditForm parentForm, List<Job> alreadyAssignedJobList, PayRate currPayRate, bool isEdit)
        {
            this.alreadyAssignedJobList = alreadyAssignedJobList;
            this.parentForm = parentForm;
            this.currPayRate = currPayRate;
            this.isEdit = isEdit;
            InitializeComponent();
        }

        private void addEditPayRateCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEditPayRateSaveBtn_Click(object sender, EventArgs e)
        {
            bool formDataValid = true;
            try
            {
                this.currPayRate.HourlyPayRate = Decimal.Parse(this.addEditPayRateHourlyRateTxt.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Hourly Pay Rate must be in decimal format.", "Format Exception");
                formDataValid = false;
            }

            this.currPayRate.Active = this.addEditPayRateActiveCheckBox.Checked;
            if (formDataValid)
            {
                if (isEdit)
                {
                    if (!this.parentForm.editPayRate(this.currPayRate))
                    {
                        MessageBox.Show("Cannot set this Pay Rate active as another active Pay Rate exists for this employee for the same Job.", "Duplicate Active Jobs Exception");
                        formDataValid = false;
                    }
                }
                else
                {
                    this.currPayRate.Job = (Job)this.addEditPayRateJobCmboBox.SelectedItem;
                    this.parentForm.addPayRate(this.currPayRate);
                }

                if (formDataValid)
                {
                    this.Close();
                }
            }
        }

        private void AddEditPayRateForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            if(isEdit)
            {
                this.addEditPayRateJobCmboBox.Items.Add(this.currPayRate.Job);
                this.addEditPayRateJobCmboBox.SelectedIndex = 0;
                this.addEditPayRateJobCmboBox.Enabled = false;
                this.addEditPayRateHourlyRateTxt.Text = this.currPayRate.HourlyPayRate.ToString();
                this.addEditPayRateActiveCheckBox.Checked = this.currPayRate.Active;
            }
            else
            {
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT jobId, refCode, jobName FROM job ORDER BY jobName", conn))
                    {
                        using(IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Job j = new Job(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                                bool jobAlreadyAssigned = false;
                                foreach (Job alreadyAssignedJob in alreadyAssignedJobList)
                                {
                                    if (j.JobName == alreadyAssignedJob.JobName && j.RefCode == alreadyAssignedJob.RefCode)
                                    {
                                        jobAlreadyAssigned = true;
                                    }
                                }

                                if (!jobAlreadyAssigned)
                                {
                                    this.addEditPayRateJobCmboBox.Items.Add(j);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AddEditPayRateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.TopMost = true;
            this.parentForm.TopMost = false;
        }

        private void AddEditPayRateForm_Shown(object sender, EventArgs e)
        {
            if (this.addEditPayRateJobCmboBox.Items.Count < 1)
            {
                MessageBox.Show("All available jobs are already assigned to this employee", "No more Jobs to assign");
                this.Close();
            }
        }
    }
}
