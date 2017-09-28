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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Library_ManagementEntities6 context = new Library_ManagementEntities6())
                {

                    var user = (from s in context.User_Details where s.UserName == TextBox1.Text select s).FirstOrDefault();
                    if (user != null)
                    {
                        Label3.Visible = true;
                        Label3.Text = "Username already exist";
                        TextBox1.Text = " ";
                        TextBox2.Text = " ";

                    }
                    else
                    {
                        User_Details obj = new User_Details();
                        obj.UserName = TextBox1.Text;
                        obj.PassWord = TextBox2.Text;
                        Session["Name"] = TextBox1.Text;
                        context.User_Details.Add(obj);
                        context.SaveChanges();
                      //  throw new Exception();
                        FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                    }


                }
                
            }
            
            catch (Exception ex)
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