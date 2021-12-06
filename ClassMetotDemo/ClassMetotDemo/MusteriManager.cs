using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine(musteri.Id+" " + musteri.Ad + " " + musteri.Soyad + " " +musteri.TelefonNumarası);

        }

        public  void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine(musteri.Id + " " +musteri.Ad + " " +musteri.Soyad + " " +musteri.TelefonNumarası);
        }   

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi");
            Console.WriteLine(musteri.Id + " " +musteri.Ad + " " +musteri.Soyad + " " +musteri.TelefonNumarası);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi");
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " +musteri.Soyad + " " +musteri.TelefonNumarası);
        }

        internal void MusteriGuncelle(string soyad)
        {
            throw new NotImplementedException();
        }
    }
}
