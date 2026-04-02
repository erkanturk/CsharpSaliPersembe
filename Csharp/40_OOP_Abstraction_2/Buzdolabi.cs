using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_2
{
    internal class Buzdolabi : Elektirikli
    {
        public override double AlisFiyati { get ; set  ; }
        public override double KarYuzdesi { get ; set; }

        public override double FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;

        }
    }
}
