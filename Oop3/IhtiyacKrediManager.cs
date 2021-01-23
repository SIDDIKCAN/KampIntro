using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //IKrediManager'dan implement ettim
    class IhtiyacKrediManager : IKrediManager
    {
        //Hesapla metodu IKrediManager'dan geliyor.Burda IhtiyacKrediManager'ın işlemlerini yaptım
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
