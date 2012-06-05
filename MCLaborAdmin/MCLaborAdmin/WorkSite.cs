using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class WorkSite
    {
        private int workSiteId;
        private string refCode;
        private string workSiteName;
        private string description;

        public int WorkSiteId { get { return this.workSiteId; } set { this.workSiteId = value; } }

        public string RefCode { get { return this.refCode; } set { this.refCode = value; } }

        public string WorkSiteName { get { return this.workSiteName; } set { this.workSiteName = value; } }

        public string Description { get { return this.description; } set { this.description = value; } }

        public WorkSite()
        {
            this.workSiteId = -1;
            this.workSiteName = string.Empty;
            this.refCode = string.Empty;
            this.description = string.Empty;
        }

        public WorkSite(int workSiteId, string refCode, string workSiteName)
        {
            this.workSiteId = workSiteId;
            this.refCode = refCode;
            this.workSiteName = workSiteName;
            this.description = string.Empty;
        }

        public WorkSite(int workSiteId, string refCode, string workSiteName, string description)
        {
            this.workSiteId = workSiteId;
            this.refCode = refCode;
            this.workSiteName = workSiteName;
            this.description = description;
        }

        public override string ToString()
        {
            return this.workSiteName + "  (" + this.refCode + ")";
        }

    }
}
