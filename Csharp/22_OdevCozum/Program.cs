namespace _22_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            // Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çift sayıları ayrı ayrı dizilere atayan method
            //Randomdan gelen değere göre tek dizi yada çift dizinin miktarı değişecek 
            //ödev
            //Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan method
            //ve 3. ürünü almak isterse 3. ürünede %50 indirim uygulayacağız.

            #endregion
            // DiziDoldur();
            Indirim();
        }
        static void DiziDoldur()
        {
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];
            int[] sayilar = new int[15];
            Random random = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = random.Next(1, 101);
                sayilar[i] = sayi;
                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                    tekSayilar[tekSayilar.Length - 1] = sayi;
                }

            }
            DiziYazdir(sayilar);
            DiziYazdir(ciftSayilar);
            DiziYazdir(tekSayilar);
        }
        static void DiziYazdir(int[] dizi)
        {
            Console.WriteLine("***********");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }

        static void Indirim()
        {
            Console.WriteLine("Birinci ürün fiyatı");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci ürün fiyatı");
            double f2 = Convert.ToDouble(Console.ReadLine());
            if (f1 > f2)
            {
                f1 *= 0.70;
            }
            else
            {
                f2 *= 0.70;
            }
            Console.WriteLine("3.Üründe %50 indirim var bak kaçırma  almak ister misin ?(E/H)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                Indirim3(f1,f2);
            }
            else
            {
                Console.WriteLine("İyi günler Toplam ödenecek tutar: " + (f1 + f2));
            }



        }
        static void Indirim3(double fiyat1, double fiyat2)
        {
            Console.WriteLine("Üçüncü ürünün fiyatı");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme: {fiyat1+fiyat2+(fiyat3/2)}");
        }
    }
}
