using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetot
{
    public class Musteri
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public long TC { get; set; }
        public decimal Bakiye { get; set; }
        public bool Durum { get; set; }
    }
}
