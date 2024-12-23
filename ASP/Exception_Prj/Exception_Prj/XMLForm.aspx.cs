using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Exception_Prj
{
    public partial class XMLForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                 Response.Redirect("Hello.aspx");
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                Grid1.DataSource = ds;
                Grid1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.LogExceptionToDB(ex);
                lblmsg.Text = "Some Technical Error Occured.. try after sometime";
            }
        }
    }
        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();
        //    Response.Write(ex.GetType());
        //    //Server.Transfer("~/Errors.aspx");
        //    Response.Redirect("~/Errors.aspx");
        //}
        
}
