using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Web.Configuration;
using System.Web;

namespace MCLaborServer
{
    public static class DBUtils
    {
        public static SqlConnection getConnection()
        {
            return getConnection("default");
        }

        public static SqlConnection getConnection(string connStringName)
        {
            ConnectionStringSettings connString = WebConfigurationManager.ConnectionStrings[connStringName];
            return new SqlConnection(connString.ToString());
        }
    }
}
