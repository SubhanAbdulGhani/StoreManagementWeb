using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class SalesContractDAL
    {
        public static DataTable GetSalesContract()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
           // var commands = "Select * from SalesContract";
            var commands = "Select BM.ID as [Buyer ID],SC.SalesContractID,SC.SaleContractDate,SC.PreparedBy,SC.ApprovedBy,SC.Approve,BM.CompanyName as [Buyer Master] from SalesContract SC inner join BuyerMaster BM on SC.BuyerID = BM.ID";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static int AddSalesContract(DateTime SaleContractDate, String PreparedBy, int BuyerID,String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var sql = "Insert SalesContract(SaleContractDate,PreparedBy,BuyerID,ApprovedBy) values('" + SaleContractDate + "','" + PreparedBy + "','" + BuyerID + "','" +ApprovedBy+ "'); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            //sql.ExecuteNonQuery();
            int modified = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return modified;
        }

        public static void DeleteSalesContract(int SaleContractID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from SalesContract where SalesContractID =" + SaleContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateSalesContract(DateTime SaleContractDate, String PreparedBy, int BuyerID, int SalesContractID, String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update SalesContract set SaleContractDate ='" + SaleContractDate + "', PreparedBy='" + PreparedBy + "', BuyerID =" + BuyerID + ", ApprovedBy ='" +ApprovedBy+ "' where SalesContractID =" + SalesContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetSalesContractByID(int SalesContractID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SalesContract where SalesContractID =" + SalesContractID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void ApproveSalesContract(int SalesContractID, String ApprovedBy)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spApproveSalesContract";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@SalesContractID", SalesContractID);
            sql.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }
    }
}
