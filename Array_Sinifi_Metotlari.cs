using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            int[] Sayilar = {23, 12, 4, 86, 72, 3, 11, 17};

            Console.WriteLine("<<<< Başlangıçta ki dizi sırası >>>>");

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);

                
            Console.WriteLine("<<<< Array Sort >>>>");

            Array.Sort(Sayilar); //Diziyi küçükten büyüğe doğru sıralar.

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);

                
            Console.WriteLine("<<<< Array Clear >>>>");

            Array.Clear(Sayilar, 2, 2); //2. parametrede belirtilen index'ten itibaren 3. parametrede belirtilen uzunluğa kadar olan verileri sıfırlar.

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);


            Console.WriteLine("<<<< Array Reverse >>>>");

            Array.Reverse(Sayilar); //Dizide bulunan elemanları sırasını ters çevirir.

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);


            Console.WriteLine("<<<< Array IndexOf >>>>");
            Console.WriteLine(Array.IndexOf(Sayilar, 23)); //2. parametrede belirtilen sayıyı bulup index'ini yazar.


            Console.WriteLine("<<<< Array Resize >>>>");

            Array.Resize<int>(ref Sayilar, 9); //Dizinin büyüklüğünü değiştirir.
            Sayilar[8] = 99;

            foreach (int Sayi in Sayilar)
                Console.WriteLine(Sayi);
        }
     }
 }
