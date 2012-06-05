using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCLaborAdmin
{
    public partial class EmployeeAddEditForm : Form
    {
        private EmployeeMainForm empMainForm;
        private Employee currEmp;

        public EmployeeAddEditForm(EmployeeMainForm empMainForm)
        {
            this.empMainForm = empMainForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.currEmp = new Employee();
            InitializeComponent();
        }

        public EmployeeAddEditForm(EmployeeMainForm empMainForm, Employee currEmp)
        {
            this.empMainForm = empMainForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.currEmp = currEmp;
            InitializeComponent();
        }

        public void addPayRate(PayRate p)
        {
            this.currEmp.PayRateList.Add(p);
            this.empJobDataGridView.Rows.Add(new Object[] { -1, p.Job.JobId, p.Job.JobName, p.Job.RefCode, p.Active, String.Format("{0:0.00}",p.HourlyPayRate) });
        }

        public bool editPayRate(PayRate p)
        {
            for (int i = 0; i < this.empJobDataGridView.Rows.Count; i++)
            {
                if (p.Job.JobName.Equals(this.empJobDataGridView.Rows[i].Cells[2].Value.ToString()) && 
                    p.Job.RefCode.Equals(this.empJobDataGridView.Rows[i].Cells[3].Value.ToString()))
                {
                    this.empJobDataGridView.Rows[i].Cells[4].Value = p.Active;
                    this.empJobDataGridView.Rows[i].Cells[5].Value = String.Format("{0:0.00}",p.HourlyPayRate);
                }
            }

            for (int i = 0; i < this.currEmp.PayRateList.Count; i++)
            {
                if (p.Job.JobName == this.currEmp.PayRateList[i].Job.JobName && p.Job.RefCode == this.currEmp.PayRateList[i].Job.RefCode)
                {
                    this.currEmp.PayRateList[i].Active = p.Active;
                    this.currEmp.PayRateList[i].HourlyPayRate = p.HourlyPayRate;
                }

            }

            return true;
        }

        private void populateForm()
        {
            this.empFirstNameTxt.Text = this.currEmp.FirstName;
            if (this.currEmp.MiddleName != null)
            {
                this.empMiddleNameTxt.Text = this.currEmp.MiddleName;
            }
            this.empLastNameTxt.Text = this.currEmp.LastName;
            if (this.currEmp.RefCode != null)
            {
                this.empRefCodeTxt.Text = this.currEmp.RefCode;
            }
            this.empLoginIdTxt.Text = this.currEmp.LoginId.ToString();
            if (this.currEmp.Address != null)
            {
                this.empAddressTxt.Text = this.currEmp.Address;
            }
            if (this.currEmp.City != null)
            {
                this.empCityTxt.Text = this.currEmp.City;
            }
            if (this.currEmp.State != null)
            {
                this.empStateTxt.Text = this.currEmp.City;
            }
            if (this.currEmp.Zip != null)
            {
                this.empZipTxt.Text = this.currEmp.Zip.ToString();
            }
            if (this.currEmp.PrimaryPhone != null)
            {
                this.empPrimaryPhoneTxt.Text = this.currEmp.PrimaryPhone;
            }
            if (this.currEmp.AlternatePhone != null)
            {
                this.empAlternatePhoneTxt.Text = this.currEmp.AlternatePhone;
            }
            if (this.currEmp.Ssn != null)
            {
                this.empSsnTxt.Text = this.currEmp.Ssn;
            }
            if (this.currEmp.EmergencyContactName != null)
            {
                this.empEcNameTxt.Text = this.currEmp.EmergencyContactName;
            }
            if (this.currEmp.EmergencyContactRelationship != null)
            {
                this.empEcRelationshipTxt.Text = this.currEmp.EmergencyContactRelationship;
            }
            if (this.currEmp.EmergencyContactAddress != null)
            {
                this.empEcAddressTxt.Text = this.currEmp.EmergencyContactAddress;
            }
            if (this.currEmp.EmergencyContactCity != null)
            {
                this.empEcCityTxt.Text = this.currEmp.EmergencyContactCity;
            }
            if (this.currEmp.EmergencyContactState != null)
            {
                this.empEcStateTxt.Text = this.currEmp.EmergencyContactState;
            }
            if (this.currEmp.EmergencyContactZip != null)
            {
                this.empEcZipTxt.Text = this.currEmp.EmergencyContactZip.ToString();
            }
            if (this.currEmp.EmergencyContactPhone != null)
            {
                this.empEcPhoneTxt.Text = this.currEmp.EmergencyContactPhone;
            }
            if (this.currEmp.HireStatus != null)
            {
                switch (this.currEmp.HireStatus)
                {
                    case 0:
                        this.empHireStatusFullTimeRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = string.Empty;
                        break;
                    case 1:
                        this.empHireStatusPartTimeRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = string.Empty;
                        break;
                    case 2:
                        this.empHireStatusUnemploymentRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = string.Empty;
                        break;
                    case 3:
                        this.empHireStatusTermRehirableRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = this.currEmp.TermReason;
                        break;
                    case 4:
                        this.empHireStatusTermNonRehirableRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = this.currEmp.TermReason;
                        break;
                    default:
                        this.empHireStatusFullTimeRadBtn.Checked = true;
                        this.empTermReasonTxt.Text = string.Empty;
                        break;
                }
            }
            else
            {
                this.empHireStatusFullTimeRadBtn.Checked = true;
            }

            if (this.currEmp.HireStatusDate != null)
            {
                this.empHireStatusStartDatePicker.Value = this.currEmp.HireStatusDate;
            }
            else
            {
                this.empHireStatusStartDatePicker.Value = DateTime.Today;
            }

            populateJobTable();

        }

        private void populateJobTable()
        {
            foreach (PayRate p in this.currEmp.PayRateList)
            {
                this.empJobDataGridView.Rows.Add(new object[] { p.PayRateId, p.Job.JobId, p.Job.JobName, p.Job.RefCode, p.Active, p.HourlyPayRate });
            }
        }

        private void clearForm()
        {
            this.empFirstNameTxt.Text = string.Empty;
            this.empMiddleNameTxt.Text = string.Empty;
            this.empLastNameTxt.Text = string.Empty;
            this.empRefCodeTxt.Text = string.Empty;
            this.empLoginIdTxt.Text = string.Empty;
            this.empAddressTxt.Text = string.Empty;
            this.empCityTxt.Text = string.Empty;
            this.empStateTxt.Text = string.Empty;
            this.empZipTxt.Text = string.Empty;
            this.empPrimaryPhoneTxt.Text = string.Empty;
            this.empAlternatePhoneTxt.Text = string.Empty;
            this.empSsnTxt.Text = string.Empty;
            this.empEcNameTxt.Text = string.Empty;
            this.empEcRelationshipTxt.Text = string.Empty;
            this.empEcAddressTxt.Text = string.Empty;
            this.empEcCityTxt.Text = string.Empty;
            this.empEcStateTxt.Text = string.Empty;
            this.empEcZipTxt.Text = string.Empty;
            this.empEcPhoneTxt.Text = string.Empty;
            this.empHireStatusFullTimeRadBtn.Checked = true;
            this.empTermReasonTxt.Text = string.Empty;

            for (int i = this.empJobDataGridView.Rows.Count - 1; i > -1; i--)
            {
                this.empJobDataGridView.Rows.RemoveAt(i);
            }
        }

        private int insertNewEmployee(Employee emp)
        {
            string insertSql = "INSERT INTO employee (refCode, firstName, middleName, lastName, loginId, address, city, state, zip, ssn, primaryPhone, alternatePhone, " +
                               "                        emergencyContactName, emergencyContactRelationship, emergencyContactAddress, emergencyContactCity, emergencyContactState, emergencyContactZip, emergencyContactPhone) " +
                               "VALUES               (@refCode, @firstName, @middleName, @lastName, @loginId, @address, @city, @state, @zip, @ssn, @primaryPhone, @alternatePhone, " +
                               "                      @emergencyContactName, @emergencyContactRelationship, @emergencyContactAddress, @emergencyContactCity, @emergencyContactState, @emergencyContactZip, @emergencyContactPhone); " +
                               "SELECT cast(Scope_Identity() as int)";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@refCode", emp.RefCode);
                    
                    cmd.Parameters.AddWithValue("@firstName", emp.FirstName);
                    
                    if (emp.MiddleName.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@middleName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@middleName", emp.MiddleName);
                    }
                    
                    cmd.Parameters.AddWithValue("@lastName", emp.LastName);
                    
                    cmd.Parameters.AddWithValue("@loginId", emp.LoginId);
                    
                    if (emp.Address.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address", emp.Address);
                    }

                    if (emp.City.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", emp.City);
                    }

                    if (emp.State.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@state", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@state", emp.State);
                    }

                    if (emp.Zip == null || emp.Zip == 0)
                    {
                        cmd.Parameters.AddWithValue("@zip", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@zip", emp.Zip);
                    }

                    if (emp.Ssn.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ssn", emp.Ssn);
                    }

                    if (emp.PrimaryPhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@primaryPhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@primaryPhone", emp.PrimaryPhone);
                    }

                    if (emp.AlternatePhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@alternatePhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@alternatePhone", emp.AlternatePhone);
                    }

                    if (emp.EmergencyContactName.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactName", emp.EmergencyContactName);
                    }

                    if (emp.EmergencyContactRelationship.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactRelationship", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactRelationship", emp.EmergencyContactRelationship);
                    }

                    if (emp.EmergencyContactAddress.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactAddress", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactAddress", emp.EmergencyContactAddress);
                    }

                    if (emp.EmergencyContactCity.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactCity", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactCity", emp.EmergencyContactCity);
                    }

                    if (emp.EmergencyContactState.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactState", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactState", emp.EmergencyContactState);
                    }

                    if (emp.EmergencyContactZip == null || emp.EmergencyContactZip == 0)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactZip", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactZip", emp.EmergencyContactZip);
                    }

                    if (emp.EmergencyContactPhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactPhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactPhone", emp.EmergencyContactPhone);
                    }

                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void updateEmployee(Employee emp)
        {
            string updateSql = "UPDATE employee " + 
                               "SET refCode = @refCode, firstName = @firstName, middleName = @middleName, lastName = @lastName, loginId = @loginId, " +
                               "    address = @address, city = @city, state = @state, zip = @zip, ssn = @ssn, primaryPhone = @primaryPhone, alternatePhone = @alternatePhone, " +
                               "    emergencyContactName = @emergencyContactName, emergencyContactRelationship = @emergencyContactRelationship, emergencyContactAddress = @emergencyContactAddress, emergencyContactCity = @emergencyContactCity, emergencyContactState = @emergencyContactState, emergencyContactZip = @emergencyContactZip, emergencyContactPhone = @emergencyContactPhone " +                               
                               "WHERE employeeId = @employeeId";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@refCode", emp.RefCode);

                    cmd.Parameters.AddWithValue("@firstName", emp.FirstName);

                    if (emp.MiddleName.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@middleName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@middleName", emp.MiddleName);
                    }

                    cmd.Parameters.AddWithValue("@lastName", emp.LastName);

                    cmd.Parameters.AddWithValue("@loginId", emp.LoginId);

                    if (emp.Address.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address", emp.Address);
                    }

                    if (emp.City.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", emp.City);
                    }

                    if (emp.State.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@state", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@state", emp.State);
                    }

                    if (emp.Zip == null || emp.Zip == 0)
                    {
                        cmd.Parameters.AddWithValue("@zip", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@zip", emp.Zip);
                    }

                    if (emp.Ssn.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ssn", emp.Ssn);
                    }

                    if (emp.PrimaryPhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@primaryPhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@primaryPhone", emp.PrimaryPhone);
                    }

                    if (emp.AlternatePhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@alternatePhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@alternatePhone", emp.AlternatePhone);
                    }

                    if (emp.EmergencyContactName.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactName", emp.EmergencyContactName);
                    }

                    if (emp.EmergencyContactRelationship.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactRelationship", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactRelationship", emp.EmergencyContactRelationship);
                    }

                    if (emp.EmergencyContactAddress.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactAddress", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactAddress", emp.EmergencyContactAddress);
                    }

                    if (emp.EmergencyContactCity.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactCity", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactCity", emp.EmergencyContactCity);
                    }

                    if (emp.EmergencyContactState.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactState", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactState", emp.EmergencyContactState);
                    }

                    if (emp.EmergencyContactZip == null || emp.EmergencyContactZip == 0)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactZip", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactZip", emp.EmergencyContactZip);
                    }

                    if (emp.EmergencyContactPhone.Length < 1)
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactPhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@emergencyContactPhone", emp.EmergencyContactPhone);
                    }

                    cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void updateHireStatus(Employee emp)
        {
            bool statusChanged = false;
            bool termReasonChanged = false;
            bool firstRecord = false;

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT empHireStatusId, status, statusStartDate, terminationReason FROM emp_hire_status WHERE employeeId = @employeeId AND statusEndDate IS NULL", conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (emp.HireStatus != reader.GetInt32(1))
                        {
                            statusChanged = true;
                        }

                        if (reader.IsDBNull(3))
                        {
                            if (emp.TermReason.Length > 0)
                            {
                                termReasonChanged = true;
                            }
                        }
                        else
                        {
                            if (!emp.TermReason.ToLower().Equals(reader.GetString(3).ToLower()))
                            {
                                termReasonChanged = true;
                            }
                        }
                    }
                    else
                    {
                        statusChanged = true;
                        firstRecord = true;
                    }

                    reader.Close();
                }

                if (statusChanged)
                {
                    if (!firstRecord)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE emp_hire_status SET statusEndDate = @statusEndDate WHERE employeeId = @employeeId AND statusEndDate IS NULL", conn))
                        {
                            cmd.Parameters.AddWithValue("@statusEndDate", emp.HireStatusDate.Subtract(new TimeSpan(1, 0, 0, 0)));
                            cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO EMP_HIRE_STATUS (employeeId, status, statusStartDate, terminationReason) VALUES (@employeeId, @status, @statusStartDate, @terminationReason)", conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);
                        cmd.Parameters.AddWithValue("@status", emp.HireStatus);
                        cmd.Parameters.AddWithValue("@statusStartDate", emp.HireStatusDate);
                        if (emp.TermReason.Length < 1)
                        {
                            cmd.Parameters.AddWithValue("@terminationReason", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@terminationReason", emp.TermReason);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    if ((termReasonChanged) && (emp.HireStatus == 3 || emp.HireStatus == 4))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE emp_hire_status SET terminationReason = @termReason WHERE employeeId = @employeeId AND status IN (3,4) AND statusEndDate IS NULL", conn))
                        {
                            if (emp.TermReason.Length < 1)
                            {
                                cmd.Parameters.AddWithValue("@termReason", DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@termReason", emp.TermReason);
                            }
                            cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

            }
        }

        private int insertNewPayRate(Employee emp, PayRate p)
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PAY_RATE (employeeId, jobId, hourlyPayRate, active) " +
                                                       "VALUES (@employeeId, @jobId, @hourlyPayRate, @active); " +
                                                       "SELECT cast(Scope_Identity() as int)", conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);
                    cmd.Parameters.AddWithValue("@jobId", p.Job.JobId);
                    cmd.Parameters.AddWithValue("@hourlyPayRate", p.HourlyPayRate);
                    cmd.Parameters.AddWithValue("@active", p.Active);

                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void updatePayRate(Employee emp, PayRate p)
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE PAY_RATE " +
                                                       "SET employeeId = @employeeId, jobId = @jobId, hourlyPayRate = @hourlyPayRate, active = @active " +
                                                       "WHERE payRateId = @payRateId", conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", emp.EmployeeId);
                    cmd.Parameters.AddWithValue("@jobId", p.Job.JobId);
                    cmd.Parameters.AddWithValue("@hourlyPayRate", p.HourlyPayRate);
                    cmd.Parameters.AddWithValue("@active", p.Active);
                    cmd.Parameters.AddWithValue("@payRateId", p.PayRateId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool validateFormData()
        {
            if (this.empFirstNameTxt.Text.Length < 1)
            {
                MessageBox.Show("First Name field is required.", "Data Validation Failed");
                this.empFirstNameTxt.Focus();
                return false;
            }

            this.currEmp.FirstName = this.empFirstNameTxt.Text;

            this.currEmp.MiddleName = this.empMiddleNameTxt.Text;

            if (this.empLastNameTxt.Text.Length < 1)
            {
                MessageBox.Show("Last Name field is required.", "Data Validation Failed");
                this.empLastNameTxt.Focus();
                return false;
            }

            this.currEmp.LastName = this.empLastNameTxt.Text;
            

            if (this.empRefCodeTxt.Text.Length < 1)
            {
                MessageBox.Show("Ref Code field is required.", "Data Validation Failed");
                this.empRefCodeTxt.Focus();
                return false;
            }

            this.currEmp.RefCode = this.empRefCodeTxt.Text;

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT employeeId, refCode, firstName, lastName FROM employee", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if ((reader.GetInt32(0) != this.currEmp.EmployeeId) && (reader.GetString(1).ToUpper().Equals(this.currEmp.RefCode.ToUpper())))
                        {
                            MessageBox.Show("Ref Code must be unique.  The Ref Code entered is already in use by " + reader.GetString(2) + " " + reader.GetString(3) + ".  Pick a different Ref Code value.", "Data Validation Failed");
                            this.empRefCodeTxt.Focus();
                            return false;
                        }
                    }
                }
            }

            if (this.empLoginIdTxt.Text.Length < 1)
            {
                MessageBox.Show("Login ID field is required.", "Data Validation Failed");
                this.empLoginIdTxt.Focus();
                return false;
            }

            try
            {
                this.currEmp.LoginId = Int32.Parse(this.empLoginIdTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Login ID field must be set to an integer value.", "Data Validation Failed");
                this.empLoginIdTxt.Focus();
                return false;
            }

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT employeeId, loginId, firstName, lastName FROM employee", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if ((reader.GetInt32(0) != this.currEmp.EmployeeId) && (reader.GetInt32(1) == this.currEmp.LoginId))
                        {
                            MessageBox.Show("Login ID must be unique.  The Login ID entered is already in use by " + reader.GetString(2) + " " + reader.GetString(3) + ".  Pick a different Login ID value.", "Data Validation Failed");
                            this.empLoginIdTxt.Focus();
                            return false;
                        }
                    }
                }
            }

            this.currEmp.Address = this.empAddressTxt.Text;
            this.currEmp.City = this.empCityTxt.Text;
            this.currEmp.State = this.empStateTxt.Text;

            if (this.empZipTxt.Text.Length > 0)
            {
                try
                {
                    this.currEmp.Zip = Int32.Parse(this.empZipTxt.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Zip Code field must be set to an integer value.", "Data Validation Failed");
                    this.empZipTxt.Focus();
                    return false;
                }
            }

            this.currEmp.PrimaryPhone = this.empPrimaryPhoneTxt.Text;
            this.currEmp.AlternatePhone = this.empAlternatePhoneTxt.Text;
            this.currEmp.Ssn = this.empSsnTxt.Text;

            if (this.empHireStatusFullTimeRadBtn.Checked)
            {
                this.currEmp.HireStatus = 0;
                this.currEmp.TermReason = string.Empty;
            }
            else if (this.empHireStatusPartTimeRadBtn.Checked)
            {
                this.currEmp.HireStatus = 1;
                this.currEmp.TermReason = string.Empty;
            }
            else if (this.empHireStatusUnemploymentRadBtn.Checked)
            {
                this.currEmp.HireStatus = 2;
                this.currEmp.TermReason = string.Empty;
            }
            else if (this.empHireStatusTermRehirableRadBtn.Checked)
            {
                this.currEmp.HireStatus = 3;
                if (this.empTermReasonTxt.Text.Length > 0)
                {
                    this.currEmp.TermReason = this.empTermReasonTxt.Text;
                }
                else
                {
                    this.currEmp.TermReason = string.Empty;
                }
            }
            else if (this.empHireStatusTermNonRehirableRadBtn.Checked)
            {
                this.currEmp.HireStatus = 4;
                if (this.empTermReasonTxt.Text.Length > 0)
                {
                    this.currEmp.TermReason = this.empTermReasonTxt.Text;
                }
                else
                {
                    this.currEmp.TermReason = string.Empty;
                }
            }

            try
            {
                this.currEmp.HireStatusDate = this.empHireStatusStartDatePicker.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Date Format for Hire Status Start Date", "Invalid Input");
                this.empHireStatusStartDatePicker.Focus();
                this.currEmp.HireStatusDate = DateTime.Today;
                return false;
            }

            this.currEmp.EmergencyContactName = this.empEcNameTxt.Text; 
            this.currEmp.EmergencyContactAddress = this.empEcAddressTxt.Text;
            this.currEmp.EmergencyContactCity = this.empEcCityTxt.Text;    
            this.currEmp.EmergencyContactState = this.empEcStateTxt.Text;

            if (this.empEcZipTxt.Text.Length > 0)
            {
                try
                {
                    this.currEmp.EmergencyContactZip = Int32.Parse(this.empEcZipTxt.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Emergency Contact Zip Code must be an integer value.", "Data Format Exception");
                    this.empEcZipTxt.Focus();
                    return false;
                }
            }

            this.currEmp.EmergencyContactPhone = this.empEcPhoneTxt.Text;
            this.currEmp.EmergencyContactRelationship = this.empEcRelationshipTxt.Text;

            if (this.empJobDataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Employee must have at least 1 job assigned.", "Data Validation Failed");
                this.employeeJobTabPage.Focus();
                return false;
            }
 
            return true;
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.empMainForm.Show();
        }

        private void EmployeeAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            if (this.currEmp.FirstName != null)
            {
                populateForm();
            }
        }

        private void empSaveBtn_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                if (this.currEmp.EmployeeId == -1)
                {
                    this.currEmp.EmployeeId = insertNewEmployee(this.currEmp);
                    updateHireStatus(this.currEmp);
                }
                else
                {
                    updateEmployee(this.currEmp);
                    updateHireStatus(this.currEmp);
                }

                for (int i = 0; i < this.currEmp.PayRateList.Count; i++)
                {
                    if (this.currEmp.PayRateList[i].PayRateId == -1)
                    {
                        this.currEmp.PayRateList[i].PayRateId = insertNewPayRate(this.currEmp, this.currEmp.PayRateList[i]);
                    }
                    else
                    {
                        updatePayRate(this.currEmp, this.currEmp.PayRateList[i]);
                    }
                }

                MessageBox.Show("Save Successful");

                this.empMainForm.updateEmpGrid(this.currEmp);
            }
        }

        private void empNewBtn_Click(object sender, EventArgs e)
        {
            this.currEmp = new Employee();
            clearForm();
        }

        private void empCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empHireStatusFullTimeRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.empHireStatusTermReasonLbl.Hide();
            this.empTermReasonTxt.Text = string.Empty;
            this.empTermReasonTxt.Hide();
        }

        private void empHireStatusPartTimeRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.empHireStatusTermReasonLbl.Hide();
            this.empTermReasonTxt.Text = string.Empty;
            this.empTermReasonTxt.Hide();
        }

        private void empHireStatusUnemploymentRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.empHireStatusTermReasonLbl.Hide();
            this.empTermReasonTxt.Text = string.Empty;
            this.empTermReasonTxt.Hide();
        }

        private void empHireStatusTermRehirableRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.empHireStatusTermReasonLbl.Show();
            this.empTermReasonTxt.Show();
        }

        private void empHireStatusTermNonRehirableRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.empHireStatusTermReasonLbl.Show();
            this.empTermReasonTxt.Show();
        }

        private void addPayRateBtn_Click(object sender, EventArgs e)
        {
            List<Job> alreadyAssignedJobList = new List<Job>();
            foreach (PayRate p in currEmp.PayRateList)
            {
                alreadyAssignedJobList.Add(p.Job);
            }
            AddEditPayRateForm addEditPayRateForm = new AddEditPayRateForm(this, alreadyAssignedJobList, new PayRate(), false);
            this.Enabled = false;
            addEditPayRateForm.Show();
        }

        private void editPayRateBtn_Click(object sender, EventArgs e)
        {           
            PayRate currSelectedPayRate = new PayRate();

            if(this.empJobDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select just one job record to edit.", "Invalid Input");
            }
            else if (this.empJobDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a job record to edit.", "Invalid Input");
            }
            else
            {

                if (this.empJobDataGridView.SelectedRows[0].Cells[0].Value != null)
                {
                    currSelectedPayRate.PayRateId = (int)this.empJobDataGridView.SelectedRows[0].Cells[0].Value;
                }

                if (this.empJobDataGridView.SelectedRows[0].Cells[1].Value != null)
                {
                    currSelectedPayRate.Job.JobId = (int)this.empJobDataGridView.SelectedRows[0].Cells[1].Value;
                }

                currSelectedPayRate.Job.JobName = this.empJobDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                currSelectedPayRate.Job.RefCode = this.empJobDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                currSelectedPayRate.Active = (bool)this.empJobDataGridView.SelectedRows[0].Cells[4].Value;
                currSelectedPayRate.HourlyPayRate = Decimal.Parse(this.empJobDataGridView.SelectedRows[0].Cells[5].Value.ToString());

                AddEditPayRateForm addEditPayRateForm = new AddEditPayRateForm(this, currSelectedPayRate, true);
                this.Enabled = false;
                addEditPayRateForm.Show();
            }
        }

    }
}
