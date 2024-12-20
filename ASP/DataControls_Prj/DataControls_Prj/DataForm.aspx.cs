using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DataControls_Prj
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Laptop-tjj7d977; initial catalog=infinitedb;" +
                "integrated security=true;");
            con.Open();

            //using adapter
            //SqlDataAdapter da = new SqlDataAdapter("select * from tblemployee", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();

            //using command 
            SqlCommand cmd = new SqlCommand("Select * from tblemployee", con);
          
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}