using bal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apcc.admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        public static bal.balComman com = new balComman();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static void databaseBackUp()
        {
            com.DataBaseBackUp();
        }
    }
}