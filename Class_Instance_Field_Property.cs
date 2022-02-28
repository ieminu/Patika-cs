using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("1. çalışanın bilgileri;");
            Console.WriteLine();

            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.Numara = 23425634;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisaninBilgileri();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2. çalışanın bilgileri:");
            Console.WriteLine();

            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.Numara = 25646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisaninBilgileri();
        }
     }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int Numara;
        public string Departman;

        public void CalisaninBilgileri()
        {
            Console.WriteLine("Çalışanın adı; " + Ad);
            Console.WriteLine("Çalışanın soyadı; " + Soyad);
            Console.WriteLine("Çalışanın numarası; " + Numara);
            Console.WriteLine("Çalışanın Departmanı; " + Departman);
        }
    }
 }
