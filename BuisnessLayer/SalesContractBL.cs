using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class SalesContractBL
    {
        public DataTable GetSalesContract()
        {
            return SalesContractDAL.GetSalesContract();
        }

        public int AddSalesContract(DateTime SaleContractDate, String PreparedBy, int BuyerID,String ApprovedBy)
        {
            return SalesContractDAL.AddSalesContract(SaleContractDate, PreparedBy, BuyerID, ApprovedBy);
        }

        public void DeleteSalesContract(int SalesContractID)
        {
            SalesContractDAL.DeleteSalesContract(SalesContractID);
        }

        public void UpdateSalesContract(DateTime PurchaseContractDate, String PreparedBy, int BuyerID, int SalesContractID, String ApprovedBy)
        {
            SalesContractDAL.UpdateSalesContract(PurchaseContractDate, PreparedBy, BuyerID, SalesContractID, ApprovedBy);
        }

        public DataTable GetSalesContractByID(int SalesContractID)
        {
            return SalesContractDAL.GetSalesContractByID(SalesContractID);
        }

        public void ApproveSalesContract(int SalesContractID, String ApprovedBy)
        {
            //PurchaseContractDAL.UpdatePurchaseContract(PurchaseContractDate, PreparedBy, SellerID, PurchaseContractID, ApprovedBy);
            SalesContractDAL.ApproveSalesContract(SalesContractID, ApprovedBy);
        }
    }
}
