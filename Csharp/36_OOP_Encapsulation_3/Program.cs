namespace _36_OOP_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Iban giriniz");
            ogrenci._Iban = Console.ReadLine();
            Console.WriteLine("Ad giriniz");
            ogrenci._Ad = Console.ReadLine();
            Console.WriteLine("Yaş giriniz");
            ogrenci._Yas = Convert.ToInt32(Console.ReadLine());
        }
    }
}
