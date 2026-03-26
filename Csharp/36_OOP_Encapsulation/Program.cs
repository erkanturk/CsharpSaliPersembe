namespace _36_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP
            /* Object Oriented Programming (Nesne yönelimli programlama)
             * İlk yazılım sıralı satırlar olarak geliştiriliyordu
             * Sonrasında class yapısı üzerinden geliştirilmeye başlandı ama hala büyük çaplı projeler yazılamıyordu
             * 
             * C dili => OOP geliştirilmesi ile C++ dili ortaya çıktı
             * C++ gün geçtikçe popüleritesini kaybeden ama önceki yıllarda yazılmış projeler üzerinde hala geliştirilen 
             * Çok güçlü bir dildir. Makine programlama, siber güvenlik, otomobil beyni, vb işlerde kullanılır
             * İnternetin icadı ile birlikte Java ve C# dilleri ortaya çıkmıştır.
             * 
             * OOP 4 temel ilkesi vardır.
             * 1-Encapsulation - Kapsülleme
             * 2-Inheritance - Kalıtım (Miras alma)
             * 3-Polymorphism - Çok biçimcilik
             * 4-Abstraction - Soyutlama
             * 
             
             */
            /* Encapsulation 
             * Bir nesnenin propertylerinde doğruluk kontrolü yapılması gerektiğinde kullanılan bir oop yapısıdır.
             * Propertyler private olarak tanımlanır ve dışarıdan erişime kapalı olur doğrudan propertye değer gönderilemez
             * Aynı property'nin benze isimde public olarak bir tanımlaması yapılır ve kullanıcıdan bu property'e data (veri) girişi yapılması istenir
             * girilen data set keyword ile kontrol edilerek asıl propertye aktarılır
             * get kısmı ise property'nin içindeki değeri okumak ve getirmek için kullanılır.
             
             */
            #endregion
            //Vatandas vatandas = new Vatandas();
            //vatandas.AdSoyad = "Erkan Türk";
            //vatandas._Tc = 12345678910;
            //Console.WriteLine(vatandas._Tc);
            Islem islem = new Islem();
            Console.WriteLine("1.Sayı değeri");
            islem.Sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı değeri");
            islem._Sayi2 = Convert.ToDouble(Console.ReadLine());

            
        }
    }
    class Vatandas
    {
        internal string AdSoyad;
        private long Tc;
        public long _Tc
        {
            get { return Tc; }
            set
            {
                if (value.ToString().Length == 11)
                {
                    Tc = value;
                }
                else
                {
                    Tc = 0;
                    Console.WriteLine("Tc 11 haneli olmalıdır.");
                }
            }
        }

    }

    class Islem
    {
        public double Sayi { get; set; }
        private double Sayi2 { get; set; } //Kapsülleme yapılacak yapı private olmalıdır.

        public double _Sayi2
        {
            get { return Sayi2; }
            set
            {
                if (value > 0 )
                {
                    Sayi2 = value;
                    Console.WriteLine($"Sonuç: {Sayi / Sayi2}");
                }
                else
                {
                    Console.WriteLine("Sayı sıfıra bölünemez");
                }
            }
        }
    }
}
