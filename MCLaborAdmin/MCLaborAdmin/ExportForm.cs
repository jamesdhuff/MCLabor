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
    public partial class ExportForm : Form
    {
        private MainMenuForm mainMenuForm;

        public ExportForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }
    }
}
