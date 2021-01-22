using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //bankada müşteri takibi yapmak
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Cengiz";
            musteri1.MusteriSoyadi = "Aytmatov";
            musteri1.MusteriDogumTarihi = 1928;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Ümit";
            musteri2.MusteriDogumTarihi = 1960;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Ahmet Hamdi";
            musteri3.MusteriSoyadi = "Tanpınar";
            musteri3.MusteriDogumTarihi = 1901;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MevcutMusteriListele(musteriler);
            musteriManager.Cizgi();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Cizgi();
            musteriManager.Ekle(musteri3);
            musteriManager.Cizgi();
            musteriManager.Guncelle(musteri2);
            musteriManager.Cizgi();
            musteriManager.Sil(musteri1);

        }
    }
}
