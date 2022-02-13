using System;
 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            try
            {
                int sayi1 = int.Parse("a");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Hata; veri tipi uygun değil.");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }


            try
            {
                int sayi2 = int.Parse(null);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Hata; Boş değer girdiniz.");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }


            try
            {
                int sayi3 = int.Parse("-20000000000");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Hata; Çok büyük veya çok küçük değer girdiniz.");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }
        }
     }
 }