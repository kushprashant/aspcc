using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal;
using dal.edmx;

namespace apcc.admin.Exams
{
    public partial class ExamList : System.Web.UI.Page
    {
        public bal.balComman com = new balComman();
        bal.BalExamopration exam = new bal.BalExamopration();
        public bal.courseopration courseOp = new bal.courseopration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindExam();
                bindExamDropDown();
            }
        }
        public void bindExam()
        {
            try
            {
                List<getexamList_Result> examlist = new List<getexamList_Result>();
              
                examlist = exam.GetexamList();
                grvExam.DataSource = examlist;
                grvExam.DataBind();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindExam", ex.StackTrace, ex.Message);
            }
        }
        protected void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/admin/examaddedit.aspx");
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnAddExam_Click", ex.StackTrace, ex.Message);
            }
        }

        protected void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int examid = Convert.ToInt32(bntEdit.CommandArgument);
                Response.Redirect("~/admin/Examaddedit.aspx?id=" + examid);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntEdit_Click", ex.StackTrace, ex.Message);

            }
        }

        protected void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntDelete = (Button)sender;
                int examid = Convert.ToInt32(bntDelete.CommandArgument);
                exam.Deletetexam(examid);
                bindExam();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntDelete_Click", ex.StackTrace, ex.Message);

            }

        }

        protected void btnQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int examid = Convert.ToInt32(bntEdit.CommandArgument);
                Response.Redirect("~/admin/ExamQuestioList.aspx?id=" + examid);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnQuestion_Click", ex.StackTrace, ex.Message);

            }
        }

        public void bindExamDropDown()
        {
            List<getexamList_Result> examlist = new List<getexamList_Result>();

            examlist = exam.GetexamList();

            getexamList_Result tmpexam = new getexamList_Result();
            tmpexam.Name = "Select Exam";
            tmpexam.Id = 0;
            examlist.Add(tmpexam);
            ddlExamFrom.DataSource = examlist;
            ddlExamFrom.DataTextField = "Name";
            ddlExamFrom.DataValueField = "Id";
            ddlExamFrom.DataBind();
            ddlExamFrom.SelectedValue = "0";

            ddlExamTo.DataSource = examlist;
            ddlExamTo.DataTextField = "Name";
            ddlExamTo.DataValueField = "Id";
            ddlExamTo.DataBind();
            ddlExamTo.SelectedValue = "0";
        }

        protected void btnExamCopy_Click(object sender, EventArgs e)
        {
            try
            {
                int fromid= Convert.ToInt32(ddlExamFrom.SelectedValue);
                int toid = Convert.ToInt32(ddlExamTo.SelectedValue);
                exam.CopyExam(fromid, toid);
            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnExamCopy_Click", ex.StackTrace, ex.Message);
            }
        }
    }
}