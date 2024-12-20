using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPages_Prj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = DateTime.Now.ToString();
            lblmsg.ForeColor = System.Drawing.Color.Crimson;
        }

        protected void btndo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Laptop-tjj7d977; initial catalog=infinitedb;" +
                "integrated security=true;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}