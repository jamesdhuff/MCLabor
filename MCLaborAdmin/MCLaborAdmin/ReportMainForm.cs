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
        }

        private void empDirectoryRptBtn_Click(object sender, EventArgs e)
        {
            EmpDirectoryReportForm empDirRptForm = new EmpDirectoryReportForm();
            empDirRptForm.Show();
        }
    }
}
