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
    public partial class EmployeeMainForm : Form
    {
        private Form parentForm;
        private List<Employee> empList = new List<Employee>();

        public EmployeeMainForm(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void populateEmployeeList()
        {
            this.empList = new List<Employee>();
            using(SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                string sqlString = "SELECT employeeId, refCode, firstName, middleName, lastName, loginId, " +
                                    "       address, city, state, zip, ssn, primaryPhone, alternatePhone, " +
                                    "       emergencyContactName, emergencyContactRelationShip, emergencyContactAddress, " +
                                    "       emergencyContactCity, emergencyContactState, emergencyContactZip, emergencyContactPhone " +
                                    "FROM employee ORDER BY lastName";
                conn.Open();
                using (SqlCommand empLookupCmd = new SqlCommand(sqlString, conn))
                {
                    SqlDataReader reader = empLookupCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();
                        emp.EmployeeId = reader.GetInt32(0);
                        emp.RefCode = reader.GetString(1);
                        emp.FirstName = reader.GetString(2);
                        if (reader.IsDBNull(3))
                        {
                            emp.MiddleName = string.Empty;
                        }
                        else
                        {
                            emp.MiddleName = reader.GetString(3);
                        }

                        emp.LastName = reader.GetString(4);
                        emp.LoginId = reader.GetInt32(5);
                        
                        if (reader.IsDBNull(6))
                        {
                            emp.Address = string.Empty;
                        }
                        else
                        {
                            emp.Address = reader.GetString(6);
                        }

                        if(reader.IsDBNull(7))
                        {
                            emp.City = string.Empty;
                        }
                        else
                        {
                            emp.City = reader.GetString(7);
                        }

                        if(reader.IsDBNull(8))
                        {
                            emp.State = string.Empty;
                        }
                        else
                        {
                            emp.State = reader.GetString(8);
                        }

                        if(reader.IsDBNull(9))
                        {
                            emp.Zip = 0;
                        }
                        else
                        {
                            emp.Zip = reader.GetInt32(9);
                        }

                        if(reader.IsDBNull(10))
                        {
                            emp.Ssn = string.Empty;
                        }
                        else
                        {
                            emp.Ssn = reader.GetString(10);
                        }

                        if(reader.IsDBNull(11))
                        {
                            emp.PrimaryPhone = string.Empty;
                        }
                        else
                        {
                            emp.PrimaryPhone = reader.GetString(11);
                        }

                        if(reader.IsDBNull(12))
                        {
                            emp.AlternatePhone = string.Empty;
                        }
                        else
                        {
                            emp.AlternatePhone = reader.GetString(12);
                        }

                        if(reader.IsDBNull(13))
                        {
                            emp.EmergencyContactName = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactName = reader.GetString(13);
                        }

                        if(reader.IsDBNull(14))
                        {
                            emp.EmergencyContactRelationship = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactRelationship = reader.GetString(14);
                        }

                        if(reader.IsDBNull(15))
                        {
                            emp.EmergencyContactAddress = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactAddress = reader.GetString(15);
                        }

                        if(reader.IsDBNull(16))
                        {
                            emp.EmergencyContactCity = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactCity = reader.GetString(16);
                        }

                        if(reader.IsDBNull(17))
                        {
                            emp.EmergencyContactState = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactState = reader.GetString(17);
                        }

                        if(reader.IsDBNull(18))
                        {
                            emp.EmergencyContactZip = 0;
                        }
                        else
                        {
                            emp.EmergencyContactZip = reader.GetInt32(18);
                        }
                        
                        if(reader.IsDBNull(19))
                        {
                            emp.EmergencyContactPhone = string.Empty;
                        }
                        else
                        {
                            emp.EmergencyContactPhone = reader.GetString(19);
                        }

                        string hireStatusLookupSql = "SELECT status, statusStartDate, terminationReason FROM emp_hire_status WHERE employeeId = @empId AND statusEndDate IS NULL";
                        using (SqlConnection conn2 = DBUtils.getConnection("MCLabor"))                       
                        {
                            conn2.Open();
                            using (SqlCommand hireStatusLookupCmd = new SqlCommand(hireStatusLookupSql, conn2))
                            {
                                hireStatusLookupCmd.Parameters.AddWithValue("@empId", emp.EmployeeId);
                                SqlDataReader hireStatusReader = hireStatusLookupCmd.ExecuteReader();
                                if (hireStatusReader.Read())
                                {
                                    emp.HireStatus = hireStatusReader.GetInt32(0);
                                    emp.HireStatusDate = hireStatusReader.GetDateTime(1);
                                    if(hireStatusReader.IsDBNull(2))
                                    {
                                        emp.TermReason = string.Empty;
                                    }
                                    else
                                    {
                                        emp.TermReason = hireStatusReader.GetString(2);
                                    }
                                }
                                hireStatusReader.Close();
                            }                            

                            string payRateLookupSql = "SELECT p.payRateId, j.jobId, j.refCode, j.jobName, p.hourlyPayRate, p.active " +
                                                      "FROM pay_rate p, job j " +
                                                      "WHERE p.jobId = j.jobId AND p.employeeId = @empId";

                            using (SqlCommand payRateLookupCmd = new SqlCommand(payRateLookupSql, conn2))
                            {
                                payRateLookupCmd.Parameters.AddWithValue("@empId", emp.EmployeeId);
                                SqlDataReader payRateReader = payRateLookupCmd.ExecuteReader();
                                List<PayRate> payRateList = new List<PayRate>();

                                while (payRateReader.Read())
                                {
                                    payRateList.Add(new PayRate(payRateReader.GetInt32(0), payRateReader.GetInt32(1), payRateReader.GetString(2), payRateReader.GetString(3), payRateReader.GetDecimal(4), payRateReader.GetBoolean(5)));
                                }

                                emp.PayRateList = payRateList;
                            }
                        }

                        this.empList.Add(emp);
                    }

                    if (this.empList.Count < 1)
                    {
                        this.empMainLookupCmboBox.Items.Add("No Existing Employees Found");
                        this.empMainLookupCmboBox.SelectedIndex = 0;
                    }

                    foreach(Employee emp in this.empList)
                    {
                        this.empMainLookupCmboBox.Items.Add(emp);
                    }

                    
                }
            }
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            populateEmployeeList();
        }

        private void EmployeeMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }

        private void empMainAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAddEditForm addEditForm = new EmployeeAddEditForm(this);
            addEditForm.Show();
        }

        private void empMainEditBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAddEditForm addEditForm = new EmployeeAddEditForm(this, (Employee)this.empMainLookupCmboBox.SelectedItem);
            addEditForm.Show();
        }
    }


}
