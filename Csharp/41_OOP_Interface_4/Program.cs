namespace _41_OOP_Interface_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.Yuru();
            kus.Yuz();
            kus.Uc();

            Balik balik = new Balik();
            balik.Yuz();
            Insan insan = new Insan();
            insan.Yuz();
            insan.Yuru();
        }
    }
}
