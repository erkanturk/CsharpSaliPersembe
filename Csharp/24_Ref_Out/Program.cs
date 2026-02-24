namespace _24_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ref 
             * Ref anahtar kelimesi bir method içerisinde parametreye verilir ve bu parametre dışarıdan gelecek değeri referans olarak
             *  tutar ve method içerisinde yapılan değişiklikler dışarıya yansır.
             *  Bu yapı dışarıda var olan değeri method içerisinde güncellemek için kullanılır.
             *  Gerçek hayattan bir örnek verecek olursak 
             *  Üniversiteden mezun olan bir öğrenci referans olarak kendi eğitmenini veya üniversitesini gösterir
             *  işe girdikten sonra ise bir sonraki işe girme sürecinde artık referansı son iş yeridir.
             *  ref ve out anahtar kelimeleri ile birden fazla değeri dışarı çıkarabiliriz.
            */
            //int number = 5;
            //RefMethod(ref number);

            //string metin = "Merhaba";
            //Yaz(ref metin);
            //Console.WriteLine(metin);

            //string deger = "Deneme";
            //Metin(deger);
            //Console.WriteLine(deger);

            //double f1 = 100;
            //double f2 = 200;
            //double f3 = 300;
            //RefLi(ref f1, ref f2, ref f3);
            //Console.WriteLine(f1);
            //Console.WriteLine(f2);
            //Console.WriteLine(f3);
            //Console.WriteLine(Refli2(ref f1, ref f2, ref f3));
            //double toplam = Refli3(ref f1, ref f2, ref f3);
            ////Console.WriteLine(Refli3(ref f1,ref f2,ref f3));
            //Console.WriteLine(toplam);
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Sayilar(ref sayilar);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            double[] s = {10,20,30,40,50,60,60,360,22,10 };//ref ile var olan bir değeri güncelleyip dışarı çıkarabiliriz.
            Randoms(ref s);
            foreach (var item in s)
            {
                Thread.Sleep(2000);
                Console.WriteLine(item);
            }

        }
        static void RefMethod(ref int sayi)
        {
            Console.WriteLine(sayi);
            sayi = 20;
            Console.WriteLine(sayi);
        }
        static void Yaz(ref string metin)
        {
            Console.WriteLine(metin);
            metin = "C# Methodları";

        }
        static void Metin(string yaz)
        {
            Console.WriteLine(yaz);
            yaz = "Metin Değişti";
            Console.WriteLine(yaz);
        }
        static void RefLi(ref double f, ref double f2, ref double f3)
        {
            f = f + (f * 0.10);
            f2 = f2 + (f2 * 0.20);
            f3 = f3 + (f3 * 0.30);
        }
        static string Refli2(ref double f1, ref double f2, ref double f3)
        {
            f1 = f1 + (f1 * 0.10);
            f2 = f2 + (f2 * 0.20);
            f3 = f3 + (f3 * 0.30);
            return $"1.Ürün fiyatı: {f1} 2.Ürün fiyatı: {f2} 3.Ürün fiyatı: {f3}";
        }
        static double Refli3(ref double f1, ref double f2, ref double f3)
        {
            f1 = f1 + (f1 * 0.10);
            f2 = f2 + (f2 * 0.20);
            f3 = f3 + (f3 * 0.30);
            return f1 + f2 + f3;
        }
        static void Sayilar(ref int[] dizi)
        {
            dizi = new int[10];
            int sayi = 20;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = sayi;
                sayi += 2;
            }
        }
        static void Randoms(ref double[] s)
        {
           
            Random random = new Random();
            s = new double[10];
            for (int i = 0; i < s.Length; i++)
            {
                double s2 = random.Next(1,200);
                s[i] = s2;
            }
        }
    }
}
