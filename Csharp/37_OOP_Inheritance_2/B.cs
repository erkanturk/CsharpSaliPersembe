using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Inheritance_2
{
    internal class B:A
    {
        public int BSinifi { get; set; }
        public B()
        {
            Console.WriteLine("B sınıfı constructor");
        }
    }
}
