using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["Subhan"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            return con;
        }
    }
}
