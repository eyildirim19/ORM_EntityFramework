using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }


        // navigation Property
        public Order Order { get; set; } // orderdetail'in order'ine erişmek için
        public Product Product { get; set; }//orderdetail'in product'ine erişmek için

    }
}
