using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Constructor_ReadOnly_Const
{
    internal class ReadOnlyTest
    {
        public readonly int ReadOnly = 10;//Readonly ilk tanımlandığı yerde yada constructor tarafında güncellenebilir
        //Const yapısı bu şekilde kullanılamaz genelde dışa bağımlılıklarda biz readonly yapısını kullanırız 
        //bize veriyi güvenli bir biçimde getirmesi için
        public ReadOnlyTest(int sayi)
        {
            ReadOnly = sayi;
        }
    }
    internal class ReadOnly2(int sayi)
    {
        public readonly int ReadOnly = sayi;
       
    }
}
