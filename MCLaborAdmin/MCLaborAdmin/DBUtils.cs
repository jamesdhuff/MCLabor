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
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.InitialCatalog = ConfigurationSettings.AppSettings["dbCatalog"];
            connStringBuilder.DataSource = ConfigurationSettings.AppSettings["dbServer"] + "\\" + ConfigurationSettings.AppSettings["dbInstanceName"];
            connStringBuilder.UserID = ConfigurationSettings.AppSettings["dbUser"];
            connStringBuilder.Password = ConfigurationSettings.AppSettings["dbPassword"];
            connStringBuilder.IntegratedSecurity = false;

            return new SqlConnection(connStringBuilder.ToString());
        }
    }
}
