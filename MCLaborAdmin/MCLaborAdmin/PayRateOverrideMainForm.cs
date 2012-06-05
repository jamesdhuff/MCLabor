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
    public partial class PayRateOverrideMainForm : Form
    {
        private MainMenuForm mainMenuForm;

        public PayRateOverrideMainForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void PayRateOverrideForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void PayRateOverrideForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.TopMost = true;
            this.TopMost = false;
        }
    }
}
