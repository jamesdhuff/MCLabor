using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class TimeCard
    {
        private int laborDetailId;
        private Employee employee;
        private Job job;
        private WorkSite workSite;
        private DateTime calendarDate;
        private DateTime localStartTime;
        private DateTime localEndTime;
        private DateTime utcStartTime;
        private DateTime utcEndTime;




        public int LaborDetailID { get { return this.laborDetailId; } set { this.laborDetailId = value; } }

        public Employee Employee { get { return this.employee; } set { this.employee = value; } }

        public Job Job { get { return this.job; } set { this.job = value; } }

        public WorkSite WorkSite { get { return this.workSite; } set { this.workSite = value; } }

        public DateTime CalendarDate { get { return this.calendarDate; } set { this.calendarDate = value; } }

        public DateTime LocalStartTime { get { return this.localStartTime; } set { this.localStartTime = value; } }

        public DateTime LocalEndTime { get { return this.localEndTime; } set { this.localEndTime = value; } }

        public DateTime UtcStartTime { get { return this.utcStartTime; } set { this.utcStartTime = value; } }

        public DateTime UtcEndTime { get { return this.utcEndTime; } set { this.utcEndTime = value; } }

        public double TotalHours { get { return (this.utcEndTime - this.utcStartTime).TotalHours; } }

        public TimeCard()
        {
            this.laborDetailId = -1;
        }
    }
}
