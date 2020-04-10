using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PurchaseContractDetailDAL
    {
        public static DataTable GetPurchaseContractDetail()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from PurchaseContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetPurchaseContractDetail()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetPurchaseContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddPurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID, int ProductID)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "Insert PurchaseContractDetail(Weight,Price,TotalAmount,PurchaseContractID,ProductID) values('" + Weight + "','" + Price + "','" + TotalAmount + "','" + PurchaseContractID + "','"+ ProductID + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();           
            connection.Close();
            
        }

        public static void spAddPurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID, int ProductID)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "spAddPurchaseContractDetail";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Weight",Weight);
            cmd.Parameters.AddWithValue("@Price",Price);
            cmd.Parameters.AddWithValue("@TotalAmount",TotalAmount);
            cmd.Parameters.AddWithValue("@PurchaseContractID",PurchaseContractID);
            cmd.Parameters.AddWithValue("@ProductID",ProductID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static void DeletePurchaseContractDetail(int PurchaseContractDetailID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from PurchaseContractDetail where PurchaseContractID =" + PurchaseContractDetailID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeletePurchaseContractDetail(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeletePurchaseContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdatePurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update PurchaseContractDetail set Weight ='" + Weight + "', Price ='" + Price + "where PurchaseContractID =" + PurchaseContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdatePurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdatePurchaseContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Weight", Weight);
            sql.Parameters.AddWithValue("@Price", Price);
            sql.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetPurchaseContractDetailByID(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from PurchaseContractDetail where PurchaseContractID =" + PurchaseContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetPurchaseContractDetailByID(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetPurchaseContractDetailByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
