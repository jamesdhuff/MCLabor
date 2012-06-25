using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    class ReportFilters
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Employee { get; set; }
        public string WorkSite { get; set; }
        public string Job { get; set; }

        public ReportFilters()
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today;
            this.Employee = string.Empty;
            this.WorkSite = string.Empty;
            this.Job = string.Empty;
        }
    }
}
