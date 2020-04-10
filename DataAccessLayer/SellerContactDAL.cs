using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SellerContactDAL
    {
        public static DataTable GetSellerContact()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from SellerContact";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetSellerContact()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetSellerContact";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddSellerContact(String Name, String Mobile, String Email, String Whatsapp,int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert SellerContact(Name,Mobile,Email,Whatsapp,SellerID) values('"+Name+"','"+Mobile+"','"+Email+"','"+Whatsapp+"','"+SellerID+"')";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddSellerContact(String Name, String Mobile, String Email, String Whatsapp, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddSellerContact";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Name",Name);
            sqlcommand.Parameters.AddWithValue("@Mobile",Mobile);
            sqlcommand.Parameters.AddWithValue("@Email", Email);
            sqlcommand.Parameters.AddWithValue("@Whatsapp", Whatsapp);
            sqlcommand.Parameters.AddWithValue("@SellerID",SellerID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteSellerContact(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from SellerContact where SellerID="+SellerID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteSellerContact(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteSellerContact" ;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@SellerID",SellerID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateSellerContact(String Name, String Mobile, String Email, String Whatsapp,int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update SellerContact set Name='"+ Name +"', Mobile='"+Mobile+"',Email='"+Email+"',Whatsapp='"+Whatsapp+"' where SellerContactID ="+SellerID;
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateSellerContact(String Name, String Mobile, String Email, String Whatsapp, int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateSellerContact";
            SqlCommand sqlcommand = new SqlCommand(commands, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Name", Name);
            sqlcommand.Parameters.AddWithValue("@Mobile", Mobile);
            sqlcommand.Parameters.AddWithValue("@Email", Email);
            sqlcommand.Parameters.AddWithValue("@Whatsapp", Whatsapp);
            sqlcommand.Parameters.AddWithValue("@SellerID", SellerID);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetContactByID(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from SellerContact where SellerID =" + SellerID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetContactByID(int SellerID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetContactByID";
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
