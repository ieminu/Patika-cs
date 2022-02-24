using System;
using System.Collections.Generic;

 namespace Namespace_name 
{
     class MainClass
    {
        static void Main(string[] args)
        {
            //List oluşturma:

            List<int> SayiListesi = new List<int>();
            SayiListesi.Add(23);
            SayiListesi.Add(10);
            SayiListesi.Add(4);
            SayiListesi.Add(5);
            SayiListesi.Add(92);
            SayiListesi.Add(34);

            List<string> RenkListesi = new List<string>();
            RenkListesi.Add("Kırmızı");
            RenkListesi.Add("Mavi");
            RenkListesi.Add("Turuncu");
            RenkListesi.Add("Sarı");
            RenkListesi.Add("Yeşil");


            //List elemanlarını Console'a yazdırma:

            foreach (int Sayi in SayiListesi)
                Console.WriteLine(Sayi);
            foreach (string Renk in RenkListesi)
                Console.WriteLine(Renk);

            SayiListesi.ForEach(Sayi => Console.WriteLine(Sayi));
            RenkListesi.ForEach(Renk => Console.WriteLine(Renk));


            //List işlemleri:

            //Eleman sayısını bulma;
            Console.WriteLine(SayiListesi.Count);
            Console.WriteLine(RenkListesi.Count);

            //Eleman çıkarma;
            SayiListesi.Remove(4);
            RenkListesi.Remove("Yeşil");

            SayiListesi.RemoveAt(0);
            RenkListesi.RemoveAt(1);

            SayiListesi.ForEach(Sayi => Console.WriteLine(Sayi));
            RenkListesi.ForEach(Renk => Console.WriteLine(Renk));

            //Eleman arama;
            if (SayiListesi.Contains(10));
                Console.WriteLine("10 sayısı bulundu");

            //Eleman ile index'e erişme;
            Console.WriteLine(RenkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme;
            string[] Hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> HayvanListesi = new List<string>(Hayvanlar);

            //List'i temizleme;
            HayvanListesi.Clear();

            //List içerisinde nesne tutmak;
            List<Kullanicilar> KullaniciListesi = new List<Kullanicilar>();

            Kullanicilar Kullanici1 = new Kullanicilar();
            Kullanici1.Isim = "Ayşe";
            Kullanici1.Soyisim = "Yılmaz";
            Kullanici1.Yas = 26;

            Kullanicilar Kullanici2 = new Kullanicilar();
            Kullanici2.Isim = "Özcan";
            Kullanici2.Soyisim = "Çalışkan";
            Kullanici2.Yas = 26;

            KullaniciListesi.Add(Kullanici1);
            KullaniciListesi.Add(Kullanici2);

            List<Kullanicilar> YeniListe = new List<Kullanicilar>();

            YeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var Kullanici in KullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı; " + Kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı; " + Kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı; " + Kullanici.Yas);
            }

            YeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim {get => isim; set => isim = value;}
        public string Soyisim {get => soyisim; set => soyisim = value;}
        public int Yas {get => yas; set => yas = value;}
    }
}
