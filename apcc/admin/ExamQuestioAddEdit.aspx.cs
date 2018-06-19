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
    public partial class ExamQuestioAddEdit : System.Web.UI.Page
    {
        public int? id = null;
        public int ExamId = 0;
        public int QuestionId = 0;
        public bal.balComman com = new balComman();
        public bal.BalExamopration objBalExam = new BalExamopration();

        protected void Page_Load(object sender, EventArgs e)
        {
            DivError.Visible = false;
            DivSuccess.Visible = false;
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    ExamId = Convert.ToInt32(Request.QueryString["id"].ToString());
                    bindExamDetails(ExamId);

                }
                if (Request.QueryString["Questionid"] != null)
                {
                    QuestionId = Convert.ToInt32(Request.QueryString["Questionid"].ToString());
                    bindQuestion(ExamId, QuestionId);
                }
            }
        }
        public void bindExamDetails(int? id)
        {
            try
            {
                getexamById_Result objExam = new getexamById_Result();
                objExam = objBalExam.GetexamById(id);
                lblHead.InnerText = objExam.Name;
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindExamDetails", ex.StackTrace, ex.Message);

            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                clsExamQuestionOp objQue = new clsExamQuestionOp();
                objQue.Question = txtExamName.InnerText.Trim();
                if (Request.QueryString["id"] != null)
                {
                    ExamId = Convert.ToInt32(Request.QueryString["id"].ToString());
                }
                if (Request.QueryString["Questionid"] != null)
                {
                    QuestionId = Convert.ToInt32(Request.QueryString["Questionid"].ToString());
                    objQue.Id = QuestionId;
                }
                objQue.ExamId = ExamId;
                
                objQue.Option1 = txtOption1.Text.Trim();
                objQue.Option2 = txtOption2.Text.Trim();
                objQue.Option3 = txtOption3.Text.Trim();
                objQue.Option4 = txtOption4.Text.Trim();
                objQue.CorrectAns = Convert.ToInt16(txtCorrectAnswer.Text);
                int resutl = objBalExam.ExamQuestionInsertUpdate(objQue);
                if (resutl == 1)
                {
                    DivSuccess.Visible = true;
                    DivError.Visible = false;
                   
                    if (QuestionId == 0)
                    {
                        ResetValues();
                    }
                    else {
                        lblSuccess.Text = "Question Update Sccussesfully.";
                        bindQuestion(ExamId, QuestionId);
                    }
                    
                }
                else {
                    DivError.Visible = true;
                    DivSuccess.Visible = false;
                }
            }
            catch (Exception ex)
            {
                DivSuccess.Visible = false;
                DivError.Visible = true;
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnsave_Click", ex.StackTrace, ex.Message);
            }

        }
        void ResetValues()
        {

            txtExamName.InnerText = string.Empty;
            txtOption1.Text = string.Empty;
            txtOption1.Text = string.Empty;
            txtOption2.Text = string.Empty;
            txtOption3.Text = string.Empty;
            txtOption4.Text = string.Empty;
            txtCorrectAnswer.Text = string.Empty;
        }

        public void bindQuestion(int ExamId, int QuestionId)
        {
            try
            {
                getExamQuestionListByExamQuestionId_Result objquestion = new getExamQuestionListByExamQuestionId_Result();
                objquestion = objBalExam.getExamQuestionListByExamQuestionId(ExamId, QuestionId);
                txtExamName.InnerText = objquestion.Question;
                txtOption1.Text = objquestion.Option1;
                txtOption2.Text = objquestion.Option2;
                txtOption3.Text = objquestion.Option3;
                txtOption4.Text = objquestion.Option4;
                txtCorrectAnswer.Text = Convert.ToString(objquestion.CorrectAns);
            }
            catch (Exception ex)
            {
                DivError.Visible = true;
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindQuestion", ex.StackTrace, ex.Message);
            }
        }
        protected void btncancle_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                ExamId = Convert.ToInt32(Request.QueryString["id"].ToString());
                Response.Redirect("ExamQuestioList.aspx?id="+ ExamId);
            }
        }
    }
}