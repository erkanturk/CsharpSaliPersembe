using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_2
{
    internal class Telefon:Sarjli
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public override double MiliAmperSaat { get; set; } = 5000;
        public override double AlisFiyati { get; set ; }
        public override double KarYuzdesi { get ; set; }

        public override double FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;

        }
        public Telefon()
        {
            
        }
    }
}
