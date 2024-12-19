using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenFields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtuname.Text;
            HiddenField2.Value = txtpassword.Text;
            txtuname.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("TestForm.aspx");
            lblmessage.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}