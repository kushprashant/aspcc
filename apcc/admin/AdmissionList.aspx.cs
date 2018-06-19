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
    public partial class AdmissionList : System.Web.UI.Page
    {
        public bal.BalAdmissionOpration AdmissionOp = new bal.BalAdmissionOpration();
        public bal.balComman com = new balComman();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindAdmission();
                
            }
        }


        public void bindAdmission()
        {
            try
            {
                List<getAdmissionList_Result> Admissionlist = new List<getAdmissionList_Result>();
                bal.BalAdmissionOpration Admission = new bal.BalAdmissionOpration();
                Admissionlist = AdmissionOp.GetAdminssionList();
                grvAdmission.DataSource = Admissionlist;
                grvAdmission.DataBind();

            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindAdmission", ex.StackTrace, ex.Message);
            }
        }
        protected void btnAddAdmission_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/admin/AdmissionAddEdit.aspx");

        }

        protected void bntEdit_Click(object sender, EventArgs e)
        {
            Button bntEdit = (Button)sender;
            int AdmissionID = Convert.ToInt32(bntEdit.CommandArgument);
            Response.Redirect("~/admin/AdmissionAddEdit.aspx?id=" + AdmissionID);
        }

        protected void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int Admissionid = Convert.ToInt32(bntEdit.CommandArgument);
                AdmissionOp.DeleteAdmission(Admissionid);
                bindAdmission();
            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntDelete_Click", ex.StackTrace, ex.Message);
            }

        }

        protected void btnprint_Click(object sender, EventArgs e)
        {
            Button bntEdit = (Button)sender;
            int AdmissionID = Convert.ToInt32(bntEdit.CommandArgument);
            Response.Redirect("~/admin/AdmissionFormPrint.aspx?id=" + AdmissionID);

        }
    }
}