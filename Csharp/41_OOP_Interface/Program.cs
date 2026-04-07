namespace _41_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface Nedir ?
            /* Interface(Arayüz)
             * Bir arayüzdür,Sınıf değildir!!!!!!!
             * Gövdesiz methodlar tanımlanır
             * .Net 8+ ile gövdeli methodlar da tanımlanabilir (default implementation)
             * Constructor tanımlanmaz
             * Instance(nesne) oluşturulamaz
             * Bir sınıf birden fazla interface'i implemente edebilir
             * Interface isimleri genelde 'I' ile başlar (IRepostory,IService,ITasit) gibi
             * Arayüzler soyut yapılardır inheritance değil implemente edilir 
             * Daima arayüzler public tanımlanmalıdır.
             * Neden kullanılır ?
             * 
             * Büyük projelerde geliştiricilere yol gösterir 
             * Sınıfların hangi özellikleri barındırması gerektiğini belirtir
             * Loose coupling (gevşek bağlılık) sağlar
             * Test edilebilirliği arttırır
             * Hata payını minimize eder.
             */
            #endregion

            Araba araba = new()
            {
                Marka = "Toyota",
                Model = "Corolla"
            };
            araba.Calistir();
            araba.Durdur();

            Console.WriteLine("Polymorphism ile interface");
            IArac arac = new Araba { Marka = "Honda", Model = "Civic" };//Çok biçimcilik ile 
            //IArac yapısı üzerinden arabayı biçimlendiriyoruz.

            ElektirikliAraba arac1 = new ElektirikliAraba { Marka = "Togg", Model = "T10F", BataryaKapasitesi = 75 };
            arac1.Calistir();
            arac1.Durdur();
            arac1.SarjEt();


           ILogger logger = new ConsoleLogger();
            logger.Log("Bu bir test mesajıdır");
            logger.LogHata("Bu bir hata mesajıdır.");

        }
    }

    public interface IArac
    {
        //Properyt
        string Marka { get; set; }
        string Model { get; set; }
        //Gövdesiz methodlar
        void Calistir();
        void Durdur();
    }
    public interface ISarjEdilebilir
    {
        int BataryaKapasitesi { get; set; }
        void SarjEt();
    }
    public interface IPilli:ISarjEdilebilir
    {
        int volt {  get; set; }
    }

    public class Araba : IArac
    {
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        public void Calistir()
        {
            Console.WriteLine($"{Marka} {Model} çalıştırıldı.");
        }

        public void Durdur()
        {
            Console.WriteLine($" {Marka} {Model} durduruldu");
        }
    }
    public class ElektirikliAraba : IArac, ISarjEdilebilir
    {
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int BataryaKapasitesi { get; set; } = 0;

        public void Calistir()
        {
            Console.WriteLine($"{Marka} {Model} çalıştırıldı.");
        }

        public void Durdur()
        {
            Console.WriteLine($"{Marka} {Model} durduruldu.");
        }

        public void SarjEt()
        {
            Console.WriteLine($"{Marka} {Model} Şarj ediliyor kapasitesi {BataryaKapasitesi} kWh.");
        }
    }
    public interface ILogger
    {
        void Log(string mesaj);//Gövdesiz
        void LogHata(string mesaj)//Gövdeli yapı
        {
            Console.WriteLine("Hata:" + mesaj);
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        //LogHata methodu implemente edilmedi -default implementation kullanılır
        //Zaten gövdesi var tekrardan gövdelendirilemez 
        
    }
}
