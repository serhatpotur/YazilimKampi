using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseService = new DatabaseLoggerService();
            ILoggerService fileloger = new FileLoggerService();
            ILoggerService smslogger = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };
            // list ile çoklu loglama yaptık



            // hangi kredi türünü seçersek onu seçeriz
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager, databaseService);
            //basvuruManager.BasvuruYap(tasitKrediManager, fileloger);
            basvuruManager.BasvuruYap(konutKrediManager, loggers);

            List<IKrediManager> krediManagers = new List<IKrediManager>() { ıhtiyacKrediManager, tasitKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmeYap(krediManagers);

        }
    }
}
