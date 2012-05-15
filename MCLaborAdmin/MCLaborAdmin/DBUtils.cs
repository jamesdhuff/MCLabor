using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MCLaborAdmin
{
    public static class DBUtils
    {
        public static SqlConnection getConnection()
        {
            return getConnection("default");
        }

        public static SqlConnection getConnection(string connStringName)
        {            
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings[connStringName];
            return new SqlConnection(connString.ToString());
        }
    }
}
