using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SalesContractDetailDAL
    {
        public static DataTable GetSalesContractDetail()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from SalesContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetSalesContractDetail()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetSalesContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddSalesContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int SalesContractID, int ProductID)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "Insert SalesContractDetail(Weight,Price,TotalAmount,SalesContractID,ProductID) values('" + Weight + "','" + Price + "','" + TotalAmount + "','" + SalesContractID + "','" + ProductID + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public static void DeleteSalesContractDetail(int SalesContractDetailID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from SalesContractDetail where SalesContractID =" + SalesContractDetailID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteSalesContractDetail(int SalesContractDetailID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteSalesContractDetail";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SalesContractDetailID", SalesContractDetailID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateSalesContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int SalesContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update SalesContractDetail set Weight ='" + Weight + "', Price ='" + Price + "where SalesContractID =" + SalesContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetSalesContractDetailByID(int SalesContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SalesContractDetail where SalesContractID =" + SalesContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetSalesContractDetailByID(int SalesContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetSalesContractDetailByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SalesContractID", SalesContractID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
