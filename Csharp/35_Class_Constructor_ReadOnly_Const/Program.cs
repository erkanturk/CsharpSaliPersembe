namespace _35_Class_Constructor_ReadOnly_Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstTest test = new ConstTest(3.22);
            double sayi = ConstTest.PiSayisi;
            Console.WriteLine(sayi);
            Console.WriteLine(ConstTest.PiSayisi);

            ReadOnlyTest readOnly = new ReadOnlyTest(15);
            //readOnly.ReadOnly = 3;
            Console.WriteLine(readOnly.ReadOnly);
            ReadOnly2 readOnly2 = new ReadOnly2(25);
            Console.WriteLine(readOnly2.ReadOnly);

        }
    }
}
