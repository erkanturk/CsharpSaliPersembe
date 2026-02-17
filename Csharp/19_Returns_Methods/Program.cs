namespace _19_Returns_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Returs açıklama
            /* Geriye değer döndüren methodlar
             * Bir veri yapısı ile dönüş sağlarlar örneğin
             * int,double,char,decimal,string,bool,ve dizi yapılarda dahildir,enum, class,list,arraylist,vb.
             * yapıları da geriye dönüş olarak sağlar
             * ve parametre olarak iş yapan ve geriye değer döndüren yapılarda bu yapıları kullanırlar.
             * return ifadesi geriye bir işlem sonucunu yada bir iş dönderir
             * Fakat .net 7 ile gelen tuple özelliği ile birden fazla demet yapısı dönderilebilir.
             * 
            */
            #endregion
            #region Örnek 1
            //int sayi = SayiDondur();
            //double iskonto = sayi * 0.90;
            //Console.WriteLine(iskonto);
            Yaz("Merhaba");
            string degerAl = Yaz2();
            Console.WriteLine(Yaz2("test"));
            Console.WriteLine(degerAl);
            #endregion
            #region  Araç Örneği
            //Console.WriteLine("Şu an ki hızınız");
            //double hiz = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hızlanmak ister misiniz ?");
            //string cevap = Console.ReadLine().ToUpper().Trim();
            //if (cevap == "E")
            //{
            //    double hizlan = Hizlan(hiz);
            //    Hiz(hiz);
            //    Console.WriteLine("Mevcut hızınız:" + hizlan);
            //}
            //else if (cevap == "H")
            //{
            //    double yavasla = Yavasla(hiz);
            //    Console.WriteLine("Mevcut hızınız:"+yavasla);
            //}
            //else
            //{
            //    Console.WriteLine("Sabit hızda kalmaya devam:"+hiz);
            //}
            #endregion
        }
        static int SayiDondur()//yapılan işlem sonucunu geriye döndürür.
        {
            Console.WriteLine("Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //string metin = "Merhaba"; metinsel bir dönüş yapamaz method tipi int yapısında değer döndereceğini belirtiyor.
            double kdv = sayi * 1.20;
            Console.WriteLine(kdv);
            return (int)kdv;

        }
        static void Islem()//sadece iş yaptırır 
        {
            Console.WriteLine("Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double kdv = sayi * 1.20;
            Console.WriteLine(kdv);
        }
        static void Hiz(double hiz)
        {
            Console.WriteLine("Mevcut Hızınız:" + hiz);
        }
        static double Hizlan(double hiz)
        {
            return hiz + 10;
        }
        static double Yavasla(double yavasla)
        {//return ifadesi bir işlem sonucu yada bir değeri döndürür.
            return yavasla - 10;
        }

        static void Yaz(string metin)
        {
            Console.WriteLine(metin);

        }
        static string Yaz2(string metin)
        {
            metin = "Sanada Merhaba";
            return metin;
        }
    }
}
