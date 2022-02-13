using System;

 namespace Degiskenler
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            //Tam Sayı İfadeleri:

            byte Byte = 1; //1 byte
            sbyte Sbyte = 1; //1 byte

            short Short = 2; //2 byte
            ushort Ushort = 2; //2 byte

            Int16 İnt16 = 2; //2 byte
            int İnt = 4; //4 byte
            Int32 İnt32 = 4; //4 byte
            Int64 int64 = 8; //8 byte

            uint Uint = 4; //4 byte
            long Long = 8; //8 byte
            ulong Ulong = 8; //8 byte


            //Ondalıklı Sayı İfadeleri:

            float Float = 4.0f; //4 byte
            double Double = 8.0d; //8 byte
            decimal Decimal = 16.0m; //16 byte


            //Sözlü İfadeler:

            char Char = '2'; //2 byte
            string String = string.Empty; //sınırsız


            //Boolean Tanımlama Şekilleri:

            bool BoolT = 10 > 2; //true
            bool BoolF = 2 > 10; //false


            //DateTime Kullanım Şekilleri:

            DateTime Datetime = DateTime.Now;
            Console.WriteLine(Datetime);

            string Tarih = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(Tarih);

            string Saat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(Saat);


            //object Tanımlama Şekilleri:

            object Object_String = "Object";
            object Object_İnt = 4;
            object Object_Float = 4.3;


            //String ve İnt Dönüşümleri:

            string String20 = "20";
            int İnt20 = 20;

            string İnt_Dönüşüm_Örneği = String20 + İnt20.ToString();
            Console.WriteLine(İnt_Dönüşüm_Örneği); //Çıktısı 2020

            int String_Dönüşüm_Örnek1 = İnt20 + Convert.ToInt32(String20);
            Console.WriteLine(String_Dönüşüm_Örnek1); //Çıktısı 40

            int String_Dönüşüm_Örnek2 = İnt20 + int.Parse(String20);
            Console.WriteLine(String_Dönüşüm_Örnek2); //Çıktısı 40
        }
     }
 }