using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Başvuran bilgileri vs alınır
            // Birden fazla logg yollayacağımız için List ile yapıyoruz
            krediManager.Hesapla();
            foreach (var item in loggerService)
            {
                item.Log();
            } // Hangi loglayıcı seçilmişse sistemde onu logla dedik
        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediManagers)
        {
            foreach (var item in krediManagers)
            {
                item.Hesapla();
            }
        }
    }
}
