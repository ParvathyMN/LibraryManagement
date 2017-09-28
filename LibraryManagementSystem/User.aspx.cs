using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ((Label)Master.FindControl("Label1")).Visible = true;
            try
            {
                int total = 0;
                foreach (GridViewRow row in GridView1.Rows)
                {
                    var bookName = Convert.ToString(row.Cells[0].Text);


                    Library_ManagementEntities6 db = new Library_ManagementEntities6();
                    var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();
                    if (book.Booked == 0)
                    {
                        var checkbox = row.FindControl("chkCtrl") as CheckBox;
                        checkbox.Visible = false;
                    }
                    else
                    {
                        row.Cells[4].Text = null;
                    }
                }

                foreach (GridViewRow row in GridView1.Rows)
                {
                    var bookName = Convert.ToString(row.Cells[0].Text);


                    Library_ManagementEntities6 db = new Library_ManagementEntities6();
                    var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();
                    var checkbox = row.FindControl("chkCtrl") as CheckBox;
                    int bookamt = Convert.ToInt32(book.Book_Amount);
                    if (checkbox.Checked)
                    {
                        total = total + bookamt;
                        TextBox1.Text = Convert.ToString(total);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int countCheck = 0;
                foreach (GridViewRow row in GridView1.Rows)
                {

                    var bookName = Convert.ToString(row.Cells[0].Text);
                    Library_ManagementEntities6 db = new Library_ManagementEntities6();
                    var uname = Session["Name"].ToString();
                    var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();
                    var user = (from items in db.User_Details where items.UserName == uname select items).FirstOrDefault();
                    var checkbox = row.FindControl("chkCtrl") as CheckBox;
                    if (checkbox.Checked)
                    {
                        countCheck = countCheck + 1;
                        Order_Details obj = new Order_Details();
                        obj.UserId = user.UserId;

                        obj.BookId = book.BookId;
                        obj.mode = 1;
                        var count = book.Booked;
                        count = count - 1;
                        book.Booked = count;
                        db.Order_Details.Add(obj);
                        db.SaveChanges();
                        Session["noOfCheck"] = countCheck;
                    }

                }

                throw new Exception();
                
            }
            catch (Exception ex)
            {
                Response.Redirect("Confirm.aspx");
            }

        }
    }
}