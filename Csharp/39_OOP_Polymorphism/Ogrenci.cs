using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism
{
    internal class Ogrenci:Insan
    {
        public int Numara { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public void NotAl()
        {
            Console.WriteLine("Vize");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final");
            Final = Convert.ToInt32(Console.ReadLine());
        }
        public void NotAl(int vize, int final)
        {
            Vize = vize;
            Final = final;
        }
        public override void Kaydet()
        {
            base.Kaydet();//Anasınıfta yazılı olan yapıyı da kullan
            Console.WriteLine("Numara");
            Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final");
            Final = Convert.ToInt32(Console.ReadLine());
        }
    }
}
