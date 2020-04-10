using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class BuyerMasterBL
    {
        public DataTable GetBuyerMaster()
        {
            //return BuyerMasterDAL.GetBuyerMaster();
            return BuyerMasterDAL.spGetBuyerMaster();
        }

        public void AddBuyerMaster(String CompanyName)
        {
            //BuyerMasterDAL.AddBuyerMaster(CompanyName);
            BuyerMasterDAL.spAddBuyerMaster(CompanyName);
        }

        public void DeleteBuyerMaster(int ID)
        {
            //BuyerMasterDAL.DeleteBuyerMaster(ID);
            BuyerMasterDAL.spDeleteBuyerMaster(ID);
        }

        public void UpdateBuyerMaster(String CompanyName, int ID)
        {
            //BuyerMasterDAL.UpdateBuyerMaster(CompanyName , ID);
            BuyerMasterDAL.spUpdateBuyerMaster(CompanyName, ID);
        }

        public DataTable GetBuyerByID(int ID)
        {
            //return BuyerMasterDAL.GetBuyerByID(ID);
            return BuyerMasterDAL.spGetBuyerByID(ID);
        }
    }
}
