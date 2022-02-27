using System;
using System.Collections;

namespace KoleksiyonLar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> GirilenSayilar = new List<int>();
            List<int> EnBuyuk3Sayi = new List<int>();
            List<int> EnKucuk3Sayi = new List<int>();

            Console.WriteLine("20 adet sayı giriniz: ");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ", i);
                GirilenSayilar.Add(Metotlar.TryStringToPositiveInt());
            }

            Console.WriteLine();
            Console.WriteLine();

            GirilenSayilar.Sort();
            GirilenSayilar.Reverse();

            for (int i = 1; i <= 3 ; i++)
            {
                EnBuyuk3Sayi.Add(GirilenSayilar[0]);
                GirilenSayilar.RemoveAt(0);

                EnKucuk3Sayi.Add(GirilenSayilar[GirilenSayilar.Count - 1]);
                GirilenSayilar.RemoveAt(GirilenSayilar.Count - 1);
            }

            float EnBuyuk3SayininOrtalamasi = (EnBuyuk3Sayi[0] + EnBuyuk3Sayi[1] + EnBuyuk3Sayi[2]) / 3f;

            Console.WriteLine("En büyük 3 sayının ortalaması; " + EnBuyuk3SayininOrtalamasi);
            Console.WriteLine();

            
            float EnKucuk3SayininOrtalamasi = (EnKucuk3Sayi[0] + EnKucuk3Sayi[1] + EnKucuk3Sayi[2]) / 3f;

            Console.WriteLine("En küçük 3 sayının ortalaması; " + EnKucuk3SayininOrtalamasi);
            Console.WriteLine();


            float OrtalamalarinOrtalamasi = (EnBuyuk3SayininOrtalamasi + EnKucuk3SayininOrtalamasi) / 2f;

            Console.WriteLine("Ortalamaların Ortalaması; " + OrtalamalarinOrtalamasi);            
        }
    }
    
     static class Metotlar
     {
        public static int TryStringToPositiveInt()
        { 
            int Sayi = 0;
            
            TryInput();

            void TryInput()
            {
                try
                {
                    Sayi = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz: ");
                    TryInput();
                }
            }
            
            return Sayi;
        }
     }
}