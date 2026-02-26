namespace _25_Recursive_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Recursive method
             * Bir işin tamamını yapmak yerine bu işi parçalara ayırarak bir bütünü bozmadan çalışma yapısıdır.
             * Bir methodun kendi içerisinde çağırılması sonucunda bu işlem gerçekleştirilir fakat 
             * bu işlem için koşullu bir yapı olmalıdır.
             
             */
            //Yaz();
         
            Console.WriteLine("Çoklu form için 1 e basın Tekli form için 2 ye basın");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 1)
            {
                Console.WriteLine("Kaç kişi kayıt edeceksin ?");
                int kayit = Convert.ToInt32(Console.ReadLine());
                CokluForm(kayit-1);
            }
            else if (sayi == 2)
            {
                Form();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }

        }
        static void Yaz()//hatalı yazım system overflow hatası verir.
        {
            Console.WriteLine("Merhaba");
            Yaz();
        }
        static void Form()
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas}");
        }
        static void CokluForm(int sayi)//Recursive method yapı LİFO (Last in First out) son giren ilk çıkar mantığı ile çalışıyor.
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                CokluForm(sayi - 1);
            }
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas}");
        }
    }
}
