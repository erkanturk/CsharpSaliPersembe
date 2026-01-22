namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız 
            //ve ekrana yazdırınız
            //En büyük sayı 15
            //Ortanca sayı 13
            //En küçük sayı 5
            //2. ödev
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 
            #endregion
            #region If else açıklama
            /* Karar Yapısı (Conditions) if else , switch case
             * If else blokları senkronize olarak çalışır bir yapıda bir if bir else bulunurken birden fazla else if yapısı bulunabilir
             * Bu yapılardan sadece birtanesi çalışır ve geri kalan koşul yapılarını kontrol etmez true sonucunun bulunduğu blok içerisindeki kod satırı okunmaya başlar eğer hiç bir yapıda true sonucu dönmüyorsa geriye kalan tüm koşullar için else yapısı devreye girer ve içerisinde bulunan kodu çalıştırır.
             * Bu yapıda olmazsa olmaz yapımız if yapısıdır else yapısı kullanılmaya bilir fakat karar ağacı if ile başlar.
             * Else yapısında if veya else if de olduğu gibi bir karşılaştırma yada karar yapısında true false dönecek bir yapı bulunmaz geriye kalan tüm koşullar olduğu için bir sınırlama olamaz.

             */
            //Kullanıcının girdiği değeri kontrol edelim kullanıcı negatif bir sayımı pozitif bir sayı mı yada nötür bir sayı mı girdiğini kontrol edelim
            #endregion
            #region Örnek1
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)//eğer(if) koşul doğruysa {bu alanda bulunan kod yapısını oku} 
            //{
            //    Console.WriteLine("Pozitif değer");
            //}
            //else if (sayi < 0)//değilse eğer bu yapı true dönerse kod bloğunu okuyacak
            //{
            //    Console.WriteLine("Negatif bir değer");
            //}
            //else//else geriye kalan tüm koşullar için geçerlidir.
            //{
            //    Console.WriteLine("Sayı sıfırdır.");
            //}
            #endregion
            #region Örnek 2
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif sayıdır");
            //}
            //if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif sayi");
            //}
            //if (sayi != 0)
            //{
            //    Console.WriteLine("Sayı 0 değildir");
            //}
            //if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı 0 dır");
            //}
            #endregion
            #region Örnek 3
            //instagram örneği yapısı
            //Console.WriteLine("Kullanıcı adınız,telefon numaranız veya e posta adresiniz");
            //string kad = Console.ReadLine();
            //Console.WriteLine("Şifreniz");
            //string password = Console.ReadLine();

            //if ((kad == "Erkan" || kad == "e@gmail.com" || kad == "123") && password == "1453")
            //{
            //    Console.WriteLine("sisteme giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Sisteme giriş başarısız");
            //    if (password != "1453")
            //    {
            //        Console.WriteLine("Şifreniz hatalıdır");
            //        if (kad == "Erkan" || kad == "123" || kad == "e@gmail.com")
            //        {
            //            Console.WriteLine("Kullanıcı adınız hatalı değildir");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kullanıcı adınız hatalıdır.");
            //        }


            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalıdır.");
            //    }

            //}
            #endregion
            #region Örnek 4
            //Kullanıcının girdiği değeri önce 0 dan büyük mü kontrol edelim eğer sıfırdan büyükse 100 den büyük mü küçük mu kontrol edelim

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    if (sayi > 100)
            //    {
            //        Console.WriteLine("Girilen sayı büyüktür 100 sayı değeri: " + sayi);
            //    }
            //    else if (sayi < 100)
            //    {
            //        Console.WriteLine("sayı küçüktür 100 den sayı: " + sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 100 e eşittir sayı: " + sayi);
            //    }
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("sayı 0 dan küçüktür");
            //    if (sayi >= -100)
            //    {
            //        Console.WriteLine("Sayı -100 e Eşit veya büyüktür: " + sayi);
            //    }
            //    else if (sayi < -100)
            //    {
            //        Console.WriteLine("Sayı küçüktür -100 den: " + sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayı -100 dür: " + sayi);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0 dır");
            //}
            #endregion

            #region Örnek5
            ////// Kullanıcının girdiği değeri kontrol edelim tek mi çift mi olduğunu ekrana yazdıralım 
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            ////if (sayi % 2 == 0)
            ////{
            ////    Console.WriteLine("Girilen sayı Çifttir");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Girilen değer tektir.");
            ////}
            //if (sayi % 2 == 1)
            //{
            //    Console.WriteLine("Girilen değer tektir.");
            //}
            //else if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı Çifttir");
            //}
            #endregion

            #region Örnek 6 
            // kullanıcıya bir soru soracağız haftanın kaçıncı günü diye kullanıcı eğer 1 girerse pazartesi 2 salı gibi if else blokları ile değeri ekrana yazdıracağız kullanıcı 0'dan küçük ve 0 girerse  veya 7 den büyük bir değer girerse ekrana bir uyarı vereceğiz.
            //Console.WriteLine("Haftanın kaçıncı günü");
            //string gun = Console.ReadLine();
            //if (gun == "1")
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == "2")
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == "3")
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == "4")
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == "5")
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == "6")
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == "7")
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("lütfen 1 ila 7 arasında değer giriniz");
            //}
            //Goto satıra konuşlanma ifadesidir döngü olarak çalışmaz belirtiğimiz koşul sağlanıyorsa yada sağlanmıyorsa tekrardan bu satıra dön gibi bir yapı oluşturabiliriz.
            //DateTime time = DateTime.Now;
            //Console.WriteLine(time.DayOfWeek);//haftanın hangi günü
            //xc://başlangıç kısmı : iki nokta
            //Console.WriteLine("Haftanın kaçıncı günü");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun <= 0 || gun >= 8)
            //{
            //    Console.WriteLine("lütfen 1 ila 7 arasında değer giriniz");
            //    goto xc;//belirtilen satıra git ve kodları baştan oku
            //            //goto kısmı ; noktalı virgül ile tanımlanır.
            //}
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else
            //{
            //    Console.WriteLine("Pazar");
            //}
            #endregion

            #region Örnek 7
            //Kullanıcıdan değer alacağız kullanıcı pozitif bir değer girerse girdiği değeri göstereceğiz
            //kullanıcı negatif değer girerse girdiği değeri göstereceğiz
            //kullanıcı eğer '0' girerse pozitif veya negatif değer girin diye tekrardan soru yapısına yönlendireceğiz.
            //basla:
            //    Console.WriteLine("Bir değer giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif yada negatif değer giriniz");
            //        goto basla;
            //    }
            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine($"Negatif sayı {sayi}");
            //    }
            //    else if (sayi > 0)
            //    {
            //        Console.WriteLine($"Pozitif sayı {sayi}");
            //    }
            #endregion
            //https://www.w3schools.com/cs/index.php
        }
    }
}
