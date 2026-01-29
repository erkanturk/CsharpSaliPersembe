namespace _10_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Loops (Döngüler) Do while,While,For,Foreach(koleksiyon yapıları için) 
             * Döngü yapıları koşul true olduğu sürece çalışır fakat do while yapıdı bu kalıpların dışında yer alır.
             * Do yap sonra koşulu kontrol et eğer koşul true ise yapmaya devam et
             * Koşul false ise bir defa işlemi yapar do kısmı sonra while kısmı kontrol edilir ve false olduğu için
             * devamında işlem yapmaz.
             * 
             * 
            */
            #region Döngü çalışma prensibi
            //Console.WriteLine("Erkan");//100 defa yazdırmak istediğimizde döngüler devreye girer.
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i + " :Erkan");
            //    i++;
            //}
            //while (i <= 100);//Koşulun gerçekleşeceği yer
            #endregion

            #region Do while çalışma prensibi
            //int j = 0;
            //do//Do while çalışma prensibi durum false olsa dahi bir defa çalışır.
            //{
            //    Console.WriteLine("Erkan");
            //} while (j > 10);//False

            //do
            //{
            //    Console.WriteLine("Sonsuz döngü");
            //}
            //while (true);
            //int i = 0;
            //do//dikkat edilmeli
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (true);
            //int sayi = 0;
            //do
            //{
            //    if (sayi == 5)
            //    {


            //        break;//Döngüyü kırma yöntemi 
            //        Console.WriteLine(sayi);//hiçbir zaman okunmayacak.

            //    }
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //while (true);
            //Console.WriteLine("Merhaba");
            #endregion
            #region Do while örnek 1
            //kullanıcı 0 girene kadar girilen sayıları toplayarak devam etsin kullanıcı 0 a bastığında döngü
            //sonlansın ve toplam girdiği değerlerin toplamını ekrana yazdırsın.

            //int toplam = 0;
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine("Sayı gir:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //} while (sayi != 0);//Eğer sayı 0 a eşitse döngü sonlansın.
            //Console.WriteLine("Toplam: " + toplam);
            //kullanıcı 0 girene kadar girilen sayıları toplayarak devam etsin kullanıcı 0 a bastığında döngü
            //sonlansın ve toplam girdiği değerlerin toplamını ekrana yazdırsın.
            //fakat kullanıcının girdiği ilk değer sıfırsa bu kontrol edilecek ve döngü yapısına devam edecek

            //int counter = 0;
            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0 && counter == 0)
            //    {
            //        counter++;
            //    }

            //    toplam += sayi;
            //}
            //while (sayi!=0);
            //Console.WriteLine("Toplam: "+toplam);

            //int sayac = 0;
            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı gir");
            //    sayi=Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0 && sayac == 0)
            //    {
            //        continue;//bu koşullar sağlanırsa bu adımı atla ve döngünün başına geri dön

            //    }
            //    else if (sayi > 0)
            //    {

            //        sayac++;
            //        toplam += sayi;
            //    }
            //    else if (sayi == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negatif değer girmeyiniz");
            //    }

            //}
            //while (true);
            //Console.WriteLine("Toplam: "+toplam);
            #endregion

        }
    }
}
