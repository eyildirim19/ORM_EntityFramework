using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace _3_CodeFirst.Models
{
    //Context sınıfı veritabanı objleri ile c# objelerinin eşleştirildiği sınıftır. Aynı zamanda veritabanı erişimi bu sınıf üzerinden yapılır...
    // Eşleştirme yapılan yer DbSet genericidir...

    // Veritabanına yansıtmak istediğiniz sınıfı Context sınıfında DbSet olarak işaretlemeniz gerekmekte...
    public class ModelContext : DbContext
    {
        // Tablo isimlerimiz aksini belitrmediğimiz sürece context sınıfımıdaki property ismine göre verilir...

        public DbSet<Category> Categories { get; set; }
        public DbSet<Shipper> Shipp { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Employees> Employee { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }


        // FluentApi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // tablo adı Tedarikci olsun
            modelBuilder.Entity<Suppliers>().ToTable("Tedarikci");

            modelBuilder.Entity<Suppliers>().Property(c => c.Name).HasColumnName("MusteriAdi").HasMaxLength(100);

            modelBuilder.Entity<Suppliers>().Property(c=> c.Title).HasColumnType("varchar").HasMaxLength(200).IsRequired(false); // IsRequired(false); => allow null

            modelBuilder.Entity<Suppliers>().HasKey(c => c.SuppID); // PK
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodeFirst1;uid=sa;pwd=123");
        }
    }
}
