using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı; " + Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan sayısı; " + Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan3 = new Calisan("Yemin", "Elhasan", "IK");
            Console.WriteLine("Çalışan sayısı; " + Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu; " + Islemler.Topla(100, 200));
            Console.WriteLine("Toplama işlemi sonucu; " + Islemler.Cikar(400, 50));
        }
     }

    class Calisan
    {
        static int calisanSayisi;
        public static int CalisanSayisi {get => calisanSayisi;}

        string Isim;
        string SoyIsim;
        string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;
        }
        
        public static long Cikar(int Sayi1, int Sayi2)
        {
            return Sayi1 - Sayi2;
        }
    }
 }
