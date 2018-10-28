using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class NewDiscountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string promo = TextBox1.Text;
            int disrate = Int32.Parse(TextBox2.Text);
            DateTime st =Convert.ToDateTime( TextBox3.Text);
            DateTime et = Convert.ToDateTime(TextBox4.Text);
            BusinessLogic.AddDis(promo, disrate, st, et);         
            Response.Redirect("Discountpage.aspx");
        }
        protected void Homebtn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }
}