using System.Collections;

namespace Telefon_Rehberi_Uygulamasi
{
    class Kisiler
    {
        string isim;
        string soyisim;
        string numara;


        public string Isim
        {
            get
            {
                return isim;
            }
            set
            {
                TryInput:

                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Boş değer girdiniz! Tekrar deneyiniz:\n");
                    value = Console.ReadLine();
                    goto TryInput;
                }

                isim = value;
            }
        }
        public string Soyisim
        {
            get
            {
                return soyisim;
            }
            set
            {
                TryInput:

                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Boş değer girdiniz! Tekrar deneyiniz:\n");
                    value = Console.ReadLine();
                    goto TryInput;
                }

                soyisim = value;
            }
        }
        public string Numara
        {
            get
            {
                return numara;
            }
            set
            {
                TryInput:

                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Boş değer girdiniz! Tekrar deneyiniz:\n");
                    value = Console.ReadLine();
                    goto TryInput;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    bool HarfYok = char.IsNumber(value[i]);

                    if (HarfYok != true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Geçersiz karakter girdiniz! Lütfen sayı giriniz:\n");
                        value = Console.ReadLine();
                        goto TryInput;
                    }
                }

                numara = value;
            }
        }

        public Kisiler(string isim, string soyisim, string numara)
        {
            Isim = isim;
            Soyisim = soyisim;
            Numara = numara;
        }
        public Kisiler(){}
    }
}