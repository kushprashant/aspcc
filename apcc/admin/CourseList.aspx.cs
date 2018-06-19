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
    public partial class CourseList : System.Web.UI.Page
    {
      public  bal.courseopration courseOp = new bal.courseopration();
        public bal.balComman com = new balComman();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindCourse();
            }
        }

        public void bindCourse()
        {
            try
            {
                List<getCourseList_Result> courselist = new List<getCourseList_Result>();
                bal.courseopration course = new bal.courseopration();
                courselist = courseOp.GetCourseList();
                grvCourser.DataSource = courselist;
                grvCourser.DataBind();

            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindCourse",ex.StackTrace,ex.Message);
            }
        }

        public void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntDelete = (Button)sender;
                int courseid = Convert.ToInt32(bntDelete.CommandArgument);
                courseOp.DeleteCourse(courseid);
                bindCourse();
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntDelete_Click", ex.StackTrace, ex.Message);

            }
           
        }

        protected void bntEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button bntEdit = (Button)sender;
                int courseid = Convert.ToInt32(bntEdit.CommandArgument);
                Response.Redirect("~/admin/courseAddEdit.aspx?id=" + courseid);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bntEdit_Click", ex.StackTrace, ex.Message);

            }
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
              Response.Redirect("~/admin/courseAddEdit.aspx");
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnAddCourse_Click", ex.StackTrace, ex.Message);
            }
        }
    }
}