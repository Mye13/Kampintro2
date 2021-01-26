using System;
using System.Collections.Generic;
using System.Text;

namespace OOP32
{
    class BasvuruManager
    {
        public  void BasvuruYap(IKrediManager krediManager, List<ILoggerServices> loggerServices)
        {
            //Başvuran bilgilerini değerlendir
            //...

            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }

        public  void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); 
            }
        }
    }
}
