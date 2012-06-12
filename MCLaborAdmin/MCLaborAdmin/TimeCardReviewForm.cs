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
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
                            tc.LaborDetailId = reader.GetInt32(0);
                            tc.CalendarDate = reader.GetDateTime(1);
                            tc.LocalStartTime = reader.GetDateTime(2);
                            if (reader.IsDBNull(3))
                            {
                                tc.LocalEndTime = null;
                            }
                            else
                            {
                                tc.LocalEndTime = reader.GetDateTime(3);
                            }
                            tc.UtcStartTime = reader.GetDateTime(4);
                            if (reader.IsDBNull(5))
                            {
                                tc.UtcEndTime = null;
                            }
                            else
                            {
                                tc.UtcEndTime = reader.GetDateTime(5);
                            }
                            tc.WorkSite = new WorkSite(reader.GetInt32(6), reader.GetString(8), reader.GetString(7));
                            tc.Job = new Job(reader.GetInt32(9), reader.GetString(11), reader.GetString(10));
                            tc.Employee = this.currEmp;

                            this.timeCardDataGridView.Rows.Add(new Object[] 
                                                                    {   tc.LaborDetailId,
                                                                        ((DateTime)tc.CalendarDate).ToString("d"),
                                                                        tc.Job.ToString(),
                                                                        tc.WorkSite.ToString(),
                                                                        tc.LocalStartTime.ToString(),
                                                                        (tc.LocalEndTime == null) ? string.Empty : tc.LocalEndTime.ToString(), 
                                                                        String.Format("{0:0.00}",tc.TotalHours)   });

                            this.timeCardList.Add(tc.LaborDetailId, tc);
                        }
                    }
                }
            }

        }

        public void updateTimeCardGrid(TimeCard tc)
        {
            bool newRecord = true;

            for (int i = this.timeCardDataGridView.Rows.Count - 1; i > -1; i--)
            {
                if (tc.LaborDetailId == (int)this.timeCardDataGridView.Rows[i].Cells[0].Value)
                {
                    newRecord = false;
                    this.timeCardDataGridView.Rows[i].Cells[1].Value = ((DateTime)tc.CalendarDate).ToString("d");
                    this.timeCardDataGridView.Rows[i].Cells[2].Value = tc.Job.ToString();
                    this.timeCardDataGridView.Rows[i].Cells[3].Value = tc.WorkSite.ToString();
                    this.timeCardDataGridView.Rows[i].Cells[4].Value = tc.LocalStartTime.ToString();
                    this.timeCardDataGridView.Rows[i].Cells[5].Value = (tc.LocalEndTime == null) ? string.Empty : tc.LocalEndTime.ToString();
                    this.timeCardDataGridView.Rows[i].Cells[6].Value = String.Format("{0:0.00}", tc.TotalHours);

                    this.timeCardList[tc.LaborDetailId] = tc;
                }
            }

            if (newRecord)
            {
                this.timeCardDataGridView.Rows.Add(new Object[] 
                                                                    {   tc.LaborDetailId,
                                                                        ((DateTime)tc.CalendarDate).ToString("d"),
                                                                        tc.Job.ToString(),
                                                                        tc.WorkSite.ToString(),
                                                                        tc.LocalStartTime.ToString(),
                                                                        (tc.LocalEndTime == null) ? string.Empty : tc.LocalEndTime.ToString(), 
                                                                        String.Format("{0:0.00}",tc.TotalHours)   });

                this.timeCardList.Add(tc.LaborDetailId, tc);
            }
        }


        private void TimeCardReviewForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
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

        private void timeCardReviewSummaryTotalsBtn_Click(object sender, EventArgs e)
        {
            TimeCardSummaryTotalsForm summaryForm = new TimeCardSummaryTotalsForm(this, this.timeCardList.Values.ToList(), this.currEmp, this.timeCardReviewDateRangeTxt.Text);
            this.Hide();
            summaryForm.Show();
        }
    }
}
