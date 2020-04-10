using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BuisnessLayer
{
    public class SellerContactBL
    {
    
        public DataTable GetSellerContact()
        {
            //return SellerContactDAL.GetSellerContact();
            return SellerContactDAL.spGetSellerContact();
        }

        public void AddSellerContact(String Name, String Mobile, String Email, String Whatsapp,int SellerID)
        {
            SellerContactDAL.spAddSellerContact(Name, Mobile, Email, Whatsapp, SellerID);
            // SellerContactDAL.AddSellerContact(Name,Mobile,Email,Whatsapp, SellerID);
        }

        public void DeleteSellerContact(int SellerID)
        {
            //SellerContactDAL.DeleteSellerContact(SellerID);
            SellerContactDAL.spDeleteSellerContact(SellerID);
        }

        public void UpdateSellerContact(String Name, String Mobile, String Email, String Whatsapp,int SellerContactID)
        {
            //SellerContactDAL.UpdateSellerContact(Name, Mobile, Email, Whatsapp, SellerContactID);
            SellerContactDAL.spUpdateSellerContact(Name, Mobile, Email, Whatsapp, SellerContactID);
        }

        public DataTable GetContactById(int SellerID)
        {
            //return SellerContactDAL.GetContactByID(SellerID);
            return SellerContactDAL.spGetContactByID(SellerID);
        }
    }
}
