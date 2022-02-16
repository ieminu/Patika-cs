using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            //out parametreler:

            string stringSayi = "100";
            bool Basarili = int.TryParse(stringSayi, out int IntSayi);

            if (Basarili == true)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(IntSayi);
            }
            else
                Console.WriteLine("Başarısız!");


            Metotlar metotlar = new Metotlar();

            metotlar.Topla(4, 5, out int Toplam);
            Console.WriteLine(Toplam);


            //Metot aşırı yükleme - Overloading:

            int Sayi = 15;

            metotlar.EkranaYazdir(Convert.ToString(Sayi));
            metotlar.EkranaYazdir(Sayi);
            metotlar.EkranaYazdir("Yemin", "Elhasan");

            //Metot İmzası:
            //Metot adı, parametre sayısı, parametre tipi.
        }
     }

     class Metotlar
     {
         public void Topla(int a, int b, out int Toplam)
         {
             Toplam = a + b;             
         }

         public void EkranaYazdir(string veri)
         {
             Console.WriteLine(veri);
         }

         public void EkranaYazdir(int veri)
         {
             Console.WriteLine(veri);
         }

         public void EkranaYazdir(string veri1, string veri2)
         {
             Console.WriteLine(veri1 + " " + veri2);
         }
     }
 }
