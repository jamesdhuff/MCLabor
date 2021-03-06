﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCLaborAdmin
{
    public partial class TimeCardForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private MainMenuForm mainMenuForm;

        public TimeCardForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void populateEmpList()
        {
            this.timeCardEmployeeCmbo.Items.Clear();

            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand( "SELECT emp.employeeId, emp.refCode, emp.firstName, emp.lastName " + 
                                                        "FROM employee emp JOIN emp_hire_status hireStatus ON emp.employeeId = hireStatus.employeeId AND hireStatus.statusEndDate IS NULL " +
                                                        "WHERE hireStatus.status IN (0,1,2) OR @ShowTerminated = 1 " +
                                                        "ORDER BY firstName, lastName", conn))
                {
                    cmd.Parameters.AddWithValue("@ShowTerminated", this.chkShowTerminatedEmployees.Checked);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee currEmp = new Employee();
                            currEmp.EmployeeID = reader.GetInt32(0);
                            currEmp.RefCode = reader.GetString(1);
                            currEmp.FirstName = reader.GetString(2);
                            currEmp.LastName = reader.GetString(3);

                            this.timeCardEmployeeCmbo.Items.Add(currEmp);
                        }
                    }
                }
            }
        }

        private void TimeCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void TimeCardForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            populateEmpList();
            if (this.timeCardEmployeeCmbo.Items.Count < 1)
            {
                MessageBox.Show("There are currently no employees defined.  Define an employee before trying to add/edit time cards");
                this.Close();
            }

            this.timeCardStartDatePicker.Value = DateTime.Today.AddDays(-14);
        }

        private void timeCardGoBtn_Click(object sender, EventArgs e)
        {
            if (this.timeCardEmployeeCmbo.SelectedItem == null)
            {
                MessageBox.Show("Please select an Employee from the list");
                this.timeCardEmployeeCmbo.Focus();
            }
            else
            {
                if (this.timeCardStartDatePicker.Value.CompareTo(this.timeCardEndDatePicker.Value) > 0)
                {
                    MessageBox.Show("Please select a Start Date that is earlier than or equal to the End Date");
                }
                else
                {
                    TimeCardReviewForm reviewForm = new TimeCardReviewForm(this, (Employee)this.timeCardEmployeeCmbo.SelectedItem,
                                                                            this.timeCardStartDatePicker.Value, this.timeCardEndDatePicker.Value);
                    this.Hide();
                    reviewForm.Show(this);
                }
            }
        }

        private void chkShowTerminatedEmployees_CheckedChanged(object sender, EventArgs e)
        {
            populateEmpList();
        }
    }
}
