using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        int sonuc;
        public void Topla(int sayi1, int sayi2)
        {
            sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplamın sonucu : " + sonuc);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkarmanın sonucu : " + sonuc);
        }
        public void Carp(int sayi1, int sayi2)
        {
            sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpmanın sonucu : " + sonuc);
        }
        public void Bol(int sayi1, int sayi2)
        {
            sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölmenin sonucu : " + sonuc);
        }
    }
}
