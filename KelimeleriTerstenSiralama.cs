using System;

 namespace KelimeleriTerstenSiralama
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilcek kelime sayısını giriniz: ");

            int Input = Metotlar.TryStringToPositiveInt();

            string[] Kelimeler = new string[Input];
            for (int i = 1 ; i <= Input ; i++)
            {
                Console.WriteLine("{0}. kelimeyi yazınız: " , i);
                Kelimeler[i-1] = Console.ReadLine();
            }

            Array.Reverse(Kelimeler);

            Console.WriteLine("Kelimelerin tersten sıralanışı; ");
            foreach (string kelime in Kelimeler)
                Console.WriteLine(kelime);
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

                if (Sayi <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                    TryInput();
                }  
            }
            
            return Sayi;
        }
     }
 }
