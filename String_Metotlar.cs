using System;

 namespace Namespace_name 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            string degisken1 = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";


            //Length:
            Console.WriteLine(degisken1.Length); //29


            //ToUpper, ToLower:
            Console.WriteLine(degisken1.ToUpper()); //DERSIMIZ CSHARP, HOŞGELDINIZ!
            Console.WriteLine(degisken1.ToLower()); //dersimiz csharp, hoşgeldiniz!


            //Concat:
            Console.WriteLine(string.Concat(degisken1, " Merhaba!")); //Dersimiz CSharp, Hoşgeldiniz! Merhaba!


            //Compare, CompareTo:
            Console.WriteLine(degisken1.CompareTo(degisken2)); //1
            Console.WriteLine(string.Compare(degisken1, degisken2, true)); //1
            Console.WriteLine(string.Compare(degisken1, degisken2, false)); //1


            //Contains, EndsWith, StartsWith:
            Console.WriteLine(degisken1.Contains(degisken2)); //true
            Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz!")); //true
            Console.WriteLine(degisken1.StartsWith("Merhaba!")); //false

            
            //IndexOf, LastIndexOf:
            Console.WriteLine(degisken1.IndexOf("CS")); //9
            Console.WriteLine(degisken1.IndexOf("1")); //-1
            Console.WriteLine(degisken1.LastIndexOf("i")); //26


            //Insert:
            Console.WriteLine(degisken1.Insert(0, "Merhaba! ")); //Merhaba! Dersimiz CSharp, Hoşgeldiniz!


            //PadLeft, PadRight:
            Console.WriteLine(degisken1 + degisken2.PadLeft(30)); //Dersimiz CSharp, Hoşgeldiniz!                        CSharp
            Console.WriteLine(degisken1 + degisken2.PadLeft(30, '*')); //Dersimiz CSharp, Hoşgeldiniz!************************CSharp
            Console.WriteLine(degisken1.PadRight(50) + degisken2); //Dersimiz CSharp, Hoşgeldiniz!                     CSharp
            Console.WriteLine(degisken1.PadRight(50, '-') + degisken2); //Dersimiz CSharp, Hoşgeldiniz!---------------------CSharp


            //Remove:
            Console.WriteLine(degisken1.Remove(10)); //Dersimiz C
            Console.WriteLine(degisken1.Remove(5, 3)); //Dersi CSharp, Hoşgeldiniz!
            Console.WriteLine(degisken1.Remove(0, 1)); //ersimiz CSharp, Hoşgeldiniz!


            //Replace:
            Console.WriteLine(degisken1.Replace("CSharp", "C#")); //Dersimiz C#, Hoşgeldiniz!
            Console.WriteLine(degisken1.Replace(" ", "*")); //Dersimiz*CSharp,*Hoşgeldiniz!


            //Split:
            Console.WriteLine(degisken1.Split(' ') [1] ); //CSharp,


            //Substring:
            Console.WriteLine(degisken1.Substring(4)); //imiz CSharp, Hoşgeldiniz!
            Console.WriteLine(degisken1.Substring(4, 6)); //imiz C
        }
     }
 }
