namespace _18_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Yaz();//Çağırıldığı sürece methodlar çalışır
            //Yaz();
            //Yaz();
            //Yaz();
            //Yaz();
            //Console.WriteLine("MErhaba method");
            //ParametreliIsYapan("Parametreli Method");
            //string text = "Erkan Türk";
            //ParametreliIsYapan(text);
            //Console.WriteLine("Bir değer giriniz");
            //string deger = Console.ReadLine();
            //Uzunluk(deger);
            Topla(20,40);

        }
        static void Yaz()//Parametresiz iş yapan method
        {
            Console.WriteLine("Erkan");
        }
        static void ParametreliIsYapan(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Uzunluk(string metin)
        {
            int sayi = metin.Length;
            Console.WriteLine(sayi);
        }
        static void Topla(int sayi, int sayi2)
        {
            int toplam = sayi + sayi2;
            Console.WriteLine(toplam);
            Console.WriteLine(sayi+sayi2);
        }
    }
}
