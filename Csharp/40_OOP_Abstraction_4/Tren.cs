using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_4
{
    internal class Tren : Tasit
    {
        public int VagonSayisi { get; set; }
        public string Sinif { get; set; }

        public Tren(string marka, string model, double tabanFiyat, int vagonSayisi, string sinif) : base(marka, model, tabanFiyat)
        {
            VagonSayisi = vagonSayisi;
            Sinif = sinif;
        }

        public override double Fiyat
        {
            get
            {
                if (Sinif == "A")
                {
                    TabanFiyat += 5000;
                }
                else if (Sinif == "B")
                {
                    TabanFiyat += 10000;
                }
                return TabanFiyat + (VagonSayisi * 30000);
            }
        }
    }
}

