using System.Collections.Generic;

namespace _20_Overload_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Overload methods Aynı isme sahip metot türleridir bu metot yapısı farklı imza tipleri barındırmalıdır.
             * Aynı isme sahip farklı imza yapıları olmalıdır yoksa hata verir
             * Bu yapı aslında OOP(Object oriented programing) yapısından Polymorphism'i desteklemektedir.
             * Yani Statik(sabit) çok biçimcilik
             * Hem iş yapan hemde geriye değer döndüren metot yapısında overload olarak kullanıma uygundur.
             */
            //Yaz();
            //Yaz("Metin değeri");
            //Yaz("C#", "Dersi");
            //Console.WriteLine();
            //4 temel matematik işlemini yapan Islem adında bir methodumuz olacak bu yapıya verdiğimiz değerlerle toplama,
            //çıkartma , çarpma,bölme işlemi yapacak hepsinin adı Islem olacak method imzaları farklı olacak
            //bir if ile kullanıcıyı yapması gereken işleme yönlendirip o methodu çağırabiliriz örneğin
            //+ dedi ise kullanıcının girdiği 2 sayıyı toplama olan Islem methoduna yönlendirecek. sonuç yazacak.

            //Console.WriteLine("Yapmak istediğiniz işlem");
            //string islem = Console.ReadLine();
            //IslemYap(islem);
            Console.WriteLine("1.Sayı:");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem");
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                IslemYap((int)sayi, (int)sayi2);
            }
            else if (islem == "-")
            {
                IslemYap(sayi, (int)sayi2);
            }
            else if (islem == "*")
            {
                IslemYap(sayi, sayi2);
            }
            else if (islem == "/")
            {
                IslemYap((int)sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }

        }
        static void Yaz()
        {
            Console.WriteLine("Merhaba");
        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Yaz(string metin, string metin2)
        {
            Console.WriteLine(metin + " " + metin2);
        }
        static void IslemYap(string islem)
        {
            Console.WriteLine("1.Sayı:");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (islem == "+")
            {
                IslemYap((int)sayi, (int)sayi2);
            }
            else if (islem == "-")
            {
                IslemYap(sayi, (int)sayi2);
            }
            else if (islem == "*")
            {
                IslemYap(sayi, sayi2);
            }
            else if (islem == "/")
            {
                IslemYap((int)sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }

        }
        static void IslemYap(int sayi, int sayi2)
        {
            Console.WriteLine($"Değerlerin Toplamı {sayi + sayi2}");
        }
        static void IslemYap(double sayi, int sayi2)
        {
            Console.WriteLine($"Değerlerin Çıkartma sonucu: {sayi - sayi2}");
        }
        static void IslemYap(double sayi, double sayi2)
        {
            Console.WriteLine($"Değerlerin Çarpımı {sayi * sayi2}");
        }
        static void IslemYap(int sayi, double sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Sayı sıfıra bölünemez");
            }
            else
            {
                Console.WriteLine($"Değerlerin Bölme sonucu {sayi / sayi2}");
            }
            
        }

    }
}
