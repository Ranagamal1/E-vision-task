﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_vision_task
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void view(object sender, EventArgs e)
        {
            Response.Redirect("viewer.aspx");
        }
        protected void editt(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}