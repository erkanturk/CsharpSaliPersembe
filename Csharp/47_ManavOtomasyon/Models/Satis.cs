using System;
using System.Collections.Generic;
using System.Text;

namespace _47_ManavOtomasyon.Models
{
    public class Satis
    {
        public int Id { get; set; }//Id değeri Identity (Kimlik yapısının kısaltmasıdır)
        //Bu yapı auto increment yapısı ile 1 den başlayıp 1 + 1 olarak devam eder aynı değeri tekrar etmez
        //Kullanıcı tarafından değiştirilemez veya girilemez bir yapıdır.
        public string UrunAdi { get; set; }
        public double Miktar { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
