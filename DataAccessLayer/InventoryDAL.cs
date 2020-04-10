using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class InventoryDAL
    {
        

        public static DataTable GetInventory()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var query = "GetInventory";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static int AddInventory(int ProductID,int Quantity,DateTime UpdatedDate,String UpdatedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var query = "AddInventory; SELECT SCOPE_IDENTITY();";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ProductID", ProductID);
            sql.Parameters.AddWithValue("@Quantity", Quantity);
            sql.Parameters.AddWithValue("@UpdatedDate", UpdatedDate);
            sql.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
            connection.Open();
            int modified = Convert.ToInt32(sql.ExecuteScalar());
            connection.Close();
            return modified;
        }

        public static void UpdateInventory(int ID, int ProductID, int Quantity, DateTime UpdatedDate, String UpdatedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var query = "UpdateInventory";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            sql.Parameters.AddWithValue("@ProductID", ProductID);
            sql.Parameters.AddWithValue("@Quantity", Quantity);
            sql.Parameters.AddWithValue("@UpdatedDate", UpdatedDate);
            sql.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteInventory(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var query = "DeleteInventory";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetInventoryByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var query = "GetInventoryByID";
            SqlCommand sql = new SqlCommand(query, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID",ID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
