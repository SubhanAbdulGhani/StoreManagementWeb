using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SellerAddressDAL
    {
        public static DataTable GetSellerAddress()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from SellerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetSellerAddress()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetSellerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddSellerAddress(String Address, String City, String Phone, String Street, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert SellerAddress(Address,City,Phone,Street,SellerID) values('"+Address+"','"+City+"','"+Phone+"','"+Street+"','"+SellerID+"')";
            SqlCommand sql = new SqlCommand(commands,connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddSellerAddress(String Address, String City, String Phone, String Street, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands ="spAddSellerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Address",Address);
            sql.Parameters.AddWithValue("@City",City);
            sql.Parameters.AddWithValue("@Phone",Phone);
            sql.Parameters.AddWithValue("@Street",Street);
            sql.Parameters.AddWithValue("@SellerID",SellerID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteSellerAddress(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from SellerAddress where SellerID ="+SellerID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteSellerAddress(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteSellerAddress";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SellerID", SellerID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateSellerAddress(String Address, String City, String Phone, String Street, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update SellerAddress set Address ='"+ Address + "', City='" + City + "',Phone='" + Phone + "',Street='" + Street + "' where SellerAddressID =" + SellerID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateSellerAddress(String Address, String City, String Phone, String Street, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateSellerAddress" ;
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Address", Address);
            sql.Parameters.AddWithValue("@City", City);
            sql.Parameters.AddWithValue("@Phone", Phone);
            sql.Parameters.AddWithValue("@Street", Street);
            sql.Parameters.AddWithValue("@SellerID", SellerID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAddressByID(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SellerAddress where SellerID =" + SellerID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetAddressByID(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetSellerAddressByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SellerID", SellerID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

    }
}
