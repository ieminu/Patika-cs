using System;

 namespace CiftSayiYazdirma
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilecek sayı sayısını giriniz: ");

            int input = Metotlar.TryStringToPositiveInt();

            List<int> InputSayilar = new List<int>();

            for (int i = 1 ; i <= input ; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: " , i);
                InputSayilar.Add(Metotlar.TryStringToPositiveInt());
            }

            Console.WriteLine("Çift sayılar; ");
            foreach (int Sayi in InputSayilar)
            {
                if (Sayi % 2 == 0)
                {
                    Console.WriteLine(Sayi);
                }
            }
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
