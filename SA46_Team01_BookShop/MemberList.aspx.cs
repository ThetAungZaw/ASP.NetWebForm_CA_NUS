using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class MemberList : System.Web.UI.Page
    {
        public  int userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            GridView1.DataSource = BusinessLogic.ListUsersBy();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            BusinessLogic.DeleteUser(userId);
            BindGrid();
        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            userid = (int)GridView1.SelectedDataKey.Value;
            Response.Redirect("UserOrderDetail.aspx?UserID=" + userid);
        }
        protected void Homebtn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }

    }
