namespace _37_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Inheritance(Kalıtım Miras alma)
             * Bir sınıf Ortak özellikleri barındırır.
             * Bu sınıf yapısı Parrent sınıf olarak oluşturulur ve bu sınıftan miras alan child sınıflar,
             * Parrent sınıfın özelliklerini kullanabilirler.
             * Bu yapıyı kullanmak için ':' iki nokta işlemi ile sınıfın kalıtım alması gerekmektedir
             * fakat bu yapı sealed olarak işaretlenmiş ise kalıtım almaya uygun olamaz 
             * !!!!Önemli not 
             * Parrent sınıf child sınıftan miras alamaz veya child sınıfın özelliklerini kullanamaz.
             * 
             */
            Personel personel = new Personel();
            IK ik = new IK();
            Pazarlama pazarlama = new Pazarlama();
            Muhasebe muhasebe = new Muhasebe();

            ik.AdSoyad = "Erkan Türk";
            ik.TC = "12345678901";
            ik.Adres = "Kadıköy";
            ik.SigortaTuru = "SSK";
            ik.IseGirisTarihi = DateTime.Now;
            ik.PersonelSayi = 3;
            ik.Yas = 25;
            ik.Yaz();

            pazarlama.AdSoyad = "Altan Emre";
            pazarlama.TC = "98765432101";
            pazarlama.Adres = "Ümraniye";
            pazarlama.MusteriSayisi = 5;
            pazarlama.SigortaTuru = "SGK";
            pazarlama.Yas = 27;
            pazarlama.IseGirisTarihi= DateTime.Now;
            pazarlama.Yaz();

            muhasebe.AdSoyad = "Tahsin Canpolat";
            muhasebe.TC = "45645645645";
            muhasebe.HesapSayisi = "5";
            muhasebe.SigortaTuru = "SSK";
            muhasebe.IseGirisTarihi = DateTime.Now;
            muhasebe.Adres = "Üsküdar";
            muhasebe.Yas = 28;
            muhasebe.Yaz();
            


        }
    }
}
