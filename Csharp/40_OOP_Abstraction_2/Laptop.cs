using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_2
{
    internal class Laptop : Sarjli//Elektirikli mutable inherit diamond problem
    {
        public override double MiliAmperSaat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double AlisFiyati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double KarYuzdesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
