using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object
{
    internal class Ogrenci
    {
        private int OgrenciNo;
        public string OgrenciAdi;
        internal string OgrenciSoyadi;
        internal protected string Bolum;
        protected string Ders;

        private void Test()
        {
            Console.WriteLine($"Öğrenci Adi {OgrenciAdi} Öğrenci Soyadı: {OgrenciSoyadi} Öğrenci No: {OgrenciNo} Bölüm: {Bolum} Ders {Ders}");
        }

    }
}
