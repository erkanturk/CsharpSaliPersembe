using System.Collections;

namespace _31_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hashtable: key sırasının önemli olmadığı ve hızlı erişim gerektiğinde ideal olarak kullanılan bir yapıdır
             * Hashtable'ın görevi çok sayıda elemanı key değerlerini kullanarak en hızlı şekilde getirmektir.
             * Bir key bir defa kullanılır.Sortedlist deki gibi key değerlerinin aynı veri tipi olma zorunluluğu yoktur
             * Düzensiz liste olarak kullanılır.
             */
            Hashtable ht = new Hashtable();
            ht.Add("06", "Ankara");
            ht.Add(01, "Adana");
            ht.Add('A', 'a');
            ht.Add("Tarih", DateTime.Now);
            ht.Add(true, false);
            ht.Add(false, true);
            ht.Add(33.5, 33);
            ht.Add("Test", "test");
            Console.WriteLine("**************");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " Value: " + item.Value);
            }
            ht.Remove(true);
            Console.WriteLine("**************");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " Value: " + item.Value);
            }

        }
    }
}
