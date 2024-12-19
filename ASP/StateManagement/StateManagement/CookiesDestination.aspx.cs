using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookiesDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            ////persistent cookie 
            //HttpCookie rc = Request.Cookies["OurCookie"]; //accessing the named cookie
            //lbldata1.Text = rc["d1"];
            //lbldata2.Text = rc["d2"];

            //2. Non persistant cookie

            lbldata1.Text = Request.Cookies["uname"].Value.ToString();
            lbldata2.Text = Request.Cookies["pass"].Value.ToString();

        }
    }
}