using System;

namespace DeğerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar3 = new int[] { 10, 20, 30 };
            int[] sayilar4 = new int[] { 100, 200, 300 };
            sayilar3 = sayilar4;
            sayilar4[0] = 999;
            Console.WriteLine(sayilar3[0]);
        }
    }
}
