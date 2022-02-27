using System;
using System.Collections;

 namespace Namespace_name 
{
     class MainClass
    {
        static void Main(string[] args)
        {
            ArrayList AsalSayilar = new ArrayList();
            ArrayList AsalOlmayanSayilar = new ArrayList();

            List<uint> asalSayilar = new List<uint>(){2};

            for(uint i = 3 ; i < 66000 ; i++)
            {
                double Kok = Math.Sqrt(i);
                uint KokTavan = (uint)Math.Ceiling(Kok);

                if (Math.Round(Kok) == Kok)
                    continue;

                for (int j = 0 ; j < asalSayilar.Count ; j++)
                {
                    if (i % asalSayilar[j] == 0)
                        break;

                    if (j == asalSayilar.Count - 1/* || asal_sayılar[j] > Ceiling_Of_Root */)
                    {
                        asalSayilar.Add(i);
                        break;
                    }
                }
            }

            Console.WriteLine("20 adet pozitif sayı giriniz: ");

            for(int k = 1 ; k <= 20 ; k++) 
            {
                try
                {
                    uint GirilenSayi = uint.Parse(Console.ReadLine());

                    if (GirilenSayi > asalSayilar[asalSayilar.Count-1])
                    {
                        for(uint i = asalSayilar[asalSayilar.Count-1] ; i <= GirilenSayi ;i++)
                        {
                            double Kok = Math.Sqrt(i);
                            uint KokTavan = (uint)Math.Ceiling(Kok);

                            if (Math.Round(Kok) == Kok)
                                continue;

                            for(int j = 0 ; j < asalSayilar.Count ; j++)
                            {
                                if (i % asalSayilar[j] == 0)
                                    break;

                                if(j == asalSayilar.Count-1 || asalSayilar[j] > KokTavan)
                                {
                                    asalSayilar.Add(i);
                                    break;
                                }
                            }
                        }
                    }

                    foreach (uint asalSayi in asalSayilar)
                    {
                        if (asalSayi == GirilenSayi && !AsalSayilar.Contains(GirilenSayi)) 
                        {
                            AsalSayilar.Add(GirilenSayi);
                            break;
                        }

                        if (GirilenSayi % asalSayi == 0 && !AsalOlmayanSayilar.Contains(GirilenSayi))
                            AsalOlmayanSayilar.Add(GirilenSayi);
                    }
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Lütfen 4294967295'ten küçük pozitif bir sayı giriniz: ");
                    k -= 1;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz: ");
                    k -= 1;
                }
            }

            Console.WriteLine();

            uint AsalSayilarinToplami = 0;
            uint AsalOlmayanSayilarinToplami = 0;
            
            Console.WriteLine("Asal sayılar; ");

            AsalSayilar.Sort();
            AsalSayilar.Reverse();
            foreach (uint AsalSayi in AsalSayilar)
            {
                Console.Write(AsalSayi + " ");
                AsalSayilarinToplami += AsalSayi; 
            }

            Console.WriteLine();
            
            Console.WriteLine("Asal olmayan sayılar; ");

            AsalOlmayanSayilar.Sort();
            AsalOlmayanSayilar.Reverse();
            foreach (uint AsalOlmayanSayi in AsalOlmayanSayilar)
            {
                Console.Write(AsalOlmayanSayi + " ");
                AsalOlmayanSayilarinToplami += AsalOlmayanSayi;
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            if (AsalSayilar.Count == 0)
                Console.WriteLine("Girdiğiniz sayılarda asal sayı bulunamadı");
            else
            {
                Console.WriteLine("Asal sayıların sayısı; {0}", AsalSayilar.Count);
                Console.WriteLine("Asal sayıların toplamının ortalaması; {0}", (float)AsalSayilarinToplami / AsalSayilar.Count);
            }

            Console.WriteLine();

            if (AsalOlmayanSayilar.Count == 0)
                Console.WriteLine("Girdiğiniz sayıların tümü asal");
            else
            {
                Console.WriteLine("Asal olmayan sayıların sayısı; {0}", AsalOlmayanSayilar.Count);
                Console.WriteLine("Asal olmayan sayıların toplamının ortalaması; {0}", (float)AsalOlmayanSayilarinToplami / AsalOlmayanSayilar.Count);
            }
        }
    }
}