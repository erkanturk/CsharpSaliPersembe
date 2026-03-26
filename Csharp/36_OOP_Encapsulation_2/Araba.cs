using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_OOP_Encapsulation_2
{
    internal class Araba
    {
        private double Hiz;
        private const double maxHiz = 250;

        public double _Hiz
        {
            get { return Hiz; }
            set
            {
                if (value > 0 && value <= maxHiz)
                {
                    Hiz = value;
                }
                else
                {
                    Console.WriteLine($"Hızınız 1 ila {maxHiz} arasında olmalıdır");

                }


            }

        }
        public void Hizlan(double artis)
        {
            if (artis > 0 && artis <= maxHiz)
            {
                Hiz += artis;
            }
            else
            {
                Console.WriteLine($"Şu an ki hızınız {Hiz} Maksimum çıkabileceğiniz Hız {maxHiz}");

            }
        }
        public void Yavasla(double yavasla)
        {
            if (Hiz >= yavasla)
            {
                Hiz -= yavasla;
            }
            else if (Hiz != 0)
            {
                Console.WriteLine("Arabanın mevcut hızı" + Hiz);
            }
             if (yavasla > Hiz)
            {
                Console.WriteLine("Araba stop etti");
                Hiz = 0;
                Console.WriteLine("Aracın hızı "+Hiz);
            }

        }

    }
}
