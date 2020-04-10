using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BuyerMasterDAL
    {
        public static DataTable GetBuyerMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from BuyerMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetBuyerMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetBuyerMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddBuyerMaster(String CompanyName)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert BuyerMaster(CompanyName) values('" + CompanyName + "')";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddBuyerMaster(String CompanyName)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddBuyerMaster";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@CompanyName", CompanyName);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteBuyerMaster(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from BuyerMaster where ID=" + ID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteBuyerMaster(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteBuyerMaster";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateBuyerMaster(String CompanyName, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update BuyerMaster set CompanyName='" + CompanyName + "' where ID =" + ID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateBuyerMaster(String CompanyName, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateBuyerMaster";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Companyname",CompanyName);
            sqlcommand.Parameters.AddWithValue("@ID",ID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetBuyerByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from BuyerMaster where ID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetBuyerByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "GetBuyerByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
