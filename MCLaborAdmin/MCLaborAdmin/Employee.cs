using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    public class Employee
    {
        private int employeeId;
        private string refCode;
        private string firstName;
        private string middleName;
        private string lastName;
        private int loginId;
        private string address;
        private string city;
        private string state;
        private int zip;
        private string ssn;
        private string primaryPhone;
        private string alternatePhone;
        private string emergencyContactName;
        private string emergencyContactRelationship;
        private string emergencyContactAddress;
        private string emergencyContactCity;
        private string emergencyContactState;
        private int emergencyContactZip;
        private string emergencyContactPhone;
        private int hireStatus;
        private DateTime hireStatusDate;

        private List<PayRate> payRateList;
        

        public int EmployeeId
        {
            get
            {
                return this.employeeId;
            }
            set
            {
                this.employeeId = value;
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

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public int Zip
        {
            get
            {
                return this.zip;
            }
            set
            {
                this.zip = value;
            }
        }

        public int LoginId
        {
            get
            {
                return this.loginId;
            }
            set
            {
                this.loginId = value;
            }
        }

        public string PrimaryPhone
        {
            get
            {
                return this.primaryPhone;
            }
            set
            {
                this.primaryPhone = value;
            }
        }

        public string AlternatePhone
        {
            get
            {
                return this.alternatePhone;
            }
            set
            {
                this.alternatePhone = value;
            }
        }

        public string Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string EmergencyContactName
        {
            get
            {
                return this.emergencyContactName;
            }
            set
            {
                this.emergencyContactName = value;
            }
        }

        public string EmergencyContactRelationship
        {
            get
            {
                return this.emergencyContactRelationship;
            }
            set
            {
                this.emergencyContactRelationship = value;
            }
        }

        public string EmergencyContactPhone
        {
            get
            {
                return this.emergencyContactPhone;
            }
            set
            {
                this.emergencyContactPhone = value;
            }
        }

        public string EmergencyContactAddress
        {
            get
            {
                return this.emergencyContactAddress;
            }
            set
            {
                this.emergencyContactAddress = value;
            }
        }

        public string EmergencyContactCity
        {
            get
            {
                return this.emergencyContactCity;
            }
            set
            {
                this.emergencyContactCity = value;
            }
        }

        public string EmergencyContactState
        {
            get
            {
                return this.emergencyContactState;
            }
            set
            {
                this.emergencyContactState = value;
            }
        }

        public int EmergencyContactZip
        {
            get
            {
                return this.emergencyContactZip;
            }
            set
            {
                this.emergencyContactZip = value;
            }
        }

        public int HireStatus
        {
            get
            {
                return this.hireStatus;
            }
            set
            {
                this.hireStatus = value;
            }
        }

        public DateTime HireStatusDate
        {
            get
            {
                return this.hireStatusDate;
            }
            set
            {
                this.hireStatusDate = value;
            }
        }

        public List<PayRate> PayRateList
        {
            get
            {
                return this.payRateList;
            }
            set
            {
                this.payRateList = value;
            }
        }


        public Employee()
        {
            this.payRateList = new List<PayRate>();
        }

        public Employee(int id, string refCode, string firstname, string lastname)
        {
            this.employeeId = id;
            this.refCode = refCode;
            this.firstName = firstname;
            this.lastName = lastname;
            this.payRateList = new List<PayRate>();
        }
       
        public override string ToString()
        {
            return this.refCode.PadRight(8) + "| " + this.firstName + " " + this.lastName;
        }
    }
}
