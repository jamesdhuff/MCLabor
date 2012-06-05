using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCLaborAdmin
{
    public partial class JobMainForm : Form
    {
        private Form parentForm;
        private Dictionary<int, Job> jobList;

        public JobMainForm(Form parentForm)
        {
            this.parentForm = parentForm;
            this.jobList = new Dictionary<int, Job>();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void populateJobGrid()
        {
            string sqlString = "SELECT jobId, jobName, refCode, description FROM job";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Job job = new Job();
                        job.JobId = reader.GetInt32(0);
                        job.JobName = reader.GetString(1);
                        job.RefCode = reader.GetString(2);
                        if(reader.IsDBNull(3))
                        {
                            job.Description = string.Empty;
                        }
                        else
                        {
                            job.Description = reader.GetString(3);
                        }
                        this.jobList.Add(job.JobId, job);
                        this.jobDataGridView.Rows.Add(new object[] { job.JobId, job.JobName, job.RefCode, job.Description });
                    }
                }
            }
        }

        public void updateJobGrid(Job job)
        {
            bool newJob = true;

            for (int i = this.jobDataGridView.Rows.Count - 1; i > -1; i--)
            {
                if (job.JobId == (int)this.jobDataGridView.Rows[i].Cells[0].Value)
                {
                    newJob = false;
                    this.jobDataGridView.Rows[i].Cells[1].Value = job.JobName;
                    this.jobDataGridView.Rows[i].Cells[2].Value = job.RefCode;
                    this.jobDataGridView.Rows[i].Cells[3].Value = job.Description;
                }
            }

            if (newJob)
            {
                this.jobDataGridView.Rows.Add(new Object[] { job.JobId, job.JobName, job.RefCode, job.Description });
                this.jobList.Add(job.JobId, job);
            }
        }

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            populateJobGrid();
        }

        private void jobAddBtn_Click(object sender, EventArgs e)
        {
            JobAddEditForm jobAddEditForm = new JobAddEditForm(this, new Job(-1, string.Empty, string.Empty, string.Empty));
            this.Enabled = false;
            jobAddEditForm.Show();
        }

        private void jobEditBtn_Click(object sender, EventArgs e)
        {
            if (this.jobDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single Job to edit");
            }
            else if (this.jobDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a Job to edit");
            }
            else
            {
                Job currJob = this.jobList[(int)this.jobDataGridView.SelectedRows[0].Cells[0].Value];
                JobAddEditForm jobAddEditForm = new JobAddEditForm(this, currJob);
                this.Enabled = false;
                jobAddEditForm.Show();
            }
        }

        private void jobCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

