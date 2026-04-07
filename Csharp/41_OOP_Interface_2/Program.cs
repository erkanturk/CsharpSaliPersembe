namespace _41_OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıf bir arabirimi implemente edebilir hatta bu sınıf abstract bile olabilir fakat
            //Bir arabirim bir sınıftan miras alamaz
            //Bir arabirim başka bir arabirimi uygulaya bilir fakat yapılarını implemente etmez.
           
        }

    }
    public interface ISarjli
    {
        int SarjSayisi { get; set; }
        int BataryaKapasitesi { get; set; }

    }
    public interface IPilli: ISarjli
    {
        int volt {  get; set; }
    }

    public interface IElektrikli
    {
        int Wat { get; set; }
        string Enerji { get; set; }
    }
    public abstract class Elektronik//:ISarjli, IElektrikli
    {
        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }
        //public int SarjSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int BataryaKapasitesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int Wat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Laptop : Elektronik, IPilli, IElektrikli
    {
        public override string Marka { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SarjSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BataryaKapasitesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Wat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Buzdolabi : Elektronik, IElektrikli
    {
        public int Wat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Marka { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
