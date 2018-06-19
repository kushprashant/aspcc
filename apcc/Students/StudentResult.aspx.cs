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
    public partial class StudentResult : System.Web.UI.Page
    {
        public bal.balComman com = new balComman();
        bal.BalStudentOpration Studentexam = new bal.BalStudentOpration();
        int? id;
        int StudentExamDetailsId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    //string DecryStudentExamDetailsId = Comman.CommanUtils.Decrypt(Request.QueryString["id"].ToString());
                    string ExamDetailsId = (Request.QueryString["id"].ToString());
                    StudentExamDetailsId = Convert.ToInt32(Convert.ToString(ExamDetailsId).ToString());
                    bindStudentExamResult(StudentExamDetailsId);
                }
            }

        }
        public void bindStudentExamResult(int id)
        {
            try
            {
                List<getStudentExamResultbyStdExamId_Result> examReulstlist = new List<getStudentExamResultbyStdExamId_Result>();
                examReulstlist = Studentexam.getStudentExamResultbyStdExamId(id);
                int totalQuestion = examReulstlist.Count;
                int totalScore = examReulstlist.Where(x => x.SCORE == 1).Count();
                lblExamName.Text = examReulstlist[0].ExamName;
                lblDate.Text = examReulstlist[0].ModDt.ToString("dddd, dd MMMM yyyy");
                lblScore.Text = "Score : "+ Convert.ToString(totalScore) + "/" + Convert.ToString(totalQuestion);
                grvStudentExamResult.DataSource = examReulstlist;
                grvStudentExamResult.DataBind();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindStudentExamResult", ex.StackTrace, ex.Message);
            }
        }

        protected string totalScore(string mark)
        {
            int total = 0;
            total = total + Convert.ToInt32(mark);
            return Convert.ToString(total);
        }
    }
}