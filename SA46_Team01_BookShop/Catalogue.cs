using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SA46Team01WNET
{
    public class Catalogue
    {
        public List<int> BookId { get; set; }
        public List<string> Title { get; set; }
        public List<string> Author { get; set; }
        public List<int> Stock { get; set; }
        public List<decimal> Price { get; set; }
        public List<string> ISBN { get; set; }
        public int CountRow;

        public Catalogue(int pageNumber) : this(pageNumber, "")
        {
            
        }

        public Catalogue(int pageNumber, string CatalogueId)
        {
            DAO newDAO = new DAO();
            int upperBound = (pageNumber) * 6 + 1;
            int lowerBound = upperBound + 5;
            string CatalogueSearch = "";

            BookId = new List<int>();
            Title = new List<string>();
            Author = new List<string>();
            Stock = new List<int>();
            Price = new List<decimal>();
            ISBN = new List<string>();

            if(CatalogueId != "")
            {
                CatalogueSearch = String.Format("WHERE CategoryId = {0}", CatalogueId);
            }

            DataSet ds = newDAO.Query(String.Format("Select * From ( Select Row_Number() " +
                "Over(Order By Title) As RowNum , * From Book {2}) " +
                "t2 Where RowNum BETWEEN {0} AND {1}", upperBound, lowerBound, CatalogueSearch));

            DataSet dscount = newDAO.Query(String.Format("Select COUNT(*) From Book {0}", CatalogueSearch));

            CountRow = (int)dscount.Tables[0].Rows[0][0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                BookId.Add((int)ds.Tables[0].Rows[i][1]);
                Title.Add(ds.Tables[0].Rows[i][2].ToString());
                Author.Add(ds.Tables[0].Rows[i][4].ToString());
                Stock.Add((int)ds.Tables[0].Rows[i][5]);
                Price.Add((decimal)ds.Tables[0].Rows[i][6]);
                ISBN.Add(ds.Tables[0].Rows[i][7].ToString());
            }
        }
    }
}