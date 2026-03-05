namespace _24_Ref_Out_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Out Parametresi 
             * Ref de bir referans değeri gösterirken out parametresinde değer göstermemize gerek yoktur null bir yapıyı 
             * Method içerisinde işleme tabi tutup null değerden çıkarırız ve bu yapıyı methodun dışına çıkarabiliriz.
             
             */
            int sayi;

            //OutParametreli(out sayi, out int sayi2);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);

            Islem(out int x, 20);
            Console.WriteLine(x);
            long y = 1;
            double z = 2;
            Islem2(out y, out z);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(TupleMethod());
            Islem3(out string deger, out char deger2);
            Console.WriteLine(deger+" "+deger2);
        }
        static void OutParametreli(out int sayi, out int sayi2)
        {
            sayi = 20;
            sayi2 = 30;
        }
        static void Islem(out int sayi, int sayi2)
        {
            sayi = sayi2;
        }
        static void Islem2(out long sayi, out double sayi2)
        {
            sayi = 123;
            sayi2 = 123.456;
        }
        static void Islem3(out string metin, out char harf)
        {
            metin = "Out";
            harf= 'A';
        }
        static (int, int,string) TupleMethod()
        {
            int x = 1;
            int y = 2;
            string metin = "Tuple";
            return (x, y, metin);
        }
    }
}
