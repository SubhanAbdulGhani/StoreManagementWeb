using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class ProductBL
    {
        public DataTable GetProducts()
        {
            //return ProductDAL.GetProduct();
            return ProductDAL.spGetProduct();
        }

        public void AddProducts(String Name, String Type, String Color,int ProductcategoryID)
        {
            //ProductDAL.AddProducts(Name, Type, Color, ProductcategoryID);
            ProductDAL.spAddProducts(Name, Type, Color, ProductcategoryID);
        }

        public void DeleteProducts(int ID)
        {
            // ProductDAL.DeleteProducts(ID);
            ProductDAL.spDeleteProducts(ID);
        }

        public void UpdateProducts(int ProductID, String Name, String Type, String Color,int ProductCategoryID)
        {
            //ProductDAL.UpdateProducts(ProductID, Name, Type, Color,ProductCategoryID);
            ProductDAL.spUpdateProducts(ProductID, Name, Type, Color,ProductCategoryID);
        }

        public DataTable GetProductsById(int ID)
        {
            return ProductDAL.GetProductsByID(ID);
        }
    }
}
