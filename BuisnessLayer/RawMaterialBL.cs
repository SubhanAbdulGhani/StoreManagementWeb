using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BuisnessLayer
{
    public class RawMaterialBL
    {

    public DataTable GetRawMaterial()
        {
            //return RawMaterialDAL.GetRawMaterial();
            return RawMaterialDAL.GetRawMaterialSP();
        }
    

    public void AddRawMaterial(String Type,String Color,String Name)
    {
            //RawMaterialDAL.AddRawMaterial(Type,Color,Name);
            RawMaterialDAL.AddRawMaterialSP(Type, Color, Name);
    }

    public void UpdateRawMaterial(int ID,String Type,String Color,String Name)
    {
            //RawMaterialDAL.UpdateRawMaterial(ID,Type,Color,Name);
            RawMaterialDAL.UpdateRawMaterialSP(ID, Type, Color, Name);
    }

    public void DeleteRawMaterial(int ID)
    {
            //RawMaterialDAL.DeleteRawMaterial(ID);
            RawMaterialDAL.DeleteRawMaterialSP(ID);
    }

    public DataTable GetRawMaterialByID(int ID)
        {
            //return   RawMaterialDAL.GetRawMaterialsByID(ID);
            return RawMaterialDAL.GetRawMaterialsByIDSP(ID);
        }

    }
}
