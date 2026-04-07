namespace _41_OOP_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OzelIsci ozelIsci = new OzelIsci();
            Console.WriteLine("Adınız");
            ozelIsci.Name = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            ozelIsci.SurName = Console.ReadLine();
            Console.WriteLine("Maaşınız");
            ozelIsci.Maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sözleşme başlangıç tarihi");
            ozelIsci.SozlesmeTarihi = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Sgk No");
            ozelIsci.SgkNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Görevi");
            ozelIsci.Gorevi = Console.ReadLine();

            ozelIsci.Bilgi();
        }
    }
}
