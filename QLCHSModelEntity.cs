using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Project_QuanLyCuaHangSach
{
    public partial class QLCHSModelEntity : DbContext
    {
        public QLCHSModelEntity()
            : base("name=QLCHSModelEntity")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BillBook> BillBooks { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorID)
                .IsUnicode(false);

            modelBuilder.Entity<BillBook>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<BillBook>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<BillBook>()
                .Property(e => e.EmpID)
                .IsUnicode(false);

            modelBuilder.Entity<BillBook>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.BillBook)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.CateID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.AuthorID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.PublisherID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CateID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .Property(e => e.CustomerTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpID)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.PublisherID)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
