using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst
{

    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Cinsiyet { get; set; }

        public Sinav Sinavlari { get; set; }
    }

    public class Sinav
    {
        public float Vize { get; set; }
        public float Final { get; set; }
        public float Ortalama { get; set; }
    }

    
}
