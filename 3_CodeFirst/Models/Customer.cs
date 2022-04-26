using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    // DataAnnotations ile tablo veya alanlarımızda değişiklikler yapabiliyoruz...
    public class Customer
    {
        // Eğer farklı bir isimde Pk oluşturmak istiyorsak propertymizie [Key] attribute'sini eklememiz gerekiyor...
        // Key attributesi System.ComponentModel.DataAnnotations namespacesi içerisindedir. Bu yüzden bu namespace using ile eklenmelidir...
        [Key] // tablonun pk alanıdır...
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}
