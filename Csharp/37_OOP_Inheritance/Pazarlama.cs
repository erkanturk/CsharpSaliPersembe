using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Inheritance
{
    internal class Pazarlama:Personel
    {
        public int MusteriSayisi { get; set; }
        public void Yaz()
        {
            base.Yaz();
        }
    }
}
