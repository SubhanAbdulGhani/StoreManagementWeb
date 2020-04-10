using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class SellerMasterBL
    {
        public DataTable GetSeller()
        {
            // return SellerMasterDAL.GetSellerMaster();
            return SellerMasterDAL.spGetSellerMaster();
        }
        
        public void AddSellerMaster(String Company)
        {
            //SellerMasterDAL.AddSellerMaster(Company);
            SellerMasterDAL.SpAddSellerMaster(Company);
        }

        public void UpdateSellerMaster(int ID ,String name)
        {
            //SellerMasterDAL.UpdateSellerMaster(ID,name);
            SellerMasterDAL.SpUpdateSellerMaster(ID, name);
        }

        public void DeleteSellerMaster(int ID)
        {
            //SellerMasterDAL.DeleteSellerMaster(ID);
            SellerMasterDAL.SpDeleteSellerMaster(ID);
        }

        public DataTable GetSellerByID(int ID)
        {
            //return SellerMasterDAL.GetSupplierByID(ID);
            return SellerMasterDAL.SpGetSupplierByID(ID);
        }
    }
}
