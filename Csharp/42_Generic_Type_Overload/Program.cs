namespace _42_Generic_Type_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun<int> urun = new Urun<int>(10, 10);//int olarak propertyler cevap verecek
            Urun<string, char> urun2 = new Urun<string, char>("Erkan", 'T');
            urun2.Value = "String";
            urun2.Value2 = 'A';
            Urun<int, char> urun3 = new(123, 'B');
            urun3.Value = 123;
            urun3.Value2 = 'B';
            int[] deger = { 123, 45, 66, };
            Urun<DateTime, int[]> urun4 = new(DateTime.Now, deger);
            urun4.Value = DateTime.Today;
            urun4.Value2 = deger;

            foreach (var item in urun4.Value2)
            {
                Console.WriteLine(item);
            }

            Urun<object, object> urun5 = new(DateTime.Now, true);//Nesnesel veri barındırma.
            urun5.Value = "Deneme";
            urun5.Value = 'A';
            urun5.Value = DateTime.Now;


        }
    }
}
