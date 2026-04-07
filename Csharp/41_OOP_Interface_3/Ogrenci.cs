using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_3
{
    internal class Ogrenci:Insan
    {
        public int OkulNo { get; set; }
        public override string Name { get ; set ; }
        public override string SurName { get ; set ; }

        public override void Bilgi()
        {
            Console.WriteLine($"Ad:{Name} Soyad: {SurName} Okul Numarası: {OkulNo}");
        }
    }
}
