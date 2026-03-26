using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Inheritance
{
    internal class IK : Personel
    {
        public int PersonelSayi { get; set; }

        public new void Yaz()
        {
            base.Yaz();
            Console.WriteLine($"Toplam Personel Sayısı{PersonelSayi}");
            //Console.WriteLine($"Adı{AdSoyad} Yaş {Yas} Adres {Adres} İşe Giriş Tarihi {IseGirisTarihi} Sigorta Türü {SigortaTuru} Personel Sayısı{PersonelSayi} ");
        }
    }
}
