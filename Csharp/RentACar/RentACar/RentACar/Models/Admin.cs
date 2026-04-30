using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Models
{
    public class Admin
    {
        [Key]//Primary key birincil anahtar değeri
        public int Id { get; set; }
        //Auto increment yapı  1 den başlayıp 1+ olarak devam edecek benzersiz olmak zorundadır.

        [Required]
        [MaxLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        public required string KullaniciAdi { get; set; }//required veri tabanında bu alan boş bırakılamaz olduğunu belirtir
        [Required]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olabilir")]
        public required string Sifre { get; set; }//required veri tabanında bu alan boş bırakılamaz olduğunu belirtir

        [Required]
        [MaxLength(100, ErrorMessage = "AdSoyad en fazla 100 karakter olabilir")]
        public required string AdSoyad { get; set; }

        public bool Aktif { get; set; } = true;
        
        public DateTime OlusturmaTarihi { get; set; }= DateTime.Now;


    }
}
