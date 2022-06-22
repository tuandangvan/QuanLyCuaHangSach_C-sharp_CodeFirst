namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [StringLength(10)]
        public string CateID { get; set; }

        [Required]
        [StringLength(50)]
        public string CateNAME { get; set; }

        [StringLength(50)]
        public string CateDESCRIBE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
    public partial class Category
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Category> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Categories.ToList();
        }

        public static Category GetCategory(string id)
        {
            return db.Categories.Where(p => p.CateID == id).FirstOrDefault();
        }

        public void InsertCate()
        {
            db.Categories.Add(this);
            db.SaveChanges();
        }

        public void UpdateCate()
        {
            db.SaveChanges();
        }

        public void DeletaCate(string id)
        {
            Category cate = GetCategory(id);
            db.Categories.Remove(cate);
            db.SaveChanges();
        }
    }
}
