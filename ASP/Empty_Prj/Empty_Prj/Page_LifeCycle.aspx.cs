using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empty_Prj
{
    public partial class Page_LifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Event" + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page Pre Load event " + " <br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page Init Complete Event " + " <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page init event " + " <br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page Pre Init event " + " <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render event " + " <br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render Complete event " + " <br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page Load complete event " + " <br/>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page Render event " + " <br/>");
        }
        //protected void Page_UnLoad(object sender, EventArgs e)
        //{
        //    Response.Write("Page Un - Load event " + " <br/>");
        //}
    }
}