using System.Collections;

namespace _26_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Collections (Koleksiyon yapıları)
             * Dizilere benzer olarka içerisinde birden çok veriyi barındıran data yapılarıdır
             * string[],int[],char[] gibi arrayler içerisinde sadece ilgili data tipini tutabilirken
             * Collections yapıları daha spesifik ve karmaşık yapılarıda beraberinde birden çok data tipini içerisinde tutabilirler
             * Dizilerden farklı olarak bir veri tipi belirtmeyiz ve maksimum uzunluğu 2 üzeri n olarak gelir.
             * system.collections yapısını kullanır ve ICollection ve IEnumareble yapısını içerisinde barındırır.
             * koleksiyon yapıları =>ArrayList,Stack,Queue,SortedList,HashTable,List(generic)


             */
            #region ArrayList Tanım
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 'A' };
            //ArrayList arrayList = new ArrayList();//Boş Arraylist Tanımı
            //arrayList.Add(1);//Tekli ekleme
            //arrayList.Add("Deneme");
            //arrayList.Add(DateTime.Now);//Arraylist her yapıyı içerisinde barındırır her değer onun için obje olarak tutulur.
            //arrayList.Add(true);
            //arrayList.Add(20.5);
            //arrayList.Add('A');
            //arrayList.Add('A');
            //arrayList.Add('A');
            //arrayList.Add('A');
            ////foreach (var item in arrayList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine($"İndex değeri {arrayList[i]}");
            //}
            //Console.WriteLine(arrayList.Count);//Array listler de 0 indexden başlar count eleman sayısını verir. 
            //Console.WriteLine(arrayList.Capacity);//2 üzeri n olarak değerler artar.

            //ArrayList list = new ArrayList {"Erkan",DateTime.Now,20.5,44,123456,'A','B','C' };//Dolu arraylist
            #endregion
            #region Koleksiyon Methodları
            ArrayList list = new ArrayList();
            list.Add(1);//Tekli ekleme
            list.AddRange(new ArrayList { "test", 1, 2, 3, 4, DateTime.Now });
            //ListeDondur(list);
            //list.Clear();//Arraylistin tamamını temizler
            //ListeDondur(list);
            //list.RemoveAt(3);//index değerine göre silme yöntemi
            //ListeDondur(list);
            //list.Remove("test");//İçinde var olan eleman değerini siler.
            //Console.WriteLine("***********");
            //ListeDondur(list);
            ////list.RemoveRange(0, 3);//ilk parametre index 2. parametre eleman değeri belirtiğimiz aralıkta silme işlemi yapar.
            //Console.WriteLine("*********");
            //ListeDondur(list);
            //string[] adlar = { "Ali", "Onur", "Ali", "Metin", "İlknur", "Hasret", "Afşın" };
            //list.Insert(0, "Erkan");
            //list.InsertRange(5, adlar);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]=20);
            //}
            list[0] = 10;
            Console.WriteLine("*********");
            ListeDondur(list);
            //ArrayList list1 = new ArrayList();

            //list1.Clone();
            //ListeDondur(list1);


            //Array.Resize(ref adlar, adlar.Length+20);
            //list1.CopyTo(0, adlar, 0, 5);
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);//Kontrol edilecek.
            //}
            //list.Sort();//Arraylistde sayısal veya metinsel tek tip veri yapısı yoksa sort yapısı kullanılamaz.
            //list.Reverse();
            //Console.WriteLine("*********");
            //ListeDondur(list);

            //Console.WriteLine(list.Contains(50) ? "Var" : "Yok");//?if : else yapısı olarak terenary if else
            //string deger = 25 > 35 ? "Büyük" : "Küçüktür";
            //Console.WriteLine(deger);

            //int index = list.IndexOf("Ali");
            //int index2 = list.IndexOf("Ali", 6);//belirtilen indexden itibaren bakar ilk bulduğunu getirir.
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            //int index3 = list.LastIndexOf("Ali");//Sondan aramaya başlar ve ilk bulduğunu getirir.
            //int index4 = list.LastIndexOf("Ali", 6);
            //Console.WriteLine(index3);
            //Console.WriteLine(index4);
            //object[] obje = list.ToArray();//Dizi formatına çevir eğer obje olarak tanımlanmazsa hata verir tek tip değer olmalıdır içerisinde
            //foreach (object item in obje)
            //{
            //    Console.WriteLine(item);
            //}
          


            #endregion
        }
        static void ListeDondur(ArrayList liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
