using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dal.edmx;
namespace apcc
{
    public partial class ChangePassWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DivError.Visible = false;
            if (!Page.IsPostBack)
            {
                if (Session["userDetails"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        protected void btnChangePws_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = txtpwd.Value;
                string Oldpwd = txtOldPwd.Value;
                string Confirmpwd = txtConfirmpwd.Value;
                string user = Session["userDetails"].ToString();
               
                aspccEntities dataBase = new aspccEntities();
                User objuser = dataBase.Users.Where(x => x.UserName == user && x.PassWord== Oldpwd).First();
                if (objuser == null)
                {
                    DivError.Visible = true;
                    lblErrorMsg.Text = "Old password Incorrect";
                }
                else if (Confirmpwd != pwd)
                {
                    DivError.Visible = true;
                    lblErrorMsg.Text = "Password and Confirm password does not match.";
                }
                else {
                    objuser.PassWord = Confirmpwd;
                    dataBase.SaveChanges();
                    Response.Redirect("~/Login.aspx");
                }
                

            }
            catch (Exception ex)
            {

                DivError.Visible = true;
                lblErrorMsg.Text = "Old password Incorrect";
            }
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}