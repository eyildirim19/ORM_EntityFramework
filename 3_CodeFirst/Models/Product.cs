using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_CodeFirst.Models
{
    
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("Supliers")] // navigaion property
        public int SupplierId { get; set; }

        // navigation property
        public Category Categories { get; set; }
        public Suppliers Supliers { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
