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
    public partial class StudentExam : System.Web.UI.Page
    {
        public bal.balComman com = new balComman();
        bal.BalStudentOpration Studentexam = new bal.BalStudentOpration();
        int? id;
        int StudentExamDetailsId;
        int studentid = 0;
        int examid = 0;
        List<GetStdExamDetailsById_Result> stdExamDetails = new List<GetStdExamDetailsById_Result>();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    studentid = Convert.ToInt32(Convert.ToString(Session["userDetails"]).Split('_')[0].ToString());
                    examid = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
                    checkExamFinish(studentid, examid);
                }
            }
        }

        public void checkExamFinish(int studentid, int examid)
        {
            try
            {
                List<ChkExamFinish_Result> chexm = new List<ChkExamFinish_Result>();
                chexm = Studentexam.checkExamFinish(studentid, examid).ToList();
                if (chexm != null && chexm.Count > 0)
                {
                    id = chexm[0].Id;
                    hdnStdexamid.Value = Convert.ToString(id);
                }
                InsertExamStudentAttemptBystdId_Result StudentExamidId = new InsertExamStudentAttemptBystdId_Result();
                StudentExamidId = Studentexam.InsertExamStudentAttemptBystdId(id, studentid, examid);
                hdnStdexamid.Value = Convert.ToString(StudentExamidId.StudentExamid);
                lblExamName.Text = StudentExamidId.ExamName;
                stdExamDetails = Studentexam.GetStdExamDetailsById(StudentExamidId.StudentExamid);
                Session["QuestionList"] = stdExamDetails;
                hdnTotalQuestion.Value = Convert.ToString(stdExamDetails.Count-1);
                noofQuestin.Text = "1" + "/" + Convert.ToString(stdExamDetails.Count);
                ltrQuestin.Text = stdExamDetails[0].Question;
                rbOption1.Text = stdExamDetails[0].Option1;
                rbOption2.Text = stdExamDetails[0].Option2;
                rbOption3.Text = stdExamDetails[0].Option3;
                rbOption4.Text = stdExamDetails[0].Option4;
                bindQuestion(stdExamDetails[0].Id);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "checkExamFinish", ex.StackTrace, ex.Message);
            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                hdnNext.Value = Convert.ToString(Convert.ToInt32(hdnNext.Value) - 1);

                stdExamDetails = (List<GetStdExamDetailsById_Result>)Session["QuestionList"];
                int index = Convert.ToInt32(hdnNext.Value);
                ltrQuestin.Text = stdExamDetails[index].Question;
                rbOption1.Text = stdExamDetails[index].Option1;
                rbOption2.Text = stdExamDetails[index].Option2;
                rbOption3.Text = stdExamDetails[index].Option3;
                rbOption4.Text = stdExamDetails[index].Option4;
                if (index == 0)
                {
                    btnPrevious.Visible = false;

                }
                else {
                    btnPrevious.Visible = true;
                }

                if (hdnTotalQuestion.Value == hdnNext.Value)
                {
                    btnNext.Visible = false;
                }
                else {
                    btnNext.Visible = true;
                }
                bindQuestion(stdExamDetails[index].Id);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindQuestion", ex.StackTrace, ex.Message);
            }

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                stdExamDetails = (List<GetStdExamDetailsById_Result>)Session["QuestionList"];
                int updateIndex = Convert.ToInt32(hdnNext.Value);
                int StudentExamDetailsId = stdExamDetails[updateIndex].Id;
                int StudentExamId = Convert.ToInt32(hdnStdexamid.Value);
                int QuestionId = stdExamDetails[updateIndex].QuestionId;
                int Answer = 0;
                if (rbOption1.Checked)
                {
                    Answer = 1;
                }
                else if (rbOption2.Checked)
                {
                    Answer = 2;
                }
                else if (rbOption3.Checked)
                {
                    Answer = 3;
                }
                else if (rbOption4.Checked)
                {
                    Answer = 4;
                }
                UpdateQuestionAnswere(StudentExamDetailsId, StudentExamId, QuestionId, Answer);


                hdnNext.Value = Convert.ToString(Convert.ToInt32(hdnNext.Value) + 1);

                int index = Convert.ToInt32(hdnNext.Value);
                ltrQuestin.Text = stdExamDetails[index].Question;
                rbOption1.Text = stdExamDetails[index].Option1;
                rbOption2.Text = stdExamDetails[index].Option2;
                rbOption3.Text = stdExamDetails[index].Option3;
                rbOption4.Text = stdExamDetails[index].Option4;

                if (hdnTotalQuestion.Value == hdnNext.Value)
                {
                    btnNext.Visible = false;
                    btnFinish.Visible = true;
                }
                else {
                    btnNext.Visible = true;
                    btnFinish.Visible = false;
                }

                if (index == 0)
                {
                    btnNext.Visible = true;
                }
                else {
                    btnPrevious.Visible = true;
                }
                bindQuestion(stdExamDetails[index].Id);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindQuestion", ex.StackTrace, ex.Message);
            }
        }

        public void bindQuestion(int StudentExamDetailsId) {

            try
            {
                noofQuestin.Text = Convert.ToString(Convert.ToInt32(hdnNext.Value) + 1) + "/" + Convert.ToString(Convert.ToInt32(hdnTotalQuestion.Value) + 1);

                GetStdUPdateQuestionAnswereById_Result question = new GetStdUPdateQuestionAnswereById_Result();
                question = Studentexam.GetStdUPdateQuestionAnswereById(StudentExamDetailsId);
                rbOption1.Checked = false;
                rbOption2.Checked = false;
                rbOption3.Checked = false;
                rbOption4.Checked = false;
                if (question.Answer == 1)
                {
                    rbOption1.Checked = true;
                }
                else if (question.Answer == 2)
                {
                    rbOption2.Checked = true;
                }
                else if (question.Answer == 3)
                {
                    rbOption3.Checked = true;
                }
                else if (question.Answer == 4)
                {
                    rbOption4.Checked = true;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindQuestion", ex.StackTrace, ex.Message);
            }

        }
        public void UpdateQuestionAnswere(int StudentExamDetailsId, int StudentExamId, int QuestionId, int Answer)
        {
            Studentexam.UpdateQuestionAnswere(StudentExamDetailsId, StudentExamId, QuestionId, Answer);
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                hdnNext.Value = Convert.ToString(Convert.ToInt32(hdnNext.Value));
                stdExamDetails = (List<GetStdExamDetailsById_Result>)Session["QuestionList"];
                int updateIndex = Convert.ToInt32(hdnNext.Value);
                int StudentExamDetailsId = stdExamDetails[updateIndex].Id;
                int StudentExamId = Convert.ToInt32(hdnStdexamid.Value);
                int QuestionId = stdExamDetails[updateIndex].QuestionId;
                int Answer = 0;
                if (rbOption1.Checked)
                {
                    Answer = 1;
                }
                else if (rbOption2.Checked)
                {
                    Answer = 2;
                }
                else if (rbOption3.Checked)
                {
                    Answer = 3;
                }
                else if (rbOption4.Checked)
                {
                    Answer = 4;
                }
                UpdateQuestionAnswere(StudentExamDetailsId, StudentExamId, QuestionId, Answer);
               
                //int updateIndex = Convert.ToInt32(hdnNext.Value);
                //stdExamDetails = (List<GetStdExamDetailsById_Result>)Session["QuestionList"];
                //int StudentExamId = Convert.ToInt32(hdnStdexamid.Value);
                studentid = Convert.ToInt32(Convert.ToString(Session["userDetails"]).Split('_')[0].ToString());
                int ExamId =  stdExamDetails[updateIndex].ExamId;
             
                Studentexam.updateStudentExam(StudentExamId, studentid, ExamId);

                // string EncryStudentExamDetailsId = Comman.CommanUtils.Encrypt(StudentExamId.ToString());
                string EncryStudentExamDetailsId =(StudentExamId.ToString());
                Response.Redirect("~/Students/StudentResult.aspx?id=" + EncryStudentExamDetailsId);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnFinish_Click", ex.StackTrace, ex.Message);
            }
        }

     
    }
}