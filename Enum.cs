using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int Sicaklik = 31;

            string mesaj = 
            Sicaklik < (int)HavaDurumu.Normal ? "Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.."
            : Sicaklik >= (int)HavaDurumu.Sicak ? "Dışarıya çıkmak için fazla sıcak bir gün.."
            : "Hadi dışarıya çıkalım!";

            Console.WriteLine(mesaj);
        }
     }

    enum Gunler
    {
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 15,
        Sicak = 25,
        CokSicak = 30
    }
 }
