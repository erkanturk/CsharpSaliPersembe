using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Generic_Type
{
    internal class Urun<T>(T fiyat, T kdv)
    {

        public T Fiyat { get; set; } = fiyat;//Constructor tarafından değerleri atanacak
        public T Kdv { get; set; } = kdv;

        //public override string ToString() => $"Fiyat: {Fiyat} Kdv {Kdv}";
        public override string ToString()
        {
            return $"Fiyat {Fiyat} Kdv {Kdv}";
        }


    }
}
