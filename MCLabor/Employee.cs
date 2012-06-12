using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborLib
{    
    public interface IEmployee
    {        
        int EmployeeId { get; set; }
        string RefCode { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int LoginId { get; set; }
        bool IsClockedIn { get; set; }
        List<PayRate> PayRateList { get; set; }
    }

    [DataContract]
    public class Employee : IEmployee
    {
        private int employeeId;
        private string refCode;
        private string firstName;
        private string lastName;
        private int loginId;
        private bool isClockedIn;
        private List<PayRate> payRateList;

        [DataMember]
        public int EmployeeId { get { return this.employeeId; } set { this.employeeId = value; } }

        [DataMember]
        public string RefCode { get { return this.refCode; } set { this.refCode = value; } }

        [DataMember]
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        [DataMember]
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public string FullName { get { return this.firstName + " " + this.lastName; } }

        [DataMember]
        public int LoginId { get { return this.loginId; } set { this.loginId = value; } }

        [DataMember]
        public bool IsClockedIn { get { return this.isClockedIn; } set { this.isClockedIn = value; } }
        public List<PayRate> PayRateList { get { return this.payRateList; } set { this.payRateList = value; } }

        public Employee()
        {
            this.employeeId = -1;
            this.payRateList = new List<PayRate>();
            this.isClockedIn = false;
        }

        public Employee(int id, string refCode, string firstname, string lastname)
        {
            this.employeeId = id;
            this.refCode = refCode;
            this.firstName = firstname;
            this.lastName = lastname;
            this.payRateList = new List<PayRate>();
            this.isClockedIn = false;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + "  (" + this.refCode + ")";
        }
    }
}
