using bal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace apcc.admin.handler
{
    /// <summary>
    /// Summary description for Comman
    /// </summary>
    public class Comman : IHttpHandler
    {
        public bal.balComman com = new balComman();
        public void ProcessRequest(HttpContext context)
        {
            string dbpath = ConfigurationManager.AppSettings["dbBackPath"];
            com.DataBaseBackUp(dbpath);
           
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}