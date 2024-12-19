using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class TestForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the viewstaete variable does not have any vaid references and hence it throws a
            //NullReferenceException
            //  lblmsg.Text = "Your Name is : " + ViewState["uname"].ToString() + " " + "and your Pasword is" + " " + ViewState["pass"].ToString();
           
            //The hiddenfield being an object does not even show up in the other page and
            //hence gives a compilation error
            
            // lblmsg.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}