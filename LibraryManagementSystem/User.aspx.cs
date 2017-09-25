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
            SqlConnection con = new SqlConnection("data source=SUYPC123;initial catalog=Library_Management;user id=sa;password=Suyati123;MultipleActiveResultSets=True;App=EntityFramework");

            foreach (GridViewRow row in GridView1.Rows)
            {
                SqlCommand cmd = new SqlCommand("select Booked from Book_Details where BookId=@id", con);
                var bookId = Convert.ToInt32(row.Cells[0].Text);
                cmd.Parameters.AddWithValue("id", bookId);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    var checkbox = row.FindControl("chkCtrl") as CheckBox;
                    checkbox.Visible = false;
                }
                else
                {
                    row.Cells[6].Text = null;
                }
                con.Close();
            }

            foreach (GridViewRow row in GridView1.Rows)
            {
                SqlCommand cmd = new SqlCommand("select Book_Amount from Book_Details where BookId=@id", con);
                var bookId = Convert.ToInt32(row.Cells[0].Text);
                cmd.Parameters.AddWithValue("id", bookId);
                con.Open();
                var checkbox = row.FindControl("chkCtrl") as CheckBox;
                int bookamt = Convert.ToInt32(cmd.ExecuteScalar());
                if (checkbox.Checked)
                {
                    total = total + bookamt;
                    TextBox1.Text = Convert.ToString(total);
                }
                con.Close();
            }
        }
    }
}