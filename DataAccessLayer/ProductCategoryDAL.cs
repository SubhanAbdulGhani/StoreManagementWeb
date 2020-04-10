using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
	public class ProductCategoryDAL
	{
		public static DataTable GetProductCategory()
		{
			var connection = ConnectionManager.GetConnection();
			DataTable table = new DataTable();
			String commands = "Select * from ProductCategory";
			SqlCommand sql = new SqlCommand(commands, connection);
			SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
			//sql.ExecuteNonQuery();
			connection.Open();
			dataAdapter.Fill(table);
			connection.Close();
			return table;
		}

        public static DataTable spGetProductCategory()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spProductCategory";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            //sql.ExecuteNonQuery();
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void AddProductCategory(String name)
		{
			var connection = ConnectionManager.GetConnection();
			String commands = "Insert ProductCategory(Name) values('" + name + "')";
			SqlCommand sql = new SqlCommand(commands, connection);
			connection.Open();
			sql.ExecuteNonQuery();
			connection.Close();
		}

        public static void spAddProductCategory(String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spAddProductCategory";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Name", name);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateProductCategory(int ID, String name)
		{
			var connection = ConnectionManager.GetConnection();
			String commands = "update ProductCategory set Name='" + name + "' where ID=" + ID;
			SqlCommand sql = new SqlCommand(commands, connection);
			connection.Open();
			sql.ExecuteNonQuery();
			connection.Close();
		}

        public static void spUpdateProductCategory(int ID, String name)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spUpdateProductCategory";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Name", name);
            sql.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteProductCategory(int ID)
		{
			var connection = ConnectionManager.GetConnection();
			String commands = "Delete from ProductCategory where ID=" + ID;
			SqlCommand sql = new SqlCommand(commands, connection);
			connection.Open();
			sql.ExecuteNonQuery();
			connection.Close();

		}

        public static void spDeleteProductCategory(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            String commands = "spDeleteProductCategory";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();

        }

        public static DataTable GetProductCategoryByID(int ID)
		{
			var connection = ConnectionManager.GetConnection();
			DataTable table = new DataTable();
			String commands = "Select * from ProductCategory where ID =" + ID;
			SqlCommand sql = new SqlCommand(commands, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sql);
			connection.Open();
			sqlData.Fill(table);
			connection.Close();
			return table;
		}

        public static DataTable spGetProductCategoryByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "spGetProductCategoryByID";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }

    }
}
