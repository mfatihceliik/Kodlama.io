using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] 
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java" 
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i + ": " + kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach bitti -- Footer");
        }
    }
}
