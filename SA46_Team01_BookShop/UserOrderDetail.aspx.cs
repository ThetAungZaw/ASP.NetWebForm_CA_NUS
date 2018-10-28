using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class UserOrderDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<OrderDetail> gg = null;

                int userId2 = Int32.Parse(Request.QueryString["UserID"]);
                using (BookShop_EF2 entity = new BookShop_EF2())
                {

                    List<Order> od = entity.Orders.Where(p => p.UserId == userId2).ToList();


                    BookShop_EF2 bf = new BookShop_EF2(); 

                    var or = (from p in bf.OrderDetails
                             join r in bf.Orders
                             on p.OrderId equals r.OrderId
                             where r.UserId == userId2
                             select new
                             {
                                 OrderId = p.OrderId,
                                 OrderLine  = p.OrderLine,
                                 BookId = p.BookId,
                                 Quantity = p.Quantity,
                                LineAmount = p.LineAmount
                             }).ToList();
          
                         GridView1.DataSource = or;
                         GridView1.DataBind();


                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }
        protected void Homebtn5_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn5_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }
}