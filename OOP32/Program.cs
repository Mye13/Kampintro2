using System;
using System.Collections.Generic;

namespace OOP32
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();
            
            ILoggerServices databaseLoggerService = new DataBaseLoggerService();
            ILoggerServices fileLoggerService = new FileLoggerService();
            ILoggerServices smsLoggerService = new SmsLoggerService();

            List<ILoggerServices> loggers = new List<ILoggerServices>() { databaseLoggerService, fileLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
