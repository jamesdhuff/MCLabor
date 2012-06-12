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
        private bool active;

        public int WorkSiteId { get { return this.workSiteId; } set { this.workSiteId = value; } }

        public string RefCode { get { return this.refCode; } set { this.refCode = value; } }

        public string WorkSiteName { get { return this.workSiteName; } set { this.workSiteName = value; } }

        public string Description { get { return this.description; } set { this.description = value; } }

        public bool Active { get { return this.active; } set { this.active = value; } }

        public WorkSite()
        {
            this.workSiteId = -1;
            this.workSiteName = string.Empty;
            this.refCode = string.Empty;
            this.description = string.Empty;
            this.active = true;
        }

        public WorkSite(int workSiteId, string refCode, string workSiteName)
        {
            this.workSiteId = workSiteId;
            this.refCode = refCode;
            this.workSiteName = workSiteName;
            this.description = string.Empty;
            this.active = true;
        }

        public WorkSite(int workSiteId, string refCode, string workSiteName, string description)
        {
            this.workSiteId = workSiteId;
            this.refCode = refCode;
            this.workSiteName = workSiteName;
            this.description = description;
            this.active = true;
        }

        public override string ToString()
        {
            return this.workSiteName + "  (" + this.refCode + ")";
        }

    }
}
