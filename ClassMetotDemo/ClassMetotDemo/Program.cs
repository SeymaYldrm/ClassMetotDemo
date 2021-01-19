using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Seyma";
            musteri1.Soyad = "Yıldırım";
            musteri1.musteriNo = 121530;

            Musteri musteri2 = new Musteri();

            musteri2.Ad = "Esma";
            musteri2.Soyad = "Kaya";
            musteri2.musteriNo = 506397;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteri1);
        }
    }
}
