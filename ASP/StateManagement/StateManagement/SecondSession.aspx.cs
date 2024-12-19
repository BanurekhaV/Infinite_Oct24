using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGetSession_Click(object sender, EventArgs e)
        {
            Lblname.Text = Session["name"].ToString();
            Lblcity.Text = Session["city"].ToString();
        }

        protected void Btnthird_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThirdSession.aspx");
        }
    }
}