using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_4
{
    internal class Kus : IYuzen, IYuruyen, IUcan
    {
        public void Uc()
        {
            Console.WriteLine("Kuş uçuyor");
        }

        public void Yuru()
        {
            Console.WriteLine("Kuş yürüyor");
        }

        public void Yuz()
        {
            Console.WriteLine("Kuş yüzüyor");
        }
    }
}
