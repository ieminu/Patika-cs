using System;

 namespace TamBolenSayiYazdirma 
 {
     class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilecek sayı sayısını giriniz: ");
            int Input1 = Metotlar.TryStringToPositiveInt();

            Console.WriteLine("Bölünecek sayıyı giriniz: ");
            int Input2 = Metotlar.TryStringToPositiveInt();

            List<int> InputSayilar = new List<int>();

            for (int i = 1 ; i <= Input1 ; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ", i);
                InputSayilar.Add(Metotlar.TryStringToPositiveInt());
            }

            Console.WriteLine(Input2 + "saysını tam bölen sayılar; ");
            foreach (int Sayi in InputSayilar)
            {
                if (Input2 % Sayi == 0)
                    Console.WriteLine(Sayi);
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
