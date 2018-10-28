using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

            if (!IsPostBack)
            {
                ShowList();
                DropDownList1.DataSource = BusinessLogic.ListCat();
                DropDownList1.DataTextField = "Genre";
                DropDownList1.DataValueField = "CategoryId";
                DropDownList1.DataBind();
                //BindGrid();

            }
        }
        public void ShowList()
        {
            if (DropDownList1.SelectedItem.ToString() == "Choose Category")
            {

                BindGrid();
            }
            else
            {
                LoadByCategory();

            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadByCategory();
        }
        protected void BindGrid()
        {
            GridView1.DataSource = BusinessLogic.ListBook();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Bookid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            BusinessLogic.DeleteBook(Bookid);
            ShowList();
        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;

            ShowList();
        }
        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            ShowList(); ;
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow &&
                (e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                Book order = (Book)e.Row.DataItem;
            
            }
        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            int Bookid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string Title = (row.FindControl("TextBox1") as TextBox).Text;
            string Author = (row.FindControl("TextBox2") as TextBox).Text;
            string ISBN = (row.FindControl("TextBox3") as TextBox).Text;
            decimal Price = decimal.Parse((row.FindControl("TextBox4") as TextBox).Text);
           // int Category = Int32.Parse((row.FindControl("DropDownList1") as DropDownList).SelectedValue);
            BusinessLogic.UpdateBook(Bookid, Title, Author, ISBN, Price);
            GridView1.EditIndex = -1;
            ShowList();
        }
        private void LoadByCategory()
        {
            if (DropDownList1.SelectedItem.ToString() == "Choose Category")
            {

                BindGrid();
            }
            else
            {
                using (BookShop_EF2 entities = new BookShop_EF2())
                {
                    string Categoryname = DropDownList1.SelectedItem.ToString();

                    Category CatId = entities.Categories.Where(p => p.Genre == Categoryname).First<Category>();

                    GridView1.DataSource = BusinessLogic.ListOrdersBy(CatId.CategoryId);
                    GridView1.DataBind();
                }
            }
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }
}