using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class InventoryBL
    {
        public static DataTable GetInventory()
        {
            return InventoryDAL.GetInventory();
        }

        public static int AddInventory(int ProductID, int Quantity, DateTime UpdatedDate, String UpdatedBy)
        {
            return InventoryDAL.AddInventory(ProductID, Quantity, UpdatedDate, UpdatedBy);
        }

        public static void UpdateInventory(int ID,int ProductID, int Quantity, DateTime UpdatedDate, String UpdatedBy)
        {
            InventoryDAL.UpdateInventory(ID, ProductID, Quantity, UpdatedDate, UpdatedBy);
        }

        public static void DeleteInventory(int ID)
        {
            InventoryDAL.DeleteInventory(ID);
        }

        public static DataTable GetInventoryByID(int ID)
        {
            return InventoryDAL.GetInventoryByID(ID);
        }


    }
}
