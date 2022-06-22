namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            BillBooks = new HashSet<BillBook>();
        }

        [Key]
        [StringLength(10)]
        public string EmpID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpNAME { get; set; }

        [StringLength(50)]
        public string EmpADDRESS { get; set; }

        [StringLength(10)]
        public string EmpPHONENUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillBook> BillBooks { get; set; }
    }
    public partial class Employee
    {
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public static List<Employee> GetAll()
        {
            db = new QLCHSModelEntity();
            return db.Employees.ToList();
        }

        public static Employee GetEmployee(string id)
        {
            return db.Employees.Where(p => p.EmpID == id).FirstOrDefault();
        }
        public void InsertEmployee()
        {
            db.Employees.Add(this);
            db.SaveChanges();
        }
        public void UpdateEmployee()
        {
            db.SaveChanges();
        }
        public void DeleteEmployee()
        {
            db.Employees.Remove(this);
            db.SaveChanges();
        }
    }
}
