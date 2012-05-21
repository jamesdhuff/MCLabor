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





        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.empMainForm.Show();
        }

        private void EmployeeAddEditForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            if (this.currEmp.FirstName != null)
            {
                populateForm();
            }
        }

        private void empSaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void empNewBtn_Click(object sender, EventArgs e)
        {

        }

        private void empCancelBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
