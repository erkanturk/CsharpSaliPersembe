using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_4
{
    public abstract class Tasit
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double TabanFiyat { get; set; }
        public abstract double Fiyat { get; }//Sadece var olan değeri gösterebilir.

        //Protected olmasının sebebi sınıf abstract yani nesnesi oluşturulamaz ama kalıtım yolu ile kullanılır.
        protected Tasit(string marka,string model,double tabanFiyat)
        {
            Marka= marka;
            Model = model;
            TabanFiyat= tabanFiyat;
        }
    }
}
