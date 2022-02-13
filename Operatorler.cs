using System;

 namespace Operatorler
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<< Atamalar >>>>");
            //Atamalar:
            //=  +=  -=  *=  /=

            int x = 3;

            x += 3;
            Console.WriteLine(x); //6

            x -= 4;
            Console.WriteLine(x); //2

            x *= 5;
            Console.WriteLine(x); //10

            x /= 2;
            Console.WriteLine(x); //5


            Console.WriteLine("<<<< Mantıksal Operatörler >>>>");
            //Mantıksal Operatörler:
            //&&  ||  !

            bool TBool = true;
            bool FBool = false;
            
            if (TBool == true && FBool == true)
            {
                Console.WriteLine("ikisi true"); //çalışmicak
            }

            if (TBool == true || FBool == true)
            {
                Console.WriteLine("birisi true"); //çalışcak
            }

            if (TBool == true && !FBool == true)
            {
                Console.WriteLine("TBool ve FBool'un tersi true"); //çalışcak
            }


            Console.WriteLine("<<< İlişkisel Operatörler >>>>");
            //İlişkisel Operatörler:
            //==  !=  >  <  >=  <=

            int a = 3;
            int b = 5;
            bool Sonuc1;

            Sonuc1 = a > b;
            Console.WriteLine(Sonuc1); //false

            Sonuc1 = a < b;
            Console.WriteLine(Sonuc1); //true

            Sonuc1 = a == b;
            Console.WriteLine(Sonuc1); //false

            Sonuc1 = a != b;
            Console.WriteLine(Sonuc1); //true

            Sonuc1 = a >= b;
            Console.WriteLine(Sonuc1); //false

            Sonuc1 = a <= b;
            Console.WriteLine(Sonuc1); //true


            Console.WriteLine("<<<< Aritmetik Operatörler >>>>");
            //Aritmetik Operatörler:
            //+  -  *  /  %  ++  --

            int y = 15;
            int z = 3;
            int Sonuc2;

            Sonuc2 = y + z;
            Console.WriteLine(Sonuc2); //18

            Sonuc2 = y - z;
            Console.WriteLine(Sonuc2); //12

            Sonuc2 = y * z;
            Console.WriteLine(Sonuc2); //45

            Sonuc2 = y / z;
            Console.WriteLine(Sonuc2); //5

            Sonuc2 = y % z;
            Console.WriteLine(Sonuc2); //0

            Sonuc2 = y++;
            Console.WriteLine(y); //16

            Sonuc2 = z--;
            Console.WriteLine(z); //2
        }
     }
 }