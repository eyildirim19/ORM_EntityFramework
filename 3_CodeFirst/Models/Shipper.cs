using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    public class Shipper
    {
        // Ef sınıf içerisinde aksini belirtmediğimiz sürece ID isimli property varsa onu pk yapar. Eğer ID isimli yok SınıfAdiID varsa onu pk yapar..
        public int ShipperId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }
    }
}
