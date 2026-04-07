using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_4
{
    internal class Insan : IYuruyen,IYuzen
    {
        public void Yuru()
        {
            Console.WriteLine("Insan yürüyor");
        }

        public void Yuz()
        {
            Console.WriteLine("Insan yüzüyor");
        }
    }
}
