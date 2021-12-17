using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //Method injection
        //Birden fazla logger ile çalışabilir.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //Başvuru bilgileri değerlendirme 

            krediManager.Hesapla();

            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
