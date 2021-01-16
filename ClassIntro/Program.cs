﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs3.KursAdi = "c";
            kurs3.Egitmeni = "Murat Kurtboğan";
            kurs3.İzlenmeOrani = 100;

            //   Console.WriteLine(kurs1.KursAdi + " \n " +kurs1.Egitmeni + " \n " + kurs1.İzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("\n");
                Console.WriteLine("kurs Adı:" + kurs.KursAdi);
                Console.WriteLine("Eğitmeni:" +kurs.Egitmeni);
                Console.WriteLine("İzlenme Oranı:" + kurs.İzlenmeOrani);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
