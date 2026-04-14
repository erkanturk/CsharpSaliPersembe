using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generic_Mimari
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }

        public DateTime SgkGirisTarihi { get; set; }
        public Personel()
        {
            SgkGirisTarihi= DateTime.Now;
        }
    }
}
