using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtıyacKrediManager = new IhtiyacKrediManager();
            // ÖNEMLİ !! Interfaceler de, o interface'i implemente eden classın referans numarasını tutabiliyormuş.O yüzden asagıdakı kullanım dogrudur.
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();


            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggers);

           // List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasıtKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
