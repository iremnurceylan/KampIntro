using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // metotlar tekrar tekrar aynı şeyi kullanmamızı sağlar
            // Dont repeat yourself -- kendını tekrar etme!!!

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması ";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu ";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach  (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("--------------------Metotlar----------------------------------");
            // instance -- örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,13);
            sepetManager.Ekle2("elma", "yeşil elma ", 12,34);


        }
    }
}
