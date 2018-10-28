using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46_Team01_BookShop
{
    public partial class Discountpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindGrid();

            }

            }
        protected void BindGrid()
        {
            GridView1.DataSource = BusinessLogic.Discount();
            GridView1.DataBind();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Disid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            BusinessLogic.DeleteDis(Disid);
          BindGrid();

        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
             BindGrid();
       }
        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
            
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow &&
                (e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                Discount order = (Discount)e.Row.DataItem;
            }
        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            int Disid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
          
            string Promo = (row.FindControl("TextBox1") as TextBox).Text;
            int rate =Int32.Parse( (row.FindControl("TextBox2") as TextBox).Text);
            BusinessLogic.UpdateDis(Disid, Promo, rate);
            GridView1.EditIndex = -1;
            BindGrid();

        }

        protected void New_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewDiscountPage.aspx");
        }
         protected void Homebtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void MemberListbtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberList.aspx");
        }

        protected void Discountbtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discountpage.aspx");
        }

        protected void AddBook2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("CataloguePage.aspx");
        }
    }
}