using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Kendisine kadar ki sayıların ortalaması hesaplancak sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int Toplam = 0;

            while(sayac <= sayi)
            {
                Toplam += sayac;
                sayac++;
            }

            Console.WriteLine(Toplam/sayi);


            //a'dan z'ye kadar ki tüm harfleri console'a yazdırma:
            char karakter = 'a';

            while(karakter <= 'z')
            {
                Console.Write(karakter + " ");
                karakter++;
            }

            Console.WriteLine();
            string[] ArabaMarkaları = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach(var ArabaMarkası in ArabaMarkaları)
            {
                Console.WriteLine(ArabaMarkası);
            }
        }
     }
 }