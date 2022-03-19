namespace Telefon_Rehberi_Uygulamasi
{
    static class KonsolIslemleri
    {
        public static ulong ConvertInputToInt()
        { 
            ulong Sayi = 0;
            string Girdi = "";

            TryInput:

            Girdi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Girdi) == true)
            {
                Console.WriteLine();
                Console.WriteLine("Boş değer girdiniz! Tekrar deneyiniz:\n");
                goto TryInput;
            }

            TryConvert:

            try
            {
                Sayi = ulong.Parse(Girdi);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen bir sayı giriniz:\n");
                Girdi = Console.ReadLine();
                goto TryConvert;
            }
            
            return Sayi;
        }

        
        public static string CheckInputNotNull()
        {
            string Girdi = "";

            TryInput:

            Girdi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Girdi) == true)
            {
                Console.WriteLine();
                Console.WriteLine("Boş değer girdiniz! Tekrar deneyiniz:\n");
                goto TryInput;
            }

            return Girdi;
        }
    }
}