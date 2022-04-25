using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    // Bu sınıfıda FluentApi yöntemi ile customize ediyoruz.....
    // Fleunt api Context sınıfı içerisinde OnModelCreating metodu içierisinde uygulanır. Bu metot context sınıfında Override metodu ile ezilerek güncelleme yapılır...

    public class Suppliers
    {
        public int SuppID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
