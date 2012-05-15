using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCLaborAdmin
{
    class AdminUser
    {
        private int adminUserId;       
        private string userName;
        private string password;

        public AdminUser()
        {
            this.adminUserId = -1;
            this.userName = "";
            this.password = "";
        }

        public AdminUser(string username, string password)
        {
            this.adminUserId = -1;
            this.userName = username;
            this.password = password;
        }

        public AdminUser(int id, string username, string password)
        {
            this.adminUserId = id;
            this.userName = username;
            this.password = password;
        }

        public int AdminUserId
        {
            get
            {
                return this.adminUserId;
            }
            set
            {
                this.adminUserId = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        
    }
}
