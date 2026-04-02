using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_Abstraction
{
    public abstract class Insan
    {
        public abstract long Tc { get; set; }//Soyut olarak işaretlediğimiz property 
        //Child sınıflar mutlaka bu değeri doldurmak zorundadır. implemente edilmediği sürece hata verir.
        public string Ad { get; set; }
        public string Soyad { get; set; }

        //Crud Operations (Create) oluşturma Read(okuma listeleme) Update(Güncelleme) Delete(Silme)
        public abstract void Create();//Gövdesiz method.
        public abstract void Update();
        public abstract void Delete();
        public abstract void List(); 

        public void Find(int id)//Gövdeli method
        {
            Console.WriteLine(id);
        }
    }
}
