using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborLib
{
    public interface ITimeCard
    {
        int LaborDetailId { get; set; }
        Job Job { get; set; }
        WorkSite WorkSite { get; set; }
        Employee Employee { get; set; }
        DateTime? CalendarDate { get; set; }
        DateTime? LocalStartTime { get; set; }
        DateTime? LocalEndTime { get; set; }
        DateTime? UtcStartTime { get; set; }
        DateTime? UtcEndTime { get;  set; }
    }

    [DataContract]
    public class TimeCard : ITimeCard
    {
        private int laborDetailId;
        private Employee employee;
        private Job job;
        private WorkSite workSite;
        private DateTime? calendarDate;
        private DateTime? localStartTime;
        private DateTime? localEndTime;
        private DateTime? utcStartTime;
        private DateTime? utcEndTime;

        [DataMember]
        public int LaborDetailId { get { return this.laborDetailId; } set { this.laborDetailId = value; } }

        [DataMember]
        public Employee Employee { get { return this.employee; } set { this.employee = value; } }

        [DataMember]
        public Job Job { get { return this.job; } set { this.job = value; } }

        [DataMember]
        public WorkSite WorkSite { get { return this.workSite; } set { this.workSite = value; } }

        [DataMember]
        public DateTime? CalendarDate { get { return this.calendarDate; } set { this.calendarDate = value; } }

        [DataMember]
        public DateTime? LocalStartTime { get { return this.localStartTime; } set { this.localStartTime = value; } }

        [DataMember]
        public DateTime? LocalEndTime { get { return this.localEndTime; } set { this.localEndTime = value; } }

        [DataMember]
        public DateTime? UtcStartTime { get { return this.utcStartTime; } set { this.utcStartTime = value; } }

        [DataMember]
        public DateTime? UtcEndTime { get { return this.utcEndTime; } set { this.utcEndTime = value; } }

        public double TotalHours
        {
            get
            {
                if (this.utcStartTime == null || this.utcEndTime == null)
                {
                    return 0;
                }
                else
                {
                    TimeSpan ts = new TimeSpan(this.utcEndTime.Value.Ticks - this.utcStartTime.Value.Ticks);
                    return ts.TotalHours;
                }
            }
        }

        public TimeCard()
        {
            this.laborDetailId = -1;
            this.employee = null;
            this.job = null;
            this.workSite = null;
            this.calendarDate = null;
            this.localStartTime = null;
            this.localEndTime = null;
            this.utcStartTime = null;
            this.utcEndTime = null;
        }

        public bool Equals(TimeCard tc)
        {
            if (
                (this.laborDetailId == tc.LaborDetailId) &&
                (this.employee.EmployeeId == tc.Employee.EmployeeId) &&
                (this.job.JobId == tc.job.JobId) &&
                (this.workSite.WorkSiteId == tc.WorkSite.WorkSiteId) &&
                (this.calendarDate.Equals(tc.CalendarDate)) &&
                (this.localStartTime.Equals(tc.LocalStartTime)) &&
                (this.localEndTime.Equals(tc.LocalEndTime)) &&
                (this.utcStartTime.Equals(tc.UtcStartTime)) &&
                (this.utcEndTime.Equals(tc.UtcEndTime))
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
