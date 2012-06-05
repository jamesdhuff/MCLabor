using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MCLaborAdmin
{
    public partial class EmpDirectoryReportForm : Form
    {
        public EmpDirectoryReportForm()
        {
            InitializeComponent();
        }

        private void EmpDirectoryReportForm_Load(object sender, EventArgs e)
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.FirstName = "emp1";
            emp1.LastName = "emp1LastName";
            emp1.RefCode = "REF1";
            emp1.Address = "123 Nowhere Street";
            emp1.City = "Ptown";
            emp1.State = "Brown";
            emp1.Zip = 12345;
            emp1.PrimaryPhone = "1234567";
            emp1.PayRateList = new List<PayRate>();

            Employee emp2 = new Employee();
            emp2.FirstName = "emp2";
            emp2.LastName = "emp2LastName";
            emp2.RefCode = "REF2";
            emp2.Address = "123 Nowhere Street";
            emp2.City = "AAAAAA";
            emp2.State = "PPPPPP";
            emp2.Zip = 54321;
            emp2.PrimaryPhone = "7654321";
            emp2.PayRateList = new List<PayRate>();

            empList.Add(emp1);
            empList.Add(emp2);

            this.BindingSource.DataSource = empList;         
            this.reportViewer1.RefreshReport();

        }
    }
}
