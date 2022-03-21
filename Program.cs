namespace ToDo_Uygulamasi
{
    class MainClass
    {
        static void Main(string[] args)
        {
            IlkIslemler();
            Menu();
        }

        public static void IlkIslemler()
        {
            _4Islem.Kisiler.Add(1, "Yemin");
            _4Islem.Kisiler.Add(2, "Mahmut");
            _4Islem.Kisiler.Add(3, "Doruk");
            _4Islem.Kisiler.Add(4, "Edanur");
            _4Islem.Kisiler.Add(5, "Nazlı");

            Kart kart1 = new Kart("Kuryelik", "Ev Teslimi", "L", "Mahmut");
            _4Islem.TODOLineKartlari.Add(kart1);

            Kart kart2 = new Kart("Kuryelik", "Dağıtım Merkezine Teslim", "M", "Doruk");
            _4Islem.TODOLineKartlari.Add(kart2);
            
            Kart kart3 = new Kart("Düzenleme", "Kargoları Düzenleme", "XS", "Edanur");
            _4Islem.INPROGRESSLineKartlari.Add(kart3);

            _4Islem.TumKartlar.Add(_4Islem.TODOLineKartlari);
            _4Islem.TumKartlar.Add(_4Islem.INPROGRESSLineKartlari);
            _4Islem.TumKartlar.Add(_4Islem.DONELineKartlari);
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("(1) Board'ı Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine();

            SayiInput:

            switch (KonsolIslemleri.ConvertInputToInt())
            {
                case 1: 
                    _4Islem.BoardiListeleme();
                    break;
                    
                case 2: 
                    _4Islem.BoardaKartEkleme();
                    break;
                    
                case 3: 
                    _4Islem.BoarddanKartSilme();
                    break;
                    
                case 4: 
                    _4Islem.KartTasima();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Lütfen 1'den 4'e kadar olan bir sayı giriniz:\n");
                    goto SayiInput;
            }
        }
    }
}