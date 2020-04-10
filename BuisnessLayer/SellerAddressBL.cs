using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BuisnessLayer
{
    public class SellerAddressBL
    {
        public DataTable GetSellerAddress()
        {
            //return SellerAddressDAL.GetSellerAddress();
            return SellerAddressDAL.spGetSellerAddress();
        }

        public void AddSellerAddress(String Address, String City, String Phone, String Street, int SellerID)
        {
            //SellerAddressDAL.AddSellerAddress(Address, City, Phone, Street, SellerID);
            SellerAddressDAL.spAddSellerAddress(Address, City, Phone, Street, SellerID);
        }

        public void DeleteSellerAddress(int SellerID)
        {
            //SellerAddressDAL.DeleteSellerAddress(SellerID);
            SellerAddressDAL.spDeleteSellerAddress(SellerID);
        }

        public void UpdateSellerAddress(String Address, String City, String Phone, String Street, int SellerContactID)
        {
            //SellerAddressDAL.UpdateSellerAddress(Address, City, Phone, Street, SellerContactID);
            SellerAddressDAL.spUpdateSellerAddress(Address, City, Phone, Street, SellerContactID);
        }

        public DataTable GetAddressById(int SellerID)
        {
            //eturn SellerAddressDAL.GetAddressByID(SellerID);
            return SellerAddressDAL.spGetAddressByID(SellerID);
        }
    }
}
