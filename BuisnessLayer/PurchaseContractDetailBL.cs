using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class PurchaseContractDetailBL
    {
        public DataTable GetPurchaseContractDetail()
        {
            //return PurchaseContractDetailDAL.GetPurchaseContractDetail();
            return PurchaseContractDetailDAL.spGetPurchaseContractDetail();
        }

        public void AddPurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID, int ProductID)
        {
            //PurchaseContractDetailDAL.AddPurchaseContractDetail(Weight, Price, TotalAmount, PurchaseContractID, ProductID);
            PurchaseContractDetailDAL.spAddPurchaseContractDetail(Weight, Price, TotalAmount, PurchaseContractID, ProductID);
        }

        public void DeletePurchaseContractDetail(int PurchaseContractDetailID)
        {
            //PurchaseContractDetailDAL.DeletePurchaseContractDetail(PurchaseContractDetailID);
            PurchaseContractDetailDAL.spDeletePurchaseContractDetail(PurchaseContractDetailID);
        }

        public void UpdatePurchaseContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int PurchaseContractID)
        {
            //PurchaseContractDetailDAL.UpdatePurchaseContractDetail(Weight,Price,TotalAmount,PurchaseContractID);
            PurchaseContractDetailDAL.spUpdatePurchaseContractDetail(Weight,Price,TotalAmount,PurchaseContractID);
        }

        public DataTable GetPurchaseContractDetailByID(int PurchaseContractDetailID)
        {
            //return PurchaseContractDetailDAL.GetPurchaseContractDetailByID(PurchaseContractDetailID);
            return PurchaseContractDetailDAL.spGetPurchaseContractDetailByID(PurchaseContractDetailID);
        }
    }
}
