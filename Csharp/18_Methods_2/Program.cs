namespace _18_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = { 1, 2, 3, 4, 5 };
            //Dondur(dizi);
            //Dondur(10,20,30,40,50);
            Console.WriteLine("Sayı giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz değer");
            string islem = Console.ReadLine();
            //if (islem == "+")
            //{
            //    Topla(sayi, sayi2);
            //}
            //else if (islem == "-")
            //{
            //    Cikartma(sayi, sayi2);
            //}
            //else if (islem == "*")
            //{
            //    Carpma(sayi, sayi2);
            //}
            //else if (islem == "/")
            //{

            //    Bol(sayi, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}
            #region Islem method kullanımı
            //IslemYap();
            //IslemYap2(sayi, sayi2);
            IslemYap3(sayi,sayi2,islem);
            #endregion

        }

        static void Dondur(int[] ints)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
        static void IslemYap()
        {
            Console.WriteLine("Sayı giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz değer");
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem == "-")
            {
                Cikartma(sayi, sayi2);
            }
            else if (islem == "*")
            {
                Carpma(sayi, sayi2);
            }
            else if (islem == "/")
            {

                Bol(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }
        }
        static void IslemYap2(double sayi, double sayi2)
        {
            Console.WriteLine("Yapmak istediğiniz değer");
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem == "-")
            {
                Cikartma(sayi, sayi2);
            }
            else if (islem == "*")
            {
                Carpma(sayi, sayi2);
            }
            else if (islem == "/")
            {

                Bol(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }
        }
        static void IslemYap3(double sayi, double sayi2, string islem)
        {
            
            if (islem == "+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem == "-")
            {
                Cikartma(sayi, sayi2);
            }
            else if (islem == "*")
            {
                Carpma(sayi, sayi2);
            }
            else if (islem == "/")
            {

                Bol(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }
        }
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine("Toplama sonucu: "+(sayi+sayi2));
        }
        static void Cikartma(double sayi, double sayi2)
        {
            Console.WriteLine("Çıkartma sonucu: "+(sayi-sayi2));
        }
        static void Carpma(double sayi, double sayi2)
        {
            Console.WriteLine("Çarpma sonucu: "+(sayi*sayi2));
        }
        static void Bol(double sayi, double sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Sayı 0 a bölünemez");
            }
            else
            {
                Console.WriteLine("Bölme Sonucu:"+(sayi/sayi2));
            }
        }
    }
}
