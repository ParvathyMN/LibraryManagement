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
            Label3.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Library_ManagementEntities6 db = new Library_ManagementEntities6();
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
                    Label3.Visible = true;
                    Label3.Text = "Sorry! Invalid username and password.";
                }
                
            }
            
            catch(Exception ex)
            {
                Response.Redirect("LoginError.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}