namespace _36_OOP_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ödev Kapsülleme
            /*** Ödev ***
        Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
        Bu uygulamada, kullanıcı kendi bakiyesini görebilecek fakat  başkaları görememeli
        bir kullanıcı girişi olsun atm sistemi gibi o yapıda kullanıcı şifresini girerse 
        1-para çek 2-para yatır 
       fakat kullanıcı eğer kendisi değilse sadece bu sisteme para gönderilsin.
        Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
        doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

       Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                erişim sağlamak için kapsülleme prensibini kullanın.
       Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
       Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
        olmasına dikkat edin (örneğin, Deposit, Withdraw).
       */
            #endregion
            Araba araba = new Araba();
            araba._Hiz = 50;
            Console.WriteLine("Saate kaç km hızla gidiyorsunuz ?");
            Console.WriteLine(araba._Hiz);
            Console.WriteLine("Hızlanmak ister misin ? (E/H)");
            string cevap = Console.ReadLine();
            #region Örnek 1
            //if (cevap.ToUpper() == "E")
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Ne kadar hızlanmak istiyorsun ?");
            //        double hiz = Convert.ToDouble(Console.ReadLine());
            //        araba.Hizlan(hiz);
            //        if (hiz > 250)
            //        {
            //            if (araba._Hiz < 250)
            //            {
            //                continue;
            //            }


            //        }
            //        else if (araba._Hiz < 250)
            //        {
            //            break;
            //        }
            //    }

            //}
            //else if (cevap.ToUpper() == "H")
            //{
            //    Console.WriteLine("İyi yolculular");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı işlem Hızınız değilmedi:" + araba._Hiz);
            //}
            #endregion
            #region Örnek 2
            if (cevap.ToUpper() == "E")
            {

                Console.WriteLine("Ne kadar hızlanmak istiyorsun ?");
                double hiz = Convert.ToDouble(Console.ReadLine());
                araba.Hizlan(hiz);


            }
            else if (cevap.ToUpper() == "H")
            {
                Console.WriteLine("İyi yolculular");
            }
            else
            {
                Console.WriteLine("Hatalı işlem Hızınız değilmedi:" + araba._Hiz);
            }
            araba.Yavasla(10);
            araba.Yavasla(50);
            Console.WriteLine(araba._Hiz);
            araba.Yavasla(250);
            #endregion
        }
    }
}
