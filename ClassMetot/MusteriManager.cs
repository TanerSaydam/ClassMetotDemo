using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetot
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.MusteriAdi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.MusteriAdi);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi : " + musteri.MusteriAdi);
        }
    }
}
