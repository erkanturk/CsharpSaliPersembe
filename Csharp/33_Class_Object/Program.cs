namespace _33_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim belirleyiciler ve static non static
            /*Data access modifiers (erişim belirleyici)
             * Internal => bu yapı sadece oluşturulduğu proje tarafından erişilebilen bir erişim belirleyici yapısıdır
             * Dışa kapalı proje içine açık bir şekilde kullanılır.
             * Private özel sınıf yapısıdır bu yapı sadece bulunduğu sınıf içerisinden erişilebilir bir yapıdır 
             * Dışa ve diğer projelere kapalıdır her yapı kendi içerisinde kullanılır
             * Sınıflara private olarak değer veremeyiz sadece property'ler private olabilir.
             * Protected=>inherit(kalıtım) sadece miras alma yolu ile kullanılır bu yapı miras alınmama durumunda erişime kapalıdır.
             * Public => public olarak tanımlanan sınıf yapısı her yerden erişime açıktır dış projeler ve iç projeler bu yapıya
             * kolaylıkla erişebilir.
             * Sealed=>Mühürlü sınıf yapısıdır bir yapının miras alma yoluyla erişilememesi için kullanılır.
             * Internal Protected => miras yolu ile sadece bulunduğu projenin erişimine açık olmasını istediğimiz sınıflar için kullanırız.
             * 
             * 
             * Static ve non static
             * static yapılar sınıf içerisinde program çalışması ile birlikte sınıf üzerinden erişilip (kolay erişim) kullanılan 
             * ve lifecycle boyunca bellekte yer tutan yapılardır bir defa çalışırlar çağırılmadığı sürece daha çalışmazlar
             * genelde extension yapıları için kullanılır yardımcı yapılar olarak kullanırız
             * kendi içlerinde nesneleri oluşturulduğu için dış tarafta tekrar nesne oluşturmamız gerekmez
             * Static sınıflar static methodlar barındırır.
             * 
             * Non-Static
             * Nonstatic yapılar nesne üzerinden erişilen esnek yapılardır çağırıldığı zaman arka planda bir yapıcı method çalışır ve 
             * devamında tekrar erişim için tekrar nesne oluşturmamız gerekir optimizasyon ve süreklilik için en iyi kullanım yöntemidir.
             * 
             
             */
            //Static class'lardan asla nesne oluşturulamaz.
            // Console console = new Console();nesnelenemez.
            //Console.WriteLine();//Static yapıdadır.
            //Console.ReadLine();//Sınıf üzerinden erişim sağlarız
            //Random random = new Random();
            //random.Next();//Nesne üzerinden erişim sağlarız
            //List<int> list = new List<int>();
            #endregion

            Ogrenci ogrenci = new Ogrenci();
            //ogrenci.OgrenciNo; private olarak belirtilen yapılar sadece kendi içinde kullanılır.
            ogrenci.Bolum = "Yazılım";//Miras alma işlemine gerek kalmadan internal protected yapısı aynı projede kullanılır.
            //ogrenci.Ders;// =>Protected yapısı sadece miras yolu ile kullanılır.
            ogrenci.OgrenciAdi = "Hasret";
            ogrenci.OgrenciSoyadi = "Özdemir";

            //ogrenci.Test(); Private yapı 

            Console.WriteLine($"{ogrenci.OgrenciAdi} {ogrenci.OgrenciSoyadi} {ogrenci.Bolum}");

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.OgretmenAdi = "Erkan";
            ogretmen.OgretmenSoyadi = "Türk";
            ogretmen.Telefon = 385620687;
            ogretmen.OgretmenNo = 1453;

            ogretmen.OgretmenBilgi();

        }
    }
}
