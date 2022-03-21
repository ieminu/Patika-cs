namespace ToDo_Uygulamasi
{
    class KonsolIslemleri
    {
        public static byte ConvertInputToInt()
        { 
            byte Sayi = 0;
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
                Sayi = byte.Parse(Girdi);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen bir sayı giriniz:\n");
                Girdi = Console.ReadLine();
                goto TryConvert;
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen 1'den 255'e kadar olan bir sayı giriniz:\n");
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