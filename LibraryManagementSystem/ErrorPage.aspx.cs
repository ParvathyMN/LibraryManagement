using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "Sorry,unexpected error occured.Click here to retry";

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }
    }
}