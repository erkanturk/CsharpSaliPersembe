namespace _09_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try -Catch (Hata Yakalama) Dene yakala
             * Yazdığımız kod bloklarında syntax hatası var ise bu kısım derleme esnasında hata verir ve program çalışmaz
             * Try catch yapısı programın çalışma sırasında oluşacak hataları algılar catch bloğuna atar ve 
             * programın çökmesini engeller 
             * Kod sağlığı ve kullanıcı deneyimi açısından önemlidir
             
             */
            #region Try catch örnek 1

            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi);
            //int sayi=0;//undefined hata almamak için burada tanımladık

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata");
            //}
            //Console.WriteLine("Kod çalışmaya devam eder");
            //Console.WriteLine(sayi);
            #endregion

            #region Try Catch Exceptions örnek
            //int sayi1 = 0;
            //int sayi2 = 0;
            //try
            //{
            //    Console.WriteLine("sayı giriniz");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.sayı");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi1 / sayi2);


            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);//formatsal hatanın mesajını göster.
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Bir sayı sıfıra bölünemez");
            //    Console.WriteLine(e.Message);
            //}
            //catch (OverflowException e)//çok büyük veya çok küçük sayılar için
            //{
            //    Console.WriteLine("Girdiğiniz sayı çok büyük veya çok küçük");
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e )
            //{

            //    Console.WriteLine(e.Message); //diğer tüm hataların mesajını göster
            //}
            //try
            //{
            //    Console.WriteLine("sayı giriniz");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.sayı");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi1 / sayi2);


            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message); //diğer tüm hataların mesajını göster
            //}

            #endregion

            #region Finally bloğu
            //int sayi = 0;
            //int sayi2 = 0;
            //try
            //{
            //    Console.WriteLine("Bağlantı açıldı");
            //    Console.WriteLine("sayi");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("sayi2");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / sayi2);
               
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Hata: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Her koşulda çalışırım. " + (sayi + sayi2));
            //    Console.WriteLine("bağlantı kapandı");
            //}

            #endregion
        }
    }
}
