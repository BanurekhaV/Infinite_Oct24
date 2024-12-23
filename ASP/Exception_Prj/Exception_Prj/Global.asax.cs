using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Exception_Prj
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            string str = "";
            str = ex.Message;
            string path = @"C:\Banu\Infinite_1\ASP\AppErrors.txt";
            File.WriteAllText(path, str);
            Server.Transfer("~/DefaultErrors.aspx");
           // Server.ClearError();
           //// Response.Write(ex.GetType());
           // Server.Transfer("~/DefaultErrors.aspx");
           // //Response.Redirect("~/Errors.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}