using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Models
{
    public class Marka
    {
        public int Id { get; set; }

        [Required]
        public string Ad {  get; set; }
        public virtual ICollection<Araba> Arabalar { get; set; }
        public Marka()
        {
            Arabalar=new List<Araba>();
        }

    }
}
