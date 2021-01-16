using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - diziler
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java" };

            //donguler
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].ToString());
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Sayi" + i);
            }
        }
    }
}
