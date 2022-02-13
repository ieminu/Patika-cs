using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            int saat = DateTime.Now.Hour;

            if (saat >= 6 && saat <= 11)
            {
                Console.WriteLine("Günaydın!");
            }

            else if (saat <= 18)
            {
                Console.WriteLine("İyi Günler!");
            }

            else
            {
                Console.WriteLine("İyi Geceler");
            }


            string mesaj = saat >= 6 && saat <= 11 ? "Günaydın!" : saat <= 18 ? "İyi Günler!" : "İyi Geceler!";

            Console.WriteLine(mesaj);
        }
     }
 }