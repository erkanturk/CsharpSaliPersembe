using System.Collections;

namespace _29_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Stack Yığın yapısı Çalışma prensibi LIFO (Last In First Out) yani son giren ilk çıkar prensibine göre çalışır.
              * Dinamik data tipi yapısındadır.
              * Stack ile ekleme işlemi Push() metodu ile yapılır.
              * Çıkarma işlemi Pop() metodu ile yapılır.
              * Eleman göstermek için Peek() metodu kullanılır.

             */
            Stack stack = new Stack();//Instance/Örneklem Nesne oluşturma
            stack.Push("Erkan");
            stack.Push(10);
            stack.Push(true);
            stack.Push(DateTime.Now);
            stack.Push('A');
            stack.Push("Cem");
            stack.Push(20.30);
            //stack.Clear();//Tamamını temizler
            stack.Pop();//Son elemanı siler
            Console.WriteLine("Peek:"+stack.Peek());//Son elemanı gösterir fakat silmez
         

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
