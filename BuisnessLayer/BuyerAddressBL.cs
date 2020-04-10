using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class BuyerAddressBL
    {
        public DataTable GetBuyerAddress()
        {
            //return BuyerAddressDAL.GetBuyerAddress();
            return BuyerAddressDAL.spGetBuyerAddress();
        }

        public void AddBuyerAddress(String Address, String City, String Phone, String Street, int BuyerMasterID)
        {
            //BuyerAddressDAL.AddBuyerAddress(Address, City, Phone, Street, BuyerMasterID);
            BuyerAddressDAL.spAddBuyerAddress(Address, City, Phone, Street, BuyerMasterID);
        }

        public void DeleteBuyerAddress(int ID)
        {
           //BuyerAddressDAL.DeleteBuyerAddress(ID);
            BuyerAddressDAL.spDeleteBuyerAddress(ID);
        }

        public void UpdateBuyerAddress(String Address, String City, String Phone, String Street, int BuyerContactID)
        {
            //BuyerAddressDAL.UpdateBuyerAddress(Address, City, Phone, Street, BuyerContactID);
            BuyerAddressDAL.spUpdateBuyerAddress(Address, City, Phone, Street, BuyerContactID);
        }

        public DataTable GetAddressById(int ID)
        {
            //return BuyerAddressDAL.GetAddressByID(ID);
            return BuyerAddressDAL.spGetAddressByID(ID);
        }
    }
}
