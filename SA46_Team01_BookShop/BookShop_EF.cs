namespace SA46_Team01_BookShop
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookShop_EF2 : DbContext
    {
        public BookShop_EF2()
            : base("name=BookShop_EF22")
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.ShoppingCarts)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Discount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.LineAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ShoppingCart>()
                .Property(e => e.LineAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ShoppingCarts)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
