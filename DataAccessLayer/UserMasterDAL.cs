using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Data;

namespace DataAccessLayer
{
    public class UserMasterDAL
    {
        public static DataTable GetUserMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from UserMaster";
            SqlCommand sqlCommand = new SqlCommand(commands, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetUserMaster()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetUserMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType=CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddUserMaster(String UserName, String Password, String Status)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert UserMaster(UserName,Password,Status) values ('"+UserName+"','"+Password+"','"+Status+"')";
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddUserMaster(String UserName, String Password, String Status)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddUserMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@UserName",UserName);
            sql.Parameters.AddWithValue("@Password",Password);
            sql.Parameters.AddWithValue("@Status",Status);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteUserMaster(int UserID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Delete from UserMaster where UserID =" + UserID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spDeleteUserMaster(int UserID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spDeleteUserMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@UserID", UserID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUserMaster(int UserID, String UserName, String Password, String Status)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Update UserMaster set Username='" + UserName + "',Password='" + Password + "',Status='" + Status + "' where UserID = " + UserID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateUserMaster(int UserID, String UserName, String Password, String Status)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spUpdateUserMaster";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@UserID", UserID);
            sql.Parameters.AddWithValue("@Password", Password);
            sql.Parameters.AddWithValue("@Status", Status);
            sql.Parameters.AddWithValue("@UserName", UserName);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetUserMasterByID(int UserID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select * from UserMaster where UserID = " + UserID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable spGetUserMasterByID(int UserID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetUserMasterByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@UserID",UserID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static User spCheckUserMasterByID(String UserName,String Password)
        {
            var connection = ConnectionManager.GetConnection();
            User result = null;
            DataTable table = new DataTable();
            var commands = "Select * from UserMaster where UserName='"+UserName+"' and Password ='"+Password+"'";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            if (table.Rows.Count > 0)
            {
                result =new User()
                {
                    UserId = (int)table.Rows[0]["UserId"],
                    UserName = (String)table.Rows[0]["UserName"]
                };
            }
            return result;
        }
    }
}
