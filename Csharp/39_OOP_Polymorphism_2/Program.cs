namespace _39_OOP_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Odev
            /* 
                Urun sınıfından miras alacak ürün sınıdında  ad fiyat KdvUygula methodu olacak.
               Tekstil:Ad,Fiyat,KumasTuru,Beden,UreticiFirma = KDVUygular(%20)
               CepTelefonu:Ad,Fiyat,Özellik,Marka = KDVUygular(%120)
               Ekmek:Ad,Fiyat,Gramaj = KDVUygular(%10)

           Nesne özelliklerini constructor methodu ile alın.
           Sepet: Alınan ürünleri bir listeye kaydetsin toplam tutarı söylesin

           */
            #endregion
            Canli canli = new Canli();
            canli.HareketEt();
            canli = new Balik();
            canli.HareketEt();
            canli = new Kus();
            canli.HareketEt();
            canli = new Insan();
            canli.HareketEt();
            canli = new Yilan();
            canli.HareketEt();
        }
    }
}
