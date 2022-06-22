namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Publisher")]
    public partial class Publisher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        [StringLength(10)]
        public string PublisherID { get; set; }

        [Required]
        [StringLength(50)]
        public string PublisherNAME { get; set; }

        [StringLength(50)]
        public string PublisherADDRESS { get; set; }

        [StringLength(10)]
        public string PublisherPHONENUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
    public partial class Publisher
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Publisher> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Publishers.ToList();
        }

        public static Publisher GetPublisher(string id)
        {
            return db.Publishers.Where(p => p.PublisherID == id).FirstOrDefault();
        }

        public void InsertPublisher()
        {
            db.Publishers.Add(this);
            db.SaveChanges();
        }

        public void UpdatePublisher()
        {
            db.SaveChanges();
        }

        public void DeletaPublisher(string id)
        {
            Publisher pb = GetPublisher(id);
            if (pb == null)
                throw new Exception("Không t?n t?i th? lo?i này");
            else
            {
                db.Publishers.Remove(pb);
                db.SaveChanges();
            }
        }
    }
}
