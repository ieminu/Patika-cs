namespace ToDo_Uygulamasi
{
    class Kart
    {
        string baslik;
        string icerik;
        string buyukluk;
        string kisi;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string Buyukluk { get => buyukluk; set => buyukluk = value; }
        public string Kisi { get => kisi; set => kisi = value; }

        public Kart(string baslik, string icerik, string buyukluk, string kisi)
        {
            Baslik = baslik;
            Icerik = icerik;
            Buyukluk = buyukluk;
            Kisi = kisi;
        }

        public Kart(){}
    }
}