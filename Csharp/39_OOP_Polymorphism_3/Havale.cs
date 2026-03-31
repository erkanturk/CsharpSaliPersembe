using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism_3
{
    internal class Havale:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            base.ParaGonder(tutar);
        }
    }
}
