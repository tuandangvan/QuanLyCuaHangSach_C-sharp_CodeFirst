namespace Project_QuanLyCuaHangSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        [StringLength(10)]
        public string EmpID { get; set; }
        
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Passwork { get; set; }
    }
    public partial class UserLogin
    {
        public static string idCrurrent = string.Empty;
        static QLCHSModelEntity db = new QLCHSModelEntity();
        public List<UserLogin> GetAll()
        {
            return db.UserLogins.ToList();
        }
        public void InsertUser()
        {
            db.UserLogins.Add(this);
            db.SaveChanges();
        }
        public static UserLogin GetUserLogin(string id)
        {
            return db.UserLogins.Where(p => p.EmpID == id).FirstOrDefault();
        }
    }
}
