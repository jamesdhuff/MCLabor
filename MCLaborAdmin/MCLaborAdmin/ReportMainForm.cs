using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.reportViewer1.RefreshReport();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string selectedReport = this.reportCmbo.SelectedItem.ToString().ToLower();
            Microsoft.Reporting.WinForms.ReportDataSource rptDS = new Microsoft.Reporting.WinForms.ReportDataSource();
            
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            
            switch(selectedReport)
            {
                case "employee directory" :
                    // TODO: This line of code loads data into the 'DSEmployee.EMPLOYEE' table. You can move, or remove it, as needed.
                    this.EMPLOYEETableAdapter.Fill(this.DSEmployee.EMPLOYEE);
                    rptDS.Name = "DSEmployee_EMPLOYEE";
                    rptDS.Value = this.EMPLOYEEBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTEmployeeDirectory.rdlc";                    
                    break;

                case "pay rate list" :
                    // TODO: This line of code loads data into the 'DSPayRateList.DTPayRateList' table. You can move, or remove it, as needed.
                    this.DTPayRateListTableAdapter.Fill(this.DSPayRateList.DTPayRateList);
                    rptDS.Name = "DSPayRateList_DTPayRateList";
                    rptDS.Value = this.DTPayRateListBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rptDS);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "MCLaborAdmin.RPTPayRateList.rdlc";
                    break;
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
