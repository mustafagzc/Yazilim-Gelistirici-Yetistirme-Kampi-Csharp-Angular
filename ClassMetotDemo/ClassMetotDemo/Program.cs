using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11;
            musteri1.Ad = "Mustafa";
            musteri1.Soyad = "Gözcü";
            musteri1.TelefonNumarası = 111111111;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 07;
            musteri2.Ad = "Elif";
            musteri2.Soyad = "Gözcü";
            musteri2.TelefonNumarası = 1447945464;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 17;
            musteri3.Ad = "Osman";
            musteri3.Soyad = "Gözcü";
            musteri3.TelefonNumarası = 31341421;


            Musteri musteri4 = new Musteri();
            musteri4.Id = 1107;
            musteri4.Ad = "Hilal";
            musteri4.Soyad = "Gözcü";
            musteri4.TelefonNumarası = 45457878;

            //METOTLARI ÇAĞIRMA
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine();
            musteriManager.MusteriGuncelle(musteri2);
            Console.WriteLine();
            musteriManager.MusteriListele(musteri4);
            Console.WriteLine();
            musteriManager.MusteriSil(musteri3);

            Console.Read();
          
           
        }
    }
}
