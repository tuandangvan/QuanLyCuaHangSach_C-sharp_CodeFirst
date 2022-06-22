namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("BillBook")]
    public partial class BillBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillBook()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        [Key]
        [StringLength(10)]
        public string BillID { get; set; }

        public int? SumBill { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BuyDate { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [StringLength(10)]
        public string EmpID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
    public partial class BillBook
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<BillBook> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.BillBooks.ToList();
        }

        public static BillBook GetBillBook(string id)
        {
            return db.BillBooks.Where(p => p.BillID == id).FirstOrDefault();
        }
        public void InsertBillBook()
        {
            db.BillBooks.Add(this);
            db.SaveChanges();
        }
        public void UpdateBillBook()
        {
            db.SaveChanges();
        }
        public void DeleteBillBook()
        {
            db.BillBooks.Remove(this);
            db.SaveChanges();
        }
    }
}
