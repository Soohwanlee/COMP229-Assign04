using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSONProject
{
    public partial class LandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            repeater1.DataSource = Global.models;
            repeater1.DataBind();
            Page.Title = "The Wrath of Kings";
        }


        protected void addButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddModel.aspx");
        }
    }
}