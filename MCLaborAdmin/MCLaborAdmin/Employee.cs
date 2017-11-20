using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string RefCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FullName { get { return String.Format("{0} {1}", this.FirstName,this.LastName); } }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public int LoginID { get; set; }

        public string PrimaryPhone { get; set; }

        public string AlternatePhone { get; set; }

        public string Ssn { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactRelationship { get; set; }

        public string EmergencyContactPhone { get; set; }

        public string EmergencyContactAddress { get; set; }

        public string EmergencyContactCity { get; set; }

        public string EmergencyContactState { get; set; }

        public int EmergencyContactZip { get; set; }

        public int HireStatus { get; set; }

        public DateTime HireStatusDate { get; set; }

        public string HireStatusDesc { get; set; }

        public List<PayRate> PayRateList { get; set; }

        public string TermReason { get; set; }


        public Employee()
        {
            this.PayRateList = new List<PayRate>();
        }
       
        public override string ToString()
        {
            return string.Format("{0}  ({1})",
                this.FullName,
                this.RefCode);
        }
    }
}
