using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCLaborAdmin
{
    public partial class AdminUserForm : Form
    {
        private MainMenuForm mainMenuForm;
        private List<AdminUser> adminUserList;
        private string errorMessage;

        public AdminUserForm(MainMenuForm mainMenuForm)
        {
            this.mainMenuForm = mainMenuForm;
            this.adminUserList = new List<AdminUser>();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void populateAdminUserList()
        {
            string sqlString = "select adminUserId, userName, password FROM admin_user";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.adminUserList.Add(new AdminUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));                    
                }
            }
        }

        private void populateDataGridView()
        {
            foreach (AdminUser currAdminUser in this.adminUserList)
            {
                object[] rowValues = { currAdminUser.AdminUserId, currAdminUser.UserName, currAdminUser.Password };
                this.adminUserDataGridView.Rows.Add(rowValues);
            }
        }

        private bool validateGridData()
        {            
            foreach (DataGridViewRow row in this.adminUserDataGridView.Rows)
            {
                //MessageBox.Show(row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString());
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                {
                    this.errorMessage = "User Name cannot be empty or null!";
                    unselectAll();
                    row.Cells[1].Selected = true;
                    return false;
                }

                if (row.Cells[2].Value == null || row.Cells[2].Value.ToString() == "")
                {
                    this.errorMessage = "Password cannot be empty or null!";
                    unselectAll();
                    row.Cells[2].Selected = true;
                    return false;
                }

                if (Int32.Parse(row.Cells[0].Value.ToString()) == -1)
                {

                }                
            }
            return true;
        }

        private void updateAdminUserListFromGrid()
        {

        }

        private void commitAdminUserList()
        {

        }

        private void unselectAll()
        {
            foreach (DataGridViewCell currCell in this.adminUserDataGridView.SelectedCells)
            {
                currCell.Selected = false;
            }

            foreach (DataGridViewRow currRow in this.adminUserDataGridView.SelectedRows)
            {
                currRow.Selected = false;
            }

            foreach (DataGridViewColumn currcolumn in this.adminUserDataGridView.SelectedColumns)
            {
                currcolumn.Selected = false;
            }
        }


        private void AdminUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void AdminUserForm_Load(object sender, EventArgs e)
        {            
            this.TopMost = true;
            populateAdminUserList();
            populateDataGridView();
        }

        private void adminUserSaveBtn_Click(object sender, EventArgs e)
        {
            if (validateGridData())
            {
                updateAdminUserListFromGrid();
                commitAdminUserList();
            }
            else
            {
                MessageBox.Show(this, "Save Failed: " + Environment.NewLine + this.errorMessage, "Data Validation Error");
            }
        }

        private void adminUserAddBtn_Click(object sender, EventArgs e)
        {
            
        }        

        private void adminUserDeleteBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
