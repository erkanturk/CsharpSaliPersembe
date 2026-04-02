using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction_2
{
    public abstract class Elektronik
    {
        protected Elektronik()//Sadece miras alınması durumunda yapıcı method çalışır 
            //Doğrudan nesnesi oluşturulamadığı için kalıtım ile constructor çalışır.
        {
            
        }
        public abstract double AlisFiyati { get; set; }
        public abstract double KarYuzdesi { get; set; }
        public abstract double FiyatHesapla();//Gövdesiz method
    }

}
