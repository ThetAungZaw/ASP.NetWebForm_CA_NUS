using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Click(object sender, EventArgs e)
        {
            //Session["name"] = name.Text;
            using (BookShop_EF2 ctx = new BookShop_EF2())
            {
                User namecheck = ctx.Users.Where(p => p.UserName == name.Text).First<User>();
                if (namecheck.Password == passowrd.Text)
                {
                    if (name.Text == "admin")
                    {
                        Response.Redirect("home.aspx");

                    }
                    else
                    {
                        
                        Response.Redirect("ViewCart.aspx");
                    }


                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
                
               
            }
            }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration.aspx");
        }
    }
}