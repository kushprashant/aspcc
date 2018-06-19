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
    public partial class ExamQuestioList : System.Web.UI.Page
    {
        public int Examid = 0;
        public int Questionid = 0;
        public bal.balComman com = new balComman();
        public bal.BalExamopration objBalExam = new BalExamopration();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Examid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    bindExamDetails(Examid);
                }
            }
        }
        public void bindExamDetails(int id)
        {
            try
            {
                getexamById_Result objExam = new getexamById_Result();
                objExam = objBalExam.GetexamById(id);
                headExam.InnerText = objExam.Name;
                ExamQuestionListByExamId(id);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindExamDetails", ex.StackTrace, ex.Message);

            }
        }

        public void ExamQuestionListByExamId(int examId)
        {
            try
            {
                List<getExamQuestionListByExamId_Result> ExamQuestionist = new List<getExamQuestionListByExamId_Result>();
                ExamQuestionist = objBalExam.getExamQuestionListByExamId(examId);
                grvQuestion.DataSource = ExamQuestionist;
                grvQuestion.DataBind();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "ExamQuestionListByExamId", ex.StackTrace, ex.Message);
            }
        }
        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Request.QueryString["id"] != null)
                {
                    Examid = Convert.ToInt32(Request.QueryString["id"].ToString());
                }
                Button bntEdit = (Button)sender;
              
                Response.Redirect("~/admin/ExamQuestioAddEdit.aspx?id=" + Examid);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnQuestion_Click", ex.StackTrace, ex.Message);

            }
        }

        protected void bntEdit_Click(object sender, EventArgs e)
        {
            Button bntEdit = (Button)sender;
            string[] tmpid= bntEdit.CommandArgument.Split('&');
            Examid = Convert.ToInt32(tmpid[0]);
            Questionid = Convert.ToInt32(tmpid[1]);
            Response.Redirect("~/admin/ExamQuestioAddEdit.aspx?id=" + Examid+ "&Questionid=" + Questionid);
        }

        protected void bntDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/admin/ExamList.aspx");
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
           
            if (Request.QueryString["id"] != null)
            {
               string Examid = Request.QueryString["id"].ToString();
                Response.Redirect("QuestionPrint.aspx?id=" + Examid);

            }
        }
    }
}