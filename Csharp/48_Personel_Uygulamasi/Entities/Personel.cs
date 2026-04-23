using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _48_Personel_Uygulamasi.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Email { get; set; }
        [StringLength(13, ErrorMessage = "13 karakterden fazla girilemez")]
        public string Telefon { get; set; }

        public override string ToString()
        {
            return $"{Isim} {SoyIsim}";
        }

    }
    public class Personel1:Personel
    {
        public override string ToString()
        {
            return $"{Isim} {SoyIsim} {Telefon} {Email}";
        }
    }
}
