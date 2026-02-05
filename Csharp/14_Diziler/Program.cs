namespace _14_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad="Erkan","Türk";
            //decimal d = 123m;
            //float fl = 123.45f,123;
            /*Değişkenler birden fazla değer tutamaz var olan değer güncellenebilir fakat bir değişken
             * Birden fazla yapıyı içerisinde barındıramaz
             * Programlamada birden fazla değer tutabilmenin yolu ise collections (koleksiyon) yapılarıdır
             * Dizi yapıları tek tip değer tutar eğer object olarak tanımlanmazsa
             * Örneğin sayıları barındıran bir dizi ise bu yapı sadece içerisinde sayılar olmalıdır.
             * Metinleri barındıran bir yapı ise metinler olmalıdır 
             * Elma sepeti demem için elma ile dolu olması gerekir eğer farklı meyveler varsa bu
             * elma sepeti olmaz.
             * Tanımlama
             * int[] dizi = new int[uzunluk];
             * Diziler index kavramı ile çalışırlar daima index değeri 0 dan başlar 
             * 0 index daima 1. eleman olarak geçer.
             */
            #region Boş dizi tanımla
            //int[] sayilar = new int[5];
            //sayilar[0] = 1;//boş dizinin içerisinde istediğim indexe eleman ekleme
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //sayilar[3] = 4;
            //sayilar[4] = 5;
            ////sayilar[5] = 6;//System.IndexOutOfRangeException index aşım hatası
            ////Console.WriteLine(sayilar[5]);
            //int[] sayilar2 = new int[5];
            //sayilar2[3] = 1;//boş dizinin içerisinde istediğim indexe eleman ekleme
            //sayilar2[4] = 2;
            //sayilar2[0] = 3;
            //sayilar2[2] = 4;
            //sayilar2[1] = 5;
            ////Console.WriteLine(sayilar2[4]);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);//i değeri benim index değerime eşittir.
            //}
            //Console.WriteLine("***************************");
            //int index = 0;
            //while (sayilar2.Length > index)
            //{
            //    Console.WriteLine(sayilar2[index]);
            //    index++;
            //}


            #endregion
            #region Dolu Dizi tanımı
            //string[] adlar = { "Erkan", "İlknur", "Cem", "Hasret", "Afşın", "Metin", "Ali", "Halil", "Zafer", "Arda", "Taner" };
            //Console.WriteLine(adlar[2]);//eleman sayısının -1 i index değeridir.
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i] + " " + i);
            //}
            //double[] sayi = { 10, 12.5, 55.3, 22, 33, 44.22 };
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine($"Sayının: {i + 1}. eleman: {sayi[i]} index değeri {i}");
            //}
            //sayi[5] = 05;//güncelleme işlemi
            //Console.WriteLine("******************");
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine($"Sayının: {i + 1}. eleman: {sayi[i]} index değeri {i}");
            //}
            ////foreach döngü yapısı koleksiyonlar için kullanılan bir döngü yapısıdır.
            //Console.WriteLine("**********************");
            //foreach (int i in sayi)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] number = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //int index = 8;
            //for (;;)
            //{
            //    Console.WriteLine(number[index]);
            //    if (index == 0)
            //    {
            //        break;
            //    }
            //    index--;
            //}
            //while (true)
            //{
            //    Console.WriteLine(number[index]);
            //    index--;
            //    if (index == 0)
            //    {
            //        Console.WriteLine(number[index]);
            //        break;
            //    }
            //}
            #endregion

            #region Dizi doldurma
            //char[] chars = new char[10];
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    chars[i] = Convert.ToChar(i + 64);
            //}

            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}
            //int[] sayilar = new int[10];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    //sayilar[i] = i;
            //    Console.WriteLine($"{i + 1}.Değer gir");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Object dizi
            //object[] nesne = new object[10];
            //nesne[0] = "Erkan";
            //nesne[1] = 31;
            //nesne[2] = 'E';
            //nesne[3] = 5000.22;
            //nesne[4] = true;
            //nesne[5] = DateTime.Now;

            //for (int i = 0; i < nesne.Length; i++)
            //{
            //    Console.WriteLine(nesne[i]);
            //}

            #endregion

            #region Array Methods
            //string[] adlar = { "Erkan", "Metin", "Hasret", "Cem", "İlknur" };
            ////Array.Clear(adlar);//Adlar dizisindeki tüm elemanları temizler.
            //Array.Clear(adlar, 1, 2);//ilk değer index ikincisi uzunluk değeri 
            //foreach (string item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] adlar2 = new string[10];
            //Array.Copy(adlar, adlar2, 3);
            //Array.Copy(adlar,1, adlar2, 2, 3);//Adlar dizisinin 1. index'inden başla 3 elemanını
            //adlar2'nin 2.index değerinden intibaren ekle
            //foreach (string item in adlar2)
            //{
            //    Console.WriteLine(item);
            //}
            /***IndexOf***/
            //string[] adlar = { "Erkan", "Metin", "Hasret", "Cem", "İlknur", "Erkan", "Cem", "Erkan", "Cem" };
            //int index = Array.IndexOf(adlar, "Erkan");//indexof ilk bulduğu değeri getirir.
            //Console.WriteLine(index);
            //Console.WriteLine(adlar[index]);
            //int index2 = Array.IndexOf(adlar, "Cem", 4);//aranacak index değerini belirterek diğer değeri buluruz
            //Console.WriteLine(index2);
            /*LastIndexOf*/
            //int index = Array.LastIndexOf(adlar, "Erkan");
            //int index2 = Array.LastIndexOf(adlar, "Erkan", 6);
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            /*Sort&&Revers*/
            //string[] sehirler = { "Zonguldak", "Amasya", "İstanbul", "İzmir", "Ankara", "Adana", "Bursa" };
            //int[] plakalar = { 67, 05, 34, 35, 06, 01, 16 };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i] + " Plakaları: " + plakalar[i]);
            //}
            //Array.Sort(sehirler);//A dan Z ye sıralar
            //Array.Sort(plakalar);//Küçükten büyüğe sıralar
            //Console.WriteLine("********************");
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i] + " Plakaları: " + plakalar[i]);
            //}
            //Array.Reverse(sehirler);//Tersine çevirme
            //Array.Reverse(plakalar);//Tersine çevirme
            //Console.WriteLine("********************");
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i] + " Plakaları: " + plakalar[i]);
            //}
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref sayilar, 5);//Eleman sayısı olarak değerini artırıp yada azaltabiliriz.
            //sayilar[3] = 40;
            //sayilar[4] = 50;
            ////sayilar[5] = 60;
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref sayilar, 2);//Resize ile boyut artırıp azaltabiliriz var olan bir dizinin boyutu küçültülebilir.
            //Console.WriteLine("**************");
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref sayilar, 5);
            //Console.WriteLine("**************");
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Örnek 1
            //Kullanıcıdan kaç elemanı olduğunu isteyelim ve eğer 5 eleman derse dizinin boyutu
            //5 olacak 3 derse 3 olacak
            //Kullanıcının belirtiği personelleri diziye adını eklesin.
            //Console.WriteLine("Personel Sayısı:");
            //int pSayi = Convert.ToInt32(Console.ReadLine());
            //string[] adlar = new string[pSayi];
            //string[] soyad = new string[pSayi];

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine("Ad:");
            //    adlar[i] = Console.ReadLine();
            //    Console.WriteLine("Soyad");
            //    soyad[i] = Console.ReadLine();

            //}

            //Console.WriteLine("************");
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"Ad: {adlar[i]} Soyad: {soyad[i]}");
            //}
            #endregion

            #region TryParse
            //while (true)
            //{
            //    Console.WriteLine("Personel Sayısı:");
            //    string pSayi = Console.ReadLine();

            //    if (int.TryParse(pSayi, out int s))
            //    {
            //        string[] adlar = new string[s];
            //        string[] soyad = new string[s];

            //        for (int i = 0; i < adlar.Length; i++)
            //        {
            //            Console.WriteLine("Ad:");
            //            adlar[i] = Console.ReadLine();
            //            Console.WriteLine("Soyad");
            //            soyad[i] = Console.ReadLine();

            //        }

            //        Console.WriteLine("************");
            //        for (int i = 0; i < adlar.Length; i++)
            //        {
            //            Console.WriteLine($"Ad: {adlar[i]} Soyad: {soyad[i]}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlış değer girdiniz tekrar deneyin");
            //    }
            //}

            Console.WriteLine("1.Sayı değerini giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı değerini giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz");
            Console.WriteLine("1-topla\n2-carp\n3-cikar\n4-bol");
            string islem = Console.ReadLine().ToLower();
            if (int.TryParse(islem, out int number))
            {
                if (number == 1)
                {
                    Console.WriteLine(sayi + sayi2);
                }
                else if (number == 2)
                {
                    Console.WriteLine(sayi * sayi2);
                }
                else if (number == 3)
                {
                    Console.WriteLine(sayi - sayi2);
                }
                else if (number == 4)
                {
                    if (sayi2 != 0)
                    {
                        Console.WriteLine(sayi / sayi2);
                    }
                    else
                    {
                        Console.WriteLine("sayı sıfıra bölünemez");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı işlem");
                }
            }
            else
            {
                if (islem == "topla")
                {
                    Console.WriteLine(sayi + sayi2);
                }
                else if (islem == "carp")
                {
                    Console.WriteLine(sayi * sayi2);
                }
                else if (islem == "cikar")
                {
                    Console.WriteLine(sayi - sayi2);
                }
                else if (islem == "bol")
                {
                    if (sayi2 != 0)
                    {
                        Console.WriteLine(sayi / sayi2);
                    }
                    else
                    {
                        Console.WriteLine("sayı sıfıra bölünemez");
                    }
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }
            }



            #endregion

        }
    }
}
