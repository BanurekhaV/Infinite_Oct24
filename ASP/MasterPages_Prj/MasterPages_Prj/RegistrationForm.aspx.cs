﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation_Prj
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                // Response.Write("Registration Successful..");
                Response.Redirect("Welcome.html");
            }
            else
            {
                Response.Write("Please Correct the Form..");
            }
        }
    }
}