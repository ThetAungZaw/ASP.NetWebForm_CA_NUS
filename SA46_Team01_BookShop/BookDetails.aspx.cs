using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["BookId"] != null && !IsPostBack)
            {
                int myBookId = Convert.ToInt32(Request.QueryString["BookId"]);
                using (BookShop_EF2 BookShop = new BookShop_EF2())
                {
                    Book myBook = new Book();
                    myBook = BookShop.Books.Where(x => x.BookId == myBookId).First();
                    ViewState["BookId"] = myBookId;

                    shopController sc = new shopController();
                    string title = (string)Session["booktitle"];
                    //string title = ;//For testing purpose
                    //Book b = sc.loadBook(title);
                    /*Category c = sc.loadCategory(b);*///Mr. Derek, I feel it is not necessary to have a seperate table for category......

                    txtTitle.Text = myBook.Title;
                    txtISBN.Text = myBook.ISBN;
                    txtAuthor.Text = myBook.Author;
                    txtCat.Text = myBook.Category.Genre;
                    txtQuantity.Text = "";
                    txtPrice.Text = myBook.Price.ToString();//Original Price
                    Image1.ImageUrl = "~/images/" + myBook.ISBN + ".jpg";
                }
            }
            else if (Request.QueryString["BookId"] == null) Response.Redirect("~/CataloguePage.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Session["BookTitle"] = txtTitle.Text;
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                shopController sc = new shopController();
                string title = (string)Session["booktitle"];
                //string title = "The Hate U Give";//For testing purpose
                Book b = sc.loadBook(title);

               // For Luke's login part
                //if (Session["username"] == null)
                //{
                //    Response.Redirect("Login.aspx");
                //}

                if (Session["cart"] != null)
                {
                    CartList cl = (CartList)Session["cart"];

                    int id = b.BookId;
                    decimal price = 0;
                    price = b.Price;
                    int quantity = Convert.ToInt32(txtQuantity.Text);

                    cartController cc = new cartController();
                    cl = cc.addItem(cl, id, title, price, quantity);
                    Session["cart"] = cl;
                }
                else
                {
                    CartList cl = new CartList();

                    int id = b.BookId;
                    decimal price = 0;
                    price = b.Price;
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    cartController cc = new cartController();
                    cl = cc.addItem(cl, id, title, price, quantity);
                    Session["cart"] = cl;
                }
                Response.Redirect("ViewCart.aspx");
            }
        }
    }
    }
    //protected void btnAddToCart_Click(object sender, EventArgs e)
    //{
    //    using (BookShop_EF2 BookShop = new BookShop_EF2())
    //    {
    //        shopController sc = new shopController();
    //        //string title = (string)Session["booktitle"];
    //        string title = "The Hate U Give";//For testing purpose
    //        Book b = sc.loadBook(title);

    //        //For Luke's login part
    //        //if (Session["username"] == null)
    //        //{
    //        //    Response.Redirect("Login.aspx");
    //        //}

    //        if (Session["cart"] != null)
    //        {
    //            CartList cl = (CartList)Session["cart"];

    //            int id = b.BookId;
    //            decimal price = 0;
    //            price = b.Price;
    //            int quantity = Convert.ToInt32(txtQuantity.Text);

    //            cartController cc = new cartController();
    //            cl = cc.addItem(cl, id, title, price, quantity);
    //            Session["cart"] = cl;
    //        }
    //        else
    //        {
    //            CartList cl = new CartList();

    //            int id = b.BookId;
    //            decimal price = 0;
    //            price = b.Price;
    //            int quantity = Convert.ToInt32(txtQuantity.Text);
    //            cartController cc = new cartController();
    //            cl = cc.addItem(cl, id, title, price, quantity);
    //            Session["cart"] = cl;
    //        }
    //        Response.Redirect("ViewCart.aspx");
    //    }
    //} 
