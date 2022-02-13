
using System;

 namespace Console_programlama 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Adını Gir");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyadını Gir");
            string soyad = Console.ReadLine();

            Console.WriteLine("Merhaba " + ad + " " + soyad);
        }
     }
 }