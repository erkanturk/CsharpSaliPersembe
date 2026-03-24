namespace _35_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Constructor
             * Bir sınıftan nesne alındığı gibi ilk çalışan yapı yapıcı method olan constructor yapısıdır
             * Sınıf çağırıldığı gibi bu yapının inşa edilmesine yardımcı olur 
             * Her sınıf yapısının arka planında bir constructor yapısı çalışır
             * Default constructor yapısı olarak sınıfın içindeki constructor yapısını kullanırız
             * Class ile aynı isimde olmak zorundadır
             * Geriye değer döndürmez void veri tipi gibi return ifadeler yoktur
             * 
             * Garbage collector:Bütün kodlar değişkenler methodlar her yapı ram bellekte tutulur
             * Ram bellek belirli bir doluluğa ulaştığında en eski en az kullanılan veya en kolay tanımlanan yapıları siler
             * Hafızada yer açmak için bu da destructor yapısı ile otomatik tetiklenir.
            */
            Customer customer = new Customer("Erkan", "Türk", 31);
            Customer customer1 = new Customer();
            customer.Yaz();
        }
    }
    class Customer
    {
        public string Ad;
        public string Soyad;
        public int Yas;

        public void Yaz()
        {
            Console.WriteLine($"Ad:{Ad} Soyad:{Soyad} Yaş:{Yas}");
        }
        public Customer(string ad, string soyad, int yas)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Console.WriteLine("Parametreli Constructor");
        }
        public Customer()
        {
            Console.WriteLine("Overload Ctor");

        }
    }
}
