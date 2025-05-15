using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("La chaîne de connexion est introuvable dans App.config");

            return new SqlConnection(connectionString);
        }
    }
}
