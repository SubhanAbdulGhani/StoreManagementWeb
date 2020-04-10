using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductDAL
    {
        public static DataTable GetProduct()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "Select P.ProductID, P.Name,P.Type,P.Color,PC.Name as [Product Category] from Product P inner join ProductCategory PC on P.ProductCategoryID = PC.ID";
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;

        }

        public static DataTable spGetProduct()
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            var commands = "spGetProducts";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            connection.Open();
            dataAdapter.Fill(table);
            connection.Close();
            return table;

        }

        public static void AddProducts(String Name, String Type, String Color,int ProductCategoryID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "Insert Product(Name,Type,Color,ProductCategoryID) values('" + Name+"','"+Type+"','"+Color+"','"+ ProductCategoryID+"')";
            SqlCommand sql = new SqlCommand(commands, connection);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void spAddProducts(String Name, String Type, String Color, int ProductCategoryID)
        {
            var connection = ConnectionManager.GetConnection();
            var commands = "spAddProducts";
            SqlCommand sql = new SqlCommand(commands, connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Name",Name);
            sql.Parameters.AddWithValue("@Type",Type);
            sql.Parameters.AddWithValue("@Color",Color);
            sql.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
            connection.Open();
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteProducts(int ProductID)
        {
            var connection = ConnectionManager.GetConnection();
            var command = "Delete from Product where ProductID =" + ProductID;
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

        }

        public static void spDeleteProducts(int ProductID)
        {
            var connection = ConnectionManager.GetConnection();
            var command = "spDeleteProducts" ;
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProductID",ProductID);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

        }

        public static void UpdateProducts(int ProductID,String Name, String Type, String Color,int ProductCategoryID)
        {
            var connection = ConnectionManager.GetConnection();
            var command = "Update Product set Name = '"+Name+"',Type = '"+Type+"',Color = '"+Color+"',ProductCategoryID ="+ProductCategoryID+" where ProductID ="+ProductID;
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void spUpdateProducts(int ProductID, String Name, String Type, String Color, int ProductCategoryID)
        {
            var connection = ConnectionManager.GetConnection();
            var command = "spUpdateProducts";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            sqlCommand.Parameters.AddWithValue("@Type", Type);
            sqlCommand.Parameters.AddWithValue("@Color", Color);
            sqlCommand.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
            sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetProductsByID(int ID)
        {
            var connection = ConnectionManager.GetConnection();
            DataTable table = new DataTable();
            String commands = "Select * from Product P where ProductID =" + ID;
            SqlCommand sql = new SqlCommand(commands, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            connection.Open();
            sqlData.Fill(table);
            connection.Close();
            return table;
        }
    }
}
