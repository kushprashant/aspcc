using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal;
using dal.edmx;
namespace apcc.Students
{
    public partial class ViewResult : System.Web.UI.Page
    {
        public bal.balComman com = new balComman();
        bal.BalStudentOpration Studentexam = new bal.BalStudentOpration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                int Studentid = Convert.ToInt32(Convert.ToString(Session["userDetails"]).Split('_')[0].ToString());
                string DecryStudentExamId = Comman.CommanUtils.Decrypt(Request.QueryString["id"].ToString());
                int ExamId = Convert.ToInt32(Convert.ToString(DecryStudentExamId).ToString());
                bindViewResult(Studentid,ExamId);
            }
        }

        public void bindViewResult(int Studentid,int ExamId)
        {
            try
            {
                List<viewResultByStdId_Result> viewResult = new List<viewResultByStdId_Result>();
                viewResult = Studentexam.viewResultByStdId(Studentid, ExamId);
              
                lblExamName.Text = viewResult[0].ExamName;
                grvviewResult.DataSource = viewResult; 
                grvviewResult.DataBind();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindViewResult", ex.StackTrace, ex.Message);
            }
        }

        protected void bntDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                string StudentExamId = bntEdit.CommandArgument;
                //string EncryStudentExamDetailsId = Comman.CommanUtils.Encrypt(StudentExamId);
                Response.Redirect("~/Students/StudentResult.aspx?id=" + StudentExamId);
            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntDetails_Click", ex.StackTrace, ex.Message);
            }
        }
    }
}