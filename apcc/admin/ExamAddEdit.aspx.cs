using bal;
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
    public partial class ExamAddEdit : System.Web.UI.Page
    {
        public int? Exameid = null;
        public bal.balComman com = new balComman();
        public bal.courseopration courseOp = new bal.courseopration();
        public bal.BalExamopration objBalExam = new BalExamopration();
        protected void Page_Load(object sender, EventArgs e)
        {
            DivError.Visible = false;
            lblErrorMsg.Text = string.Empty;
            if (!Page.IsPostBack)
            {
                bindCourseDropDown();
                if (Request.QueryString["id"] != null)
                {
                    
                    Exameid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    lblHead.InnerText = "Exam Update";
                    btnsave.Text = "Update";
                    bindExamDetails(Exameid);
                }
            }
        }
        public void bindExamDetails(int? id)
        {
            try
            {
                getexamById_Result objExam = new getexamById_Result();
                objExam = objBalExam.GetexamById(id);
                txtExamName.Text = objExam.Name;
                txtnoOFQuestion.Text = Convert.ToString(objExam.noofQestion);
                ddlCourse.SelectedValue =Convert.ToString(objExam.CoruserId);
                isActive.Checked = objExam.Isactive;
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindCourseDetails", ex.StackTrace, ex.Message);

            }
        }
        public void bindCourseDropDown()
        {
            List<getCourseList_Result> courselist = new List<getCourseList_Result>();
            bal.courseopration course = new bal.courseopration();
            courselist = courseOp.GetCourseList();

            getCourseList_Result tmpcourse = new getCourseList_Result();
            tmpcourse.CourseName = "Select Course";
            tmpcourse.Id = 0;
            courselist.Add(tmpcourse);
            ddlCourse.DataSource = courselist;
            ddlCourse.DataTextField = "CourseName";
            ddlCourse.DataValueField = "Id";
            ddlCourse.DataBind();
            ddlCourse.SelectedValue = "0";
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                clsExam objExam = new clsExam();
                if (Request.QueryString["id"] != null)
                {
                    Exameid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    objExam.Id = Exameid;
                }
                objExam.Name = txtExamName.Text.Trim();
                objExam.noofQestion = Convert.ToInt32(txtnoOFQuestion.Text);
                objExam.Isactive = isActive.Checked;
                objExam.CoruserId = Convert.ToInt32(ddlCourse.SelectedValue);
               int result = objBalExam.ExamInsertUpdate(objExam);
                if (result>0)
                {
                    Response.Redirect("ExamList.aspx");
                }
                else {
                    DivError.Visible = true;
                    lblErrorMsg.Text = "Please Try after some Time.";
                }

            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnsave_Click", ex.StackTrace, ex.Message);
                
            }

        }

        protected void btncancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExamList.aspx");
        }
    }
}