using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal;
using dal.edmx;
namespace apcc.admin
{
    public partial class InquiryList : System.Web.UI.Page
    {
        public bal.BalInquiryOpration InquiryOp = new bal.BalInquiryOpration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindInquiry();
            }
        }

        protected void btnAddInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/admin/InquiryAddEdit.aspx");
            }
            catch (Exception ex)
            {

            }
        }
        public void bindInquiry()
        {
            try
            {
                List<getInquiryList_Result> Inquiry = new List<getInquiryList_Result>();
                bal.BalInquiryOpration InquiryOp = new bal.BalInquiryOpration();
                Inquiry = InquiryOp.GetInquiryList();
                grvInquiry.DataSource = Inquiry;
                grvInquiry.DataBind();

            }
            catch (Exception ex)
            {

            }
        }
        protected void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int Inquiryid = Convert.ToInt32(bntEdit.CommandArgument);
                InquiryOp.DeleteInquiry(Inquiryid);
                bindInquiry();
            }
            catch (Exception ex)
            {

                
            }
            
        }

        protected void bntEdit_Click(object sender, EventArgs e)
        {
            Button bntEdit = (Button)sender;
            int Inquiryid = Convert.ToInt32(bntEdit.CommandArgument);
            Response.Redirect("~/admin/InquiryAddEdit.aspx?id=" + Inquiryid);
        }
    }
}