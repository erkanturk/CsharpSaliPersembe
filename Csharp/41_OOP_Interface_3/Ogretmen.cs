using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_3
{
    internal class Ogretmen:Insan,ICalisan
    {
        public string Brans {  get; set; }
        public override string Name { get ; set ; }
        public override string SurName { get ; set ; }
        public int SgkNo { get; set ; }
        public int Maas { get; set; }

        public override void Bilgi()
        {
            Console.WriteLine($"Ad:{Name} Soyad: {SurName} Branş: {Brans}");
        }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
