using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class PayRate
    {
        private int payRateId;
        private Job job;
        private bool active;
        private decimal hourlyPayRate;

        public int PayRateId { get { return this.payRateId; } set { this.payRateId = value; } }

        public Job Job { get { return this.job; } set { this.job = value; } }

        public decimal HourlyPayRate { get { return this.hourlyPayRate; } set { this.hourlyPayRate = value; } }

        public bool Active { get { return this.active; } set { this.active = value; } }

        public PayRate()
        {
            this.payRateId = -1;
            this.Job = new Job();
        }

        public PayRate(Job job, decimal hourlyPayRate)
        {
            this.payRateId = -1;
            this.job = job;
            this.hourlyPayRate = hourlyPayRate;
            this.active = true;
        }

        public PayRate(int payRateId, Job job, decimal hourlyPayRate)
        {
            this.payRateId = payRateId;
            this.job = job;
            this.hourlyPayRate = hourlyPayRate;
            this.active = true;
        }

        public PayRate(int payRateId, int jobId, string jobRefCode, string jobName, decimal hourlyPayRate, bool active)
        {
            this.payRateId = payRateId;
            this.job = new Job(jobId, jobRefCode, jobName);
            this.hourlyPayRate = hourlyPayRate;
            this.active = active;
        }
    }
}
