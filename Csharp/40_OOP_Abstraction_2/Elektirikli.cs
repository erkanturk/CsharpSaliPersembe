using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_2
{
    public abstract class Elektirikli:Elektronik
    {
        public double Voltaj { get; set; }
        protected Elektirikli()
        {
            
        }
    }
}
