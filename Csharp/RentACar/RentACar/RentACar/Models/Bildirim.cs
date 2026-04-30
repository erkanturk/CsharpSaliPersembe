using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentACar.Models
{
    public class Bildirim
    {
        public int Id { get; set; }
        public int KiralamaId { get; set; }
        public BildirimTipi Tip {  get; set; }
        public DateTime TalepTarihi { get; set; }= DateTime.Now;
        public DateTime? YeniBitisTarihi { get; set; } //? işareti nullable anlamına gelir.
        public BildirimDurum Durum { get; set; } = BildirimDurum.Beklemede;

        [MaxLength(500)]
        public string? AdminNotu { get; set; }
        public DateTime? DegerlendirilmeTarihi { get; set; }

        public virtual Kiralama Kiralama { get; set; } = null!;//virtual keyvordu bu yapıda lazy loading özelliğini aktifleştirir
    }
}
public enum BildirimDurum
{
    Beklemede=0,
    Onaylandi=1,
    Reddedildi=2
}
public enum BildirimTipi
{
    TarihUzatma=0,
    TarihKisaltma=1,
    KiralamaIptal=2
}