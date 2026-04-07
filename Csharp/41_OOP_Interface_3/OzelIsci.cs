using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Interface_3
{
    internal class OzelIsci : Insan,IOzelIsci
    {
        public string Gorevi { get; set; }
        public override string Name { get; set; }
        public override string SurName { get; set; }
        public DateTime SozlesmeTarihi { get; set; }
        public int SgkNo { get; set ; }
        public int Maas { get; set; }

        public override void Bilgi()
        {
            Console.WriteLine($"Ad:{Name} Soyad: {SurName} Görev: {Gorevi} Sözleşme Tarihi: {SozlesmeTarihi} Sgk No {SgkNo} ");
        }

        public int MaasHesapla()
        {
            return Maas = Maas * 10;
        }
    }
}
