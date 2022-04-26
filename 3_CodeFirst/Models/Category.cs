using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreDate { get; set; }

        // Category'den product'a bağlantı. Vt ilişkisi yapmaz ancak c# tarafında x bir categoryinin productlarına erişim imkanı verir...
        public List<Product> Products { get; set; }
        
    }
}
