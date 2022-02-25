using System;
using System.Collections;
using System.Collections.Generic;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Ayşe");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add('A');

            foreach (var item in arrayList)
                Console.WriteLine(item);


            //AddRange:
            Console.WriteLine("<<<< AddRange >>>>");

            ArrayList Renkler = new ArrayList();
            ArrayList Sayilar = new ArrayList();

            string[] RenkDizisi = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> SayiListesi = new List<int>(){1, 8, 3, 7, 9, 92, 5};

            Renkler.AddRange(RenkDizisi);
            Sayilar.AddRange(SayiListesi);

            Console.WriteLine("Renkler;");
            foreach (string Renk in Renkler)
                Console.WriteLine(Renk);
                
            Console.WriteLine("Sayılar;");
            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);


            //Sort
            Console.WriteLine("<<<< Sort >>>>");

            Sayilar.Sort();

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);

            
            //BinarySearch
            Console.WriteLine("<<<< BinarySearch >>>>");

            Console.WriteLine(Sayilar.BinarySearch(9));


            //Reverse
            Console.WriteLine("<<<< Reverse >>>>");

            Sayilar.Reverse();

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);


            //Clear
            Console.WriteLine("<<<< Clear >>>>");

            Sayilar.Clear();
            
            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);
        }
    }
}