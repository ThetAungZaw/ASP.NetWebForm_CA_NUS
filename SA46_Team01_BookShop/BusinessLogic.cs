using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA46_Team01_BookShop
{
    public class BusinessLogic
    {
        public static List<Book> ListBook()
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Books.ToList<Book>();
            }
        }
        public static List<Discount> Discount()
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Discounts.ToList<Discount>();
            }
        }
        public static void DeleteBook(int Bookid)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Book order = entities.Books.Where(p => p.BookId == Bookid).First<Book>();
                entities.Books.Remove(order);
                entities.SaveChanges();
            }
        }
        public static void DeleteDis(int Disid)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Discount order = entities.Discounts.Where(p => p.DiscountId == Disid).First<Discount>();
                entities.Discounts.Remove(order);
                entities.SaveChanges();
            }
        }
        public static void RegistUser(string name, string password, string address)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                User usr = new User
                {

                    UserName = name,
                    Password = password,
                    Address = address,


                };
                entities.Users.Add(usr);
                entities.SaveChanges();
            }
        }
        public static void UpdateBook(int bookid, string Title, string Author,
         string ISBN, decimal Price)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Book order = entities.Books.Where(p => p.BookId == bookid).First<Book>();
                order.BookId = bookid;
                order.Title = Title;
                order.Author = Author;
                order.ISBN = ISBN;
                order.Price = Price;
                //order.CategoryId = Category;
                entities.SaveChanges();
            }
        }
        public static void UpdateDis(int Disid, string Promo, int rate)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Discount order = entities.Discounts.Where(p => p.DiscountId == Disid).First<Discount>();
                order.DiscountId = Disid;
                order.PromoName = Promo;
             
                order.DiscountRate = rate;                             
                entities.SaveChanges();
            }
        }
        public static List<Category> ListCat()
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Categories.ToList<Category>();
            }
        }
        public static List<Book> ListOrdersBy(int id)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Books.Where(p => p.CategoryId == id).ToList<Book>();
            }
        }
        public static void AddDis(string Promo, int dis , DateTime st,
            DateTime et)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Discount cat = new Discount
                {

                    PromoName = Promo,
                    DiscountRate = dis,
                    StartDate = st,
                    EndDate = et,
                    

                };
                entities.Discounts.Add(cat);
                entities.SaveChanges();
            }
        }
        public static void AddBook(string title, string author, string isbn,
            int categoryID, decimal price, int stock)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                Book cat = new Book
                {

                    Title = title,
                    Author = author,
                    ISBN = isbn,
                    CategoryId = categoryID,
                    Price = price,
                    Stock = stock,

                };
                entities.Books.Add(cat);
                entities.SaveChanges();
            }
        }

        public static List<Category> ListCatagory()
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Categories.ToList<Category>();
            }
        }
        public static void DeleteUser(int userId)
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                User user = entities.Users.Where(p => p.UserId == userId).First<User>();
                entities.Users.Remove(user);
                entities.SaveChanges();
            }
        }
        public static List<User> ListUsersBy()
        {
            using (BookShop_EF2 entities = new BookShop_EF2())
            {
                return entities.Users.ToList<User>();
            }
        }

    }

}