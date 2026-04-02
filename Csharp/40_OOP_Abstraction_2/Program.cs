namespace _40_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elektronik diye bir sınıfımız olsun bu sınıfta alış fiyatı ve kar yüzdesi özellikleri olacak
             * Ve method olarak Fiyat hesapla methodu olacak bu method zorunlu olacak
             * Şarjlı sınıfı olacak özelliği miliamper olsun
             * Elektrikli sınıfı olsun volt diye propertisi olsun
             * Buzdolabi telefon diye child sınıflarımız olacak.
            */
           // Elektronik elektronik = new Elektronik();//Abstract (Soyut) soyut sınıftan nesne oluşturulamaz.

            Buzdolabi buzdolabi = new Buzdolabi();
            buzdolabi.AlisFiyati = 5000;
            buzdolabi.KarYuzdesi = 1.50;

            double deger = buzdolabi.FiyatHesapla();
            Console.WriteLine(deger);

            Telefon telefon = new Telefon();
            telefon.Marka = "İphone";
            telefon.Model = "16";
            telefon.AlisFiyati = 50000;
            telefon.KarYuzdesi = 2.20;
            Console.WriteLine(telefon.FiyatHesapla());


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
        }
    }
}
