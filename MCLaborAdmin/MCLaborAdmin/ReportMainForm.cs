using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace MCLaborAdmin
{
    public partial class ReportMainForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private MainMenuForm mainMenuForm;

        public ReportMainForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            InitializeComponent();
        }

        private void loadEmployees()
        {
            this.employeeCmbo.Items.Clear();
            this.employeeCmbo.Items.Add("<< No Filter >>");
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand( "SELECT emp.employeeId, emp.firstName, emp.lastName, emp.refCode " + 
                                                        "FROM employee emp " +
                                                        "JOIN emp_hire_status hireStatus ON emp.employeeId = hireStatus.employeeId " +
                                                        "WHERE hireStatus.statusEndDate IS NULL " +
                                                        "AND (hireStatus.status IN (0,1,2) OR @ShowInactive = 1) " +
                                                        "ORDER BY emp.firstName, emp.lastName", conn))
                {
                    cmd.Parameters.AddWithValue("@ShowInactive", this.chkShowInactiveFilters.Checked);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee();
                            emp.EmployeeID = reader.GetInt32(0);
                            emp.FirstName = reader.GetString(1);
                            emp.LastName = reader.GetString(2);
                            emp.RefCode = reader.GetString(3);

                            this.employeeCmbo.Items.Add(emp);
                        }
                    }
                }
            }
        }

        private void loadWorkSites()
        {
            this.workSiteCmbo.Items.Clear();
            this.workSiteCmbo.Items.Add("<< No Filter >>");
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT workSiteId, workSiteName, refCode FROM work_site WHERE active = 1 or @ShowInactive = 1 ORDER BY workSiteId DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@ShowInactive", this.chkShowInactiveFilters.Checked);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WorkSite ws = new WorkSite();
                            ws.WorkSiteId = reader.GetInt32(0);
                            ws.WorkSiteName = reader.GetString(1);
                            ws.RefCode = reader.GetString(2);

                            this.workSiteCmbo.Items.Add(ws);
                        }
                    }
                }
            }
        }

        private void loadJobs()
        {
            this.jobCmbo.Items.Clear();
            this.jobCmbo.Items.Add("<< No Filter >>");
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT jobId, jobName, refCode FROM job WHERE isActive = 1 OR @ShowInactive = 1 ORDER BY jobName", conn))
                {
                    cmd.Parameters.AddWithValue("@ShowInactive", this.chkShowInactiveFilters.Checked);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job j = new Job();
                            j.JobID = reader.GetInt32(0);
                            j.JobName = reader.GetString(1);
                            j.RefCode = reader.GetString(2);

                            this.jobCmbo.Items.Add(j);
                        }
                    }
                }
            }
        }

        private bool validateDateParams()
        {
            if (this.startDatePicker.Value > this.endDatePicker.Value)
            {
                MessageBox.Show("Invalid Filter Values.  Start Date must be before End Date!", "Report Filter Error");
                this.startDatePicker.Focus();
                return false;
            }

            return true;
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {            
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.TopMost = true;
            this.TopMost = false;

            this.startDatePicker.Value = DateTime.Today.AddDays(-14);
            this.endDatePicker.Value = DateTime.Today.AddDays(1);

            loadFilterValues();

        }

        private void loadFilterValues()
        {
            loadEmployees();
            loadWorkSites();
            loadJobs();
            this.jobCmbo.SelectedIndex = 0;
            this.workSiteCmbo.SelectedIndex = 0;
            this.employeeCmbo.SelectedIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string selectedReport = this.reportCmbo.SelectedItem.ToString().ToLower();
            ReportDataSource rptDS = new Microsoft.Reporting.WinForms.ReportDataSource();
            List<ReportParameter> rptParams = new List<ReportParameter>();
            DateTime? startDate = null;
            DateTime? endDate = null;
            
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            
            switch(selectedReport)
            {
                case "employee directory" :
                    this.EMPLOYEETableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MCLabor"].ToString();
                    this.EMPLOYEETableAdapter.Fill(this.DSEmployee.EMPLOYEE);
                    rptDS.Name = "DSEmployee_EMPLOYEE";
                    rptDS.Value = this.EMPLOYEEBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTEmployeeDirectory.rdlc";                    
                    break;

                case "pay rate list" :
                    this.DTPayRateListTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MCLabor"].ToString();
                    this.DTPayRateListTableAdapter.Fill(this.DSPayRateList.DTPayRateList);
                    rptDS.Name = "DSPayRateList_DTPayRateList";
                    rptDS.Value = this.DTPayRateListBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTPayRateList.rdlc";
                    break;
                
                case "work site labor summary" :
                    this.DTWorkSiteLaborSummaryTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MCLabor"].ToString();             
                    this.DTWorkSiteLaborSummaryTableAdapter.Fill(this.DSWorkSiteLaborSummary.DTWorkSiteLaborSummary);
                    rptDS.Name = "DSWorkSiteLaborSummary_DTWorkSiteLaborSummary";
                    rptDS.Value = this.DTWorkSiteLaborSummaryBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTWorkSiteLaborSummary.rdlc";

                    if ((this.workSiteCmbo.SelectedItem != null) && (this.workSiteCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.SelectedItem).WorkSiteName));
                    }
                    else
                    {
                        for (int i = 1; i < this.workSiteCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.Items[i]).WorkSiteName));
                        }
                    }

                    if ((this.jobCmbo.SelectedItem != null) && (this.jobCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.SelectedItem).JobName));
                    }
                    else
                    {
                        for (int i = 1; i < this.jobCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.Items[i]).JobName));
                        }
                    }

                    this.reportViewer1.LocalReport.SetParameters(rptParams);
                    break;
                
                case "employee labor detail" :

                    if (!validateDateParams())
                    {
                        break;
                    }

                    startDate = this.startDatePicker.Value;
                    endDate = this.endDatePicker.Value;
                    this.EMP_LABOR_DETAILTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MCLabor"].ToString();             
                    this.EMP_LABOR_DETAILTableAdapter.Fill(this.DSEmpLaborDetail.EMP_LABOR_DETAIL, startDate, endDate);
                    rptDS.Name = "DSEmpLaborDetail_EMP_LABOR_DETAIL";
                    rptDS.Value = this.EMP_LABOR_DETAILBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTEmployeeLaborDetail.rdlc";

                    rptParams.Add(new ReportParameter("ParmStartDate", startDate.Value.ToString()));
                    rptParams.Add(new ReportParameter("ParmEndDate", endDate.Value.ToString()));

                    if ((this.employeeCmbo.SelectedItem != null) && (this.employeeCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmEmpId", ((Employee)this.employeeCmbo.SelectedItem).EmployeeID.ToString()));
                    }
                    else
                    {
                        for (int i = 1; i < this.employeeCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmEmpId", ((Employee)this.employeeCmbo.Items[i]).EmployeeID.ToString()));
                        }
                    }

                    if ((this.workSiteCmbo.SelectedItem != null) && (this.workSiteCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.SelectedItem).WorkSiteName));
                    }
                    else
                    {
                        for (int i = 1; i < this.workSiteCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.Items[i]).WorkSiteName));
                        }
                    }

                    if ((this.jobCmbo.SelectedItem != null) && (this.jobCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.SelectedItem).JobName));
                    }
                    else
                    {
                        for (int i = 1; i < this.jobCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.Items[i]).JobName));
                        }
                    }

                    this.reportViewer1.LocalReport.SetParameters(rptParams);
                    break;
                
                case "employee labor summary" :
                    if (!validateDateParams())
                    {
                        break;
                    }

                    startDate = this.startDatePicker.Value;
                    endDate = this.endDatePicker.Value;

                    this.EMP_LABOR_SUMMARYTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["MCLabor"].ToString();
                    this.EMP_LABOR_SUMMARYTableAdapter.Fill(this.DSEmpLaborSummary.EMP_LABOR_SUMMARY, startDate, endDate);

                    rptDS.Name = "DSEmpLaborSummary_EMP_LABOR_SUMMARY";
                    rptDS.Value = this.EMP_LABOR_SUMMARYBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTEmployeeLaborSummary.rdlc";

                    rptParams.Add(new ReportParameter("ParmStartDate", startDate.Value.ToString()));
                    rptParams.Add(new ReportParameter("ParmEndDate", endDate.Value.ToString()));

                    if ((this.employeeCmbo.SelectedItem != null) && (this.employeeCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmEmpId", ((Employee)this.employeeCmbo.SelectedItem).EmployeeID.ToString()));
                    }
                    else
                    {
                        for (int i = 1; i < this.employeeCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmEmpId", ((Employee)this.employeeCmbo.Items[i]).EmployeeID.ToString()));
                        }
                    }

                    if ((this.workSiteCmbo.SelectedItem != null) && (this.workSiteCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.SelectedItem).WorkSiteName));
                    }
                    else
                    {
                        for (int i = 1; i < this.workSiteCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmWorkSiteName", ((WorkSite)this.workSiteCmbo.Items[i]).WorkSiteName));
                        }
                    }

                    if ((this.jobCmbo.SelectedItem != null) && (this.jobCmbo.SelectedIndex != 0))
                    {
                        rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.SelectedItem).JobName));
                    }
                    else
                    {
                        for (int i = 1; i < this.jobCmbo.Items.Count; i++)
                        {
                            rptParams.Add(new ReportParameter("ParmJobName", ((Job)this.jobCmbo.Items[i]).JobName));
                        }
                    }

                    this.reportViewer1.LocalReport.SetParameters(rptParams);
                    break;
            }

            this.reportViewer1.RefreshReport();
        }

        private void reportCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReport = this.reportCmbo.SelectedItem.ToString().ToLower();

            switch (selectedReport)
            {                    
                case "work site labor summary" :
                    this.startDateLbl.Enabled = false;
                    this.startDatePicker.Enabled = false;
                    this.endDateLbl.Enabled = false;
                    this.endDatePicker.Enabled = false;
                    this.empLbl.Enabled = false;
                    this.employeeCmbo.Enabled = false;
                    this.workSiteLbl.Enabled = true;
                    this.workSiteCmbo.Enabled = true;
                    this.jobLbl.Enabled = true;
                    this.jobCmbo.Enabled = true;
                    break;

                case "employee labor detail" :
                case "employee labor summary" :
                    this.startDateLbl.Enabled = true;
                    this.startDatePicker.Enabled = true;
                    this.endDateLbl.Enabled = true;
                    this.endDatePicker.Enabled = true;
                    this.empLbl.Enabled = true;
                    this.employeeCmbo.Enabled = true;
                    this.workSiteLbl.Enabled = true;
                    this.workSiteCmbo.Enabled = true;
                    this.jobLbl.Enabled = true;
                    this.jobCmbo.Enabled = true;
                    break;

                default :
                    this.startDateLbl.Enabled = false;
                    this.startDatePicker.Enabled = false;
                    this.endDateLbl.Enabled = false;
                    this.endDatePicker.Enabled = false;
                    this.empLbl.Enabled = false;
                    this.employeeCmbo.Enabled = false;
                    this.workSiteLbl.Enabled = false;
                    this.workSiteCmbo.Enabled = false;
                    this.jobLbl.Enabled = false;
                    this.jobCmbo.Enabled = false;
                    break;
            }

        }

        private void chkShowInactiveFilters_CheckedChanged(object sender, EventArgs e)
        {
            loadFilterValues();
        }
    }
}
