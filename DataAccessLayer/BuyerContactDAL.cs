using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BuyerContactDAL
    {
        public static DataTable GetBuyerContact()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from BuyerContact";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetBuyerContact()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetBuyerContact";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int BuyerMasterID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert BuyerContact(Name,Mobile,Email,Whatsapp,BuyerMasterID) values('" + Name + "','" + Mobile + "','" + Email + "','" + Whatsapp + "','" + BuyerMasterID + "')";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int BuyerMasterID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddBuyerContact";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Name",Name);
            sqlcommand.Parameters.AddWithValue("@Mobile", Mobile);
            sqlcommand.Parameters.AddWithValue("@Email", Email);
            sqlcommand.Parameters.AddWithValue("@Whatsapp", Whatsapp);
            sqlcommand.Parameters.AddWithValue("@BuyerMasterID", BuyerMasterID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteBuyerContact(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from BuyerContact where BuyerMasterID=" + ID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteBuyerContact(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteBuyerContact";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@BuyerMasterID", ID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update BuyerContact set Name='" + Name + "', Mobile='" + Mobile + "',Email='" + Email + "',Whatsapp='" + Whatsapp + "' where ID =" + ID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int ID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateBuyerContact";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Name", Name);
            sqlcommand.Parameters.AddWithValue("@Mobile", Mobile);
            sqlcommand.Parameters.AddWithValue("@Email", Email);
            sqlcommand.Parameters.AddWithValue("@Whatsapp", Whatsapp);
            sqlcommand.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetContactByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from BuyerContact where BuyerMasterID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetContactByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetBuyerContactByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@BuyerMasterID", ID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
