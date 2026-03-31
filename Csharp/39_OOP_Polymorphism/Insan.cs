using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism
{
    internal class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public virtual void Kaydet()
        {
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            Yas=Convert.ToInt32(Console.ReadLine());
        }
    }
}
