using System;

 namespace Koleksiyonlar_Soru_3
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            char[] SesliHarfler = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> CumledekiSesliHarfler = new List<char>();

            Console.WriteLine("Bir cümle giriniz: ");
            string Cumle = Console.ReadLine();

            foreach (char Harf in SesliHarfler)
                for (int i = 0 ; i < Cumle.Length ; i++)
                    if (Cumle[i] == Harf)
                        CumledekiSesliHarfler.Add(Cumle[i]);


            Console.WriteLine("Cümledeki sesli harfler; ");

            CumledekiSesliHarfler.ForEach(Harf => Console.WriteLine(Harf + " "));
        }
     }
 }
