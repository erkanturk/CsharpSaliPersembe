using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_3
{
    public abstract class Insan
    {
        public abstract string Name { get; set; }
        public abstract string SurName { get; set; }

        public abstract void Bilgi();
    }

}
