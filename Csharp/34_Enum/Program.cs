

namespace _34_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //KitapKategori adında  enum oluşturarak içerisine, BilimKurgu=0,
            //DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan string olarak kategori girmesini isteyelim,
            //girilen değeri KitapKategori enum'ına çevirerek
            //switch case ile kontrol edip aşağıda belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            #endregion
            #region Enum Açıklama
            /*Enum
             * Enumlar sabitler olarak adlandırılırlar bu veri tipleri hem sayısal hem metinsel olarak bize değer dönderirler
             * sabit veri yapılarında genelde enum yapısı tercih edilir bir veriyi veritabanında rakamsal olarak tutup
             * metinsel olarak kullanmamızı sağlar
             * bu yapı varsayılan olarak 0 dan başlar eper bir değer verilirse otomatik olarak bir sonraki veri tipi
             * en son verilen değerin bir fazlası olarak artarak devam eder
             *Değerler benzersiz olmalıdır aynı değer kullanılmamalıdır.
             
             */
            #endregion
            //Otomobil otomobil = new Otomobil();
            //otomobil.Marka = Markalar.Bmw;
            //otomobil.Model = "F30";
            //otomobil.Vites = Vitesler.Otomatik;
            //otomobil.Renk = Renkler.Siyah;
            //otomobil.UretimYili = 2020;
            //otomobil.MotorHacmi = 2000;
            //otomobil.OzellikYaz();

            //Markalar marka = Markalar.Mercedes;
            //Console.WriteLine(marka);
            //Console.WriteLine((byte)marka);
            //string[] markalar = Enum.GetNames(typeof(Markalar));
            //foreach (var item in markalar)
            //{
            //    Console.WriteLine(item);
            //}
            //byte[] deger = (byte[])Enum.GetValues(typeof(Markalar));
            //foreach (var item in deger)
            //{
            //    Console.WriteLine(item);
            //}
            //bool sonuc = Enum.IsDefined(typeof(Markalar), (byte)5);//True veya false değer dönderir
            //Console.WriteLine(sonuc);
            //bool sonuc2 = Enum.IsDefined(typeof(Markalar), "Bmw");
            //Console.WriteLine(sonuc2);

            //int sayi = 15;
            //for (int i = 0; i <= sayi; i++)
            //{
            //    string bgColor = i.ToString();
            //    string frColor = i.ToString();
            //    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bgColor);
            //    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), frColor);
            //    Console.Clear();
            //    Thread.Sleep(100);
            //    if (i == 15)
            //    {
            //        i = 0;
            //        continue;
            //    }
            //}
            //Console.WriteLine("Bg Color giriniz");
            //string bgColor = Console.ReadLine();
            //Console.WriteLine("ForeColor giriniz");
            //string foreColor = Console.ReadLine();
            //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bgColor);
            //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //Console.WriteLine("Renk ayarlandı");








        }
    }
    public enum Markalar:byte  {Honda=1,Mazda,Ford,Renault,Bmw,Mercedes }
    enum Vitesler { Manuel,Otomatik, YarıOtomatik }
    enum Renkler { Kırmızı = 2, Beyaz = 5, Mavi = 7, Turuncu, Siyah, Yeşil }
    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int UretimYili;
        public string Model;

        public void OzellikYaz()
        {
            Console.WriteLine($"Marka {Marka} Model {Model} Renk {Renk} Vites {Vites} Motor Hacmi {MotorHacmi} Üretim Yılı {UretimYili}");
        }
    }
 

}
