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
            int total = 0;
            ((Label)Master.FindControl("Label1")).Text = Session["Name"].ToString();
            SqlConnection con = new SqlConnection("data source=SUYPC123;initial catalog=Library_Management;user id=sa;password=Suyati123;MultipleActiveResultSets=True;App=EntityFramework");

            //foreach (GridViewRow row in GridView1.Rows)
            //{
            //    SqlCommand cmd = new SqlCommand("select Booked from Book_Details where BookId=@id", con);
            //    var bookId = Convert.ToInt32(row.Cells[0].Text);
            //    cmd.Parameters.AddWithValue("id", bookId);
            //    con.Open();
            //    int count = Convert.ToInt32(cmd.ExecuteScalar());
            //    if (count == 0)
            //    {
            //        var checkbox = row.FindControl("chkCtrl") as CheckBox;
            //        checkbox.Visible = false;
            //    }
            //    else
            //    {
            //        row.Cells[6].Text = null;
            //    }
            //    con.Close();
            //}
            foreach (GridViewRow row in GridView1.Rows)
            {
                //SqlCommand cmd = new SqlCommand("select Booked from Book_Details where Book_Title=@name", con);
                var bookName = Convert.ToString(row.Cells[0].Text);


                Library_ManagementEntities1 db = new Library_ManagementEntities1();
                var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();


                //cmd.Parameters.AddWithValue("name", bookName);
                //con.Open();
                //int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (book.Booked == 0)
                {
                    var checkbox = row.FindControl("chkCtrl") as CheckBox;
                    checkbox.Visible = false;
                }
                else
                {
                    row.Cells[4].Text = null;
                }
                //con.Close();
            }

            foreach (GridViewRow row in GridView1.Rows)
            {
                //SqlCommand cmd = new SqlCommand("select Book_Amount from Book_Details where Book_Title=@name", con);
                var bookName =Convert.ToString( row.Cells[0].Text);


                Library_ManagementEntities1 db = new Library_ManagementEntities1();
                var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();


                //cmd.Parameters.AddWithValue("name", bookName);
                //con.Open();
                var checkbox = row.FindControl("chkCtrl") as CheckBox;
                int bookamt =Convert.ToInt32( book.Book_Amount);
                if (checkbox.Checked)
                {
                    total = total + bookamt;
                    TextBox1.Text = Convert.ToString(total);
                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            foreach (GridViewRow row in GridView1.Rows)
            {
                var bookName = Convert.ToString(row.Cells[0].Text);
                Library_ManagementEntities1 db = new Library_ManagementEntities1();
                var book = (from item in db.Book_Details where item.Book_Title == bookName select item).FirstOrDefault();
               
                var checkbox = row.FindControl("chkCtrl") as CheckBox;
                if (checkbox.Checked)
                {
                    //var bookdate = book.Booked
                    var count = book.Booked;
                    count = count - 1;
                    book.Booked = count;
                    db.SaveChanges();
                }
            }
            
        }
    }
}