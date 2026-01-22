namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programlama dillerinde büyük küçük duyarlılığı vardır 'A' 'a' arasında fark vardır.
            //Programlama dillerinde kullanıcıdan gelen her değer metinsel olarak ifade edilir.
            //Veri tipi (string,int,char,bool,double,decimal,long,float v.b yapılarda)
            //C# data struct bir dildir data protected bir dildir 
            string metin = "Erkan Türk";//string ifadeler "" çift tırnak içerisine yazılır metinsel olarak algılanır 
            int sayi = 10;//sayısal değerlerde "" '' gibi tırnak operatörlerine ihtiyaç duyulmaz.
            Console.WriteLine(metin);
            Console.WriteLine(sayi + 10);

            //Tam sayı tipleri
            Console.WriteLine($"byte veri tipi {byte.MinValue} max değeri {byte.MaxValue}");//$ işareti string interpolation yazım tipidir bu yapıda '{}' arasında c# kodları barındırılabilir.
            Console.WriteLine($"int veri tipi {int.MinValue} max değeri {int.MaxValue}");

            Console.WriteLine($"long veri tipi {long.MinValue} max değeri {long.MaxValue}");
            //Ondalıklı sayı veri tipleri
            Console.WriteLine($"float veri tipi {float.MinValue} max değeri {float.MaxValue}");
            Console.WriteLine($"double veri tipi {double.MinValue} max değeri {double.MaxValue}");
            Console.WriteLine($"decimal veri tipi {decimal.MinValue} max değeri {decimal.MaxValue}");

            //Metinsel veri tipleri
            string metinsel = "Metinsel veri tipi";
            char harf = 'A';//Tek bir karakter barındırır
            char harf2 = 'a';//Tek bir karakter barındırır

            //Karşılaştırma veri tipi
            bool dogruMu = false;//true false olarak değer tutar

            //diğer veri tipleri
            var deger = 10;
            var deger3 = 10.5;
            var deger2 = "10";
            //her değer obje olarak tutulur.
            object obje = 30;
            object obje3 = 30.5;
            object obje2 = "metin";

            Console.WriteLine(deger + deger2);
            Console.WriteLine(deger + deger3);
            Console.WriteLine((int)obje+(double)obje3);
            Console.WriteLine(harf + harf2);
            Console.WriteLine($"A harfi:{(int)harf}");
            Console.WriteLine($"a harfi:{(int)harf2}");





        }
    }
}
