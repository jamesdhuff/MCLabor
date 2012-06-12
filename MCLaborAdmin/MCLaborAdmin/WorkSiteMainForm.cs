﻿using System;
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
    public partial class WorkSiteMainForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private MainMenuForm mainMenuForm;
        private Dictionary<int, WorkSite> workSiteList;

        public WorkSiteMainForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            this.workSiteList = new Dictionary<int,WorkSite>();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void populateWorkSiteGrid()
        {
            string sqlString = "SELECT workSiteId, workSiteName, refCode, description, active FROM work_site";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        WorkSite ws = new WorkSite();
                        ws.WorkSiteId = reader.GetInt32(0);
                        ws.WorkSiteName = reader.GetString(1);
                        ws.RefCode = reader.GetString(2);
                        if (reader.IsDBNull(3))
                        {
                            ws.Description = string.Empty;
                        }
                        else
                        {
                            ws.Description = reader.GetString(3);
                        }
                        ws.Active = reader.GetBoolean(4);
                        this.workSiteList.Add(ws.WorkSiteId, ws);
                        this.workSiteDataGridView.Rows.Add(new object[] { ws.WorkSiteId, ws.RefCode, ws.WorkSiteName, ((ws.Active) ? "\u221A" : string.Empty) });
                    }
                }
            }
        }

        public void updateWorkSiteGrid(WorkSite ws)
        {
            bool newRecord = true;

            for (int i = this.workSiteDataGridView.Rows.Count - 1; i > -1; i--)
            {
                if (ws.WorkSiteId == (int)this.workSiteDataGridView.Rows[i].Cells[0].Value)
                {
                    newRecord = false;
                    this.workSiteDataGridView.Rows[i].Cells[1].Value = ws.RefCode;
                    this.workSiteDataGridView.Rows[i].Cells[2].Value = ws.WorkSiteName;
                    this.workSiteDataGridView.Rows[i].Cells[3].Value = ((ws.Active) ? "\u221A" : string.Empty);
                }
            }

            if (newRecord)
            {
                this.workSiteDataGridView.Rows.Add(new Object[] { ws.WorkSiteId, ws.RefCode, ws.WorkSiteName, ((ws.Active) ? "\u221A" : string.Empty) });
                this.workSiteList.Add(ws.WorkSiteId, ws);
            }
        }

        private void WorkSiteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void WorkSiteForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            populateWorkSiteGrid();
        }

        private void workSiteMainAddBtn_Click(object sender, EventArgs e)
        {
            WorkSiteAddEditForm workSiteAddEditForm = new WorkSiteAddEditForm(this, new WorkSite(-1, string.Empty, string.Empty, string.Empty));
            this.Enabled = false;
            workSiteAddEditForm.Show();
        }

        private void workSiteMainEditBtn_Click(object sender, EventArgs e)
        {
            if (this.workSiteDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single Work Site to edit", "Multiple Records Selected");
            }
            else if (this.workSiteDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a Work Site to edit");
            }
            else
            {
                WorkSite currWorkSite = this.workSiteList[(int)this.workSiteDataGridView.SelectedRows[0].Cells[0].Value];
                WorkSiteAddEditForm workSiteAddEditForm = new WorkSiteAddEditForm(this, currWorkSite);
                this.Enabled = false;
                workSiteAddEditForm.Show();
            }
        }

        private void workSiteMainCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
