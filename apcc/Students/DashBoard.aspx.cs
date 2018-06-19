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
    public partial class DashBoard : System.Web.UI.Page
    {
        public bal.balComman com = new balComman();
        bal.BalExamopration exam = new bal.BalExamopration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

               int id = Convert.ToInt32(Convert.ToString(Session["userDetails"]).Split('_')[0].ToString());
                bindStudentExam(id);
            }
        }
        public void bindStudentExam(int id)
        {
            try
            {
                
                List<getStudentexamById_Result> examlist = new List<getStudentexamById_Result>();

                examlist = exam.getStudentexamById(id);
                grvStudentExam.DataSource = examlist;
                grvStudentExam.DataBind();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindStudentExam", ex.StackTrace, ex.Message);
            }
        }
        protected void bntAttemtpt_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int examid = Convert.ToInt32(bntEdit.CommandArgument);
                Response.Redirect("~/Students/StudentExam.aspx?id=" + examid);
            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntAttemtpt_Click", ex.StackTrace, ex.Message);
            }

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int stdid = Convert.ToInt32(Convert.ToString(Session["userDetails"]).Split('_')[0].ToString());
                int examid = Convert.ToInt32(bntEdit.CommandArgument);
                string Encryexamid = Comman.CommanUtils.Encrypt(examid.ToString());
                Response.Redirect("~/Students/ViewResult.aspx?id=" + Encryexamid);
            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntAttemtpt_Click", ex.StackTrace, ex.Message);
            }
        }
    }
}