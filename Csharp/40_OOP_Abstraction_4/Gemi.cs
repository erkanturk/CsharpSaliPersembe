using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_4
{
    internal class Gemi : Tasit
    {
        public int KamaraSayisi {  get; set; }
        public Gemi(string marka, string model, double tabanFiyat, int kamaraSayisi) : base(marka, model, tabanFiyat)
        {
            KamaraSayisi = kamaraSayisi;
        }

        public override double Fiyat {

            get
            {
                return TabanFiyat + (KamaraSayisi * 40000);
            }
        
        }
    }
}
