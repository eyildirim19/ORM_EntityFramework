using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    // tablo veya alanlarımızı customize etmenin iki yolu vardır.
    // 1) DataAnnotations yolu...
    // 2) FluentApi yoludur (Supplier sınıfı için uygulandı...)...
    // DataAnnotaions ile tabloyu customize ediyoruz...

    [Table("Calisanlar")] // tablo ismi Calisanlar'dır...
    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
           
        [StringLength(maximumLength:50)] // karakter uzunluğu
        [Column("Unvan",TypeName ="varchar")] // kolonadı ve tipi
        public string? Title { get; set; } // ? Allow Null olarak işaretlendi...

        //not:stringler default nvarchardır.
        [StringLength(maximumLength:50)] // nvarchar(50)
        public string Name { get; set; }

        [StringLength(maximumLength:50)] // nvarchar(50)
        public string SurName { get; set; }

        // navigation property
        public List<Order> Orders { get; set; }
    }
}
