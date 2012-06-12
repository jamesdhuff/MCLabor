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
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

                for(int i = 0; i < this.adminUserDataGridView.Rows.Count; i++)
                {
                    if((row.Index != i) && (row.Cells[1].Value.ToString().ToUpper().Equals(this.adminUserDataGridView.Rows[i].Cells[1].Value.ToString().ToUpper())))
                    {
                        this.errorMessage = "Username must be unique!";
                        unselectAll();
                        row.Cells[1].Selected = true;
                        this.adminUserDataGridView.Rows[i].Cells[1].Selected = true;
                        return false;
                    }
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
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();                
                foreach(AdminUser currUser in this.adminUserMap.Values)
                {
                    using (SqlCommand userLookupCmd = new SqlCommand("SELECT adminUserId FROM admin_user WHERE userName = @username",conn))
                    {
                        userLookupCmd.Parameters.Add(new SqlParameter("@username",currUser.UserName));
                        SqlDataReader reader = userLookupCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            reader.Close();
                            using (SqlCommand updateUserCmd = new SqlCommand("UPDATE admin_user SET userName = @username, password = @password WHERE adminUserId = @adminUserId", conn))
                            {
                                updateUserCmd.Parameters.AddWithValue("@username", currUser.UserName.ToUpper());
                                updateUserCmd.Parameters.AddWithValue("@password", currUser.Password);
                                updateUserCmd.Parameters.AddWithValue("@adminUserId", currUser.AdminUserId);

                                updateUserCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            reader.Close();
                            using (SqlCommand insertUserCmd = new SqlCommand("INSERT INTO admin_user (userName, password) VALUES(@username, @password); SELECT cast(Scope_Identity() as int)", conn))
                            {
                                insertUserCmd.Parameters.AddWithValue("@username", currUser.UserName.ToUpper());
                                insertUserCmd.Parameters.AddWithValue("@password", currUser.Password);

                                int newId = (int)insertUserCmd.ExecuteScalar();

                                this.adminUserMap[currUser.UserName].AdminUserId = newId;
                            }
                        }
                    }

                }
            }
            MessageBox.Show("Save Successful!");
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

        private void addNewDataGridViewRecord()
        {
            AdminUser newUser = new AdminUser();
            this.adminUserDataGridView.Rows.Add(new object[] {newUser.AdminUserId, newUser.UserName, newUser.Password});
        }

        private bool deleteRecord()
        {
            if (this.adminUserDataGridView.SelectedRows.Count > 1)
            {
                this.errorMessage = "Cannot delete multiple records.  Select a single record to delete.";
                return false;
            }

            if (this.adminUserDataGridView.SelectedRows.Count < 1)
            {
                this.errorMessage = "Please select a row to delete.";
                return false;
            }

            if (this.adminUserDataGridView.Rows.Count < 2)
            {
                this.errorMessage = "At least one Admin User record must exist...  Retard";
                return false;
            }

            if ((int)this.adminUserDataGridView.SelectedRows[0].Cells[0].Value > -1)
            {
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM admin_user WHERE adminUserId = @adminUserId", conn))
                    {
                        cmd.Parameters.AddWithValue("@adminUserId", (int)this.adminUserDataGridView.SelectedRows[0].Cells[0].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            this.adminUserDataGridView.Rows.Remove(this.adminUserDataGridView.SelectedRows[0]);

            return true;
        }

        private void AdminUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenuForm.Show();
        }

        private void AdminUserForm_Load(object sender, EventArgs e)
        {            
            this.TopMost = true;
            this.TopMost = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
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
            addNewDataGridViewRecord();
        }

        private void adminUserDeleteBtn_Click(object sender, EventArgs e)
        {
            if(!deleteRecord())
            {
                MessageBox.Show(this.errorMessage, "Delete Operation Failed");
            }
        }
    }
}
