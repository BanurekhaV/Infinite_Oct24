using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empty_Prj
{
    public partial class FirstForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            //Response.Write("Welcome to Web programming using ASP.Net");
            Txtname.Text = "Welcome to ASP.net";
            Response.Write(Txtname.Text);
        }
    }
}