﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empty_Prj
{
    public partial class PostBack : System.Web.UI.Page
    {
         int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // if it is not postback then it means first time
            if (!IsPostBack)  
            {
                txtcount.Text = "0";
            }
        }
        protected void BtnCount_Click(object sender, EventArgs e)
        {
            //step 1 :
            //ClicksCount = ClicksCount + 1;
            //txtcount.Text = ClicksCount.ToString();

            //step 2 using explicit viewstate
            //if(ViewState["clicks"]!=null)
            //{
            //    ClicksCount = (int)ViewState["clicks"] + 1;
            //}
            //ViewState["clicks"] = ClicksCount;  //viewstate variable is getting created and initialized with data
            //txtcount.Text = ClicksCount.ToString();

            //step 3 using inbuilt viewstate variable of the server control
            ClicksCount = Convert.ToInt32(txtcount.Text) + 1;
            txtcount.Text = ClicksCount.ToString();
        }
    }
}