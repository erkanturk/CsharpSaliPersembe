namespace _39_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Havale havale = new Havale();
            havale.ParaGonder(500);
            Eft eft = new Eft();
            eft.ParaGonder(500);
            Swift swift = new Swift();
            swift.ParaGonder(500);
            
        }
    }
}
