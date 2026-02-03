namespace _12_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tahmin Ödev
            //Kullanıcıya 5 hak tanımlayacağız kullanıcı random oluşturulan sayıyı bu 5 hak ile arayacakk eğer 
            //hak kısmı dolmadan bilirse tebrikler deyip random sayıyı göstereceğiz 
            //eğer kullanıcı 5 hakkı dolarsa hakkınız doldu deyip random sayıyı göstereceğiz
            //kullanıcı 1 ila 100 arasında sayıyı tahmin etmeye çalışacak
            //Örneğin oluşturulan random sayı değeri 50 kullanıcı 25 girdi girdiğiniz sayı oluşturulan sayıdan küçüktür
            // uyarısı verilip kullanıcı yönlendirilecek  kullanıcı 75 girdi girilen sayı büyüktür deyip yönlendirilecek
            //eğer sayılar birbirine eşitse şanslı sayıyı buldunuz diyecek ve 5 hakta bu işlemi yapacak.
            #endregion

            #region  Do-while Tahmin ödevi Çözüm
            //Random random = new Random();//Nesne instance örneklem
            //int tutulanSayi = random.Next(1, 101);
            //int girilenSayi = 0;
            //int hak = 5;
            //do
            //{
            //    Console.WriteLine($"{hak}.hakkınız lütfen bir sayı giriniz");
            //    girilenSayi = Convert.ToInt32(Console.ReadLine());
            //    if (girilenSayi > tutulanSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz");
            //    }
            //    else if (girilenSayi < tutulanSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin: " + tutulanSayi);
            //    }
            //    if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Doldu Aradığınız sayı: " + tutulanSayi);
            //    }
            //    hak--;
            //}
            //while (girilenSayi!=tutulanSayi&&hak>=0);

            #endregion
            #region While Örneği
            //Random random = new Random();
            //int tutulanSayi = random.Next(1, 101);
            //int hak = 1;
            //int girilenSayi = 0;
            //while (girilenSayi!=tutulanSayi&&hak<=5)
            //{
            //    Console.WriteLine($"{hak}.Değeri giriniz");
            //    girilenSayi = Convert.ToInt32(Console.ReadLine());
            //    if (tutulanSayi > girilenSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz");
            //    }
            //    else if (tutulanSayi < girilenSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Doğru tahmin: " + tutulanSayi);
            //        break;
            //    }
            //    hak++;
            //    if (hak == 5)
            //    {
            //        Console.WriteLine("Hakkınız doldu kalan hak: "+hak);
            //    }
            //}

            #endregion

            #region Ödev Switc Case if else
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion
            #region Switch Case Ödev Çözüm
            //try
            //{
            //    Console.WriteLine("Cinsiyet:");
            //    string cinsiyet = Console.ReadLine().ToUpper();
            //    switch (cinsiyet)
            //    {
            //        case "E": Console.WriteLine("Yaş:");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            if (yas > 59)
            //            {
            //                Console.WriteLine("Maaş:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 10));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayısı:");
            //                int gunSayisi = Convert.ToInt32(Console.ReadLine());
            //                if (gunSayisi >= 6000)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu...");
            //                }
            //            }
            //            break;
            //        case "K":
            //            Console.WriteLine("Yaş:");
            //            int yas2 = Convert.ToInt32(Console.ReadLine());
            //            if (yas2 > 57)
            //            {
            //                Console.WriteLine("Maaş:");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 10));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayısı:");
            //                int gunSayisi = Convert.ToInt32(Console.ReadLine());
            //                if (gunSayisi >= 5600)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz: " + (maas * 11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu...");
            //                }
            //            }
            //            break;
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

        }
    }
}
