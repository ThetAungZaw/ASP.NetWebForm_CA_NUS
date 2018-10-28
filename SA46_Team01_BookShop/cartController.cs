using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA46_Team01_BookShop
{
    public class cartController
    {
        public CartList addItem(CartList cl, int id, string t, decimal p, int q)
        {
            Book b = new Book();
            b.BookId = id;
            b.Title = t;
            b.Price = p;
            int quantity = q;
            Cart c = new Cart(b, quantity);
            cl.add(c);
            CartList Cl = cl;
            return Cl;
        }

        public decimal countprice(CartList cl)
        {
            List<Cart> cart = cl.getCl();
            decimal totalprice = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                Cart c = cart[i];
                decimal p = 0;
                p = c.b.Price;
                totalprice = totalprice + p;
            }
            return totalprice;
        }

        public void minusStock(CartList cl)
        {
            using (BookShop_EF2 bookshop = new BookShop_EF2())
            {

                List<Cart> cart = cl.getCl();

                for (int i = 0; i < cart.Count; i++)
                {
                    Cart c = cart[i];
                    Book b = bookshop.Books.Find(c.b.BookId);

                    int bookstock = 1;
                    bookstock = b.Stock - 1;

                    b.Stock = bookstock;
                    bookshop.SaveChanges();
                }
            }
        }
    }
}