using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MCLaborAdmin
{
    public static class DBUtils
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
