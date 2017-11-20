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
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Form parentForm;
        private Dictionary<int, Job> jobList;

        public JobMainForm(Form parentForm)
        {
            this.parentForm = parentForm;
            this.jobList = new Dictionary<int, Job>();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void PopulateJobGrid()
        {
            this.jobDataGridView.Rows.Clear();
            this.jobList.Clear();

            string sqlString = "SELECT jobId, jobName, refCode, description, isActive FROM job WHERE isActive = 1 OR @ShowInactive = 1 ORDER BY jobName";

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowInactive", this.chkShowInactive.Checked);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Job job = new Job();
                        job.JobID = reader.GetInt32(0);
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
                        job.IsActive = reader.GetBoolean(4);

                        this.jobList.Add(job.JobID, job);
                        this.jobDataGridView.Rows.Add(new object[] { job.JobID, job.JobName, job.RefCode, job.Description, job.IsActive });
                    }
                }
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

            PopulateJobGrid();
        }

        private void JobAddBtn_Click(object sender, EventArgs e)
        {
            JobAddEditForm jobAddEditForm = new JobAddEditForm(this, new Job() { JobID = -1 });
            this.Enabled = false;
            jobAddEditForm.Show();
        }

        private void JobEditBtn_Click(object sender, EventArgs e)
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
                jobAddEditForm.Text = "Edit Job";
                this.Enabled = false;
                jobAddEditForm.Show();
            }
        }

        private void JobCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkShowInactive_CheckedChanged(object sender, EventArgs e)
        {
            PopulateJobGrid();
        }
    }
}

