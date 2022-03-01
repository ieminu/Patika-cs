using System;

 namespace Namespace_name 
{
     class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. çalışanın bilgileri;");
            Console.WriteLine();

            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");

            calisan1.CalisaninBilgileri();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2. çalışanın bilgileri;");
            Console.WriteLine();

            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.Numara = 25646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisaninBilgileri();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("3. çalışanın bilgileri;");
            Console.WriteLine();

            Calisan calisan3 = new Calisan("Yemin", "Elhasan");
            calisan3.CalisaninBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int Numara;
        public string Departman;

        public Calisan(string ad, string soyad, int numara, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Numara = numara;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisaninBilgileri()
        {
            Console.WriteLine("Çalışanın adı; " + Ad);
            Console.WriteLine("Çalışanın soyadı; " + Soyad);
            Console.WriteLine("Çalışanın numarası; " + Numara);
            Console.WriteLine("Çalışanın Departmanı; " + Departman);
        }
    }
}
