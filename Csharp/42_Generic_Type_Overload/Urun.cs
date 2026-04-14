using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Generic_Type_Overload
{
    internal class Urun<T>
    {
        public T Value { get; set; }
        public T Value2 { get; set; }
        public Urun(T value,T value2)
        {
            Value = value;//DI
            Value2 = value2;
        }
    }
    internal class Urun<Erkan,Turk>//T Type manasında kullanılır istediğimiz değeri belirtebiliriz 
    {
        public Erkan Value { get; set; }
        public Turk Value2 { get; set; }
        public Urun(Erkan value,Turk value2)
        {
            Value2 = value2;
            Value = value;
        }
    }
}
