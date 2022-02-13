using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            //Dizi tanımlama yöntemleri :

            int[] AsalSayilar;
            AsalSayilar = new int[4];
            AsalSayilar[2] = 5;

            string[] Renkler = new string[4];
            Renkler[1] = "mavi";

            string[] Hayvanlar = {"kedi", "köpek", "balık", "sincap"};

            Console.WriteLine(AsalSayilar[2] + " " + Renkler[1] + " " + Hayvanlar[0]);


            //Döngülerle Dizi Kullanımı :

            Console.Write("Dizinin eleman sayısını giriniz: ");
            int DiziUzunlugu = int.Parse(Console.ReadLine());
            int[] Sayilar = new int[DiziUzunlugu];

            for (int i = 1; i <= DiziUzunlugu; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: " , i);
                Sayilar[i-1] = int.Parse(Console.ReadLine());
            }

            float Toplam = 0;

            foreach (var Sayi in Sayilar)
                Toplam += Sayi;

            Console.WriteLine("Ortalama: " + Toplam/DiziUzunlugu);
        }
     }
 }