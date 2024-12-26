using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService_Client
{
    public partial class ClientForm : System.Web.UI.Page
    {
        OurService.OurWebService1SoapClient client =
            new OurService.OurWebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsayhello_Click(object sender, EventArgs e)
        {
            Label1.Text = client.SayHello(txtname.Text);
        }

        protected void btnhello_Click(object sender, EventArgs e)
        {
            Label1.Text = client.HelloWorld();
        }

        protected void btnSquare_Click(object sender, EventArgs e)
        {
           Label1.Text = client.Squareroot(Convert.ToSingle(txtnum1.Text)).ToString();
        }
    }
}