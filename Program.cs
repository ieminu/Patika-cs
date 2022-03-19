using System;

namespace Telefon_Rehberi_Uygulamasi
{
     class MainClass
    {
        public static List<Kisiler> KisiListesi = new List<Kisiler>();

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("(1) Yeni Numara Kaydetme");
            Console.WriteLine("(2) Varolan Numarayı Silme");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listeleme");
            Console.WriteLine("(5) Rehberde Arama Yapma");
            Console.WriteLine();

            SayiInput:
            switch (KonsolIslemleri.ConvertInputToInt())
            {
                case 1 : _5Islem.YeniNumaraKaydetme();
                break;

                case 2 : _5Islem.VarolanNumarayiSilme();
                break;

                case 3 : _5Islem.VarolanNumarayiGuncelleme();
                break;

                case 4 : _5Islem.RehberiListeleme();
                break;

                case 5 : _5Islem.RehberdeAramaYapma();
                break;

                default :Console.WriteLine("Lütfen 1'den 5'e kadar olan bir sayı giriniz:\n"); goto SayiInput;
            }
        }

        public static void IlkIslemler()
        {
            Kisiler Kisi1 = new Kisiler("Eren", "Çelik", "5330987610");
            Kisiler Kisi2 = new Kisiler("Kemal", "Çiftçi", "5371989315");
            Kisiler Kisi3 = new Kisiler("Orçun", "İşkol", "5367686645");
            Kisiler Kisi4 = new Kisiler("Doruk", "Demir", "5382188359");
            Kisiler Kisi5 = new Kisiler("Dilek", "Süleymanoğlu", "5380984031");

            KisiListesi.Add(Kisi1);
            KisiListesi.Add(Kisi2);
            KisiListesi.Add(Kisi3);
            KisiListesi.Add(Kisi4);
            KisiListesi.Add(Kisi5);
            
            foreach (Kisiler kisi in MainClass.KisiListesi)
                _5Islem.KisiIsimleri.Add(kisi.Isim);
        }
        
        static void Main(string[] args)
        {
            IlkIslemler();
            Menu();
        }
    }
}
