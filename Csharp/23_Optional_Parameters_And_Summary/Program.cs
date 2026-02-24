namespace _23_Optional_Parameters_And_Summary
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* OptionalParameters(isteğe bağlı parametreler)
             * Eğer bir yapıya değer göndermeden çalışmasını sağlamak istiyorsak isteğe bağlı parametreleri kullanmamız gerekmektedir.
             * Bu yapı değerin boş gelmesini engeller ve methodun parametre değeri gelmesede çalışmasını sağlar.
             */
            
            string adSoyad = AdSoyadDondur("Erkan", "Türk");
            Console.WriteLine(adSoyad);
            AdSoyad("Erkan");
            AdSoyad("Erkan", "TÜRK");
            //Insan("Tahsin Canpolat", 34, "01-01-1992");
            Console.WriteLine("Ad:");
            string ad = Console.ReadLine();
            //Insan(ad, 36, "04-12-1990", "Yazılım Eğitmeni", "İsviçre", "Erkek");
            //Insan(ad, 36, "04-12-1990", "Yazılım Eğitmeni");

            //Insan("Erkan Türk",31,"21,04,1995","Yazılım","","Erkek");//isteğe bağlı parametre kullanımı
            Insan(ad, yas: 31, dogumTarihi: "21-04-1995", meslek: "Yazılım", cinsiyet: "Erkek");

        }
     
        static string AdSoyadDondur(string ad, string soyad)
        {
            return ad + " " + soyad;
        }
        /// <summary>
        /// Ad soyad değerleri alıyor ve bu değerlerden soyad kısmı opsiyonel parametre
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        static void AdSoyad(string ad, string soyad = "Belirtmek istemiyorum")//varsayılan değer olarak eğer parametreye değer verilmezse
                                                                              //methodun içerisindeki değeri kullanır.
                                                                              //Optional parameters yapısı daima zorunlu parametreden sonra yazılır
        {
            Console.WriteLine(ad + " " + soyad);
        }
        /// <summary>
        /// zorunlu 3 parametresi bulunur geriye kalan 3 parametre opsiyonel
        ///<see cref = "link" href="https://github.com/erkanturk"/>
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <param name="yas"></param>
        /// <param name="dogumTarihi"></param>
        /// <param name="meslek"></param>
        /// <param name="ulke"></param>
        /// <param name="cinsiyet"></param>
        static void Insan(string adSoyad, int yas, string dogumTarihi, string meslek = "serbest", string ulke="Türkiye",string cinsiyet="Belirtmek istemiyor")
        {
            Console.WriteLine($"Adınız: {adSoyad} Yaşınız: {yas} Doğum Tarihiniz: {dogumTarihi} Meslek: {meslek} Ülke: {ulke} Cinsiyet: {cinsiyet}");
        }
    }
}
