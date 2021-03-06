﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCLaborAdmin
{
    public partial class MainMenuForm : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        LoginForm loginForm;
        bool logoutFlag = false;

        public MainMenuForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void doLogout()
        {
            logoutFlag = true;
            this.Close();
        }

        private void loadEmployeeForm()
        {
            EmployeeMainForm empForm = new EmployeeMainForm(this);
            this.Hide();
            empForm.Show(this);
        }

        private void loadJobForm()
        {
            JobMainForm jobForm = new JobMainForm(this);
            this.Hide();
            jobForm.Show(this);
        }

        private void loadWorkSiteForm()
        {
            WorkSiteMainForm workSiteForm = new WorkSiteMainForm(this);
            this.Hide();
            workSiteForm.Show(this);
        }

        private void loadTimeCardForm()
        {
            TimeCardForm timeCardForm = new TimeCardForm(this);
            this.Hide();
            timeCardForm.Show(this);
        }

        private void loadReportForm()
        {
            ReportMainForm reportForm = new ReportMainForm(this);
            this.Hide();
            reportForm.Show(this);
        }

        private void loadPayRateOverrideForm()
        {
            PayRateOverrideMainForm payRateOverrideForm = new PayRateOverrideMainForm(this);
            this.Hide();
            payRateOverrideForm.Show(this);
        }

        private void loadAdminUserForm()
        {
            AdminUserForm adminUserForm = new AdminUserForm(this);
            this.Hide();
            adminUserForm.Show(this);
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(logoutFlag)
            {
                this.loginForm.Show();
            }
            else
            {
                //this.loginForm.Close();
                Application.Exit();
            }
        }

        private void menuLogoutBtn_Click(object sender, EventArgs e)
        {
            doLogout();                
        }

        private void menuEmployeeBtn_Click(object sender, EventArgs e)
        {
            loadEmployeeForm();
        }

        private void menuJobBtn_Click(object sender, EventArgs e)
        {
            loadJobForm();
        }

        private void menuWorkSiteBtn_Click(object sender, EventArgs e)
        {
            loadWorkSiteForm();
        }

        private void menuTimeCardBtn_Click(object sender, EventArgs e)
        {
            loadTimeCardForm();
        }

        private void menuReportBtn_Click(object sender, EventArgs e)
        {
            loadReportForm();
        }

        private void menuPayRateOverrideBtn_Click(object sender, EventArgs e)
        {
            loadPayRateOverrideForm();
        }

        private void menuAdminUserBtn_Click(object sender, EventArgs e)
        {
            loadAdminUserForm();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

    }
}
