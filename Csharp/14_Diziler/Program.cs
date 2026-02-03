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
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                //sayilar[i] = i;
                Console.WriteLine($"{i+1}.Değer gir");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
