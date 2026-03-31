namespace _37_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Suv> listeSuv = new List<Suv>();
            List<Sport> sports = new List<Sport>();

            Suv suv = new Suv();
            suv.Yakit = "Benzin";
            suv.Marka = "Volvo";
            suv.Ceker = "4";
            suv.Model = "XC90";
            suv.Vites = "Otomatik";
            suv.Id = 123;

            listeSuv.Add(suv);

            Sport sport = new Sport()
            {
                Yakit = "Benzin",
                Marka = "Nissan",
                Cabrio = "Hayır",
                Model = "GTR34",
                Vites = "Manuel",
                Id = 10
            };
            sports.Add(sport);

            foreach (Suv item in listeSuv)
            {
                Console.WriteLine(item.Id + " " + item.Marka + " " + item.Model + " " + item.Vites + " " + item.Yakit + " " + item.Ceker);
            }

            foreach (Sport item in sports)
            {
                Console.WriteLine(item.Id + " " + item.Marka + " " + item.Model + " " + item.Vites + " " + item.Yakit + " " + item.Cabrio);
            }
        }
    }
}
