using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a+b);

            int Toplam = Topla(a, b);
            Console.WriteLine(Toplam);

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir(Convert.ToString(Toplam));

            int Toplam2 = metotlar.ArttirVeTopla(ref a, ref b);
            metotlar.EkranaYazdir(Convert.ToString(Toplam2));
            metotlar.EkranaYazdir(Convert.ToString(a + b));

            static int Topla(int Value1, int Value2)
            {
                return Value1 + Value2;
            }
        }
     }

     class Metotlar
     {
         public void EkranaYazdir(string veri)
         {
            Console.WriteLine(veri);
         }

         public int ArttirVeTopla(ref int Value1, ref int Value2)
         {
             Value1 += 1;
             Value2 += 1;
             return Value1 + Value2;
         }
     }
 }
