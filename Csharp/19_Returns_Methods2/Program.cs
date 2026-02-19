namespace _19_Returns_Methods2
{
    internal class Program
    {   //ödev
        //Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan method
        //ve 3. ürünü almak isterse 3. ürünede %50 indirim uygulayacağız.
        static void Main(string[] args)
        {

            //Console.WriteLine("Ad:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Soyad:");
            //string surName = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //int age = Convert.ToInt32(Console.ReadLine());
            //age += 10;
            //Kaydet(name, surName, age);
            //int degerAl = Kaydet2(name, surName, age);
            //Console.WriteLine(degerAl+10);

            //Kullanıcıdan method içerisinde iki değer isteyeceğiz bu methodda değerler toplanıp %20 kdv uygulanacak ve 
            // değer dışarıya çıkarılıp kdv li fiyata %12 indirim uygulayacağız.



            int[] ints = DiziDondur();
            foreach (int i in ints)
            {
                Console.WriteLine(i + 10);
            }

            //int[] dizi = { 10, 20, 30, 40, 60, 50, 44, 55, 66, 77, 88, 66, 99, 54, 66, 55 };

            //Console.WriteLine(SayiDegeri(dizi));

            //double indirim = KdvUygula();
            //indirim = indirim * 0.88;

            ////Console.WriteLine("Kdv li fiyata indirim uygulanmış değer: " + indirim);
            //Console.WriteLine("1.Ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            ////Console.WriteLine(KdvFiyat(fiyat, fiyat2));
            //Console.WriteLine(KdvFiyat(fiyat,fiyat2)*0.88);

        }
        static double KdvUygula()
        {
            Console.WriteLine("1.Ürün fiyatı");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün fiyatı");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
            double kdv = (fiyat + fiyat2) * 1.20;
            return kdv;
        }
        static double KdvFiyat(double sayi, double sayi2)
        {
            double kdv = (sayi + sayi2) * 1.20;
            // return kdv*0.88;
            return kdv;
        }
        static void Kaydet(string ad, string soyad, int yas)
        {
            Console.WriteLine($"Adınız: {ad} Soyad: {soyad} Yaş {yas}");
        }
        static int Kaydet2(string ad, string soyad, int yas)
        {
            Console.WriteLine($"Adınız: {ad} Soyad: {soyad}");
            return yas;
        }
        static int SayiDonder(int sayi, int sayi2)
        {
            return sayi;
        }
        static int[] DiziDondur()
        {
            Random random = new Random();

            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                int rad = random.Next(1, 10);
                ints[i] = rad;
            }
            return ints;
        }
        static int SayiDegeri(int[] ints)
        {
            int toplam = ints.Length;
            return toplam;
        }
    }
}
