namespace _07_OdevCozum_if_Else
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

            #region Sayı ödevi çözüm
            //Console.WriteLine("1.Sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine("En büyük sayı değeri: " + sayi1);
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi2);
            //        Console.WriteLine("En küçük sayı: " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi3);
            //        Console.WriteLine("En küçük sayı: " + sayi2);
            //    }
            //}
            //else if (sayi2 > sayi1 && sayi2 > sayi3)
            //{
            //    Console.WriteLine("En büyük sayı değeri: " + sayi2);
            //    if (sayi1 > sayi3)
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi1);
            //        Console.WriteLine("En küçük sayı: " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi3);
            //        Console.WriteLine("En küçük sayı: " + sayi1);
            //    }
            //}
            //else if (sayi3 > sayi1 && sayi3 > sayi2)
            //{
            //    Console.WriteLine("En büyük sayı değeri: " + sayi3);
            //    if (sayi2 > sayi1)
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi2);
            //        Console.WriteLine("En küçük sayı: " + sayi1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortancı sayı: " + sayi1);
            //        Console.WriteLine("En küçük sayı: " + sayi2);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Eşit değer girmeyiniz");
            //}
            #endregion
            #region Ödev Sıcaklık Çözüm
            Console.WriteLine("Hava durumunu belirtin");
            int sicaklik = Convert.ToInt32(Console.ReadLine());
            if (sicaklik < 5)
            {
                Console.WriteLine("Hava soğuk");
            }
            else if (sicaklik >= 5 && sicaklik <= 15)
            {
                Console.WriteLine("hava serin");
            }
            else if (sicaklik > 15 && sicaklik <= 25)
            {
                Console.WriteLine("Hava ılık");
            }
            else if (sicaklik > 25)
            {
                Console.WriteLine("Hava çok sıcak");
            }
            else
            {
                Console.WriteLine("Geçersiz değer.");
            }
            #endregion
        }
    }
}
