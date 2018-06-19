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
    public partial class CourseAddEdit : System.Web.UI.Page
    {

        public int? courseid = null;
        public  bal.courseopration course = new bal.courseopration();
        public bal.balComman com = new balComman();
        protected void Page_Load(object sender, EventArgs e)
        {
            DivError.Visible = false;
            lblErrorMsg.Text = string.Empty;
            if (!Page.IsPostBack) {
                if (Request.QueryString["id"] != null) {
                    courseid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    lblHead.InnerText = "Course Update";
                    btnsave.Text = "Update";
                    bindCourseDetails(courseid);
                }
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                clsCourse objcourse = new clsCourse();
                if (Request.QueryString["id"] != null)
                {
                    courseid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    objcourse.Id = courseid;
                }
                objcourse.CourseName = txtCourseName.Text;
                objcourse.Fee = Convert.ToDecimal(txtCourserFee.Text);
                objcourse.Duration = Convert.ToInt32(txtCourseDuaration.Text);
                objcourse.Active = ChkActive.Checked;
                bal.courseopration course = new bal.courseopration();
                result = course.CourseInsertUpdate(objcourse);
                if (result > 0)
                {
                    Response.Redirect("CourseList.aspx");
                }
                else {
                    DivError.Visible = true;
                    lblErrorMsg.Text = "Please Try after some Time.";
                }

            }
            catch (Exception ex)
            {
                DivError.Visible = true;
                lblErrorMsg.Text = "Please Try after some Time.";
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnsave_Click", ex.StackTrace, ex.Message);
            }
        }
        public void bindCourseDetails(int? id) {
            try
            {
                getCourseById_Result objcourse = new getCourseById_Result();
                objcourse = course.GetCourseById(id);
                txtCourseName.Text = objcourse.CourseName;
                txtCourserFee.Text = Convert.ToString(objcourse.Fee);
                txtCourseDuaration.Text = Convert.ToString(objcourse.Duration);
                ChkActive.Checked= objcourse.Active;
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindCourseDetails", ex.StackTrace, ex.Message);

            }
        }
        protected void btncancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseList.aspx");
        }
    }
}