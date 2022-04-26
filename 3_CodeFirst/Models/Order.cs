using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    //? => Nullable
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }

        public Nullable<DateTime> ShippedDate { get; set; }


        public int CalisanId { get; set; }
        public int MusteriId { get; set; }
        public int ShipTo { get; set; }

        // navigation property
        public Employees Employee { get; set; }
        public Customer Customer { get; set; }
        public Shipper Shipper { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } // Order'in orderdetailine erişmek için

    }
}
