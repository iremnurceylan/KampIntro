using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirici kampi";
            string kurs2 = " java egitim kampı ";
            string kurs3 = " c# kampı";
            // boyle tek tek yazmak icin array = dizi tanımlamır

            string[] kurslar = new string[] {"yazılım gelistirici kampı" , "java egitim kampı", "c# kampı" };

           for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti ");
            // foreach kullanımı
            //dizi temelli ysapıları tek tek donmeyı saglar dizlere uygulanır
            //' in kurslar'kursları tek tek dolas demek
            //'kurs' yazılan kısma istedigini yazabılırsın orası takma isimdir kurslar icerikli oldugu icin anlamlı olması ıcın kurs yazdık
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
           
            string kategoriEtiketi = "kategori";
            Console.WriteLine(kategoriEtiketi);

      
            }
    
    }
}
