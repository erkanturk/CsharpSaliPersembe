namespace _21_Params_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            /* Params Method
             * Params anahtar kelimesi bir methodda değişken sayıda argümanın aynı tipte geçirilmesine olanak tanır.
             * Params parametresi methodun son parametresi olmak zorundadır. ve yalnızca params anahtar kelimesi ile kullanılabilir.
             * Params ile belirtilen parametre bir dizi olarak işaretlenir bu methodun 
             * içerisinde bir dizi erişilebileceğini ve üzerinde işlem yapılabileceği anlamına gelir.
             */
            #region Örnek 1
            //Islem(20, 40);//parametreli method

            //Paramsli(10);
            //Paramsli(10, 12, 3, 5, 7, 8, 9, 4, 6, 8, 7, 4, 6, 12, 3, 5, 7, 8, 9, 4, 6, 8, 7, 4, 6, 12, 3, 5, 7, 8, 9, 4, 6, 8, 7, 4, 6);

            //Paramsli2(20.33,'A');
            //Paramsli2(33.33, 'B', DateTime.Now, true, false, 20, "Merhaba", 33.44f, 99.44m, 'a', 'b');
            #endregion

            //foreach (int sayi in Dizi(10, 20, 30, 40, 50, 60, 70, 80, 90))
            //{
            //    Console.WriteLine(sayi);
            //}
            //string metin = "Bugün hava çok soğuktu";
            //DiziYaz(metin);
           // DiziYaz2("Erkan", "Ali", "İlknur", "Cem", "Arda", "Hasret", "Halil", "Afşın", "Zafer");
            #region Dizi Yapısı 
            //1-ila 21 arasında rasgele sayılar oluşturulacak bu sayılar benzersiz bir şekilde dizinin içerisine aktarılacak 
            //eğer 1 sayısı dizinin içerisinde var ise tekrardan eklenilmeyecek.
            Random random = new Random();
            int[] dizi = new int[random.Next(1, 21)];

            int i = 0;
            while (i<dizi.Length)
            {
                int sayi = random.Next(1, 21);
                bool varMi = false;
                foreach (int item in dizi)
                {
                    if (item == sayi)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi == false)
                {
                    dizi[i] = sayi;
                    i++;
                }
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];
            foreach (int item in dizi)
            {
                if (item > enBuyuk)
                {
                    enBuyuk = item;
                }
                if (item < enKucuk)
                {
                    enKucuk = item;
                }
            }
            Console.WriteLine("Dizinin en büyük elemanı:"+enBuyuk);
            Console.WriteLine("Dizinin en küçük elemanı:"+enKucuk);
            #endregion
        }
        static void Islem(int sayi, int sayi2)
        {
            Console.WriteLine(sayi + " " + sayi2);
        }
        static void Paramsli(int sayi, params int[] paramsli)
        {
            Console.WriteLine(sayi);
           
            foreach (int item in paramsli)
            {
                Console.WriteLine(item);
            }
        }
        static void Paramsli2(double sayi, char harf, params object[] obje)
        {
            Console.WriteLine(sayi);
            Console.WriteLine(harf);
            foreach (var item in obje)
            {
                Console.WriteLine(item);
            }
        }
        static int[] Dizi(params int[] dizi)
        {
            int[] sayilar = new int[dizi.Length];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    sayilar[i] = dizi[i];
            //}
            int index = 0;
            foreach (int item in dizi)
            {
                sayilar[index++] = item;
            }
            return sayilar;
        }
        static void DiziYaz(string metin)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                Console.WriteLine(metin[i]);
            }
        }
        static void DiziYaz2(params string[] dizi)
        {
            foreach (string item in dizi)
            {
                Console.WriteLine();
                for (int i = 0; i < item.Length; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }
        }
    }
}
