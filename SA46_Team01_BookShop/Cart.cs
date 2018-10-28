using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA46_Team01_BookShop
{
    public class Cart
    {
        public Book b;
        public Book B
        {
            get { return b; }
            set { b = value; }
        }
        
        public int quantity
        {
            get;
            set;
        }
        public Cart(Book b, int q)
        {
            this.b = b;
            this.quantity = q;
        }
    }
}