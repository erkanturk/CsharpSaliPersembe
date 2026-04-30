using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentACar.Models
{
    public class Kiralama
    {
        public int Id { get; set; }
        [Required]
        public int MusteriId { get; set; }
        [Required]
        public int ArabaId { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [Required]
        public double ToplamTutar {  get; set; }
        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }
        [ForeignKey("ArabaId")]
        public virtual Araba Araba { get; set; }
        public virtual ICollection<Bildirim> Bildirimler { get; set; } = new List<Bildirim>();

    }
}
