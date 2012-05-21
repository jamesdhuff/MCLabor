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
        private decimal hourlyPayRate;

        public int PayRateId
        {
            get
            {
                return this.payRateId;
            }
            set
            {
                this.payRateId = value;
            }
        }


        public Job Job
        {
            get
            {
                return this.job;
            }
            set
            {
                this.job = value;
            }
        }

        public decimal HourlyPayRate
        {
            get
            {
                return this.hourlyPayRate;
            }
            set
            {
                this.hourlyPayRate = value;
            }
        }



        public PayRate()
        {
        }

        public PayRate(Job job, decimal hourlyPayRate)
        {
            this.payRateId = -1;
            this.job = job;
            this.hourlyPayRate = hourlyPayRate;
        }

        public PayRate(int payRateId, Job job, decimal hourlyPayRate)
        {
            this.payRateId = payRateId;
            this.job = job;
            this.hourlyPayRate = hourlyPayRate;
        }

        public PayRate(int payRateId, int jobId, string jobRefCode, string jobName, decimal hourlyPayRate)
        {
            this.payRateId = payRateId;
            this.job = new Job(jobId, jobRefCode, jobName);
            this.hourlyPayRate = hourlyPayRate;
        }
    }
}
