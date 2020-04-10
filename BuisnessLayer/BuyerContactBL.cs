using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class BuyerContactBL
    {
        public DataTable GetBuyerContact()
        {
            //return BuyerContactDAL.GetBuyerContact();
            return BuyerContactDAL.spGetBuyerContact();
        }

        public void AddBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int BuyerMasterID)
        {
            //BuyerContactDAL.AddBuyerContact(Name, Mobile, Email, Whatsapp, BuyerMasterID);
            BuyerContactDAL.spAddBuyerContact(Name, Mobile, Email, Whatsapp, BuyerMasterID);
        }

        public void DeleteBuyerContact(int ID)
        {
            //BuyerContactDAL.DeleteBuyerContact(ID);
            BuyerContactDAL.spDeleteBuyerContact(ID);
        }

        public void UpdateBuyerContact(String Name, String Mobile, String Email, String Whatsapp, int ID)
        {
            //BuyerContactDAL.UpdateBuyerContact(Name, Mobile, Email, Whatsapp, ID);
            BuyerContactDAL.spUpdateBuyerContact(Name, Mobile, Email, Whatsapp, ID);
        }

        public DataTable GetContactById(int ID)
        {
            //return BuyerContactDAL.GetContactByID(ID);
            return BuyerContactDAL.spGetContactByID(ID);
        }
    }
}
