using System.Collections;

namespace _30_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sortedlist Sıralı liste yapısıdır. Key-Value (Anahtar-Değer) yapısına sahiptir.
             * Keyler benzersizdir ve sıralıdır. Value'lar ise herhangi bir veri tipinde olabilir ve sıralama yapılmaz.
              * SortedList ile ekleme işlemi Add() metodu ile yapılır.
              * Çıkarma işlemi Remove() metodu ile yapılır.
              * Eleman göstermek için key value kullanılır.
              * DictonaryEntry yani sözlük yapısındadır.
             * 
            */

            //SortedList sortedList = new SortedList();
            //sortedList.Add(06, "Ankara");//ilk değer key ikinci değer value olarak eklenir.
            //sortedList.Add(34, "İstanbul");//keyler aynı tip olmalıdır. Value'lar ise herhangi bir tipte olabilir.
            //sortedList.Add(35, "İzmir");
            //sortedList.Add(16, "Bursa");
            //sortedList.Add(42, "Konya");
            //sortedList.Add(1, true);
            //sortedList.Add(0, "Deneme");
            //sortedList[5] = "Amasya";//Eğer yoksa ekler varsa günceller.
            ////sortedList[5] = "Adana";
            //// sortedList.Add("07", "Antalya");//key değerleri aynı yapıda olmazsa hata fırlatır.
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine($"Key: {item.Key} Value: {item.Value}");


            //}
            ////foreach (var item in sortedList)
            ////{
            ////    Console.WriteLine(item.Key);//key değerini göstemeyiz 
            ////}
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList isimler = new SortedList();
            //isimler.Add("Erkan", 1);
            //isimler.Add("Ali", 2);
            //isimler.Add("Metin", 3);
            //isimler.Add("Afşın", 4);
            //isimler.Add("Hasret", 5);
            //isimler.Add("Cem", 6);
            //isimler.Add("İlknur", 7);
            //isimler.Add("Zafer", 8);
            //isimler.Add("Arda", 9);

            //Console.WriteLine("Aradığınız ismi giriniz");
            //string aranan = Console.ReadLine();
            //if (isimler.ContainsKey(aranan))
            //{

            //    Console.WriteLine($"Aradığınınız İsmin Tc: {isimler[aranan]}");
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız isim bulunamadı eklemek ister misiniz ?");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap == "E")
            //    {
            //        Console.WriteLine("Tc yi ekleyin");
            //        int tc = Convert.ToInt32(Console.ReadLine());
            //        isimler[aranan] = tc;

            //        foreach (DictionaryEntry item in isimler)
            //        {
            //            Console.WriteLine($"Liste {item.Key} Tc {item.Value}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("İsminiz eklenmeyecektir");
            //    }

            //}
            ///*Bir ingilizce türkçe sözlük olsun kullanıcının girdiği ingilizce karakterin türkçesini ekrana yazdırsın*/

            //SortedList sozluk = new SortedList();
            //sozluk.Add("Book", "Kitap");
            //sozluk.Add("Table", "Masa");
            //sozluk.Add("Computer", "Bilgisayar");
            //sozluk.Add("Phone", "Telefon");

            //Console.WriteLine("Türkçesini aradığınız kelime");
            //string kelime = Console.ReadLine();
            //Console.WriteLine(sozluk[kelime]);
            #region İngilizce Türkçe Sözlük
            //Bu alanda <> içerisine verdiğimiz veri tipleri ilki key ikincisi value değeridir
            //Bu değerler kısıtlama işlemi için kullanılır.
            SortedList<string, string> sozluk = new SortedList<string, string>();
            sozluk.Add("mavi", "blue");
            sozluk.Add("bir", "one");
            sozluk.Add("bulutlu", "cloudy");
            sozluk.Add("sari", "yellow");
            sozluk.Add("turuncu", "orange");
            sozluk.Add("yesil", "green");
            while (true)
            {
                Console.WriteLine("1-Arama\n2-Çıkartma\n3-Listeleme\n4-Çıkış");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Aranacak kelime:");
                    string kelime = Console.ReadLine().ToLower();
                    if (sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte bulunamadı. Eklemek ister misiniz ?(E/H)");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap == "e")
                        {
                            Console.WriteLine("Kelimenin ingilizcesini giriniz");
                            sozluk[kelime] = Console.ReadLine();
                        }
                        else if (cevap == "h")
                        {
                            Console.WriteLine("İyi günler...");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                        }
                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çıkarılacak Kelime:");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);

                    }
                    else
                    {
                        Console.WriteLine("Kelime mevcut değil");
                    }
                }
                else if (secim == "3")
                {
                    foreach (KeyValuePair<string, string> item in sozluk)
                    {
                        Console.WriteLine(item.Value + "=>" + item.Key);
                    }
                }
                else if (secim == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                }
            }
            #endregion
            //Solid

        }
    }
}
