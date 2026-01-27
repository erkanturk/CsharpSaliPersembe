namespace _06_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Random başlangıç
            /*Random bilgisayar tarafından (ram bellekten) türetilen rasgele sayılardır bu değerler genellikle
             * Şans oyunları simulasyonlar veya çark yapılarında kullanılır.

        //     */
            //    Random random = new Random(); //Random c# tarafından sağlanan bir sınıftır
            //git:                //new Random() ifadesi random sınıfından bir nesne türetiriz
            //    int rasgele = random.Next(1, 101);//1 ila 100 arasında rasgele sayı oluşturmak için 101 değeri vermek zorundayız.

            //    if (rasgele != 100)
            //    {
            //        Console.WriteLine(rasgele);
            //        goto git;
            //    }
            //    else if (rasgele == 100)
            //    {
            //        Console.WriteLine(rasgele);
            //    }
            #endregion

            #region random Tahmin oyunu
            Random rnd = new Random();
        basla:
            int sansliSayi = rnd.Next(1, 21);

       
            Console.WriteLine("Şanslı sayınızı giriniz");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin == sansliSayi)
            {
                Console.WriteLine("Tebrikler doğru tahmin: " + sansliSayi);
            }
            else
            {
                Console.WriteLine("Yanlış tahmin tekrar deneyiniz: "+sansliSayi);
                goto basla;
            }
            #endregion

        }
    }
}
