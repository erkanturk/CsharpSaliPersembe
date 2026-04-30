using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Models
{
    public class Araba
    {
        public int Id { get; set; }
        [Required]
        public int MarkaId { get; set; }//Navigator Property
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        [MaxLength(50)]
        public string Plaka { get; set; }
        [Required]
        public int Yil { get; set; }
        [Required]
        [Range(0,double.MaxValue,ErrorMessage ="minimum 0 maksimum ise double max değeridir")]
        public double SaatlikUcret {  get; set; }
        [Required]
       
        public bool Aktif {  get; set; }

        public virtual Marka Marka { get; set; }//Foreign key değeri yabancıl anahtar bu yapı ile marka sınıfına ulaşım gerçekleşir.

        public  virtual ICollection<Kiralama> Kiralamalar { get; set; }

        public Araba()
        {
            Kiralamalar=new List<Kiralama>();
        }


    }
}
