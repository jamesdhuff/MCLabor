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
    public partial class TimeCardSummaryTotalsForm : Form
    {

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Form parentForm;
        private List<TimeCard> timeCardList;
        private Employee currEmp;
        private string dateRangeString;

        public TimeCardSummaryTotalsForm(Form parentForm, List<TimeCard> timeCardList, Employee currEmp, string dateRangeString)
        {
            this.parentForm = parentForm;
            this.timeCardList = timeCardList;
            this.currEmp = currEmp;
            this.dateRangeString = dateRangeString;
            InitializeComponent();
        }

        private void populateSummaryGrid()
        {
            List<string> dateList = new List<string>();
            foreach (TimeCard tc in this.timeCardList)
            {
                bool newGroup = true;
                int groupIndex = 0;
                string id = tc.WorkSite.WorkSiteId + "|" + tc.Job.JobId;

                for (int i = this.timeCardSummaryDataGridView.Rows.Count - 1; i > -1; i--)
                {
                    if (id.Equals(this.timeCardSummaryDataGridView.Rows[i].Cells[0].Value.ToString()))
                    {
                        groupIndex = i;
                        newGroup = false;
                    }
                }

                if (newGroup)
                {
                    this.timeCardSummaryDataGridView.Rows.Add(new Object[] {  id,
                                                                              tc.WorkSite.ToString(),
                                                                              tc.Job.ToString(),
                                                                              1,
                                                                              String.Format("{0:0.00}", tc.TotalHours) });
                    dateList.Add(id + "|" + tc.CalendarDate.Value.Ticks);
                }
                else
                {
                    if(!dateList.Contains(id + "|" + tc.CalendarDate.Value.Ticks))
                    {
                        this.timeCardSummaryDataGridView.Rows[groupIndex].Cells[3].Value = (int)this.timeCardSummaryDataGridView.Rows[groupIndex].Cells[3].Value + 1;
                        dateList.Add(id + "|" + tc.CalendarDate.Value.Ticks);
                    }

                    this.timeCardSummaryDataGridView.Rows[groupIndex].Cells[4].Value = String.Format("{0:0.00}", Double.Parse(this.timeCardSummaryDataGridView.Rows[groupIndex].Cells[4].Value.ToString()) + tc.TotalHours);
                }
            }
        }

        private void timeCardSummaryPrintBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button doesn't do anything yet.  Fuck off.");
        }

        private void timeCardSummaryCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeCardSummaryTotalsForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            populateSummaryGrid();
            this.empNameTxt.Text = this.currEmp.FullName;
            this.dateRangeTxt.Text = this.dateRangeString;
        }

        private void TimeCardSummaryTotalsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }
    }
}
