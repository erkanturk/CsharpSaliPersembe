using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Generic_Type
{
    /*<T> parametresi ile herhangi bir tip alınabilinir
        Kullanımı
        * Test sınıfına verilen <T> aslında burada bir veri tipi kullanılacağını fakat bu veritipinin 
        * Tanımlanırken ne olacağı daha belirlenmemiş olduğunu belirtiyoruz.
        * T değeri string int double istediğimiz veri tipi kullanılabilinir.
     */
    internal class Test<T>
    {
        public int NonGenericField { get; set; } = 0;//Default varsayılan değer Eğer bir değer atanmazsa hatayı önlemek için kullanılır.

        public T GenericField { get; set; } = default!; //string null döndürebilir eğer int 0 dönderebilir.
    }
}
