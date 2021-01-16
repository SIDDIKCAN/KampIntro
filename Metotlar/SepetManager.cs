using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention --> Metotların ilk harfi büyük harfle başlar
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler." + " " + urun.Adi + " " +  "Sepete Eklendi!");
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler." + " " + urunAdi + " " + "Sepete Eklendi!");
        }
    }
}
