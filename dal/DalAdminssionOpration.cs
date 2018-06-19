using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;


namespace dal
{
    public class DalAdminssionOpration
    {
        public bal.balComman com = new balComman();
        public int InsertUpdateAdminssion(clsAdmission objAdmissio)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.InsertUpdateAdmission(objAdmissio.Id, objAdmissio.fname, objAdmissio.Mname, objAdmissio.Lname, objAdmissio.Address, objAdmissio.MobileH,objAdmissio.MobileF, objAdmissio.MobileP, objAdmissio.Email,objAdmissio.AreId, objAdmissio.QualificationId,objAdmissio.StreamId, objAdmissio.OccupationId, objAdmissio.CourseId, objAdmissio.SchoolName, objAdmissio.BirthDate, objAdmissio.PreferTimeTO, objAdmissio.PreferTimeFrom, objAdmissio.Remark, objAdmissio.TotalFees, objAdmissio.DisCount, objAdmissio.NetFees, objAdmissio.NoOfInstallment, objAdmissio.Installment1Rs, objAdmissio.Installment1Date, objAdmissio.Installment2Rs, objAdmissio.Installment2Date, objAdmissio.Installment3Rs, objAdmissio.Installment3Date, objAdmissio.Installment4Rs, objAdmissio.Installment4Date, objAdmissio.Installment5Rs, objAdmissio.Installment5Date, objAdmissio.Installment6Rs, objAdmissio.Installment6Date, objAdmissio.Installment7Rs, objAdmissio.Installment7Date, objAdmissio.Installment8Rs, objAdmissio.Installment8Date, objAdmissio.Installment9Rs, objAdmissio.Installment9Date, objAdmissio.Installment10Rs, objAdmissio.Installment10Date, objAdmissio.ModBy, objAdmissio.AdmissionNo,objAdmissio.RegNo, objAdmissio.AdmissionDate);
                    return 1;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("admin/AdmissionAddEdit", "InsertUpdateAdminssion", ex.StackTrace, ex.Message);
                return 0;
            }

        }
        public List<getAdmissionList_Result> GetAdminssionList()
        {
            try
            {
                List<getAdmissionList_Result> Adminssionlist = new List<getAdmissionList_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    Adminssionlist = db.getAdmissionList().ToList();
                    return Adminssionlist;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("Adminssionlist", "Adminssionlist", ex.StackTrace, ex.Message);
                return null;
            }
        }
        public getAdmissionById_Result GetAdminssionById(int? id)
        {
            try
            {
                getAdmissionById_Result objAdminssion = new getAdmissionById_Result();
                using (aspccEntities db = new aspccEntities())
                {
                    objAdminssion = db.getAdmissionById(id).FirstOrDefault();
                    return objAdminssion;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("admin/AdmissionAddEdit", "GetAdminssionById", ex.StackTrace, ex.Message);
                return null;
            }
        }
        public void DeleteAdmission(int id)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.DeleteAdmission(id);
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("admin/AdmissionList", "DeleteAdmission", ex.StackTrace, ex.Message);

            }
        }
    }
}
