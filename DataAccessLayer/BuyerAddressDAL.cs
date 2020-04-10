using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BuyerAddressDAL
    {
        public static DataTable GetBuyerAddress()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from BuyerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetBuyerAddress()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetBuyerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddBuyerAddress(String Address, String City, String Phone, String Street, int BuyerMasterID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert BuyerAddress(Address,City,Phone,Street,BuyerMasterID) values('" + Address + "','" + City + "','" + Phone + "','" + Street + "','" + BuyerMasterID + "')";
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddBuyerAddress(String Address, String City, String Phone, String Street, int BuyerMasterID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddBuyerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Address",Address);
            sql.Parameters.AddWithValue("@City",City);
            sql.Parameters.AddWithValue("@Phone",Phone);
            sql.Parameters.AddWithValue("@BuyerMasterID", BuyerMasterID);
            sql.Parameters.AddWithValue("@Street",Street);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteBuyerAddress(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from BuyerAddress where ID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteBuyerAddress(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteBuyerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateBuyerAddress(String Address, String City, String Phone, String Street, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update BuyerAddress set Address ='" + Address + "', City='" + City + "',Phone='" + Phone + "',Street='" + Street + "' where ID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateBuyerAddress(String Address, String City, String Phone, String Street, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateBuyerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Address", Address);
            sql.Parameters.AddWithValue("@City", City);
            sql.Parameters.AddWithValue("@Phone", Phone);
            sql.Parameters.AddWithValue("@ID", ID);
            sql.Parameters.AddWithValue("@Street", Street);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAddressByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from BuyerAddress where BuyerMasterID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetAddressByID(int BuyerMasterID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetAddressByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@BuyerMasterID",BuyerMasterID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
