namespace _05_If_Else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            /* Kullanıcıdan aylık geliri istenecek eğer geliri 40000 üstünde ise  %12 lik vergi kesilecek 
             * 40000 ve altında ise %9 luk vergi kesilecek yeni gelirini göstereceğiz
             */

            //Console.WriteLine("Lütfen aylık gelirinizi giriniz");
            //double maas = Convert.ToDouble(Console.ReadLine());

            //if (maas > 40000)
            //{
            //    Console.WriteLine($"Maaşınıza gelir vergisi % 12 uygulanmıştır güncel maaşınız: {maas * 0.88}");
            //}
            //else
            //{
            //    Console.WriteLine("Maaşınıza gelir vergisi % 9 uygulanmıştır güncel maaşınız: " + maas * 0.91);
            //    Console.WriteLine("Maaşınıza gelir vergisi % 9 uygulanmıştır güncel maaşınız: {0}", maas * 0.91);
            //}
            #endregion
            #region Örnek 2
            /*Kullanıcıdan iki ürünün fiyatını isteyin ürün fiyatlarınınb toplamı 2500 tl yi 
             * geçerse ucuz ürüne %25 indirim uygulayalım 
             * Eğer geçmezse ürün toplamlarını ekrana yazdıralım 
                                   
             */
            //Console.WriteLine("1. Ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2. Ürün fiyatı");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());
            //double toplam = fiyat + fiyat2;
            //if (toplam > 2500)
            //{
            //    if (fiyat > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //        Console.WriteLine($"{fiyat2}. ürüne %25 indirim uygulandı yeni tutarınız {fiyat + fiyat2}");
            //    }
            //    else
            //    {
            //        fiyat = fiyat * 0.75;
            //        Console.WriteLine($"{fiyat}. ürüne %25 indirim uygulandı yeni tutarınız {fiyat + fiyat2}");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Toplam ödemeniz gereken tutar 2500 tl yi aşmadığı için: " + toplam);
            //}
            #endregion
            #region Örnek 3
            /* Kullanıcıdan harcadığı tutar istenilecek eğer kullanıcı 0 ila 1000 arasında harcama yaptıysa 0.35 ile çarpılacak
             * 1001-2500 0.38 üzerinden hesaplanacak
             * 2501-4000 arası 0.41
             * 4001-6000 arası 0.42
             * 6000 ve üstü 1200 tl indirim yapılıp 0.43 üzerinden işlem yapılacak 
             */
            //Console.WriteLine("1. Ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());

            //if (fiyat > 0 && fiyat < 1001)
            //{
            //    Console.WriteLine(fiyat * 0.35);
            //}
            //else if (fiyat > 1001 && fiyat < 2501)
            //{
            //    Console.WriteLine(fiyat * 0.38);
            //}
            //else if (fiyat > 2501 && fiyat < 4001)
            //{
            //    Console.WriteLine(fiyat * 0.41);
            //}
            //else if (fiyat > 4001 && fiyat < 6000)
            //{
            //    Console.WriteLine(fiyat * 0.42);
            //}
            //else if (fiyat > 6000)
            //{
            //    Console.WriteLine((fiyat * 0.43)-1200);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı işlem");
            //}
            #endregion
            #region Örnek 4
            //1 ila 300 arasındaki sayıların 7 ye tam bölünenlerini ekrana teker teker yazdıran programı yazalım

            //    int sayi = 1;
            //    int toplam = 0;
            //basla:
            //    if (sayi % 7 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        toplam += sayi;
            //    }
            //    sayi++;
            //    if (sayi <= 300)
            //    {
            //        goto basla;
            //    }
            //    Console.WriteLine("7 ye tam bölünen değerlerin toplamı:" + toplam);

            //    int sayi2 = 300;

            //basla2:
            //    if (sayi2 % 7 == 0)
            //    {
            //        Console.WriteLine(sayi2);

            //    }
            //    sayi2--;
            //    if (sayi2 >= 0)
            //    {
            //        goto basla2;
            //    }

            #endregion
            #region Örnek 5
            /* Kullanıcıdan isim ,yaş , maaş  ve çocuk sayısı isteyeceğiz 
             * Eğer kullanıcı 45 yaşının altında ise çocuksayısına bakılacak
             * ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 3 ve 3'ten fazla ise çocuk başına 2000₺ maaşına ekleme yapılacak
             * 45 in üzerinde ise çocuk başına para verilmeyecek anca 10000₺ ekleme yapılacak 
             * Son olarak  ekranda çıktı : Erkan TÜRK Maaşınız 40000₺ gibi yazılacak.
             */

            //Console.WriteLine("İsim");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaş");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //int cocuk = 0;

            //if (yas < 45 && yas > 0)
            //{
            //    Console.WriteLine("Çocuk sayısı");
            //    cocuk = Convert.ToInt32(Console.ReadLine());
            //    if (cocuk >= 3)
            //    {
            //        maas = maas + (cocuk * 2000);
            //    }
            //    else
            //    {
            //        maas = maas + (cocuk * 2500);
            //    }
            //}
            //else
            //{
            //    maas += 10000;
            //}
            //Console.WriteLine($"Adınız {isim} Yaşınız {yas} Maaşınız {maas} Çocuk sayınız {cocuk}");
            //Console.WriteLine("Adınız {0} Yaşınız {1} Maaşınız {2} Çocuk sayınız {3}",isim,yas,maas,cocuk);
            //Console.WriteLine("Adınız: "+isim+ " Yaşınız: "+yas+" Maaşınız: " +maas+" Çocuk sayınız "+cocuk);
            #endregion

        }
    }
}
