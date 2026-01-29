namespace _11_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While
             * Koşul true olduğu sürece çalışır ve eğer break veya false olabilecek bir koşul vermezsek
             * Sonsuza kadar devam eder.
            */
            #region Tahmin Ödev
            //Kullanıcıya 5 hak tanımlayacağız kullanıcı random oluşturulan sayıyı bu 5 hak ile arayacakk eğer 
            //hak kısmı dolmadan bilirse tebrikler deyip random sayıyı göstereceğiz 
            //eğer kullanıcı 5 hakkı dolarsa hakkınız doldu deyip random sayıyı göstereceğiz
            //kullanıcı 1 ila 100 arasında sayıyı tahmin etmeye çalışacak
            //Örneğin oluşturulan random sayı değeri 50 kullanıcı 25 girdi girdiğiniz sayı oluşturulan sayıdan küçüktür
            // uyarısı verilip kullanıcı yönlendirilecek  kullanıcı 75 girdi girilen sayı büyüktür deyip yönlendirilecek
            //eğer sayılar birbirine eşitse şanslı sayıyı buldunuz diyecek ve 5 hakta bu işlemi yapacak.
            #endregion
            #region Örnek1
            //int i = 0;

            //while (i <= 10)//sadece true olduğunda içindeki kod bloğunu okur.
            //{
            //    Console.WriteLine(i + " :Erkan");
            //    i++;
            //}
            //while (true)//break veya sonlanacak bir ifade belirtmezsek sonsuz döngüye girer.
            //{
            //    Console.WriteLine(i + " :Erkan");
            //    i++;
            //}
            //bool durum = true;
            //while (durum)
            //{
            //    Console.WriteLine("Devam (E) Tamam (H)");
            //    string deger = Console.ReadLine().ToUpper();//ToUpper girilen her karakteri büyült

            //    if (deger == "E")
            //    {
            //        //continue;//döngü devam etsin
            //        durum = true;

            //    }
            //    else if (deger == "H")
            //    {
            //       // break;//döngü sonlansın
            //       durum=false;
            //    }
            //}
            #endregion
            #region Örnek 2
            //10 dan 0 kadar sayıları yazdıran döngü yapısı olacak fakat bu döngü yapısında 5 ve 6 sayılarını görmeyelim
            //sayı değeri 1 a geldiğinde döngü sonlansın
            //int counter = 10;
            //while (counter>=0)
            //{
            //    counter--;
            //    if (counter == 5 || counter == 6)
            //    {
            //        continue;
            //    }
            //    if (counter == 1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(counter);
            //}
            //int i = 0;
            //int j = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);

            //    while (j <= 10)
            //    {
            //        Console.WriteLine(i + "'i' nin 'j'ninci değeri:" + j);
            //        j++;
            //    }
            //    i++;

            //}
            #endregion

            #region Örnek 3
            ////300 den başlayarak çift ve tek sayıların ayrı ayrı toplamlarını ekrana yazdıran while döngüsünü yazın
            //int sayi = 300;
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //while (sayi > 0)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    else
            //    {
            //        tekToplam += sayi;
            //    }
            //    sayi--;
            //}
            //Console.WriteLine("Tek toplam: "+tekToplam);
            //Console.WriteLine("Cift toplam: "+ciftToplam);
            #endregion
            #region Örnek 4
            //Modem arayüzü yapısı kullanıcı 3 hakkı olacak kullanıcının girdiği kullanıcı ad ve şifre 3 defa yanlış
            //girilirse eğer kullanıcıyı 5 saniye bekleteceğiz ve tekrar değer girmesini isteyeceğiz.
            //doğru girerse hoşgeldiniz yazısını görecek
            //string userName = "erkan";
            //string password = "1453";

            //int hak = 3;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı adınız");
            //    string kad = Console.ReadLine();
            //    Console.WriteLine("Şifreniz");
            //    string pass = Console.ReadLine();
            //    hak--;
            //    if (userName == kad && password == pass)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız kalmadı");
            //        Console.WriteLine("Sistem kitlendi");
            //        Thread.Sleep(5000);//Sistemi belirtiğimiz milisaniye cinsinden bekletir.
            //        Console.Clear();//Konsolu temizle
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sisteme giriş başarısız kalan hakkınız: "+hak);
            //        Console.WriteLine("Tekrar deneyiniz.");
            //    }

            //}
            #endregion

        }
    }
}
