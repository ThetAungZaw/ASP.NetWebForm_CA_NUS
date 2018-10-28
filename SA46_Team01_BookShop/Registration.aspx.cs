using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRigister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPass.Text;
            string comPassword = txtComfirmPass.Text;
            string address = txtAddress.Text;
             BusinessLogic.RegistUser(name, password, address);

            Response.Redirect("~/Login.aspx");
          }
    }
}