namespace Telefon_Rehberi_Uygulamasi
{
    class _5Islem
    {
        public static void YeniNumaraKaydetme()
        {
            Kisiler Kisi = new Kisiler();

            Console.WriteLine();
            Console.WriteLine("İsim giriniz:\n");
            Kisi.Isim = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Soyisim giriniz:\n");
            Kisi.Soyisim = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Numara giriniz:\n");
            Kisi.Numara = Console.ReadLine();

            MainClass.KisiListesi.Add(Kisi);
            Console.WriteLine();
            Console.WriteLine(Kisi.Isim + " adlı kişi rehbere eklendi.");

            MainClass.Menu();
        }



        public static void VarolanNumarayiSilme()
        {
            Console.WriteLine();
            Console.WriteLine("Numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:\n");

            string GirilenIsimveyaSoyisim = KonsolIslemleri.CheckInputNotNull();
            bool KisiBulundu = false;

            foreach (Kisiler kisi in MainClass.KisiListesi)
                if (GirilenIsimveyaSoyisim.ToLower() == kisi.Isim.ToLower() || GirilenIsimveyaSoyisim.ToLower() == kisi.Soyisim.ToLower())
                {
                    KisiBulundu = true;

                    MainClass.KisiListesi.Remove(kisi);
                    KisiIsimleri.Remove(kisi.Isim);
                    Console.WriteLine();
                    Console.WriteLine(kisi.Isim + " adlı kişi rehberden silindi.");
                    MainClass.Menu();
                    break;
                }
            
            if (KisiBulundu == false)
            {
                Console.WriteLine();
                Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı. Lütfen bir seçim yapınız:\n");
                Console.WriteLine("(1) Tekrar deneme");
                Console.WriteLine("(2) Menüye dönme");
                Console.WriteLine();
                
                SayiInput:
                switch (KonsolIslemleri.ConvertInputToInt())
                {
                    case 1:
                        VarolanNumarayiSilme();
                    break;

                    case 2:
                        MainClass.Menu();
                    break;

                    default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                        goto SayiInput;
                    }
                }
            }
        }



