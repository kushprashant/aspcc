using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;
namespace dal
{
    public class DalInquiryOptation
    { public bal.balComman com = new balComman();
        public int InsertUpdateInquiry(ClsInquiry objClsInquiry)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.InsertUpdateInquiry(objClsInquiry.Id, objClsInquiry.fname, objClsInquiry.lname, objClsInquiry.CourseID, objClsInquiry.EmailId, objClsInquiry.Mobile, objClsInquiry.Address, objClsInquiry.AreaId, objClsInquiry.City, objClsInquiry.PreferTimeFrom, objClsInquiry.PreferTimeFrom, objClsInquiry.Final, objClsInquiry.Notes, objClsInquiry.EntBy, objClsInquiry.ModBy);
                    return 1;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("/admin/InquiryAddEdit", "InsertUpdateInquiry", ex.StackTrace, ex.Message);
                return 0;
            }

        }

        public List<getInquiryList_Result> GetInquiryList()
        {
            try
            {
                List<getInquiryList_Result> Inquirylist = new List<getInquiryList_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    Inquirylist = db.getInquiryList().ToList();
                    return Inquirylist;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("/admin/InquiryList", "GetInquiryList", ex.StackTrace, ex.Message);
                return null;

            }
        }
        public getInquiryById_Result GetInquiryById(int? id)
        {
            try
            {
                getInquiryById_Result objInquiry = new getInquiryById_Result();
                using (aspccEntities db = new aspccEntities())
                {
                    objInquiry = db.getInquiryById(id).FirstOrDefault();
                    return objInquiry;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("/admin/InquiryAddEdit", "GetInquiryById", ex.StackTrace, ex.Message);
                return null;
            }
        }

        public void DeleteInquiry(int id)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.DeleteInquiry(id);
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("/admin/InquiryList", "DeleteInquiry", ex.StackTrace, ex.Message);
            }
        }
    }
}
