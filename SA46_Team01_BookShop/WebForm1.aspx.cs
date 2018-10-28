using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class WebForm1 : System.Web.UI.Page
    {                 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            using (BookShop_EF2 ctx = new BookShop_EF2())
            {
                var shoppingcart = ctx.ShoppingCarts.ToList();
                GridView1.DataSource = shoppingcart;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (BookShop_EF2 ctx = new BookShop_EF2())
            {
                int bookId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
                var id = ctx.Books.Where(x => x.BookId == bookId).FirstOrDefault();
                ctx.Books.Remove(id);
                ctx.SaveChanges();
                BindGrid();
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            using (BookShop_EF2 ctx = new BookShop_EF2())
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ShoppingCart sc = (ShoppingCart)e.Row.DataItem;
                DropDownList ddl = (e.Row.FindControl("ddlCategory") as DropDownList);
                if (ddl != null)
                {
                    ddl.DataSource = ctx.Users.ToList();
                    ddl.DataTextField = "Name";
                    ddl.DataValueField = "CategoryID";
                    ddl.DataBind();
                }
                TextBox author = (e.Row.FindControl("tbxAuthor") as TextBox);
            }
        }
    }
}}