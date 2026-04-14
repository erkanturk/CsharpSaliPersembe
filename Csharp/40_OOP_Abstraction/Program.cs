namespace _40_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract Nedir ?
            /*Abstract class'lar oluşturulması istenen class'ların sadece base class olarak davranması
             * ve üzerinden bir instance (örneklem/nesne oluşturma) oluşturulmamasını istediğimiz durumlarda kullanılır
             * C# da bu fonksiyonaliteyi sağlamak için abstract keywordu kullanmak yeterlidir.
             * Abstract sınıflar içerisinde gövdesiz methodlar tanımlayabiliriz.
             * bu methodlar base class dan miras alan sınıfların içerisinde mutlaka gövdeleri doldurulmalıdır.
             * Abstract sınıflar alt sınıflara abstract olan yapıları kullanmayı zorlar.
             * Bu işleme biz implemente deriz.
             * Abstract olarak işaretlenen yapılar override edilebilinir.
             * Sadece methodlar değil propertyler de abstract olarak işaretlenir ve override edilir.
             *
             */
           
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Create();
            ogrenci.Update();
            ogrenci.Delete();
            Ogrenci ogrenci1 = new();

        }
    }
}
