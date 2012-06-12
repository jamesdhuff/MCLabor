using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborLib
{
    public interface IJob
    {
        int JobId { get; set; }
        string RefCode { get; set; }
        string JobName { get; set; }
        string Description { get; set; }
    }

    [DataContract]
    public class Job : IJob
    {
        [DataMember]
        private int jobId;
        [DataMember]
        private string refCode;
        [DataMember]
        private string jobName;
        [DataMember]
        private string description;

        [DataMember]
        public int JobId { get { return this.jobId; } set { this.jobId = value; } }

        [DataMember]
        public string RefCode { get { return this.refCode; } set { this.refCode = value; } }

        [DataMember]
        public string JobName { get { return this.jobName; } set { this.jobName = value; } }

        [DataMember]
        public string Description { get { return this.description; } set { this.description = value; } }

        public Job()
        {
            this.jobId = -1;
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
            return this.jobName + "  (" + this.refCode + ")";
        }

    }
}
