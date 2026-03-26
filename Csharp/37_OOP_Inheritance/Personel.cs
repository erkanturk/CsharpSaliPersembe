using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Inheritance
{
    internal class Personel
    {
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string SigortaTuru { get; set; }

        public void Yaz()
        {
            Console.WriteLine($"Adı{AdSoyad} Yaş {Yas} Adres {Adres} İşe Giriş Tarihi {IseGirisTarihi} Sigorta Türü {SigortaTuru} ");
        }
    }
}
