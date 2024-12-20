using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching_Prj
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGetData_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", txtname.Text);
            Context.Items.Add("Email", txtemail.Text);

            //1. Redirect
             Response.Redirect("OtherPage.aspx"); //this resource is in the same web server

            // Response.Redirect("https://www.amazon.in"); //this is from other webserver

            //2. Transfer
          // Server.Transfer("OtherPage.aspx");

           // Server.Transfer("https://www.amazon.in"); 
        }
    }
}