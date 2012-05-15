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
        private Dictionary<String, AdminUser> adminUserMap;
        private string errorMessage;

        public AdminUserForm(MainMenuForm mainMenuForm)
        {
            this.adminUserMap = new Dictionary<String, AdminUser>();
            this.mainMenuForm = mainMenuForm;            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void populateAdminUserMap()
        {
            this.adminUserMap = new Dictionary<String, AdminUser>();
            string sqlString = "select adminUserId, userName, password FROM admin_user";
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.adminUserMap.Add(reader.GetString(1), new AdminUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));                    
                }
            }
        }

        private void populateDataGridView()
        {            
            foreach(AdminUser currAdminUser in this.adminUserMap.Values)
            {
                object[] rowValues = { currAdminUser.AdminUserId, currAdminUser.UserName, currAdminUser.Password };
                this.adminUserDataGridView.Rows.Add(rowValues);
            }
        }

        private bool validateGridData()
        {            
            foreach (DataGridViewRow row in this.adminUserDataGridView.Rows)
            {                
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString().Trim() == "")
                {
                    this.errorMessage = "User Name cannot be empty or null!";
                    unselectAll();
                    row.Cells[1].Selected = true;
                    return false;
                }

                if (row.Cells[2].Value == null || row.Cells[2].Value.ToString().Trim() == "")
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
            if (validateGridData())
            {
                foreach (DataGridViewRow row in this.adminUserDataGridView.Rows)
                {
                    if (this.adminUserMap.ContainsKey(row.Cells[1].Value.ToString()))
                    {
                        this.adminUserMap[row.Cells[1].Value.ToString()].AdminUserId = Int32.Parse(row.Cells[0].Value.ToString());
                        this.adminUserMap[row.Cells[1].Value.ToString()].UserName = row.Cells[1].Value.ToString();
                        this.adminUserMap[row.Cells[1].Value.ToString()].Password = row.Cells[2].Value.ToString();
                    }
                    else
                    {
                        this.adminUserMap.Add(row.Cells[1].Value.ToString(), new AdminUser(Int32.Parse(row.Cells[0].Value.ToString()),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString()));
                    }
                }
            }

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
            populateAdminUserMap();
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
