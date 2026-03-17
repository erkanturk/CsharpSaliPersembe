using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object_2
{
    internal static class User
    {
        public static string Ad;
        public static string Soyad;
        public static string KullaniciAdi;
        public static long TelefonNo;
        public static void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Telefon No");
            TelefonNo = long.Parse(Console.ReadLine());
            Console.WriteLine($"Ad{Ad} Soyad{Soyad} Kullanıcı Adı{KullaniciAdi} Telefon{TelefonNo}");
        }
    }
}
