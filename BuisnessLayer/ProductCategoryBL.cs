using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
	public class ProductCategoryBL
	{
		public DataTable GetProductCategory()
		{
            //return ProductCategoryDAL.GetProductCategory();
            return ProductCategoryDAL.spGetProductCategory();
		}

		public void AddProductCategory(String Name)
		{
            //ProductCategoryDAL.AddProductCategory(Name);
            ProductCategoryDAL.spAddProductCategory(Name);
		}

		public void UpdateProductCategory(int ID, String name)
		{
            //ProductCategoryDAL.UpdateProductCategory(ID,name);
            ProductCategoryDAL.spUpdateProductCategory(ID,name);
		}

		public void DeleteProductCategory(int ID)
		{
            //ProductCategoryDAL.DeleteProductCategory(ID);
            ProductCategoryDAL.spDeleteProductCategory(ID);
		}

		public DataTable GetProductCategoryByID(int ID)
		{
            //return ProductCategoryDAL.GetProductCategoryByID(ID);
            return ProductCategoryDAL.spGetProductCategoryByID(ID);
		}
	}
}
