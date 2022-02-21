using System;

 namespace Kelime_ve_HarfSayisiniYazdirma
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle yazınız: ");

            string Cumle = Console.ReadLine();

            string[] Bosluklar = Cumle.Split(" ");

            Console.WriteLine("Kelime sayısı; " + Bosluklar.Count());
            Console.WriteLine("Harf sayısı; " + (Cumle.Length - Bosluklar.Count() + 1));
        }
     }
 }
