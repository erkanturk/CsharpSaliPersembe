namespace _08_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case Başlangıç
            /* Switch - Case (Koşul yapısı) 
             * İf else yapısında biz durumları karşılaştırarak işlemler yapıyoruz 
             * Fakat switch case yapısında gelen değer case bloklarında bulunuyor ise yapılacak işlem başlatılır
             * Eğer hiçbir case bloğu ile eşleşmez ise default bloğu çalışır
            */
            //Console.WriteLine("Aradığınız şehirin adını girin plakasını öğrenin");
            //string sehir = Console.ReadLine().ToLower();//kullanıcının girdiği tüm karakterleri küçült
            //switch (sehir)
            //{
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "ankara": Console.WriteLine($"{sehir} plakası 06"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    case "adana": Console.WriteLine($"{sehir} plakası 01"); break;
            //    case "antalya": Console.WriteLine($"{sehir} plakası 07"); break;
            //    case "trabzon": Console.WriteLine($"{sehir} plakası 61"); break;
            //    case "samsun": Console.WriteLine($"{sehir} plakası 55"); break;
            //    case "konya": Console.WriteLine($"{sehir} plakası 42"); break;
            //    //case "konya": Console.WriteLine($"{sehir} plakası 42"); break;//aynı case ifadesi birden fazla kullanılamaz
            //    //case 10: Console.WriteLine($"{sehir} plakası 42"); break;//hata verir çünkü case ifadeleri sabit olmalı
            //    default:
            //        Console.WriteLine("Plaka bilgisine ulaşılamadı");
            //        break;
            //}
            #endregion

            #region goto case kullanımı
            //Console.WriteLine("*******Kasiyer çalışma prensibi*******");
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin");
            //Console.WriteLine("1-Stok eksiltme\n2-Ürün ekleme\n3-Satış yap");//\n enter yani bir alt satıra geç demek
            //int islem = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 0: Console.WriteLine("Stok eksiltme işlemi yapıldı"); break;
            //    case 1: Console.WriteLine("Ürün ekleme işlemi yapıldı"); break;
            //    case 2: Console.WriteLine("Satış işlemi yapıldı"); goto case 0;
            //    default:
            //        Console.WriteLine("Yanlış işlem");
            //        break;
            //}
            #endregion

            #region Switch case if else kullanımı
            //Console.WriteLine("1.Sayı değerini giriniz");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı değerini giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz Aritmatik işlem\n+\n-\n*\n/");
            //char islem = Convert.ToChar(Console.ReadLine());
            //switch (islem)
            //{
            //    case '+': Console.WriteLine($"Sonuc: {sayi1 + sayi2}"); break;
            //    case '-': Console.WriteLine($"Sonuc: {sayi1 - sayi2}"); break;
            //    case '*': Console.WriteLine($"Sonuc: {sayi1 * sayi2}"); break;
            //    case '/':

            //        if (sayi2 == 0)
            //        {
            //            Console.WriteLine("Sayı sıfıra bölünemez");
            //        }
            //        else
            //        {
            //            Console.WriteLine(sayi1 / sayi2);
            //        }
            //        break;
            //    default: Console.WriteLine("Hatalı seçim"); break;
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

          


        }
    }
}
