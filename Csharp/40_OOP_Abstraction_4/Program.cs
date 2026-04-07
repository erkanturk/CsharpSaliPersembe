namespace _40_OOP_Abstraction_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork
            //Örnek: Bir tane Tasit sınıfı oluşturalım ancak bu sınıftan nesne üretilemesin.
            //İçerisinde Marka, Model, TabanFiyat property'leri  bir de türeyen her sınıfa
            //özel hesaplanacak abstract Fiyat property'si ekleyelim.
            //Tasit'dan türeyen Araba, Ucak, Tren ve Gemi class'larımız olsun.
            //Araba'ya özel fiyat hesabı YakitTuru, VitesTuru bilgilerine göre yapılsın
            //(Dizel'se +5000, Otomatikse'se +10000)
            //Uçak'a özel fiyat hesabı kapasite bilgisine göre yapılsın.
            //(Kapasite başına +100)
            //Trene özel fiyat hesabı vagon sayısı ve sınıf bilgisine göre yapılsın
            //(sınıf A ise + 5000, B ise +10000 vagon sayısı başına + 30000)
            //Gemi'ye özel fiyat hesabı kamara sayısına göre yapılsın
            //(kamara başına +40000)
            #endregion
            Araba araba = new Araba("Nissan", "Gtr34", 150000, "Otomatik", "Benzin");
            Console.WriteLine($"Taşıt {araba.Marka} Fiyat {araba.Fiyat}");
            Tren tren = new Tren("Siemens", "B150", 1400000, 6, "B");
            Console.WriteLine($"Taşıt {tren.Marka} Fiyat {tren.Fiyat}");
            Ucak ucak = new Ucak("Boeing", "Airbus", 25000000, 200);
            Console.WriteLine($"Taşıt {ucak.Marka} Fiyat {ucak.Fiyat}");
            Gemi gemi = new Gemi("Titanic", "1992", 10000000, 100);
            Console.WriteLine($"Taşıt {gemi.Marka} Fiyat {gemi.Fiyat}");

        }
    }
}
