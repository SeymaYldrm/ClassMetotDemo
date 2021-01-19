using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriNo +"  "+ musteri.Ad + "  " + musteri.Soyad + " Kullanıcının Ekleme İşlemi Yapıldı.");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriNo + "  " + musteri.Ad + "  " + musteri.Soyad + " Kullanıcının Silme İşlemi Yapıldı.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriNo + "  " + musteri.Ad + "  " + musteri.Soyad + " Listeleme İşlemi Yapıldı.");
        }
    }
}
