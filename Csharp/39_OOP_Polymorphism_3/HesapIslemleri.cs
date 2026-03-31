using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Polymorphism_3
{
    internal class HesapIslemleri
    {
        public virtual void ParaGonder(int tutar)
        {
            const double kdv = 1.20;
            Console.WriteLine($"{tutar*kdv} Havale Yapıldı");
            
        }
    }
}
