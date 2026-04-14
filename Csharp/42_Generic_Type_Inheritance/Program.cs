namespace _42_Generic_Type_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass<char> baseClass = new();//Value sadece char alacak
            baseClass.Value = 'A';
           // baseClass.Value = "deneme";//hata 
            ChildClass childClass = new();
            childClass.Value = "A";//Miras alırken baseclass da bulunan değer string olacak dedik 
            childClass.Deger = 'A';

            ChildClass2<double> childClass2 = new();//Test ve Value artık double tipinde olacak
            childClass2.Test = 123.45;
            childClass2.Value = 345.67;

            ChildClass3<string> childClass3 = new();
            childClass3.Value = 12;//Miras alınırken yapıya generic değeri belirtik bu sebeple int olarak value propertysi değer alacak
            childClass3.Test2 = "Generic";




        }
    }
    class BaseClass<T>
    {
        public T Value { get; set; }//Tanımlanan sınıfta tip değeri verilecektir.
    }
    class ChildClass : BaseClass<string>
    {
        //BaseClass da bulunan value  property'si artık string tipinde değer tutacak.
        public char Deger { get; set; }//ChildClass sadece char olarak kullanılacak.
    }
    class ChildClass2<T> : BaseClass<T>//Tanımlanma süreci olmadığı için iki değerde t olarak kalabilir.
    {
        public T Test { get; set; }
    }
    class ChildClass3<T> : BaseClass<int>
    {
        //Base yapısındaki property nin değerini belirledik 
        //Fakat hala daha childclass3 yapısına ne gelecek belli değil
        public T Test2 { get; set; }
    }
}
