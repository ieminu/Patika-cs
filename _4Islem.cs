using System;
using System.Collections.Generic;

namespace ToDo_Uygulamasi
{
    class _4Islem
    {
        enum BuyuklukListesi
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }

        public static Dictionary<byte, string> Kisiler = new Dictionary<byte, string>();

        public static List<List<Kart>> TumKartlar = new();
        public static List<Kart> TODOLineKartlari = new();
        public static List<Kart> INPROGRESSLineKartlari = new();
        public static List<Kart> DONELineKartlari = new();



        public static void BoardiListeleme()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line");
            Console.WriteLine("---------------------------------------------\n");

            if (TODOLineKartlari.Count != 0)
            {
                foreach (Kart kart in TODOLineKartlari)
                {
                    Console.WriteLine("Başlık   ; " + kart.Baslik);
                    Console.WriteLine("İçerik   ; " + kart.Icerik);
                    Console.WriteLine("Büyüklük ; " + kart.Buyukluk);
                    Console.WriteLine("Kişi     ; " + kart.Kisi);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("~ BOŞ ~\n");
            }


            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("---------------------------------------------\n");

            if (INPROGRESSLineKartlari.Count != 0)
            {
                foreach (Kart kart in INPROGRESSLineKartlari)
                {
                    Console.WriteLine("Başlık   ; " + kart.Baslik);
                    Console.WriteLine("İçerik   ; " + kart.Icerik);
                    Console.WriteLine("Büyüklük ; " + kart.Buyukluk);
                    Console.WriteLine("Kişi     ; " + kart.Kisi);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("~ BOŞ ~\n");
            }


            Console.WriteLine();
            Console.WriteLine("DONE Line");
            Console.WriteLine("---------------------------------------------");

            if (DONELineKartlari.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("~ BOŞ ~\n");
            }
            else
            {
                foreach (Kart kart in DONELineKartlari)
                {
                    Console.WriteLine();
                    Console.WriteLine("Başlık   ; " + kart.Baslik);
                    Console.WriteLine("İçerik   ; " + kart.Icerik);
                    Console.WriteLine("Büyüklük ; " + kart.Buyukluk);
                    Console.WriteLine("Kişi     ; " + kart.Kisi);
                }

                Console.WriteLine();
            }

            MainClass.Menu();
        }
        


        public static void BoardaKartEkleme()
        {
            Console.WriteLine();
            Console.WriteLine("Başlık giriniz:\n");
            string InputBaslik = KonsolIslemleri.CheckInputNotNull();

            Console.WriteLine();
            Console.WriteLine("İçerik giriniz:\n");
            string InputIcerik = KonsolIslemleri.CheckInputNotNull();

            Console.WriteLine();
            Console.WriteLine("Büyüklük seçiniz -->  XS(1), S(2), M(3), L(4), XL(5) :\n");
            string InputBuyukluk = "";

            SayiInput:

            switch (KonsolIslemleri.ConvertInputToInt())
            {
                case 1:
                    InputBuyukluk = BuyuklukListesi.XS.ToString();
                    break;

                case 2:
                    InputBuyukluk = BuyuklukListesi.S.ToString();
                    break;

                case 3:
                    InputBuyukluk = BuyuklukListesi.M.ToString();
                    break;

                case 4:
                    InputBuyukluk = BuyuklukListesi.L.ToString();
                    break;

                case 5:
                    InputBuyukluk = BuyuklukListesi.XL.ToString();
                    break;

                default:
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen 1'den 5'e kadar olan bir sayı giriniz:\n");
                    goto SayiInput;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kişi ID seçiniz -->  Yemin(1), Mahmut(2), Doruk(3), Edanur(4), Nazlı(5) :\n");
            byte InputID = 0;

            _SayiInput:

            InputID = KonsolIslemleri.ConvertInputToInt();

            if (InputID > 5)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen 1'den 5'e kadar olan bir sayı giriniz:\n");
                goto _SayiInput;
            }

            string InputKisi = Kisiler[InputID];

            Kart kart = new(InputBaslik, InputIcerik, InputBuyukluk, InputKisi);
            TODOLineKartlari.Add(kart);

            Console.WriteLine();
            Console.WriteLine("'{0}' Başlıklı kart, TODO Line'a eklendi.\n", InputBaslik);

            MainClass.Menu();
        }
        


        public static void BoarddanKartSilme()
        {
            Console.WriteLine();
            Console.WriteLine("Silmek istediğiz kartın başlığını giriniz:\n");
            string InputBaslik = KonsolIslemleri.CheckInputNotNull();
            bool KartBulundu = false;

            foreach (var liste in TumKartlar)
            {
                int listeninElemanSayisi = liste.Count();
                int Fixed_i = 0;

                for (int i = 0; i < listeninElemanSayisi; i++, Fixed_i++)
                {
                    if (InputBaslik.ToLower() == liste[Fixed_i].Baslik.ToLower())
                    {
                        KartBulundu = true;

                        liste.Remove(liste[Fixed_i]);

                        Fixed_i--;
                    }
                }
            }

            if (KartBulundu == true)
            {
                Console.WriteLine();
                Console.WriteLine("'{0}' Başlıklı kart(lar) silindi.\n", InputBaslik);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Aradığınız kritere uygun kart bulunamadı! Bir seçim yapınız:\n");
                Console.WriteLine("(1) Menüye dönmek");
                Console.WriteLine("(2) Tekrar denemek");
                Console.WriteLine();

                SayiInput:
                
                switch (KonsolIslemleri.ConvertInputToInt())
                {
                    case 1:
                        break;

                    case 2:
                        BoarddanKartSilme();
                        break;
                        
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                        goto SayiInput;
                }
            }
            
            MainClass.Menu();
        }
        


        public static void KartTasima()
        {
            Console.WriteLine();
            Console.WriteLine("Taşımak istediğiniz kartın başlığını giriniz:\n");

            string InputBaslik = KonsolIslemleri.CheckInputNotNull();
            bool KartBulundu = false;
            Kart BulunanKart = new Kart();
            List<Kart> BulunanKartinBulunduguListe = new();
            string BulunanKartinBulunduguListeIsmi = "";

            foreach (var liste in TumKartlar)
            {
                for (int i = 0; i < liste.Count(); i++)
                {
                    if (InputBaslik.ToLower() == liste[i].Baslik.ToLower())
                    {
                        KartBulundu = true;
                        BulunanKart = liste[i];
                        BulunanKartinBulunduguListe = liste;
                        
                        if (liste == TODOLineKartlari)
                            BulunanKartinBulunduguListeIsmi = "TODO";

                        else if (liste == INPROGRESSLineKartlari)
                            BulunanKartinBulunduguListeIsmi = "IN PROGRESS";

                        else
                            BulunanKartinBulunduguListeIsmi = "DONE";

                        break;
                    }
                }
            }

            if (KartBulundu == true)
            {
                Console.WriteLine();
                Console.WriteLine("Bulunan kartın bilgileri;\n");
                Console.WriteLine("Başlık   : " + BulunanKart.Baslik);
                Console.WriteLine("İçerik   : " + BulunanKart.Icerik);
                Console.WriteLine("Kişi     : " + BulunanKart.Kisi);
                Console.WriteLine("Büyüklük : " + BulunanKart.Buyukluk);
                Console.WriteLine("Line     : " + BulunanKartinBulunduguListeIsmi);
                Console.WriteLine();
                Console.WriteLine("Taşınacağı Line'ı seçiniz:\n");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                Console.WriteLine();

                int BulunanKartinBulunduguListeninIndexi = TumKartlar.IndexOf(BulunanKartinBulunduguListe);
                TumKartlar[BulunanKartinBulunduguListeninIndexi].Remove(BulunanKart);

                _SayiInput:

                switch (KonsolIslemleri.ConvertInputToInt())
                {
                    case 1:
                        TODOLineKartlari.Add(BulunanKart);
                        Console.WriteLine();
                        Console.WriteLine("Kart, TODO Line'a taşındı.\n");
                        break;
                        
                    case 2:
                        INPROGRESSLineKartlari.Add(BulunanKart);
                        Console.WriteLine();
                        Console.WriteLine("Kart, IN PROGRESS Line'a taşındı.\n");
                        break;
                        
                    case 3:
                        DONELineKartlari.Add(BulunanKart);
                        Console.WriteLine();
                        Console.WriteLine("Kart, DONE Line'a taşındı.\n");
                        break;

                    default :
                        Console.WriteLine();
                        Console.WriteLine("Lütfen 1, 2 veya 3 giriniz:\n");
                        goto _SayiInput;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Aradığınız kritere uygun kart bulunamadı! Bir seçim yapınız:\n");
                Console.WriteLine("(1) Menüye dönmek");
                Console.WriteLine("(2) Tekrar denemek");
                Console.WriteLine();

                SayiInput:

                switch (KonsolIslemleri.ConvertInputToInt())
                {
                    case 1:
                        break;

                    case 2:
                        KartTasima();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                        goto SayiInput;
                }
            }

            MainClass.Menu();
        }
    }
}