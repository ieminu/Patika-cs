using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Kendisine kadar ki tek sayıları yazdırılcak olan sayıyı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }


            int TekToplam = 0;
            int CiftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    TekToplam += i;
                else
                    CiftToplam += i;
            }

            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine("Cift Toplam: " + CiftToplam);

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
     }
 }