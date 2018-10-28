using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = BusinessLogic.ListCatagory();
                DropDownList1.DataTextField = "Genre";
                DropDownList1.DataValueField = "CategoryID";
                DropDownList1.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath("~/images/") + filename);
                    StatusLabel.Text = "New Book with image has been added";
                    StatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
                }

                catch (Exception ex)

                {
                    StatusLabel.Text = "Upload status: The file could not    be uploaded." + "The following error occurred: " + ex.Message;
                }

                string title = TextBox1.Text;
                string author = TextBox2.Text;
                string isbn = TextBox3.Text;
                int categoryID = Int32.Parse(DropDownList1.SelectedValue);
                decimal price = Convert.ToDecimal(TextBox4.Text);
                int stock = Int32.Parse(TextBox5.Text);

                try
                {
                    BusinessLogic.AddBook(title, author, isbn, categoryID, price, stock);
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";

                }
                catch (Exception exp)
                {
                    Response.Write(exp.ToString());
                }
            }
        }
        protected void Homebtn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }
}