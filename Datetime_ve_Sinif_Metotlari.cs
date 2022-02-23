using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<< DateTime >>>>");

            Console.WriteLine(DateTime.Now); //Şuan ki tarih & Saat
            Console.WriteLine(DateTime.Now.Date); //Şuan ki tarih
            Console.WriteLine(DateTime.Now.Day); //Şuan ki ayın kaçıncı günü
            Console.WriteLine(DateTime.Now.Month); //Şuan ki yılın kaçıncı ayı
            Console.WriteLine(DateTime.Now.Year); //Şuan ki yıl
            Console.WriteLine(DateTime.Now.Hour); //Şuan ki saat
            Console.WriteLine(DateTime.Now.Minute); //Şuan ki dakika
            Console.WriteLine(DateTime.Now.Second); //Şuan ki saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); //Haftanın hangi günü
            Console.WriteLine(DateTime.Now.DayOfYear); //Yılın kaçıncı günü

            Console.WriteLine(DateTime.Now.ToLongDateString()); //string şeklinde şuan ki tarih
            Console.WriteLine(DateTime.Now.ToShortDateString()); //Şuan ki tarih
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //Şuan ki saat & dakika & saniye
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //Şuan ki saat & dakika

            Console.WriteLine(DateTime.Now.AddDays(2)); //Şuan ki tarihin 2 gün sonrası
            Console.WriteLine(DateTime.Now.AddHours(3)); //Şuan ki tarihin 3 saat sonrası
            Console.WriteLine(DateTime.Now.AddSeconds(30)); //Şuan ki tarihin 30 saniye sonrası
            Console.WriteLine(DateTime.Now.AddMonths(5)); //Şuan ki tarihin 5 ay sonrası
            Console.WriteLine(DateTime.Now.AddYears(10)); //Şuan ki tarihin 10 yıl sonrası
            Console.WriteLine(DateTime.Now.AddMilliseconds(50)); //Şuan ki tarihin 50 salise sonrası

            Console.WriteLine(DateTime.Now.ToString("dd")); //Şuan ki ayın kaçıncı günü
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Şuan ki günün adının kısaltılışı
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Şuan ki günün adı

            Console.WriteLine(DateTime.Now.ToString("MM")); //Şuan ki yılın kaçıncı ayı
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Şuan ki ayın adının kısaltılışı
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Şuan ki ayın adı

            Console.WriteLine(DateTime.Now.ToString("yy")); //Şuan ki yılın kısaltılışı
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //Şuan ki yıl


            Console.WriteLine("<<<< Math >>>>");

            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10)); //-0.5440211108893698
            Console.WriteLine(Math.Cos(10)); //-0.8390715290764524
            Console.WriteLine(Math.Tan(10)); //0.6483608274590866

            Console.WriteLine(Math.Ceiling(22.1)); //23
            Console.WriteLine(Math.Round(22.6)); //23
            Console.WriteLine(Math.Round(22.4)); //22
            Console.WriteLine(Math.Floor(22.9)); //22

            Console.WriteLine(Math.Max(2, 6)); //6
            Console.WriteLine(Math.Min(2, 6)); //2

            Console.WriteLine(Math.Pow(3, 4)); //81
            Console.WriteLine(Math.Sqrt(9)); //3
            Console.WriteLine(Math.Log(9)); //2.1972245773362196
            Console.WriteLine(Math.Exp(3)); //20.085536923187668
            Console.WriteLine(Math.Log10(10)); //1
        }
     }
 }
