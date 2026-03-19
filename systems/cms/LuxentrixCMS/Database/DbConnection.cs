using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LuxentrixContentManagementSystem.Database
{
   internal class DbConnection
   {
        public static SqlConnection GetConnection()
        {
            string connString =
                @"Server=lappyyyy\SQLEXPRESS01;
                Database=LuxentrixDB;
                Trusted_Connection=True;
                TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