        public static void VarolanNumarayiGuncelleme()
        {
            Console.WriteLine();
            Console.WriteLine("Numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:\n");

            string GirilenIsimveyaSoyisim = KonsolIslemleri.CheckInputNotNull();
            bool KisiBulundu = false;

            foreach (Kisiler kisi in MainClass.KisiListesi)
                if (GirilenIsimveyaSoyisim.ToLower() == kisi.Isim.ToLower() || GirilenIsimveyaSoyisim.ToLower() == kisi.Soyisim.ToLower())
                {
                    KisiBulundu = true;

                    Console.WriteLine();
                    Console.WriteLine("Yeni numarayı giriniz:\n");
                    string YeniNumara = Console.ReadLine();
                    kisi.Numara = YeniNumara;

                    Console.WriteLine();
                    Console.WriteLine(kisi.Isim + " adlı kişinin numarası güncellendi.");
                    MainClass.Menu();
                    break;
                }
            
            if (KisiBulundu == false)
            {
                Console.WriteLine();
                Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı. Lütfen bir seçim yapınız:\n");
                Console.WriteLine("(1) Tekrar deneme");
                Console.WriteLine("(2) Menüye dönme");
                Console.WriteLine();
                
                SayiInput:
                switch (KonsolIslemleri.ConvertInputToInt())
                {
                    case 1:
                        VarolanNumarayiGuncelleme();
                    break;

                    case 2:
                        MainClass.Menu();
                    break;

                    default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                        goto SayiInput;
                    }
                }
            }
        }



        public static List<string> KisiIsimleri = new();
        public static async void RehberiListeleme()
        {
            Console.WriteLine();
            Console.WriteLine("Listeleme şeklini seçiniz:\n");
            Console.WriteLine("(1) A-Z");
            Console.WriteLine("(2) Z-A");
            Console.WriteLine();

            char[] Harfler = {'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'};

            byte enUzunIsminHarfSayisi = 0;

            for (int i = 0; i < KisiIsimleri.Count; i++)
                if (enUzunIsminHarfSayisi < KisiIsimleri[i].Length)
                    enUzunIsminHarfSayisi = (byte)KisiIsimleri[i].Length;

            string BastanAlincakIsim;
            Kisiler BastanAlincakKisi;
            byte siralamaSayaci = 0;
            for (int i = 0; i < enUzunIsminHarfSayisi; i++)
            {
                foreach (char harf in Harfler)
                    for (int t = 0; t < KisiIsimleri.Count; t++)
                        if (KisiIsimleri[t].Length != i)
                            if (harf == KisiIsimleri[t].ToLower()[i])
                                if (i == 0)
                                {
                                    BastanAlincakIsim = KisiIsimleri[0 + siralamaSayaci];
                                    KisiIsimleri[0 + siralamaSayaci] = KisiIsimleri[t];
                                    KisiIsimleri[t] = BastanAlincakIsim;

                                    BastanAlincakKisi = MainClass.KisiListesi[0 + siralamaSayaci];
                                    MainClass.KisiListesi[0 + siralamaSayaci] = MainClass.KisiListesi[t];
                                    MainClass.KisiListesi[t] = BastanAlincakKisi;

                                    siralamaSayaci++;
                                }
                                else
                                {
                                    if (KisiIsimleri[t].ToLower()[i - 1] == KisiIsimleri[0 + siralamaSayaci].ToLower()[i - 1])
                                    {
                                        BastanAlincakIsim = KisiIsimleri[0 + siralamaSayaci];
                                        KisiIsimleri[0 + siralamaSayaci] = KisiIsimleri[t];
                                        KisiIsimleri[t] = BastanAlincakIsim;
                                            
                                        BastanAlincakKisi = MainClass.KisiListesi[0 + siralamaSayaci];
                                        MainClass.KisiListesi[0 + siralamaSayaci] = MainClass.KisiListesi[t];
                                        MainClass.KisiListesi[t] = BastanAlincakKisi;

                                        siralamaSayaci++;
                                    }
                                }

                siralamaSayaci = 0;
            }

            SayiInput:
            switch (KonsolIslemleri.ConvertInputToInt())
            {
                case 1:
                break;

                case 2:
                    MainClass.KisiListesi.Reverse();
                break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                    goto SayiInput;
            }

            Console.WriteLine();
            Console.WriteLine("TELEFON REHBERİ;");
            Console.WriteLine("---------------------------------------------\n");


            foreach (Kisiler kisi in MainClass.KisiListesi)
            {
                Console.WriteLine("İsim; " + kisi.Isim);
                Console.WriteLine("Soyisim; " + kisi.Soyisim);
                Console.WriteLine("Telefon Numarası; " + kisi.Numara);
                Console.WriteLine();
            }

            MainClass.Menu();
        }



        public static void RehberdeAramaYapma()
        {
            Console.WriteLine();
            Console.WriteLine("Arama tipini seçiniz:\n");
            Console.WriteLine("(1) İsim veya soyisime göre arama yapma");
            Console.WriteLine("(2) Telefon numarasına göre arama yapma");
            Console.WriteLine();
            
            string GirilenIsimveyaSoyisim = "";
            ulong GirilenTelefonNumarası = 0;
            bool KisiBulundu = false;

            SayiInput:
            
            switch (KonsolIslemleri.ConvertInputToInt())
            {
                case 1:
                {
                    Console.WriteLine();
                    Console.WriteLine("Aradığınız kişinin adını veya soyadını giriniz:\n");
                    GirilenIsimveyaSoyisim = KonsolIslemleri.CheckInputNotNull();
                    break;
                }

                case 2:
                {
                    Console.WriteLine();
                    Console.WriteLine("Aradığınız kişinin telefon numarasını giriniz:\n");
                    GirilenTelefonNumarası = KonsolIslemleri.ConvertInputToInt();
                    break;
                }

                default:
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                    goto SayiInput;
                }
            }

            foreach (Kisiler kisi in MainClass.KisiListesi)
            {
                if (GirilenIsimveyaSoyisim.ToLower() == kisi.Isim.ToLower()
                || GirilenIsimveyaSoyisim.ToLower() == kisi.Soyisim.ToLower()
                || GirilenTelefonNumarası == ulong.Parse(kisi.Numara))
                {
                    KisiBulundu = true;

                    Console.WriteLine();
                    Console.WriteLine("Aradığınız kişinin;");
                    Console.WriteLine("İsmi : " + kisi.Isim);
                    Console.WriteLine("Soyismi : " + kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası : " + kisi.Numara);

                    MainClass.Menu();
                    break;
                }

                if (KisiBulundu == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı. Lütfen bir seçim yapınız:\n");
                    Console.WriteLine("(1) Tekrar deneme");
                    Console.WriteLine("(2) Menüye dönme");
                    Console.WriteLine();

                    _SayiInput:
                    switch (KonsolIslemleri.ConvertInputToInt())
                    {
                        case 1:
                            RehberdeAramaYapma();
                        break;

                        case 2:
                            MainClass.Menu();
                        break;

                        default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen 1 veya 2 giriniz:\n");
                            goto _SayiInput;
                        }
                    }
                }
            }
        }
    }
}