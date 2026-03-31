using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism_3
{
    internal class Eft:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            const double kdv = 1.35;
            Console.WriteLine($"{tutar*kdv} eft yapıldı");
            
        }
    }
}
