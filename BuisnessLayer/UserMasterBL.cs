using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using DataAccessLayer.Data;

namespace BuisnessLayer
{
    public class UserMasterBL
    {
        public  DataTable GetUserMaster()
        {
            //return UserMasterDAL.GetUserMaster();
            return UserMasterDAL.spGetUserMaster();
        }

        public void AddUserMaster(String UserName, String Password, String Status)
        {
            //UserMasterDAL.AddUserMaster( UserName, Password, Status);
            UserMasterDAL.spAddUserMaster(UserName, Password, Status);
        }

        public void UpdateUserMaster(int UserID, String UserName, String Password, String Status)
        {
            //UserMasterDAL.UpdateUserMaster(UserID ,UserName , Password, Status);
            UserMasterDAL.spUpdateUserMaster(UserID ,UserName , Password, Status);
        }

        public void DeleteUserMaster(int UserID)
        {
            //UserMasterDAL.DeleteUserMaster(UserID);
            UserMasterDAL.spDeleteUserMaster(UserID);
        }

        public DataTable GetUserMasterByID(int UserID)
        {
            //return UserMasterDAL.GetUserMasterByID(UserID);
            return UserMasterDAL.spGetUserMasterByID(UserID);
        }

        public User spCheckUserMasterByID(String UserName, String Password)
        {
            return UserMasterDAL.spCheckUserMasterByID(UserName,Password);
        }

    }
}
