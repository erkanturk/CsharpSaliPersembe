using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object
{
    internal class Ogretmen
    {
        internal int OgretmenNo;
        internal string OgretmenAdi;
        internal string OgretmenSoyadi;
        internal int Telefon;
        internal void OgretmenBilgi()
        {
            Console.WriteLine($"Öğretmen Adı: {OgretmenAdi} Soyadı: {OgretmenSoyadi} Telefon:{Telefon}");
        }
    }
}
