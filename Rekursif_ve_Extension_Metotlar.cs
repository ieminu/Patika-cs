using System;

 namespace Namespace_name 
 {
    class MainClass
    {
        static void Main(string[] args)
        {
            //Rekorsif - Öz yenilemeli:
                //3 üssü 4;

            int Result = 1;

            for (int i = 1 ; i <= 4 ; i++)
                Result = Result * 3;

            Console.WriteLine(Result);

            Islemler islemler = new();
            Console.WriteLine(islemler.Expo(3, 4));


            //Extension Metotlar:

            string ifade = "Yemin Elhasan";
            bool Sonuc = ifade.CheckSpaces();

            Console.WriteLine(Sonuc);

            if (Sonuc == true)
                Console.WriteLine(ifade.RemoveWhiteSpaces());


            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());


            int[] Dizi = {9, 3, 6, 2, 1, 5, 0};

            Dizi.SortArray();
            Dizi.EkranaYazdir();


            int sayi = 5;

            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCaracter());
        }
    }
    public class Islemler
    {
        public int Expo(int taban, int us)
        {
            if (us <= 2)
                return taban;

            return Expo(taban, us - 1) * 3;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string parametre)
        {
            return parametre.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string parametre)
        {
            string[] dizi = parametre.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string parametre)
        {
            return parametre.ToUpper();
        }
        
        public static string MakeLowerCase(this string parametre)
        {
            return parametre.ToLower();
        }

        public static int[] SortArray(this int[] parametre)
        {
            Array.Sort(parametre);
            return parametre;
        }

        public static void EkranaYazdir(this int[] parametre)
        {
            foreach (int item in parametre)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int parametre)
        {
            return parametre % 2 == 0;
        }

        public static string GetFirstCaracter(this string parametre)
        {
            return parametre.Substring(0, 1);
        }
    }
}
