using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mustafa Gözcü için;


            //Gerçek Müşteri (Şahıs) - Tüzel Müşteri (Şirket)
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Gözcü";
            musteri1.TcNo = "777777777";
            //SOLID (L)


            //Berkan Türel
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54789";
            musteri2.SirketAdi = "Türel";
            musteri2.VergiNo = "1234564567897";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Musteri classı hem GercekMusterinin referansını hemde TuzelMusterinin referansını tutuyor..  

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}
