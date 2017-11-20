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
    public partial class JobAddEditForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private JobMainForm jobMainForm;
        private Job currJob;

        public JobAddEditForm(JobMainForm jobMainForm, Job currJob)
        {
            this.jobMainForm = jobMainForm;
            this.currJob = currJob;
            InitializeComponent();
        }

        private void JobAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.jobAddEditNameTxt.Text = this.currJob.JobName;
            this.jobAddEditRefCodeTxt.Text = this.currJob.RefCode;
            this.jobAddEditDescriptionTxt.Text = this.currJob.Description;
            this.chkIsActive.Checked = this.currJob.IsActive;

        }

        private void jobAddEditCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JobAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.jobMainForm.Enabled = true;
            this.jobMainForm.Show();
        }

        private void jobAddEditSaveBtn_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                string insertString = "INSERT INTO job (jobName, refCode, description, isActive) VALUES (@jobName, @refCode, @description, @isActive); SELECT cast(Scope_Identity() as int)";
                string updateString = "UPDATE job SET jobName = @jobName, refCode = @refCode, description = @description, isActive = @isActive WHERE jobId = @jobId";
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    if (this.currJob.JobID == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertString, conn))
                        {
                            cmd.Parameters.AddWithValue("@jobName", this.currJob.JobName);
                            cmd.Parameters.AddWithValue("@refCode", this.currJob.RefCode);
                            if (this.currJob.Description.Equals(string.Empty))
                            {
                                cmd.Parameters.AddWithValue("@description", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@description", this.currJob.Description);
                            }
                            cmd.Parameters.AddWithValue("@isActive", this.currJob.IsActive);

                            this.currJob.JobID = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(updateString, conn))
                        {
                            cmd.Parameters.AddWithValue("@jobName", this.currJob.JobName);
                            cmd.Parameters.AddWithValue("@refCode", this.currJob.RefCode);
                            if (this.currJob.Description.Equals(string.Empty))
                            {
                                cmd.Parameters.AddWithValue("@description", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@description", this.currJob.Description);
                            }
                            cmd.Parameters.AddWithValue("@isActive", this.currJob.IsActive);
                            cmd.Parameters.AddWithValue("@jobId", this.currJob.JobID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.jobMainForm.PopulateJobGrid();
                this.Close();
            }
        }

        private bool validateFormData()
        {
            if (this.jobAddEditNameTxt.Text.Length < 1)
            {
                MessageBox.Show("Must enter a value for the Job Name field", "Data Validation Failed");
                this.jobAddEditNameTxt.Focus();
                return false;
            }

            this.currJob.JobName = this.jobAddEditNameTxt.Text;

            if (this.jobAddEditRefCodeTxt.Text.Length < 1)
            {
                MessageBox.Show("Must enter a value for the Ref Code field", "Data Validation Failed");
                this.jobAddEditRefCodeTxt.Focus();
                return false;
            }

            this.currJob.RefCode = this.jobAddEditRefCodeTxt.Text;

            if (this.jobAddEditDescriptionTxt.Text.Length < 1)
            {
                this.currJob.Description = string.Empty;
            }
            else
            {
                this.currJob.Description = this.jobAddEditDescriptionTxt.Text;
            }

            this.currJob.IsActive = this.chkIsActive.Checked;

            return true;
        }
    }
}
