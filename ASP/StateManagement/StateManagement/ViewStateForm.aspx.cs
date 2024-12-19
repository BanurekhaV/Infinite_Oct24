using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = txtuname.Text;
            ViewState["pass"] = txtpassword.Text;
            txtuname.Text = "";
            txtpassword.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //to check if the viewstate variables data are availabe in another page
            Response.Redirect("TestForm.aspx");

            //1. 
            lblmessage.Text = "Your Name is : " + ViewState["uname"].ToString() + " " + "and your Pasword is" + " " + ViewState["pass"].ToString();

            //or

            //string a = ViewState["uname"].ToString();
            //string b = ViewState["pass"].ToString();

            //lblmessage.Text = "Your Login name is : " + a + " and your password is : " + b;
        }
    }
}