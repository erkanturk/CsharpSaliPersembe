using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generic_Mimari
{
    //where koşul ifadesidir bu T type yapısının zorunlu olarak sınıf tipi alacağını int string vb tipler alamayacapını belirtiyor.
    internal interface IPersonel<T> where T: class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
    }
}
