using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Constructor_ReadOnly_Const
{
    internal class ConstTest
    {
        public const double PiSayisi = 3.14;
        public ConstTest(double sayi)
        {
            //PiSayisi = sayi;//Const ilk intialize ediliği zamanki değeri okur değiştirilemez
        }
    }
}
