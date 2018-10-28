using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA46Team01WNET
{
    public partial class CataloguePage : System.Web.UI.Page
    {
        Catalogue pageCatalogue;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack || ViewState["PageNumber"] == null)
            {

                ViewState["PageNumber"] = 0;
                ViewState["Paging"] = 0;

                ViewState["CountPaging"] = 1;
                ViewState["Count"] = 1;

                LinkButton3.Text = ((int)ViewState["Paging"] * 3 +3).ToString();
                LinkButton2.Text = ((int)ViewState["Paging"] * 3 +2).ToString();
                LinkButton1.Text = ((int)ViewState["Paging"] * 3 +1).ToString();         

                PreRender += new System.EventHandler(Page_PreRender);



                DisplayCatalogue();
            }

           
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            int test = pageCatalogue.CountRow;
            ViewState["CountPage"] = Convert.ToInt32(Math.Ceiling(pageCatalogue.CountRow / 6d));
            int test2 = (int)ViewState["CountPage"];
            ViewState["CountPaging"] = Convert.ToInt32(Math.Ceiling(((int)ViewState["CountPage"] - 1) / 2d));

            if ((int)ViewState["Paging"] == 0) LinkButtonPrev.Text = "";
            else LinkButtonPrev.Text = "Previous";

            //if ((int)ViewState["Paging"] == (int)ViewState["CountPaging"]) LinkButtonNext.Text = "";
            //else 

            if ((int)ViewState["CountPage"] < (int)ViewState["Paging"] * 3 + 3)
            {
                LinkButtonNext.Text = "";
                LinkButton3.Text = "";
            }
            else
            {
                LinkButton3.Text = ((int)ViewState["Paging"] * 3 + 3).ToString();
                LinkButtonNext.Text = "Next";
            }
            

            if ((int)ViewState["CountPage"] < (int)ViewState["Paging"] * 3 + 2) LinkButton2.Text = "";
            else LinkButton2.Text = ((int)ViewState["Paging"] * 3 + 2).ToString();

            for (int i = 0; i < pageCatalogue.BookId.Count; i++)
            {
                ViewState[String.Format("BookId{0}", i)] = pageCatalogue.BookId[i];
            }
        }

        private void DisplayCatalogue()
        {
            if(Request.QueryString["Cat"] == null)
            {
                pageCatalogue = new Catalogue((int)ViewState["PageNumber"]);
            }
            else pageCatalogue = new Catalogue((int)ViewState["PageNumber"], Request.QueryString["Cat"].ToString());

            for (int i = 0; i < pageCatalogue.BookId.Count; i++)
            {
                ContentPlaceHolder content = (ContentPlaceHolder)Master.FindControl("MainContent");
                //Control imageControl = content.FindControl(String.Format("Image{0}", i + 1));
                ((Image)content.FindControl(String.Format("Image{0}", i + 1))).ImageUrl = String.Format("~/images/{0}.jpg", pageCatalogue.ISBN[i]);
                ((Label)content.FindControl(String.Format("LBLName{0}", i + 1))).Text = pageCatalogue.Title[i];
                ((Label)content.FindControl(String.Format("LBLPrice{0}", i + 1))).Text = pageCatalogue.Price[i].ToString();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            ViewState["PageNumber"] = Convert.ToInt32(LinkButton1.Text) - 1;
            DisplayCatalogue();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            ViewState["PageNumber"] = Convert.ToInt32(LinkButton2.Text) - 1;
            DisplayCatalogue();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            ViewState["PageNumber"] = Convert.ToInt32(LinkButton3.Text) - 1;
            DisplayCatalogue();
        }

        protected void LinkButtonPrevious_Click(object sender, EventArgs e)
        {
            if((int)ViewState["Paging"] != 0)
            {
                ViewState["Paging"] = (int)ViewState["Paging"] - 1;
                LinkButton3.Text = ((int)ViewState["Paging"] * 3 + 3).ToString();
                LinkButton2.Text = ((int)ViewState["Paging"] *3 + 2).ToString();
                LinkButton1.Text = ((int)ViewState["Paging"] *3 + 1).ToString();
                DisplayCatalogue();
            }
        }

        protected void LinkButtonNext_Click(object sender, EventArgs e)
        {
            ViewState["Paging"] = (int)ViewState["Paging"] + 1;

            if ((int)ViewState["CountPage"] < (int)ViewState["Paging"] * 3 + 3) LinkButton3.Text = "";
            else LinkButton3.Text = ((int)ViewState["Paging"] * 3 + 3).ToString();

            if((int)ViewState["CountPage"] < (int)ViewState["Paging"] * 3 + 2) LinkButton2.Text = "";
            else LinkButton2.Text = ((int)ViewState["Paging"] * 3 + 2).ToString();

            LinkButton1.Text = ((int)ViewState["Paging"] * 3 + 1).ToString();
            DisplayCatalogue();
        }

        protected void Image1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId0"]).ToString());
        }
        protected void Image2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId1"]).ToString());
        }
        protected void Image3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId2"]).ToString());
        }
        protected void Image4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId3"]).ToString());
        }
        protected void Image5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId4"]).ToString());
        }
        protected void Image6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/BookDetails.aspx?BookId=" + ((int)ViewState["BookId5"]).ToString());
        }
    }
}