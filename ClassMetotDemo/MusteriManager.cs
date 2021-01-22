using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " isimli müşteri eklendi.");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " isimli müşteri bilgileri güncellendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " isimli müşteri bilgileri silindi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriDogumTarihi + "-->" + " müşteri bilgileri listelendi");
        }
        public void MevcutMusteriListele(Musteri[] musteri)
        {
            foreach (Musteri musterii in musteri)
            {
                Console.WriteLine(musterii.MusteriId);
                Console.WriteLine(musterii.MusteriAdi);
                Console.WriteLine(musterii.MusteriSoyadi);
                Console.WriteLine(musterii.MusteriDogumTarihi);

            }
        }
        public void Cizgi()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-*-*--*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine(" ");
        }


    }
}
