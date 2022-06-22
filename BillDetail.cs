namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BookID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string BillID { get; set; }

        [Column(TypeName = "image")]
        public byte[] BookImage { get; set; }

        public int BookPrice { get; set; }

        public int BookAmount { get; set; }

        public int SumPrice { get; set; }

        public virtual BillBook BillBook { get; set; }

        public virtual Book Book { get; set; }
    }
    public partial class BillDetail
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<BillDetail> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.BillDetails.ToList();
        }

        public static BillDetail GetBillDetail(string bookid,string billid)
        {
            return db.BillDetails.Where(p => p.BookID == bookid && p.BillID == billid).FirstOrDefault();
        }
        public void InsertBillDetail()
        {
            db.BillDetails.Add(this);
            db.SaveChanges();
        }
        public void UpdateBillDetail()
        {
            db.SaveChanges();
        }
        public void DeleteBillDetail()
        {
            db.BillDetails.Remove(this);
            db.SaveChanges();
        }
    }
}
