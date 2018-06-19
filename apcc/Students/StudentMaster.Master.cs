using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apcc.Students
{
    public partial class StudentMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["userDetails"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }
                else {
                    lblStudentName.Text = Convert.ToString(Session["userDetails"]).Split('_')[1].ToString();
                }
            }
        }

        protected void btnSignout_Click(object sender, EventArgs e)
        {
            Session.Remove("userDetails");
            Response.Redirect("~/Login.aspx");

        }

        protected void btnLogId_Click(object sender, EventArgs e)
        {
            Session.Remove("userDetails");
            Response.Redirect("~/Login.aspx");

        }
    }
}