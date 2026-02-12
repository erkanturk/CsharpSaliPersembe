namespace _15_OtomatProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proje
            /* 

            Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
           Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, 
              aksi durumda para ekle seçeneği
           ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
           satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
              var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

            // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de
              var ise eklenmeyecek yok ise eklenecek
              Admin şifresi 3 defa yanlış girilince 10 saniye 
              bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
            */
            //int a = 5;
            //int b = ++a;
            //int c = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(a);
            //int sum = 0; for (int i = 1; i <= 5; i++)
            //{
            //    if (i % 2 == 0)
            //    { continue; }
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Proje Çözüm
            bool isAdmin = false;
            string password = "123";
            string adminPassword;
            int hataSayisi = 0;
            bool isLocked = false;
            string[] urunler = { "cips", "çikolata", "soda", "su", "kahve" };
            double[] fiyatlar = { 50, 30, 30, 20, 100 };
            double para = 0;
            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün numaranızı giriniz (Admin girişi için -1 e basınız)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo == -1)
                    {
                        Console.Clear();
                        if (!isLocked)
                        {
                            while (hataSayisi < 3)
                            {
                                Console.WriteLine("Admin Şifrenizi giriniz");
                                adminPassword = Console.ReadLine();
                                if (adminPassword == password)
                                {
                                    isAdmin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hataSayisi++;
                                    Console.WriteLine("Yanlış şifre! Kalan hakkınız: " + (3 - hataSayisi));

                                }
                                if (hataSayisi == 3)
                                {
                                    Console.WriteLine("Yanlış giriş yapıldı hesap 10 saniye kitlendi");
                                    isLocked = true;
                                    Thread.Sleep(10000);
                                    isLocked = false;
                                    hataSayisi = 0;

                                }

                            }
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hesap Kitli");
                            Thread.Sleep(10000);
                            isLocked = false;
                            hataSayisi = 0;
                        }
                        continue;
                    }
                    Console.WriteLine("Para Girişi yapınız");
                    para = Convert.ToDouble(Console.ReadLine());
                    if (para >= fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız\nAfiyet Olsun.\nPara üstünüz: " + (para - fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        para = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz bakiye");
                            Console.WriteLine("Para Ekle 1\nPara İade 2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            
                            if (secim == 1)
                            {
                                Console.WriteLine("Para ekle");
                                para += Convert.ToDouble(Console.ReadLine());

                                if (para >= fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız\nAfiyet Olsun.\nPara üstünüz: " + (para - fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    para = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Para iade edildi: " + para);
                                para = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                Thread.Sleep(2000);
                            }
                        }

                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hatalı işlem: " + ex.Message);
                }
            }
            if (isAdmin)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****Admin Panel****");
                    Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Çıkış");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Ürün Adı");
                        string urunAdi = Console.ReadLine().ToLower();
                        bool kontrol = false;
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            if (urunler[i].ToLower() == urunAdi)
                            {
                                kontrol = true;
                                break;//Ürün benim dizimde zaten varsa eklemeye gerek yok
                            }
                        }
                        if (kontrol)
                        {
                            Console.WriteLine("Ürün zaten mevcut Güncelleme yada silme işlemi için listeyi kontrol edin");
                            Thread.Sleep(2000);
                            continue;
                        }
                        Console.WriteLine("Ürün fiyatı:");
                        double fiyat = Convert.ToDouble(Console.ReadLine());
                        Array.Resize(ref urunler, urunler.Length + 1);//dizinin eleman sayısını 1 arttırdık eleman sayısı +1 oldu
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                        urunler[urunler.Length - 1] = urunAdi;//ürün uzunluğunun -1 i benim index değerime eşittir yani 6 elemanlı bir dizi -1 i 5. index değeridir.
                        fiyatlar[fiyatlar.Length - 1] = fiyat;//kulanıcıdan gelen değeride indexe atadık
                        Console.WriteLine("Ürün başarıyla eklendi");
                        Thread.Sleep(2000);
                    }
                    else if (secim == 2)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                        }
                        Console.WriteLine("Güncellenecek Ürün Numarası veya adı");
                        string guncellenecekUrun = Console.ReadLine().ToLower();
                        int guncellenecekIndex;
                        if (int.TryParse(guncellenecekUrun, out guncellenecekIndex))
                        {
                            if (guncellenecekIndex >= 0 && guncellenecekIndex < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı");
                                string yeniUrunAdi = Console.ReadLine().ToLower();
                                Console.WriteLine("Yeni fiyat");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[guncellenecekIndex] = yeniUrunAdi;
                                fiyatlar[guncellenecekIndex] = yeniFiyat;
                                Console.WriteLine("Güncelleme işlemi başarılı");
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                                }
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            int index = Array.IndexOf(urunler, guncellenecekUrun);
                            if (index >= 0 && index < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı");
                                string yeniUrunAdi = Console.ReadLine().ToLower();
                                Console.WriteLine("Yeni fiyat");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[index] = yeniUrunAdi;
                                fiyatlar[index] = yeniFiyat;
                                Console.WriteLine("Güncelleme işlemi başarılı");
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                                }
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün");
                                Thread.Sleep(2000);
                            }

                        }
                    }
                    else if (secim == 3)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                        }
                        Console.WriteLine("Silmek istediğiniz Ürün numarası");
                        int silinecekIndex = Convert.ToInt32(Console.ReadLine());
                        if (silinecekIndex >= 0 && silinecekIndex < urunler.Length)
                        {
                            for (int i = silinecekIndex; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }
                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                            Console.WriteLine("Ürün silindi");
                        }
                    }
                    else if (secim == 4)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}: {fiyatlar[i]}");
                        }
                        Thread.Sleep(5000);
                    }
                    else if (secim == 5)
                    {
                        Console.WriteLine("İyi günler");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }

                }
            }
            #endregion


        }
    }
}
