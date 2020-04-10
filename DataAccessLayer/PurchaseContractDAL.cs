using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PurchaseContractDAL
    {


        public static DataTable GetPurchaseContract()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            //var commands = "Select * from PurchaseContract";
            var commands = "Select SM.ID as [Seller ID],PC.PurchaseContractID,PC.PurchaseContractDate,PC.PreparedBy,PC.Approvedby,PC.Approve,SM.CompanyName as [Seller Master] from PurchaseContract PC inner join SellerMaster SM on PC.SellerID = SM.ID";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetPurchaseContract()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            //var commands = "Select * from PurchaseContract";
            var commands = "GetPurchaseContract";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static int AddPurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID,String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "Insert PurchaseContract(PurchaseContractDate,PreparedBy,SellerID,ApprovedBy) values('" + PurchaseContractDate + "','" + PreparedBy + "','" + SellerID + "','"+ApprovedBy+"'); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            //sql.ExecuteNonQuery();
            int modified = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return modified;
        }

        public static int spAddPurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID, String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "spAdddPurchaseContract";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseContractDate", PurchaseContractDate);
            cmd.Parameters.AddWithValue("@PreparedBy", PreparedBy);
            cmd.Parameters.AddWithValue("@SellerID", SellerID);
            cmd.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);
            connection.Open();
            //sql.ExecuteNonQuery();
            int modified = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return modified;
        }

        public static void DeletePurchaseContract(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from PurchaseContract where PurchaseContractID =" + PurchaseContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeletePurchaseContract(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeletePurchaseContract";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdatePurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID, int PurchaseContractID,String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update PurchaseContract set PurchaseContractDate ='" + PurchaseContractDate + "', PreparedBy='" + PreparedBy + "', SellerID = "+SellerID+", ApprovedBy ='"+ApprovedBy +"' where PurchaseContractID =" + PurchaseContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdatePurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID, int PurchaseContractID, String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdatePurchaseContract";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@PurchaseContractDate", PurchaseContractDate);
            sql.Parameters.AddWithValue("@PreparedBy", PreparedBy);
            sql.Parameters.AddWithValue("@SellerID", SellerID);
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            sql.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetPurchaseContractByID(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from PurchaseContract where PurchaseContractID =" + PurchaseContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetPurchaseContractByID(int PurchaseContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetPurchaseContractByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void ApprovePurchaseContract(int PurchaseContractID, String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spApprovePurchaseContract";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;           
            sql.Parameters.AddWithValue("@PurchaseContractID", PurchaseContractID);
            sql.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }
    }
}
