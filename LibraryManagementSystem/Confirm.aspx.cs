using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Library_ManagementEntities6 db = new Library_ManagementEntities6();
            int i =Convert.ToInt32( Session["noOfCheck"]);
            for (int j = 1; j <= i; j++)
            {

                var order = (from item in db.Order_Details where item.mode == 1 select item).FirstOrDefault();
                order.mode = 0;
                db.SaveChanges();
            }
            Response.Redirect("User.aspx");

           
        }
    }
}