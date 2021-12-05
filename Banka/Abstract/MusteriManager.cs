using Banka.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Abstract
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }        
    }
}
