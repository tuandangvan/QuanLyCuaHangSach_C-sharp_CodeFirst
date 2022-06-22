namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("CustomerType")]
    public partial class CustomerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerType()
        {
            Customers = new HashSet<Customer>();
        }

        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerTypeNAME { get; set; }

        [StringLength(50)]
        public string CustomerTypeDESCRIBE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
    public partial class CustomerType
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<CustomerType> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.CustomerTypes.ToList();
        }

        public static CustomerType GetCustomerType(string id)
        {
            return db.CustomerTypes.Where(p => p.CustomerTypeID == id).FirstOrDefault();
        }

        public void InsertCustomerType()
        {
            db.CustomerTypes.Add(this);
            db.SaveChanges();
        }

        public void UpdateCustomerType()
        {
            db.SaveChanges();
        }

        public void DeletaCustomerType(string id)
        {
            CustomerType cusT = GetCustomerType(id);
            db.CustomerTypes.Remove(cusT);
            db.SaveChanges();
        }
    }
}
