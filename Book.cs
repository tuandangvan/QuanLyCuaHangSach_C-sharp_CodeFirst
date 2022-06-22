namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        [StringLength(10)]
        public string BookID { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] BookIMAGE { get; set; }

        [Required]
        [StringLength(50)]
        public string BookNAME { get; set; }

        public int BookPRICE { get; set; }

        public int? BookAMOUNT { get; set; }

        [StringLength(10)]
        public string CateID { get; set; }

        [StringLength(10)]
        public string AuthorID { get; set; }

        [StringLength(10)]
        public string PublisherID { get; set; }

        public virtual Author Author { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual Category Category { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
    public partial class Book
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Book> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Books.ToList();
        }
        public static Book GetBook(string id)
        {
            return db.Books.Where(p => p.BookID == id).FirstOrDefault();
        }
        
        public void InsertBook()
        {
            db.Books.Add(this);
            db.SaveChanges();
        }
        public void UpdateBook()
        {
            db.SaveChanges();
        }
        public void DeleteBook()
        {
            db.Books.Remove(this);
            db.SaveChanges();
        }

    }
}
