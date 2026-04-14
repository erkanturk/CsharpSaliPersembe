namespace _42_Generic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Generic mimari
             * Aynı tasarımda farklı tiplerle çalışan yapılar için kullanılır
             * Kod tekrarını önler
             * Tip güvenliği sağlar
             * LINQ yapısının temelini oluşturur
             * <T> parametresini kullanarak tip belirlenir 
            
            */
            Console.WriteLine("Generic kullanımı");
            //Test test = new Test();//Hata verir generic bir yapıtıdır generic olan yapıda T değerini belirmeliyiz.
            Test<double> test = new Test<double>();
            //test.NonGenericField = 15.5;//int bir field olduğu için sadece int değer taşır.
            test.NonGenericField = 10;//Sadece int değer barındırır.
            test.GenericField = 15.5;
            Console.WriteLine(test.GenericField);
            Test<char> test1 = new();
            test1.GenericField = 'a';
            Console.WriteLine(test1.GenericField);
            Test<string> test2 = new();
            test2.GenericField = "hello";
            Console.WriteLine(test2.GenericField);

            Console.WriteLine("Primary constructor ile generic");

            Urun<int> urun = new(10, 25);
            urun.Fiyat = 25000;
            urun.Kdv = 2;


            Console.WriteLine(urun.ToString());

            Urun<decimal> urun1 = new(123.45m, 1.20m);
            urun1.Fiyat = 12345.65m;
            urun1.Kdv = 1.20m;
            Console.WriteLine(urun1.ToString()) ;

        }
    }
}
