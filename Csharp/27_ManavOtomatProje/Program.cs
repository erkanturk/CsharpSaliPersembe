using System.Collections;

namespace _27_ManavOtomatProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList yapısı kullanarak bir manav otomasyonu yapınız.
            #region ManavOtomasyonu
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion

            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "KARPUZ", "PORTAKAL", "KAVUN" };
            ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "PATATES", "SOĞAN" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();
            Console.WriteLine("Uby Hale Hoşgeldiniz");
            while (true)
            {
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış Q ya basınız");
                string halSecim = Console.ReadLine().ToUpper();
                if (halSecim == "M")
                {
                    try
                    {
                        Console.WriteLine("1-Elma\n2-Armut\n3-Karpuz\n4-Portakal\n5-Kavun");
                        string meyve = Console.ReadLine().ToUpper();
                        if (meyve == "ELMA")
                        {
                            UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);

                        }
                        else if (meyve == "ARMUT")
                        {
                            UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                        }
                        else if (meyve == "KARPUZ")
                        {
                            UrunAl(manavMeyveler, "KARPUZ", manavMeyveKilo);
                        }
                        else if (meyve == "PORTAKAL")
                        {
                            UrunAl(manavMeyveler, "PORTAKAL", manavMeyveKilo);
                        }
                        else if (meyve == "KAVUN")
                        {
                            UrunAl(manavMeyveler, "KAVUN", manavMeyveKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("Başka arzunuz var mı ? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                           
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                            Thread.Sleep(2000);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);

                    }
                }
                else if (halSecim == "S")
                {
                    try
                    {
                        Console.WriteLine("1-Domates\n2-Biber\n3-Patlıcan\n4-Patates\n5-Soğan");
                        string sebze = Console.ReadLine().ToUpper();
                        if (sebze == "DOMATES")
                        {
                            UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);

                        }
                        else if (sebze == "BİBER")
                        {
                            UrunAl(manavSebzeler, "BİBER", manavSebzeKilo);
                        }
                        else if (sebze == "PATLICAN")
                        {
                            UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze == "PATATES")
                        {
                            UrunAl(manavSebzeler, "PATATES", manavSebzeKilo);
                        }
                        else if (sebze == "SOĞAN")
                        {
                            UrunAl(manavSebzeler, "SOĞAN", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("Başka arzunuz var mı ? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                            Thread.Sleep(2000);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);

                    }

                }
                else if (halSecim == "Q")
                {
                    Console.WriteLine("Yine bekleriz");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı işlem");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Uby Manava Hoşgeldiniz");
                Console.WriteLine("Meyve mi Sebze mi ? (M/S)");
                string manavSecim = Console.ReadLine().ToUpper();
                if (manavSecim == "M")
                {
                    if (manavMeyveler.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir");
                        continue;
                    }
                    for (int i = 0; i < manavMeyveler.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} {manavMeyveler[i]}=>{manavMeyveKilo[i]} kilo mevcut");
                    }
                    try
                    {
                        Console.WriteLine("Ürün seçiniz veya numara giriniz");
                        string input = Console.ReadLine().ToUpper();
                        string meyve = "";
                        if (int.TryParse(input, out int meyveNo))
                        {
                            if (meyveNo >= 1 && meyveNo <= manavMeyveler.Count)
                            {
                                meyve = manavMeyveler[meyveNo - 1].ToString();
                                //kullanıcının girdiği sayının -1 i benim index değerim
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        else
                        {
                            meyve = input;
                            if (!manavMeyveler.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan ürün");
                                Thread.Sleep(2000);
                                continue;
                            }

                        }
                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç Kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavMeyveler.IndexOf(meyve);
                            int meyveKilo = (int)manavMeyveKilo[index];
                            if (meyveKilo >= kilo)
                            {
                                meyveKilo -= kilo;
                                musteri.Add($"{meyve} {kilo} kilo");
                                manavMeyveKilo[index] = meyveKilo;
                                if (meyveKilo == 0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı {meyve} için kalan stok: {meyveKilo} kilo");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine($"İstenilen kilo mevcut değil {meyve}=>{meyveKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata: " + ex.Message);
                    }
                    Console.WriteLine("Başka bir arzunun var mı ? (E/H)");
                    string cevap = Console.ReadLine();
                    if (cevap.ToUpper() == "E")
                    {
                        continue;
                    }
                    else if (cevap.ToUpper() == "H")
                    {
                        Console.WriteLine("iyi günler");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }
                }
                else if (manavSecim == "S")
                {
                    if (manavSebzeler.Count == 0)
                    {
                        Console.WriteLine("Sebzeler tükenmiştir");
                        Thread.Sleep(2000);
                        continue;
                    }
                    for (int i = 0; i < manavSebzeler.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} {manavSebzeler[i]}=>{manavSebzeKilo[i]} kilo mevcut");
                    }
                    try
                    {
                        Console.WriteLine("Ürün adı veya Numarası");
                        string input = Console.ReadLine().ToUpper();
                        string sebze = "";
                        if (int.TryParse(input, out int sebzeNo))
                        {
                            if (sebzeNo >= 1 && sebzeNo <= manavSebzeler.Count)
                            {
                                sebze = manavSebzeler[sebzeNo - 1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        else
                        {
                            sebze = input;
                            if (!manavSebzeler.Contains(sebze))
                            {
                                Console.WriteLine("Olmayan ürün");
                                Thread.Sleep(2000);
                                continue;
                            }

                        }
                        if (manavSebzeler.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavSebzeler.IndexOf(sebze);
                            int sebzeKilo = (int)manavSebzeKilo[index];
                            if (sebzeKilo >= kilo)
                            {
                                sebzeKilo -= kilo;
                                musteri.Add($"{sebze} {kilo} kilo");
                                manavSebzeKilo[index] = sebzeKilo;
                                if (sebzeKilo == 0)
                                {
                                    manavSebzeler.RemoveAt(index);
                                    manavSebzeKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı {sebze} için kalan stok: {sebzeKilo} kilo");
                                Thread.Sleep(2000);

                            }
                            else
                            {
                                Console.WriteLine($"istenilen {sebze} {sebzeKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata: " + ex.Message);
                    }
                    Console.WriteLine("Başka bir arzunuz var mı (E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        continue;
                    }
                    else if(cevap=="H")
                    {
                        Console.WriteLine("Yine bekleriz");
                        break;
                    }
                }
                else if (manavSecim == "Q")
                {
                    Console.WriteLine("Yine bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                }

            }
            Console.WriteLine("Aldığınız ürünler");
            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }



        }
        static void UrunAl(ArrayList list, string urun, ArrayList kiloList)
        {
            if (list.Contains(urun) == false)//Yoksa ekle
            {
                list.Add(urun);
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else//Varsa güncelle
            {
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf(urun);
                int urunKilo = (int)kiloList[index];
                urunKilo += kilo;
                kiloList[index] = urunKilo;


            }
        }
    }
}
