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
    public partial class TimeCardAddEditForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private TimeCardReviewForm timeCardReviewForm;
        private TimeCard currTimeCard;
        private TimeCard updatedTimeCard;
        private bool skipValueChangedAction = false;

        public TimeCardAddEditForm(TimeCardReviewForm timeCardReviewForm, TimeCard tc)
        {
            this.timeCardReviewForm = timeCardReviewForm;
            this.currTimeCard = tc;
            this.updatedTimeCard = new TimeCard();
            this.updatedTimeCard.LaborDetailId = tc.LaborDetailId;
            this.updatedTimeCard.Employee = tc.Employee;
            this.updatedTimeCard.Job = tc.Job;
            this.updatedTimeCard.WorkSite = tc.WorkSite;
            this.updatedTimeCard.CalendarDate = tc.CalendarDate;
            this.updatedTimeCard.LocalStartTime = tc.LocalStartTime;
            this.updatedTimeCard.LocalEndTime = tc.LocalEndTime;
            this.updatedTimeCard.UtcStartTime = tc.UtcStartTime;
            this.updatedTimeCard.UtcEndTime = tc.UtcEndTime;
            InitializeComponent();
        }

        private void populateJobs()
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT j.jobId, j.jobName, j.refCode " +
                                                        "FROM job j, pay_rate p " +
                                                        "WHERE j.jobId = p.jobId " +
                                                        "AND p.active = 1 " +
                                                        "AND p.employeeId = @employeeId"
                                                        , conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", this.currTimeCard.Employee.EmployeeId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job j = new Job();
                            j.JobId = reader.GetInt32(0);
                            j.JobName = reader.GetString(1);
                            j.RefCode = reader.GetString(2);

                            this.jobCmbo.Items.Add(j);
                        }
                    }
                }
            }
        }

        private void populateWorkSites()
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT workSiteId, workSiteName, refCode FROM work_site", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WorkSite ws = new WorkSite();
                            ws.WorkSiteId = reader.GetInt32(0);
                            ws.WorkSiteName = reader.GetString(1);
                            ws.RefCode = reader.GetString(2);

                            this.workSiteCmbo.Items.Add(ws);
                        }
                    }
                }
            }            

        }

        private bool validateFormData()
        {
            if ((!this.noClockOutChkBox.Checked) && (this.clockOutDatePicker.Value.CompareTo(this.clockInDatePicker.Value) < 1))
            {
                MessageBox.Show("Clock Out Time must be later than Clock In Time.", "Data Validation Failed");
                return false;
            }

            if (this.jobCmbo.SelectedItem == null)
            {
                MessageBox.Show("Please select a Job.", "Data Validation Failed");
                return false;
            }

            if (this.workSiteCmbo.SelectedItem == null)
            {
                MessageBox.Show("Please select a Work Site.", "Data Validation Failed");
                return false;
            }

            
            this.updatedTimeCard.LaborDetailId = this.currTimeCard.LaborDetailId;
            this.updatedTimeCard.Employee = this.currTimeCard.Employee;
            this.updatedTimeCard.Job = (Job)this.jobCmbo.SelectedItem;
            this.updatedTimeCard.WorkSite = (WorkSite)this.workSiteCmbo.SelectedItem;
            this.updatedTimeCard.CalendarDate = this.clockInDatePicker.Value.Date;
            this.updatedTimeCard.LocalStartTime = this.clockInDatePicker.Value;
            this.updatedTimeCard.UtcStartTime = this.clockInDatePicker.Value.ToUniversalTime();
            if (this.noClockOutChkBox.Checked)
            {
                this.updatedTimeCard.LocalEndTime = null;
                this.updatedTimeCard.UtcEndTime = null;
            }
            else
            {
                this.updatedTimeCard.LocalEndTime = this.clockOutDatePicker.Value;
                this.updatedTimeCard.UtcEndTime = this.clockOutDatePicker.Value.ToUniversalTime();
            }
            

            //Check for overlapping time card records
            bool overlap = false;
            string overlapMessage = "This time card record will overlap existing records." + Environment.NewLine + Environment.NewLine +
                                    "Records that overlap...";

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();

                string sqlstring;

                if (this.noClockOutChkBox.Checked)
                {
                    sqlstring = "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE (laborEndDateTime IS NULL " +
                                "		OR @clockInTime < laborEndUtcDateTime) " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId";
                }
                else
                {
                    sqlstring = "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE @clockInTime BETWEEN laborStartUtcDateTime AND laborEndUtcDateTime " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId " +
                                "UNION " +
                                "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE @clockOutTime BETWEEN laborStartUtcDateTime AND laborEndUtcDateTime " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId " +
                                "UNION " +
                                "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE laborStartUtcDateTime BETWEEN @clockInTime AND @clockOutTime " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId " +
                                "UNION " +
                                "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE laborEndUtcDateTime BETWEEN @clockInTime AND @clockOutTime " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId " +
                                "UNION " +
                                "SELECT laborDetailId, laborStartDateTime, laborEndDateTime " +
                                "FROM labor_detail " +
                                "WHERE laborEndUtcDateTime IS NULL " +
                                "AND @clockOutTime > laborStartUtcDateTime " +
                                "AND employeeId = @employeeId " +
                                "AND laborDetailId != @laborDetailId ";
                }

                using (SqlCommand cmd = new SqlCommand(sqlstring, conn))
                {
                    cmd.Parameters.AddWithValue("@laborDetailId", this.updatedTimeCard.LaborDetailId);
                    cmd.Parameters.AddWithValue("@employeeId", this.updatedTimeCard.Employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@clockInTime", this.updatedTimeCard.UtcStartTime);
                    if (!this.noClockOutChkBox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@clockOutTime", this.updatedTimeCard.UtcEndTime);
                    }
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<int> overlapRecordList = new List<int>();
                        while (reader.Read())
                        {
                            overlap = true;
                            int id = reader.GetInt32(0);
                            DateTime start = reader.GetDateTime(1);
                            DateTime? end = null;
                            if (!reader.IsDBNull(2))
                            {
                                end = (DateTime)reader.GetDateTime(2);
                            }

                            if (!overlapRecordList.Contains(id))
                            {
                                overlapRecordList.Add(id);
                                overlapMessage += Environment.NewLine + "ID = " + id + ", Clock In = " + start + ", Clock Out = " + ((end == null) ? "null" : end.ToString());
                            }
                        }
                    }
                }
            }

            if (overlap)
            {
                overlapMessage += Environment.NewLine + Environment.NewLine +
                                "Click YES if you'd like to make this change, regardless of overlap.  " + Environment.NewLine +
                                "Click NO if you'd like to cancel the change and go back to editing the time card.";

                DialogResult result = MessageBox.Show(this, overlapMessage, "Time Card Overlap", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }


        private void saveTimeCard()
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();

                string insertString = "INSERT INTO labor_detail " +
                                      " (employeeId, workSiteId, jobId, laborCalendarDate, laborStartDateTime, laborEndDateTime, laborStartUTCDateTime, laborEndUTCDateTime) " +
                                      "VALUES (@employeeId, @workSiteId, @jobId, @calendarDate, @startTime, @endTime, @startUtcTime, @endUtcTime); " +
                                      "SELECT cast(Scope_Identity() as int)";

                string updateString = "UPDATE labor_detail SET " +
                                      " workSiteId = @workSiteId, " +
                                      " jobId = @jobId, " +
                                      " laborCalendarDate = @calendarDate, " +
                                      " laborStartDateTime = @startTime, " +
                                      " laborEndDateTime = @endTime, " +
                                      " laborStartUTCDateTime = @startUtcTime, " +
                                      " laborEndUTCDateTime = @endUtcTime " +
                                      "WHERE laborDetailId = @laborDetailId " +
                                      "AND employeeId = @employeeId ";

                if (this.updatedTimeCard.LaborDetailId == -1)
                {
                    using (SqlCommand cmd = new SqlCommand(insertString, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", this.updatedTimeCard.Employee.EmployeeId);
                        cmd.Parameters.AddWithValue("@workSiteId", this.updatedTimeCard.WorkSite.WorkSiteId);
                        cmd.Parameters.AddWithValue("@jobId", this.updatedTimeCard.Job.JobId);
                        cmd.Parameters.AddWithValue("@calendarDate", this.updatedTimeCard.CalendarDate);
                        cmd.Parameters.AddWithValue("@startTime", this.updatedTimeCard.LocalStartTime);                        
                        cmd.Parameters.AddWithValue("@startUtcTime", this.updatedTimeCard.UtcStartTime);

                        if (this.noClockOutChkBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@endTime", DBNull.Value);
                            cmd.Parameters.AddWithValue("@endUtcTime", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@endTime", this.updatedTimeCard.LocalEndTime);
                            cmd.Parameters.AddWithValue("@endUtcTime", this.updatedTimeCard.UtcEndTime);
                        }

                        this.updatedTimeCard.LaborDetailId = (int)cmd.ExecuteScalar();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand(updateString, conn))
                    {
                        cmd.Parameters.AddWithValue("@laborDetailId", this.updatedTimeCard.LaborDetailId);
                        cmd.Parameters.AddWithValue("@employeeId", this.updatedTimeCard.Employee.EmployeeId);
                        cmd.Parameters.AddWithValue("@workSiteId", this.updatedTimeCard.WorkSite.WorkSiteId);
                        cmd.Parameters.AddWithValue("@jobId", this.updatedTimeCard.Job.JobId);
                        cmd.Parameters.AddWithValue("@calendarDate", this.updatedTimeCard.CalendarDate);
                        cmd.Parameters.AddWithValue("@startTime", this.updatedTimeCard.LocalStartTime);
                        cmd.Parameters.AddWithValue("@startUtcTime", this.updatedTimeCard.UtcStartTime);

                        if (this.noClockOutChkBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@endTime", DBNull.Value);
                            cmd.Parameters.AddWithValue("@endUtcTime", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@endTime", this.updatedTimeCard.LocalEndTime);
                            cmd.Parameters.AddWithValue("@endUtcTime", this.updatedTimeCard.UtcEndTime);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
            }            
        }


        private void TimeCardAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.empNameTxt.Text = this.currTimeCard.Employee.FullName + "  (" + this.currTimeCard.Employee.RefCode + ")";
            populateJobs();
            populateWorkSites();

            //In case we're editing a time card for a Job that's no longer active for this employee, and thus isn't in the list, we'll add it to the list so it can be selected.
            bool jobNotInList = true;
            for (int i = this.jobCmbo.Items.Count - 1; i > -1 ; i-- )
            {
                if (this.currTimeCard.Job.JobId == ((Job)this.jobCmbo.Items[i]).JobId)
                {
                    this.jobCmbo.SelectedIndex = i;
                    jobNotInList = false;
                }
            }

            for (int i = this.workSiteCmbo.Items.Count - 1; i > -1; i--)
            {
                if (this.currTimeCard.WorkSite.WorkSiteId == ((WorkSite)this.workSiteCmbo.Items[i]).WorkSiteId)
                {
                    this.workSiteCmbo.SelectedIndex = i;
                }
            }

            if (jobNotInList)
            {
                if (this.currTimeCard.Job.JobId != -1)
                {
                    this.jobCmbo.Items.Insert(this.jobCmbo.Items.Count, this.currTimeCard.Job);
                    this.jobCmbo.SelectedIndex = this.jobCmbo.Items.Count - 1;
                }
            }

            if (this.currTimeCard.LocalStartTime != null)
            {
                this.clockInDatePicker.Value = (DateTime)this.currTimeCard.LocalStartTime;
            }
            
            if (this.currTimeCard.LocalEndTime != null)
            {
                this.clockOutDatePicker.Value = (DateTime)this.currTimeCard.LocalEndTime;
            }
            else
            {
                this.noClockOutChkBox.Checked = true;
            }
        }

        private void TimeCardAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timeCardReviewForm.Show();
        }

        private void clockInDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (skipValueChangedAction)
            {
                skipValueChangedAction = false;
            }
            else
            {
                skipValueChangedAction = true;
                this.clockInTimePicker.Value = this.clockInDatePicker.Value;
            }
        }

        private void clockInTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (skipValueChangedAction)
            {
                skipValueChangedAction = false;
            }
            else
            {
                skipValueChangedAction = true;
                this.clockInDatePicker.Value = this.clockInTimePicker.Value;
            }
        }

        private void clockOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (skipValueChangedAction)
            {
                skipValueChangedAction = false;
            }
            else
            {
                skipValueChangedAction = true;
                this.clockOutTimePicker.Value = this.clockOutDatePicker.Value;
            }
        }

        private void clockOutTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (skipValueChangedAction)
            {
                skipValueChangedAction = false;
            }
            else
            {
                skipValueChangedAction = true;
                this.clockOutDatePicker.Value = this.clockOutTimePicker.Value;
            }
        }

        private void noClockOutChkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.clockOutDatePicker.Enabled = !this.noClockOutChkBox.Checked;
            this.clockOutTimePicker.Enabled = !this.noClockOutChkBox.Checked;
        }

        private void timeCardAddEditCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeCardAddEditSaveBtn_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                if (this.updatedTimeCard.Equals(this.currTimeCard))
                {
                    MessageBox.Show("No changes to save.");
                }
                else
                {
                    saveTimeCard();
                    this.timeCardReviewForm.updateTimeCardGrid(this.updatedTimeCard);
                }

                this.Close();
            }
        }
    }
}
