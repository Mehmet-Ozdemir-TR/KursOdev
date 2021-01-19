using System;

namespace KursOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.SoyAd = "Özdemir";
            musteri1.Id = 1456;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Yoda";
            musteri2.SoyAd = "Kalisya";
            musteri2.Id = 1796;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Obivan";
            musteri3.SoyAd = "Kenobi";
            musteri3.Id = 25656;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

           

            MusteriManager musteriManger = new MusteriManager();
            musteriManger.Listeleme(musteriler);
            musteriManger.MusteriEkleme(musteri2);
            musteriManger.MusteriSil(musteri3);
        }
    }
}
