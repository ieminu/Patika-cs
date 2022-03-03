using System;

namespace Namespace_name 
{
     class MainClass
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Isim = "Ayşe";
            ogrenci1.SoyIsim = "Yılmaz";
            ogrenci1.Numara = 293;
            ogrenci1.Sinif = 3;

            ogrenci1.OgrenciBilgileriniYazdir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniYazdir();


            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);

            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniYazdir();
        }
    }

    class Ogrenci
    {
        string isim;
        string soyIsim;
        int numara;
        int sinif;


        public string Isim
        {
            get {return isim;}
            set {isim = value;}
        }
        public string SoyIsim {get => soyIsim; set => soyIsim = value;}
        public int Numara {get => numara; set => numara = value;}
        public int Sinif 
        {
            get => sinif;

            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");

                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyIsim, int numara, int sinif)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            Numara = numara;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniYazdir()
        {
            Console.WriteLine();
            Console.WriteLine("Öğrencinin Bilgileri;");
            Console.WriteLine();
            Console.WriteLine("Öğrencinin adı; " + this.Isim);
            Console.WriteLine("Öğrencinin soyadı; " + this.SoyIsim);
            Console.WriteLine("Öğrencinin numarası ; " + this.Numara);
            Console.WriteLine("Öğrencinin sınıfı; " + this.Sinif);
            Console.WriteLine();
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
