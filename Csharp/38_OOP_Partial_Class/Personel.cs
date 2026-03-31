using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Partial_Class
{
    partial class Personel
    {
        public Personel(string name)
        {
            Name = name;
        }
        public void BilgiVer()
        {
            Console.WriteLine("Personel sınıfı");
            Console.WriteLine(Id+" "+Name+" "+Age+" "+Address);
        }
    }
}
