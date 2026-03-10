namespace _32_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List Generic Type verdiğimiz tipte göre bize birden fazla eleman barındıran bir koleksiyon yapısıdır
             * List yapısı indexler ile çalışır.
             * ArrayListden farklı olarak data protected bir yapıdadır.Tip güvenliği vardır.
             * Diziden farklı olarak uzunluk belirtmeyiz 2 üzeri n olarak uzunluğu artar
             * List yapısı içerisinde her type  barındırılır bu yapılar variable olarak int,string,double,datetime,bool,veya sınıf yapıları olabilir.
             *!!!!Arraylist yapısı ile aynı hazır methodları kullanırız.
             *Arraylistden farklı olarak linq yapısını(ileri sorgulama yöntemi) kullanıyoruz.
             */
            #region List
            //List<string> list = new List<string>();
            //list.Add("Ögrenci 1");
            //list.Add("Ögrenci 2");
            //list.Add("Ögrenci 3");
            //list.Add("Ögrenci 4");
            //list.Add("Ögrenci 5");
            //list.Add("Ögrenci 6");
            //list.Add("Ögrenci 7");
            //list.Add("Ögrenci 8");
            //list.ForEach(x => Console.WriteLine(x));//Linq method foreach '=>' lambda expresion

            //List<int> sayilar = new List<int>() { 10, 20, 30, 22, 23, 24, 35, 33, 50, 10, 20, 30, 22, 23, 24, 35, 33, 50, 10, 20, 30, 22, 23, 24, 35, 33, 50, 10, 20, 30, 22, 23, 24, 35, 33, 50 };

            //sayilar.ForEach(x => Console.WriteLine(x));

            ////20 den büyük sayıları getiren linq sorgusu
            //Console.WriteLine("************");
            ////Where ToList ForEach Yapısı linq da kullanılan ileri sorgulama yöntemidir.

            //sayilar.Where(yas => yas > 20).ToList().ForEach(yas => Console.WriteLine(yas));

            //int index = sayilar.FindIndex(x => x == 20);//index değerini getirir belirtilen elemanı
            //Console.WriteLine(index);
            //var varMi = sayilar.Find(x => x == 20);//İçinde olan elemanı getirir.
            //Console.WriteLine(varMi);
            //Console.WriteLine("*****************");
            //int toplam = 0;
            //foreach (var item in sayilar)
            //{
            //    toplam += item;
            //}
            //Console.WriteLine(toplam);
            //Console.WriteLine("*********");
            //int topla = sayilar.Sum();
            //Console.WriteLine(topla);
            //Console.WriteLine("************");
            //double ortalama = sayilar.Average();
            //Console.WriteLine(ortalama);
            #endregion

            #region Class ve List
            //Kisi kisi = new Kisi();//nesne oluşturma instance örneklem
            //kisi.Ad = "Erkan";
            //kisi.Soyad = "Türk";
            //kisi.Yas = 31;

            //Kisi kisi2 = new Kisi();
            //kisi2.Ad = "Altan";
            //kisi2.Soyad = "Demirci";
            //kisi2.Yas = 36;

            //Kisi kisi3 = new Kisi();
            //kisi3.Ad = "Tahsin";
            //kisi3.Soyad = "Canpolat";
            //kisi3.Yas = 34;

            //kisi.Ad = "Furkan";
            //kisi.Soyad = "Uçan";
            ////Console.WriteLine(kisi.Ad);
            ////Console.WriteLine(kisi2.Ad);
            ////Console.WriteLine(kisi3.Ad);

            //List<string> kisiler = new List<string>();
            //kisiler.Add(kisi.Ad);
            //kisiler.Add(kisi.Soyad);
            //kisiler.Add(kisi2.Ad);
            //kisiler.Add(kisi2.Soyad);
            //kisiler.Add(kisi3.Ad);
            //kisiler.Add(kisi3.Soyad);

            //foreach (var item in kisiler)
            //{
            //    Console.WriteLine(item);
            //}
            Kisi kisi = new Kisi();//nesne oluşturma instance örneklem
            kisi.Ad = "Erkan";
            kisi.Soyad = "Türk";
            kisi.Yas = 31;

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Altan";
            kisi2.Soyad = "Demirci";
            kisi2.Yas = 36;

            Kisi kisi3 = new Kisi();
            kisi3.Ad = "Tahsin";
            kisi3.Soyad = "Canpolat";
            kisi3.Yas = 34;
            Random random = new Random();
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(kisi);
            kisiler.Add(kisi2);
            kisiler.Add(kisi3);
            //kisiler.Add(random);

            foreach (var item in kisiler)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Yas);
            }
            Kisi kisi4=new Kisi();
            for (int i = 0; i <= 1; i++)
            {
                var kisis =new Kisi();
                
                Console.WriteLine("Ad:");
                kisis.Ad = Console.ReadLine();
                Console.WriteLine("Soyad");
                kisis.Soyad = Console.ReadLine();
                Console.WriteLine("Yaş");
                kisis.Yas = Convert.ToInt32(Console.ReadLine());

                kisiler.Add(kisis);
            }
            Console.WriteLine("**********");
            foreach (var item in kisiler)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Yas);
            }
            #endregion


        }
    }
    class Kisi
    {
        public string Ad;//Property field nitelik özellik
        public string Soyad;
        public int Yas;
    }
}
