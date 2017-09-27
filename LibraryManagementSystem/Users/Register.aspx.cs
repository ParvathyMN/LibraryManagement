﻿using LibraryManagementSystem.Models;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (Library_ManagementEntities5 context = new Library_ManagementEntities5())
            {
                User_Details obj = new User_Details();
                obj.UserName = TextBox1.Text;
                obj.PassWord = TextBox2.Text;
                Session["Name"] = TextBox1.Text;
                context.User_Details.Add(obj);
                context.SaveChanges();
                  FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                //FormsAuthentication.RedirectToLoginPage();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}