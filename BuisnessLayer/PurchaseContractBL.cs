using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class PurchaseContractBL
    {
        public DataTable GetPurchaseContract()
        {
            //return PurchaseContractDAL.GetPurchaseContract();
            return PurchaseContractDAL.spGetPurchaseContract();
        }

        public int AddPurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID,String ApprovedBy)
        {
            //return PurchaseContractDAL.AddPurchaseContract(PurchaseContractDate, PreparedBy, SellerID, ApprovedBy);
            return PurchaseContractDAL.spAddPurchaseContract(PurchaseContractDate, PreparedBy, SellerID, ApprovedBy);
        }

        public void DeletePurchaseContract(int PurchaseContractID)
        {
            //PurchaseContractDAL.DeletePurchaseContract(PurchaseContractID);
            PurchaseContractDAL.spDeletePurchaseContract(PurchaseContractID);
        }

        public void UpdatePurchaseContract(DateTime PurchaseContractDate, String PreparedBy, int SellerID,int PurchaseContractID, String ApprovedBy)
        {
            //PurchaseContractDAL.UpdatePurchaseContract(PurchaseContractDate, PreparedBy, SellerID, PurchaseContractID, ApprovedBy);
            PurchaseContractDAL.spUpdatePurchaseContract(PurchaseContractDate, PreparedBy, SellerID, PurchaseContractID, ApprovedBy);
        }

        public DataTable GetPurchaseContractByID(int PurchaseContractID)
        {
            // return PurchaseContractDAL.GetPurchaseContractByID(PurchaseContractID);
            return PurchaseContractDAL.spGetPurchaseContractByID(PurchaseContractID);
        }

        public void ApprovePurchaseContract(int PurchaseContractID, String ApprovedBy)
        {
            //PurchaseContractDAL.UpdatePurchaseContract(PurchaseContractDate, PreparedBy, SellerID, PurchaseContractID, ApprovedBy);
            PurchaseContractDAL.ApprovePurchaseContract( PurchaseContractID, ApprovedBy);
        }

    }
}
