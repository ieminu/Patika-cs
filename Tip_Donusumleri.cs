using System;

namespace Namespace_name 
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // İmplicit Conversion:
            Console.WriteLine("<<<<< Bilinçsiz Dönüşüm >>>>>");

            byte Byte1 = 2;
            sbyte Sbyte = 5;
            short Short = 10;

            int Toplam1 = Byte1 + Sbyte + Short;
            Console.WriteLine("Int1;  " + Toplam1);

            long Long = Toplam1;
            Console.WriteLine("Long;  " + Long);

            float Float1 = Long;
            Console.WriteLine("Float1;  " + Float1);

            string String1 = "Yemin";
            char Char = '_';

            object Object = String1 + Char + Toplam1;
            Console.WriteLine("Object;  " + Object);


            // Explicit Conversion:
            Console.WriteLine("<<<<< Bilinçli Dönüşüm >>>>>");

            int Int2 = 4;
            byte Byte2 = (byte)Int2;
            Console.WriteLine("Byte2:  " + Byte2);

            float Float2 = 10.3f;
            byte Byte3 = (byte)Float2;
            Console.WriteLine("Byte3:  " + Byte3);

            int Int3 = 6;
            string String2 = Int3.ToString();
            Console.WriteLine("String2:  " + String2);

            string String3 = 12.5f.ToString();
            Console.WriteLine("String3:  " + String3);

            string String4 = "10", String5 = "20";
            int Int4, Int5;
            int Toplam2;

            Int4 = Convert.ToInt32(String4);
            Int5 = Convert.ToInt32(String5);
            Toplam2 = Int4 + Int5;
            Console.WriteLine("Toplam2:  " + Toplam2);

            ParseMethod();
        }

        static void ParseMethod()
        {
            string String6 = "15";
            string String7 = "13.25";
            int Int6;
            double Double;

            Int6 = Int32.Parse(String6);
            Double = Double.Parse(String7);

            Console.WriteLine("Int6:  " + Int6);
            Console.WriteLine("Double:  " + Double);
        }
    }
}