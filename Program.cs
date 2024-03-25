namespace Araba_Uretim
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Uretim> aracList = new List<Uretim>()
            {
                new Uretim("volkswagen","passat","siyah",2000,2008),
                new Uretim("volkswagen","golf","kırmızı",1400,2017),
                new Uretim("opel","corsa","siyah",1300,2013),
                new Uretim("opel","astra","mavi",1600,2012),
                new Uretim("toyota","corolla","beyaz",1400,2017),
                new Uretim("toyota","yaris","beyaz",1500,2017),
                new Uretim("bmw","320d","kahverengi",2000,2018),               
                new Uretim("bmw","520d","mavi",2000,2018),               
                new Uretim("hyundai","accent","gri",1500,1998),               
                new Uretim("hyundai","i20","kırmızı",1400,2023),               
          
            };
            while (true)
            {
                Console.WriteLine("1 - Kayıt\n2 - Liste\n3 - Güncelle\n4 - Filtre\n5 - Çıkış");
               
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Kayit(aracList);
                }
                else if (secim == 2)
                {
                    Listele(aracList);
                }
                else if (secim == 3)
                {
                    Guncelleme(aracList);
                }
                else if (secim == 4)
                {
                    Filtrele(aracList);
                }
                else if (secim == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız.");
                }
            }
        }
        static void Kayit(List<Uretim> liste)
        {
            Console.WriteLine("Marka:");
            string marka = Console.ReadLine().ToLower();

            Console.WriteLine("Model:");
            string model = Console.ReadLine().ToLower();

            Console.WriteLine("Renk:");
            string renk = Console.ReadLine().ToLower();

            Console.WriteLine("Motor Hacmi:");
            int motorHacmi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üretim Yılı:");
            int uretimYili = Convert.ToInt32(Console.ReadLine());

            Uretim uretim = new Uretim(marka, model, renk, motorHacmi, uretimYili);
            liste.Add(uretim);
        }
        static void Listele(List<Uretim> liste)
        {
            Uretim.Goster(liste);
        }
        static void Guncelleme(List<Uretim> liste)
        {
            Listele(liste);
            Console.WriteLine("Güncellenecek araç numarası:");
            int numara = Convert.ToInt32(Console.ReadLine());
            Uretim.Guncelleme(liste, numara);
        }
        static void Filtrele(List<Uretim> liste)
        {
            Console.WriteLine("Filtrelenecek marka:");
            string marka1 = Console.ReadLine().ToLower();
            Uretim.Filtrele(liste, marka1);
        }
    }
}
