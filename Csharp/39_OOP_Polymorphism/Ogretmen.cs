using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism
{
    internal class Ogretmen : Insan
    {
        public string Brans { get; set; }
        public int OgrenciSayisi { get; set; }

        public override void Kaydet()
        {
            Console.WriteLine("Brans");
            Brans = Console.ReadLine();
            Console.WriteLine("OgrenciSayisi");
            OgrenciSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
