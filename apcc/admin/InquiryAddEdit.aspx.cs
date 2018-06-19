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
    public partial class InquiryAddEdit : System.Web.UI.Page
    {
        public bal.BalInquiryOpration InquiryOp = new bal.BalInquiryOpration();
        public bal.courseopration courseOp = new bal.courseopration();
        public bal.balComman com = new balComman();
        public ClsInquiry objInquiry = new ClsInquiry();
        public int? Inquiryid = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindCourseDropDown();
                bindCityDropDown();
                bindAreaDropDown();
                txtInquiryDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                if (Request.QueryString["id"] != null)
                {
                    Inquiryid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    lblHead.InnerText = "Inquiry Update";
                    btnsave.Text = "Update";
                    bindInquiryDetails(Inquiryid);
                }
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (Request.QueryString["id"] != null)
                {
                    Inquiryid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    objInquiry.Id = Inquiryid;
                }
                objInquiry.fname = txtFirstName.Text.Trim();
                objInquiry.lname = txtLastName.Text.Trim();

                string courseId = string.Empty;
                foreach (ListItem item in ddlCourse.Items)
                {
                    if (item.Selected)
                    {
                        courseId += item.Value + ",";
                    }
                }
                courseId = courseId.TrimEnd(',');
                objInquiry.CourseID = courseId;
                objInquiry.EmailId = txtEmail.Text.Trim();
                objInquiry.Mobile = txtMobile.Text.Trim();
                objInquiry.Address = txtAddress.InnerText;
                objInquiry.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                objInquiry.City = Convert.ToInt32(ddlCity.SelectedValue);
                objInquiry.PreferTimeFrom = txtFromTime.Text.Trim();
                objInquiry.PreferTimeTO = txtToTime.Text.Trim();
                objInquiry.Final    = Convert.ToBoolean(ddlFinal.SelectedValue);
                objInquiry.Notes = txtNotes.InnerText.Trim();
                objInquiry.EntBy = 1;
                objInquiry.ModBy = 1;
                int result = InquiryOp.InsertUpdateInquiry(objInquiry);
                if (result > 0)
                {
                    Response.Redirect("InquiryList.aspx");
                }
                else {
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
            Response.Redirect("InquiryList.aspx");
        }
        public void bindCourseDropDown()
        {
            List<getCourseList_Result> courselist = new List<getCourseList_Result>();
            bal.courseopration course = new bal.courseopration();
            courselist = courseOp.GetCourseList();
            ddlCourse.DataSource = courselist;
            ddlCourse.DataTextField = "CourseName";
            ddlCourse.DataValueField = "Id";
            ddlCourse.DataBind();
        }
        public void bindCityDropDown()
        {
            using (aspccEntities db = new aspccEntities())
            {
                var citylist = db.Cities.ToList();
                ddlCity.DataSource = citylist;
                ddlCity.DataTextField = "CityName";
                ddlCity.DataValueField = "Id";
                ddlCity.DataBind();
            }
            
        }
        public void bindAreaDropDown()
        {
            using (aspccEntities db = new aspccEntities())
            {
                var Arealist = db.Areas.ToList();
                ddlArea.DataSource = Arealist;
                ddlArea.DataTextField = "AreaName";
                ddlArea.DataValueField = "Id";
                ddlArea.DataBind();
            }

        }

        public void bindInquiryDetails(int? Inquiryid) {
            try
            {
                getInquiryById_Result objInquiry = new getInquiryById_Result();
                objInquiry = InquiryOp.GetInquiryById(Inquiryid);
                txtFirstName.Text=objInquiry.fname;
                txtLastName.Text= objInquiry.lname;
                ddlCourse.SelectedValue = Convert.ToString(objInquiry.CourseID) ;
                txtInquiryDate.Text = objInquiry.InquiryDate_S;
                string[] courseId = Convert.ToString(objInquiry.CourseID).Split(',');
                foreach (ListItem item in ddlCourse.Items)
                {
                    foreach (var id in courseId)
                    {
                        if (item.Value== id)
                        {
                            item.Selected = true;
                        }
                    }
                    
                }

                txtEmail.Text =objInquiry.EmailId ;
                 txtMobile.Text= objInquiry.Mobile;
                 txtAddress.InnerText= objInquiry.Address;
                ddlArea.SelectedValue = Convert.ToString(objInquiry.AreaId);
                ddlCity.SelectedValue = Convert.ToString(objInquiry.City);
                txtFromTime.Text = objInquiry.PreferTimeFrom;
                txtToTime.Text = objInquiry.PreferTimeTO;
                 ddlFinal.SelectedValue = (objInquiry.Final==true)? "true":"false";
                txtNotes.InnerText = objInquiry.Notes;
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindInquiryDetails", ex.StackTrace, ex.Message);
            }
            
        }
    }
}