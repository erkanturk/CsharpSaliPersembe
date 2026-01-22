namespace _04_TurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazım kuralları
            /* Yazım biçimleri
             * SnakeCase=ad_soyad;
             * CamelCase=adSoyad;
             * KebabCase=ad-soyad;
             * UpperCase=ADSOYAD;
             * LowerCase=adsoyad;
             * PascalCase=AdSoyad; 
            Yazılım dillerinde ingilizce karakterler kullanılır türkçe karakterlerle tanımlama yapmak hataya sebebiyet verebilir.
            Kullanmamamız gereken değerler
            ı,İ,ü,ö,ğ,ş,ç v.b yapılar kullanılmamalıdır.
            2sayi,?sayi,ad soyad, ad!soyad,adsoyad? v.b gibi tanımlamalar hatalıdır.
            Doğru tanımlar
            sayi,sayi2,ad_soyad,_soyad,sayi_ özel karakter olarak sadece _ kullanılır.
             */
            #endregion

            #region Kullanıcıdan değer alma
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());//Console.ReadLine Satırı okur ve değeri alır değişkene atar
            ////Convert.ToInt32 ise girilen değeri int tipine çevirir int.Pars ile aynı işlemi yapar.
            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());//Varsayılan olarak 32bit değer alır.
            //int sonuc = sayi % sayi2;
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sayi % sayi2);

            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();//Metinsel işlem dışında her yapıda tür dünüşümü yapmamız gerekir.
            //Console.WriteLine("Soyad");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Adınız:{ad} Soyad:{soyad}");

            #endregion

            #region Casting Biliçli bilinçsiz tür dönüşümleri
            //string deger = "10";//eğer içinde sayısal bir değer yoksa hata verir sayısal bir değer varsa tür dönüşümü gerçekleşir.
            ////int deger2 =deger;//Tür dönüşümü yapmazsak hata verir
            //int deger3 = Convert.ToInt32(deger);
            //Console.WriteLine(deger3);

            //bilinçsiz tür dönüşümü
            //int sayi = 123;
            //double sayi2 = sayi;//int olarak gelen değerin çıktısını double tipinde yaptım
            //Console.WriteLine(sayi2);
            //double sayi = 123;
            //int sayi2 =(int)sayi;//Casting işlemi double sayıdaki veriyi tam sayı tipine çevirir ondalıkları almaz.
            //Console.WriteLine(sayi2);
            //char harf = '~';
            //Console.WriteLine(harf);
            //Console.WriteLine((int)harf);
            //int sayi = 88;
            ////Console.WriteLine((char)sayi);
            //char deger = Convert.ToChar(sayi);
            ////double deger2=Convert.ToDouble(harf);
            //Console.WriteLine(deger);

            //Kullanıcıdan 2 kardeşin yaşını alalım ve bu yaşların toplamını ekrana yazdıralım.
            //int i = 10;
            //Console.WriteLine(i);
            //i = 20;//güncelleme işlemi
            //Console.WriteLine(i);

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yaş2:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //double sonuc = (yas + yas2) / 2;
            //Console.WriteLine($"Ortalama Sonucu {(yas + yas2) / 2}");//string interpolation
            //Console.WriteLine("Ortalama Sonucu:" + sonuc);//string yazım biçimi 
            //Console.WriteLine("Girilen yaşlar {0} ikinci yaş {1}", yas, yas2);//index yazım biçimi

            /*Tarih zaman yapıları*/
            DateTime zaman = DateTime.Now;// Şimdiki zaman değerini getirir.

            Console.WriteLine(zaman);//Şimdiki zaman
            Console.WriteLine(zaman.Year);//Sadece yıl değeri
            Console.WriteLine(zaman.Month);//Sadece ay değeri
            Console.WriteLine(zaman.Day);//Sadece gün değeri
            Console.WriteLine(zaman.Hour);//Saat
            Console.WriteLine(zaman.Minute);//Dakika
            Console.WriteLine(zaman.Second);//Saniye
            Console.WriteLine(zaman.ToString("yyyy-MM-dd HH:mm:ss"));//tarih zaman yapısı format değiştirme.
            #endregion



        }
    }
}
