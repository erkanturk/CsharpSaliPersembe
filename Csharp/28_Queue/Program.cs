using System.Collections;

namespace _28_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Queue Kuyruk yapısı Çalışma prensibi FIFO (First In First Out) yani ilk giren ilk çıkar prensibine göre çalışır.
             * Dinamik data tipi yapısındadır.
             * Queue ile ekleme işlemi Enqueue() metodu ile yapılır.
             * Çıkarma işlemi Dequeue() metodu ile yapılır.
             * Eleman göstermek için Peek() metodu kullanılır.
             */
            //Queue queue = new Queue();//Instance/Örneklem Nesne oluşturma
            //queue.Enqueue("Erkan");
            //queue.Enqueue("Ali");
            //queue.Enqueue("Metin");
            //queue.Enqueue("Afşın");
            //queue.Enqueue("Hasret");
            //KuyrukListele(queue);
            //queue.Dequeue();//Kuyruğun ilk elemanını siler
            //KuyrukListele(queue);
            //queue.Clear();//Kuyruğun tamamını temizler
            //object obj = queue.Peek();//Kuyruğun ilk elemanını gösterir fakat silmez
            //Console.WriteLine(obj);

            Queue queue = new Queue();//Instance/Örneklem Nesne oluşturma
            queue.Enqueue("Erkan");
            queue.Enqueue("Ali");
            queue.Enqueue("Metin");
            queue.Enqueue("Afşın");
            queue.Enqueue("Hasret");
            queue.Enqueue(10);
            queue.Enqueue(true);
            queue.Enqueue("Cem");
            //2 üzeri n olarak kapasite artar.
            for (int i = 8; i >= queue.Count; i--)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"{i+1}.Sıradasınız");
                if (queue.Count == 0)
                {
                    Console.WriteLine("Sıra Sizde");
                }
                else
                {
                    Console.WriteLine($"{queue.Peek()}"); 
                    queue.Dequeue();
                }
            }

        }
        static void KuyrukListele(Queue queue)
        {
            Console.WriteLine("************");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
