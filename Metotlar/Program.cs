using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 20;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 30;

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi+ " " + "Fiyat -->" +  urun.Fiyati+ " " + "Ürün Açıklaması : " +  urun.Aciklama + " " + "Stok Adedi : "+ urun.StokAdedi);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("---------------Metotlar-----------------");

            //instance -- örnek
            //encapsulation 
            //Metotları 


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Kiraz", "Çok güzel kiraz", 12,50);
            
            Console.ReadLine();
        }
    }
}

//Do not repeat yourself (Kendini tekrar etme)