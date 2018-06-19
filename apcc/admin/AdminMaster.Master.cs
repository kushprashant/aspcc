using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apcc.admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                if (Session["userDetails"] == null) {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        

        protected void btnSignout_Click(object sender, EventArgs e)
        {
            Session.Remove("userDetails");
            Response.Redirect("~/Login.aspx");

        }

        protected void btnchangePwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ChangePassWord.aspx");
        }
    }
}