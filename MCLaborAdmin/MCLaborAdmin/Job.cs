using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class Job
    {

        public int JobID { get; set; }

        public string RefCode { get; set; }

        public string JobName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", 
                this.JobName,
                this.RefCode);
        }
    }
}
