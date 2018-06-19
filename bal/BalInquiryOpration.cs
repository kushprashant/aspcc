using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;
namespace bal
{
    public class BalInquiryOpration
    {
        public dal.DalInquiryOptation Inquiryop = new dal.DalInquiryOptation();
        public int InsertUpdateInquiry(ClsInquiry objInquiry)
        {
            return Inquiryop.InsertUpdateInquiry(objInquiry);
        }
        public List<getInquiryList_Result> GetInquiryList()
        {
            return Inquiryop.GetInquiryList();
        }
        public getInquiryById_Result GetInquiryById(int? id)
        {
            return Inquiryop.GetInquiryById(id);
        }
        public void DeleteInquiry(int id)
        {
            Inquiryop.DeleteInquiry(id);
        }
    }
}
