namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            BillBooks = new HashSet<BillBook>();
        }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerNAME { get; set; }

        [StringLength(10)]
        public string CustomerPHONENUM { get; set; }

        [StringLength(50)]
        public string CustomerADDRESS { get; set; }

        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillBook> BillBooks { get; set; }

        public virtual CustomerType CustomerType { get; set; }
    }
    public partial class Customer
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Customer> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Customers.ToList();
        }

        public static Customer GetCustomer(string id)
        {
            return db.Customers.Where(p => p.CustomerID == id).FirstOrDefault();
        }
        public void InsertCustomer()
        {
            db.Customers.Add(this);
            db.SaveChanges();
        }
        public void UpdateCustomer()
        {
            db.SaveChanges();
        }
        public void DeleteCustomer()
        {
            db.Customers.Remove(this);
            db.SaveChanges();
        }

    }
}
