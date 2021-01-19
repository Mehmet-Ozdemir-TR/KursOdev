using System;
using System.Collections.Generic;
using System.Text;

namespace KursOdev
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri yeni)
        {
            Console.WriteLine(yeni.Adi + " " + yeni.SoyAd + " :Bankamıza Hoşgeldiniz !");
        }
        public void MusteriSil(Musteri silme)
        {
            Console.WriteLine(silme.Adi + " " + silme.SoyAd + " :Bankamızdan ayrıldınız !");
        }
        public void Listeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAd);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("*****************************************");
            }
        }
    }
}
