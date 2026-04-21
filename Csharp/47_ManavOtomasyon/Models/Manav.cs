using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _47_ManavOtomasyon.Models
{
    public class Manav
    {
        //Attribute Bu alanın Primary key olduğunu belirtik .net yapısı Id değerini görünce 
        //Kendisi Key değerini otomatik olarak verir.
        //Dataannotations tarafı ile her bir property tarafına özellik verdik.
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Minimum 3 karakter girilmeli")]
        public string Ad { get; set; }
        public string Kategori { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Minimum 1 değer giriniz")]
        public double Stok { get; set; }
    }
}
