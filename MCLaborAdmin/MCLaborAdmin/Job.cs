using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class Job
    {
        private int jobId;
        private string refCode;
        private string jobName;
        private string description;

        public int JobId
        {
            get
            {
                return this.jobId;
            }
            set
            {
                this.jobId = value;
            }
        }

        public string RefCode
        {
            get
            {
                return this.refCode;
            }
            set
            {
                this.refCode = value;
            }
        }

        public string JobName
        {
            get
            {
                return this.jobName;
            }
            set
            {
                this.jobName = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public Job()
        {
        }

        public Job(int jobId, string refCode, string jobName)
        {
            this.jobId = jobId;
            this.refCode = refCode;
            this.jobName = jobName;
        }

        public Job(int jobId, string refCode, string jobName, string description)
        {
            this.jobId = jobId;
            this.refCode = refCode;
            this.jobName = jobName;
            this.description = description;
        }

        public override string ToString()
        {
            return this.jobName.PadRight(15) + " |  " + this.refCode;
        }

    }
}
