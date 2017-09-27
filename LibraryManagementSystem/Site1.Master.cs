using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                 if (Session["Name"] != null)
                {

                    Label Label1 = (Label)(LoginView1.FindControl("Label1"));

                    Label1.Text = "Welcome" + " "+ Session["Name"].ToString();
                }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            Response.Redirect("/Users/Home.aspx");
        }
    }
}