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
    public partial class TimeCardReviewForm : Form
    {
        private Employee currEmp;
        private Form parentForm;
        private DateTime startDate;
        private DateTime endDate;
        private Dictionary<int, TimeCard> timeCardList;

        public TimeCardReviewForm(Form parentForm, Employee emp, DateTime startDate, DateTime endDate)
        {
            this.parentForm = parentForm;
            this.currEmp = emp;
            this.startDate = startDate;
            this.endDate = endDate;
            this.timeCardList = new Dictionary<int, TimeCard>();
            InitializeComponent();
        }

        private void populateTimeCardDataGrid()
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT	laborDetailId, laborCalendarDate, laborStartDateTime, laborEndDateTime, laborStartUtcDateTime, laborEndUtcDateTime, " +
                                                        "       ws.workSiteId, ws.workSiteName, ws.refCode, " +
                                                        "       j.jobId, j.jobName, j.refCode " +
                                                        "FROM	labor_detail l, work_site ws, job j " +
                                                        "WHERE	l.jobId = j.jobId AND l.workSiteId = ws.workSiteId " +
                                                        "AND    l.employeeId = @employeeId " +
                                                        "AND	l.laborCalendarDate BETWEEN @startDate AND @endDate " +
                                                        "ORDER BY laborStartDateTime",
                                                        conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", this.currEmp.EmployeeId);
                    cmd.Parameters.AddWithValue("@startDate", this.startDate);
                    cmd.Parameters.AddWithValue("@endDate", this.endDate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TimeCard tc = new TimeCard();
                            tc.LaborDetailID = reader.GetInt32(0);
                            tc.CalendarDate = reader.GetDateTime(1);
                            tc.LocalStartTime = reader.GetDateTime(2);
                            tc.LocalEndTime = reader.GetDateTime(3);
                            tc.UtcStartTime = reader.GetDateTime(4);
                            tc.UtcEndTime = reader.GetDateTime(5);
                            tc.WorkSite = new WorkSite(reader.GetInt32(6), reader.GetString(8), reader.GetString(7));
                            tc.Job = new Job(reader.GetInt32(9), reader.GetString(11), reader.GetString(10));
                            tc.Employee = this.currEmp;

                            this.timeCardDataGridView.Rows.Add(new Object[] 
                                                                    {   tc.LaborDetailID,
                                                                        tc.CalendarDate.ToString("d"),
                                                                        tc.Job.JobName,
                                                                        tc.WorkSite.WorkSiteName,
                                                                        tc.LocalStartTime,
                                                                        tc.LocalEndTime, 
                                                                        String.Format("{0:0.00}",tc.TotalHours)   });

                            this.timeCardList.Add(tc.LaborDetailID, tc);
                        }
                    }
                }
            }

        }


        private void TimeCardReviewForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            populateTimeCardDataGrid();
            this.timeCardReviewEmpNameTxt.Text = this.currEmp.FullName;
            this.timeCardReviewDateRangeTxt.Text = this.startDate.ToString("d") + " - " + this.endDate.ToString("d");

        }

        private void timeCardReviewAddBtn_Click(object sender, EventArgs e)
        {
            TimeCard tc = new TimeCard();
            tc.Job = new Job();
            tc.WorkSite = new WorkSite();
            tc.Employee = this.currEmp;
            TimeCardAddEditForm addEditForm = new TimeCardAddEditForm(this, tc);
            this.Hide();
            addEditForm.Show(this);
        }

        private void timeCardReviewEditBtn_Click(object sender, EventArgs e)
        {
            if (this.timeCardDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single record to edit.");
            }
            else if (this.timeCardDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a record to edit.");
            }
            else
            {
                TimeCard tc = this.timeCardList[(int)this.timeCardDataGridView.SelectedRows[0].Cells[0].Value];
                TimeCardAddEditForm addEditForm = new TimeCardAddEditForm(this, tc);
                this.Hide();
                addEditForm.Show(this);
            }
        }

        private void timeCardReviewCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeCardReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }
    }
}
