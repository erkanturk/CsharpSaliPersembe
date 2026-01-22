namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operatörler
             *Aritmatik operatörler
             *
             *+,-,/,*,'%' mod alma bir sayının bölümünden kalan değerdir.
             *
             *Atama operatörleri 
             * = => sağdaki değeri soldaki değişkenin içerisine atar
             * += => Artırma operatörü
             * ++ =>bir arttırma operatörü
             * -= =>Azaltma operatörü
             * -- =>bir azaltma operatörü
             * (/=) =>bölme operatörü
             *  *= =>çarpma operatörü
             *  . => erişim operatörü

             *Karşılaştırma operatörleri
             *> => Büyüktür
             *< => küçüktür
             *>= =>Büyük eşittir
             *<= => küçük eşittir
             *== => Eşit mi ?
             *!= => Eşit değil mi ?
             *! => değil > true ise false dönderir false ise true dönderir.
             
             *Mantıksal operatörler
             *and(ve)&& or(veya)|| 
             *&& ve işlemi aslında matematikte çarpma işlemine benze true 1 false 0 dır
             *başlagıc bitiş sonuc
             *   1       0     0
             *   0       0     0
             *   1       1     1
             *   0       1     0
             *   
             * || ise toplama işlemine benzer
             *   1       0     1
             *   0       1     1
             *   1       1     1
             *   0       0     0
             */

            //int sayi = 10;
            //int sayi2 = 20;
            //Console.WriteLine("Toplama:" + (sayi + sayi2));
            //Console.WriteLine("Çarpma:" + sayi * sayi2);
            //Console.WriteLine("Çıkarma:" + (sayi - sayi2));
            //Console.WriteLine("Bölme:" + sayi2 / sayi);

            //sayi++;
            //Console.WriteLine(sayi);
            //sayi--;
            //Console.WriteLine(sayi);
            //sayi += 2;
            //sayi -= 2;
            //sayi *= 2;
            //sayi /= 2;
            //Console.WriteLine(sayi);
            //Console.WriteLine();//.ile Console sınıfına ait yapılara erişiriz.
            int sayi = 10;
            int sayi2 = 20;
            bool karsilastirma = sayi > sayi2;
            bool karsilastirma2 = sayi < sayi2;
            bool karsilastirma3 = sayi >= 10;
            bool karsilastirma4 = sayi <= 15;
            bool karsilastirma5 = sayi == 10;
            bool karsilastirma6 = sayi != sayi2;
            bool karsilastirma7 = true;
            Console.WriteLine(karsilastirma);//F
            Console.WriteLine(karsilastirma2);//T
            Console.WriteLine(karsilastirma3);//T
            Console.WriteLine(karsilastirma4);//T
            Console.WriteLine(karsilastirma5);//T
            Console.WriteLine(karsilastirma6);//T
            Console.WriteLine(!karsilastirma7);//F ! değil zıt işlem yapmada kullanılır.
            Console.WriteLine();
            Console.WriteLine();

            bool deger = sayi > 10 && sayi == 10;
            bool deger2 = sayi >= 10 && sayi <= 10;
            bool deger3 = sayi > 20 && sayi != 10;
            bool deger4 = sayi <= 10 && sayi >= 10;
            bool deger5 = sayi < 10 && sayi > 10;
            bool deger6 = sayi <= 10 && sayi != 10;

            Console.WriteLine(deger);
            Console.WriteLine(deger2);
            Console.WriteLine(deger3);
            Console.WriteLine(deger4);
            Console.WriteLine(deger5);
            Console.WriteLine(deger6);

            Console.WriteLine();
            Console.WriteLine();

            bool deger7 = sayi > 10 || sayi == 10;
            bool deger8 = sayi >= 10 || sayi <= 10;
            bool deger9 = sayi > 20 || sayi != 10;
            bool deger10 = sayi <= 10 || sayi >= 10;
            bool deger11 = sayi < 10 || sayi > 10;
            bool deger12 = sayi <= 10 || sayi != 10;

            Console.WriteLine(deger7);
            Console.WriteLine(deger8);
            Console.WriteLine(deger9);
            Console.WriteLine(deger10);
            Console.WriteLine(deger11);
            Console.WriteLine(deger12);
        }
    }
}
