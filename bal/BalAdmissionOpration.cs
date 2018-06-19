using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;
namespace bal
{
    public class BalAdmissionOpration
    {
        public dal.DalAdminssionOpration Admop = new dal.DalAdminssionOpration();
        public int InsertUpdateAdmission(clsAdmission objAdm)
        {
            return Admop.InsertUpdateAdminssion(objAdm);
        }

        public List<getAdmissionList_Result> GetAdminssionList()
        {
            return Admop.GetAdminssionList();
        }
        public getAdmissionById_Result GetAdminssionById(int? id)
        {
            return Admop.GetAdminssionById(id);
        }
        public void DeleteAdmission(int id)
        {
            Admop.DeleteAdmission(id);
        }
    }
}
