using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class RawMaterialDAL
    {
        public static DataTable GetRawMaterial()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from RawMaterial";
            SqlCommand sql = new SqlCommand(commands, connection);            
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            connection.Open();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable GetRawMaterialSP()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetRawMaterial";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            connection.Open();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddRawMaterial(String Type, String Color, String Name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "Insert RawMaterial(Type,Color,Name) values('" + Type + "','" + Color + "','" + Name + "')";
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddRawMaterialSP(String Type, String Color, String Name)
        {
            var connection = ConnectionManager.GetConnection();
            //String commands = "Insert RawMaterial(Type,Color,Name) values('" + Type + "','" + Color + "','" + Name + "')";
            //  String commands = "spAddRawMaterial @Type='"+Type+"',@Color='"+Color+"',@Name='"+Name+"'";
            String str = "spAddRawMaterial";
            SqlCommand cmd = new SqlCommand(str, connection);            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type",Type);
            cmd.Parameters.AddWithValue("@Color",Color);
            cmd.Parameters.AddWithValue("@Name",Name);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateRawMaterial(int ID, String Type, String Color, String Name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "Update RawMaterial set Type='"+Type+"',Color='"+Color+"',Name='"+Name+ "' where RawMaterialID=" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateRawMaterialSP(int ID, String Type, String Color, String Name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spUpdateRawMaterial" ;
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.Parameters.AddWithValue("@Type",Type);
            sql.Parameters.AddWithValue("@Color",Color);
            sql.Parameters.AddWithValue("@Name", Name);
            sql.Parameters.AddWithValue("@RawMaterialID", ID);
            sql.CommandType = CommandType.StoredProcedure;
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteRawMaterial(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "Delete from RawMaterial where RawMaterialID=" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteRawMaterialSP(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spDeleteRawMaterial";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.Parameters.AddWithValue("@RawMaterialID",ID);
            sql.CommandType = CommandType.StoredProcedure;
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetRawMaterialsByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from RawMaterial where RawMaterialID=" + ID;
            SqlCommand sql = new SqlCommand(commands,connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable GetRawMaterialsByIDSP(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetRawMaterialByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@RawMaterialID",ID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
