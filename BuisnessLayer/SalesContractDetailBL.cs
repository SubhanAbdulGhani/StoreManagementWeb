using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class SalesContractDetailBL
    {
        public DataTable GetSalesContractDetail()
        {
            //return SalesContractDetailDAL.GetSalesContractDetail();
            return SalesContractDetailDAL.spGetSalesContractDetail();
        }

        public void AddSalesContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int SalesContractID, int ProductID)
        {
            SalesContractDetailDAL.AddSalesContractDetail(Weight, Price, TotalAmount, SalesContractID, ProductID);
        }

        public void DeleteSalesContractDetail(int SalesContractDetailID)
        {
            //SalesContractDetailDAL.DeleteSalesContractDetail(SalesContractDetailID);
            SalesContractDetailDAL.spDeleteSalesContractDetail(SalesContractDetailID);
        }

        public void UpdateSalesContractDetail(decimal Weight, decimal Price, decimal TotalAmount, int SalesContractID)
        {
            SalesContractDetailDAL.UpdateSalesContractDetail(Weight, Price, TotalAmount, SalesContractID);
            //SalesContractDetailDAL.spUpdateSalesContractDetail(Weight, Price, TotalAmount, SalesContractID);
        }

        public DataTable GetSalesContractDetailByID(int SalesContractDetailID)
        {
            //return SalesContractDetailDAL.GetSalesContractDetailByID(SalesContractDetailID);
            return SalesContractDetailDAL.spGetSalesContractDetailByID(SalesContractDetailID);
        }
    }
}
