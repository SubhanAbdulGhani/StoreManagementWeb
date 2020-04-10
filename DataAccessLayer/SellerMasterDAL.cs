using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SellerMasterDAL
    {
        public static DataTable GetSellerMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SellerMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            //sql.ExecuteNonQuery();
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetSellerMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetSellerMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            //sql.ExecuteNonQuery();
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddSellerMaster(String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands ="Insert Sellermaster(CompanyName) values('" + name + "')";
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void SpAddSellerMaster(String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spAddSellerMaster";
            SqlCommand sqlCommand = new SqlCommand(commands,connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CompanyName",name);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

        }

        public static void UpdateSellerMaster(int ID,String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "update sellerMaster set CompanyName='"+name+ "' where ID="+ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void SpUpdateSellerMaster(int ID,String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spUpdateSellerMaster";
            SqlCommand sqlCommand = new SqlCommand(commands,connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CompanyName",name);
            sqlCommand.Parameters.AddWithValue("@ID",ID);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteSellerMaster(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "Delete from SellerMaster where ID=" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();

        }

        public static void SpDeleteSellerMaster(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spDelSellerMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID",ID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();

        }

        public static DataTable GetSupplierByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SellerMaster where ID ="+ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable SpGetSupplierByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetSupplierByID";
            SqlCommand sqlCommand = new SqlCommand(commands,connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID",ID);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
