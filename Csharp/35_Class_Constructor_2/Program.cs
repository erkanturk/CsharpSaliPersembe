using System.ComponentModel.DataAnnotations;

namespace _35_Class_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get getir Set güncelle
            //Primary Constructor 
            //Sınıf yapısına parametre olarak değer verilerek kullanılır
            //Ctor yapısı kullanmadan otomatik olarak parametreli yapıyı dahil ederiz.
            //Varsayılan constructor yapısını kullanma yöntemi.
            Kisi kisi = new Kisi("Erkan", "Türk", 31);
            kisi.BilgiYaz();
            Email email = new Email("ErkanTurk@gmail.com");
            Console.WriteLine(email.Adres);
            Console.WriteLine(email.Gecerlimi);
            Email2 email2 = new Email2("ErkanTurk@gmail.com");
            email2.Adres = "Erkan@test.com";
            email2.Adres = "Turk@test.com";
            Console.WriteLine(email2.Adres);
        }

    }
    class Kisi(string ad, string soyad, int yas)//Primary constructor yapısı
    {
        public string Ad { get; } = ad;
        public string Soyad { get; } = soyad;
        public int Yas { get; } = yas;
        public void BilgiYaz()
        {
            Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Yaş: {Yas}");
        }
    }
    class Email(string adres)
    {
        public bool Gecerlimi { get; } = adres.Contains('@');
        [EmailAddress]
        public string Adres { get; } = adres.Contains('@') ? adres : "Geçersiz";

    }
    public class Email2
    {

        public Email2(string adres)
        {
            Adres = adres;
        }
        public bool Gecerlimi { get; set; }
        [EmailAddress]
        public string Adres { get; set; }
    }
}
