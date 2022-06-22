namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Author")]
    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            Books = new HashSet<Book>();
        }

        [StringLength(10)]
        public string AuthorID { get; set; }

        [Required]
        [StringLength(50)]
        public string AuthorNAME { get; set; }

        [StringLength(10)]
        public string AuthorPHONENUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
    public partial class Author
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Author> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Authors.ToList();
        }

        public static Author GetAuthor(string id)
        {
            return db.Authors.Where(p => p.AuthorID == id).FirstOrDefault();
        }

        public void InsertAuthor()
        {
            db.Authors.Add(this);
            db.SaveChanges();
        }

        public void UpdateAuthor()
        {
            db.SaveChanges();
        }

        public void DeletaAuthor(string id)
        {
            Author aut = GetAuthor(id);
            if (aut == null)
                throw new Exception("Không t?n t?i th? lo?i này");
            else
            {
                db.Authors.Remove(aut);
                db.SaveChanges();
            }
        }
    }
}
