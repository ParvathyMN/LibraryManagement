using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                Library_ManagementEntities5 db = new Library_ManagementEntities5();
                var username = TextBox1.Text;
                var password = TextBox2.Text;

                var item = (from s in db.User_Details where s.UserName == username && s.PassWord == password select s).FirstOrDefault();
                if (item != null)
                {
                    Session["Name"] = TextBox1.Text;
                    //  Server.Transfer("User.aspx");
                    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                }
                else
                {
                    Response.Write("Sorry,Invalid credentials.");
                }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}