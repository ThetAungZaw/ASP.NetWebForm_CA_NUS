using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA46_Team01_BookShop
{
    public class shopController
    {
      

        public List<Book> find4Book()
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                Book a = BookShop.Books.Find(1);
                Book b = BookShop.Books.Find(2);
                Book c = BookShop.Books.Find(3);
                Book d = BookShop.Books.Find(4);

                List<Book> book = new List<Book>();
                book.Add(a);
                book.Add(b);
                book.Add(c);
                book.Add(d);

                return book;
            }
        }


        public List<Book> searchByTitle(string keyword)
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                return BookShop.Books.Where(x => x.Title.Contains(keyword)).ToList();
            }
        }

        public List<Book> searchByAuthor(string keyword)
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                return BookShop.Books.Where(x => x.Author.Contains(keyword)).ToList();
            }
        }

        public Book loadBook(string title)
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                Book b = BookShop.Books.Where(x => x.Title == title).First();
                return b;
            }
        }
        public Category loadCategory(Book b)
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                Category c = BookShop.Categories.Where(x => x.CategoryId == b.CategoryId).First();
                return c;
            }
        }

        public List<Book> selectAll()
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                return BookShop.Books.ToList();
            }
        }

        public List<Book> OrderByPrice()
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                return BookShop.Books.OrderByDescending(x => x.Price).ToList();
            }
        }

        public List<Book> OrderByTitle()
        {
            using (BookShop_EF2 BookShop = new BookShop_EF2())
            {
                return BookShop.Books.OrderBy(x => x.Title).ToList();
            }
        }
    }
}