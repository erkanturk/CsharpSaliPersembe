namespace _13_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*For döngüsü Tekrar eden kodları bir yapı halinde tanımlamak için kullanılır
             * Koşul true olduğu sürece çalışır.
             * Kullanımı
             * 
             * for(veritipi değişken = değer ; değişken<sayı veya uzunluk ;artış azalış)


             */
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #region kullanıcıdan alınan sayının faktöriyelini hesaplama
            //5=>1*2*3*4*5=120
            //Console.WriteLine("Faktöriyel hesaplanacak sayıyı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int f = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    f *= i;
            //}
            //Console.WriteLine("Faktoriyen: "+f);
            #endregion
            #region Çarpım Tablosu
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{j} X {i}={i * j}\t");// \t bir tab boşluk bırak
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            #region Örnek 3
            //100 sayının çift katlarını getiren döngü
            //for (int i = 0; i <=100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //for (int i = 0; i < 10; )//Sonsuz döngü
            //{
            //    Console.WriteLine(i);
            //}
            //for (; ;)//Sonsuz döngü
            //{
            //    Console.WriteLine("Merhaba");
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5 || i == 6)
            //    {
            //        continue;
            //    }
            //    if (i == 9)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //for (char i ='A'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i+" "+(int)i);
            //}
            #endregion
            #region 200den başlayarak 3 e tam bölünen sayıların toplamını Ekrana yazdırın
            //int toplam = 0;
            //for (int i = 200; i > 0; i--)
            //{
            //    if (i % 3 == 0)
            //    {
            //        //Console.WriteLine(i);
            //        toplam += i;

            //    }
            //}
            //Console.WriteLine("Toplam sonuc: " + toplam);
            //toplam = 0;
            //for (int i = 198; i >0; i-=3)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam sonuc: "+toplam);
            #endregion
        }
    }
}
