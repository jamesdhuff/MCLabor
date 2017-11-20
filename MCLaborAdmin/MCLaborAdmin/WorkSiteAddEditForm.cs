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
    public partial class WorkSiteAddEditForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private WorkSiteMainForm workSiteMainForm;
        private WorkSite currWorkSite;

        public WorkSiteAddEditForm(WorkSiteMainForm workSiteMainForm, WorkSite currWorkSite)
        {
            this.workSiteMainForm = workSiteMainForm;
            this.currWorkSite = currWorkSite;
            InitializeComponent();
        }

        private void WorkSiteAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.workSiteAddEditNameTxt.Text = this.currWorkSite.WorkSiteName;
            this.workSiteAddEditRefCodeTxt.Text = this.currWorkSite.RefCode;
            this.workSiteAddEditDescriptionTxt.Text = this.currWorkSite.Description;
            this.activeChkBox.Checked = this.currWorkSite.Active;

        }

        private void workSiteAddEditCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkSiteAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.workSiteMainForm.Enabled = true;
            this.workSiteMainForm.Show();
        }

        private void workSiteAddEditSaveBtn_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                string insertString = "INSERT INTO work_site (workSiteName, refCode, description, active) VALUES (@workSiteName, @refCode, @description, @active); SELECT cast(Scope_Identity() as int)";
                string updateString = "UPDATE work_site SET workSiteName = @workSiteName, refCode = @refCode, description = @description, active = @active WHERE workSiteId = @workSiteId";
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    if (this.currWorkSite.WorkSiteId == -1)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertString, conn))
                        {
                            cmd.Parameters.AddWithValue("@workSiteName", this.currWorkSite.WorkSiteName);
                            cmd.Parameters.AddWithValue("@refCode", this.currWorkSite.RefCode);                            
                            if (this.currWorkSite.Description.Equals(string.Empty))
                            {
                                cmd.Parameters.AddWithValue("@description", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@description", this.currWorkSite.Description);
                            }
                            cmd.Parameters.AddWithValue("@active", this.currWorkSite.Active);

                            this.currWorkSite.WorkSiteId = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(updateString, conn))
                        {
                            cmd.Parameters.AddWithValue("@workSiteName", this.currWorkSite.WorkSiteName);
                            cmd.Parameters.AddWithValue("@refCode", this.currWorkSite.RefCode);
                            if (this.currWorkSite.Description.Equals(string.Empty))
                            {
                                cmd.Parameters.AddWithValue("@description", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@description", this.currWorkSite.Description);
                            }
                            cmd.Parameters.AddWithValue("@active", this.currWorkSite.Active);
                            cmd.Parameters.AddWithValue("@workSiteId", this.currWorkSite.WorkSiteId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.workSiteMainForm.populateWorkSiteGrid();                
                this.Close();
            }
        }

        private bool validateFormData()
        {
            if (this.workSiteAddEditNameTxt.Text.Length < 1)
            {
                MessageBox.Show("Must enter a value for the Work Site Name field", "Data Validation Failed");
                this.workSiteAddEditNameTxt.Focus();
                return false;
            }

            this.currWorkSite.WorkSiteName = this.workSiteAddEditNameTxt.Text;

            if (this.workSiteAddEditRefCodeTxt.Text.Length < 1)
            {
                MessageBox.Show("Must enter a value for the Ref Code field", "Data Validation Failed");
                this.workSiteAddEditRefCodeTxt.Focus();
                return false;
            }

            this.currWorkSite.RefCode = this.workSiteAddEditRefCodeTxt.Text;

            if (this.workSiteAddEditDescriptionTxt.Text.Length < 1)
            {
                this.currWorkSite.Description = string.Empty;
            }
            else
            {
                this.currWorkSite.Description = this.workSiteAddEditDescriptionTxt.Text;
            }

            this.currWorkSite.Active = this.activeChkBox.Checked;

            return true;
        }
    }
}
