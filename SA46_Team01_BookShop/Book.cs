namespace SA46_Team01_BookShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(22)]
        public string ISBN { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
