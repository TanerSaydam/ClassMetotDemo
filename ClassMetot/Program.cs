using System;
using System.Collections.Generic;

namespace ClassMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { MusteriAdi = "Taner"};            
            Musteri musteri2 = new Musteri() { MusteriAdi = "Seval"};            
            Musteri musteri3 = new Musteri() { MusteriAdi = "Tugay"};            


            //Ekleme
            MusteriManager musteri = new MusteriManager();
            musteri.MusteriEkle(musteri1);
            musteri.MusteriEkle(musteri2);
            musteri.MusteriEkle(musteri3);
            Console.WriteLine("-----------------------------");
            //Silme
            musteri.MusteriSil(musteri2);
            musteri.MusteriSil(musteri1);
            Console.WriteLine("-----------------------------");
            //Güncelleme
            musteri.MusteriGuncelle(musteri3);
            Console.WriteLine("-----------------------------");
            //Listeleme
            List<Musteri> deger = new List<Musteri>();
            deger.Add(musteri1);
            deger.Add(musteri2);
            deger.Add(musteri3);

            int say = 0;
            foreach (var item in deger)
            {
                say++;
                Console.WriteLine("Müşteriler " + say + " : " + item.MusteriAdi);
            }


            Console.ReadLine();
        }
    }
}
