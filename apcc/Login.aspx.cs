using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dal.edmx;
namespace apcc
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DivError.Visible = false;
            if (!Page.IsPostBack)
            {
                Session.Remove("userDetails");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = txtEmail.Text.Trim();
                string pwd = txtpwd.Value;

                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.Users.Where(x => x.UserName == UserName && x.PassWord == pwd).FirstOrDefault();
                    if (result != null)
                    {

                        Session["userDetails"] = result.UserName;
                        if (result.UserType == 1)
                        {
                            Response.Redirect("~/admin/Dashboard.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/Students/Dashboard.aspx");
                        }

                    }
                    else
                    {
                        DivError.Visible = true;
                        lblErrorMsg.Text = "User Id or Password Incorrect.";
                    }
                }


            }
            catch (Exception ex)
            {
                DivError.Visible = true;
            }
        }

    }
}