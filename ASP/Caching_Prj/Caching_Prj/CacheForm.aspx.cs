using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Caching_Prj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductByName("All");
            }
            else
            {
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));  //duration
                Response.Cache.VaryByParams["None"] = true;  //varybyparam
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location
            }

            Label1.Text = "This Page is Cached at :" + DateTime.Now.ToString();
        }

        private void GetProductByName(string ProductName)
        {
            SqlConnection con = new SqlConnection("Data Source=laptop-tjj7d977;" +
                "initial catalog=homecare;integrated security=true;");
            SqlDataAdapter da = new SqlDataAdapter("spGetproductByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@ProductName";
            param1.Value = ProductName;
            da.SelectCommand.Parameters.Add(param1);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(DDL.SelectedValue);
        }
    }
}