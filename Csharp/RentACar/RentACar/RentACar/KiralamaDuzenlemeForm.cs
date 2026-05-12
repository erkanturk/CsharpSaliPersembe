using RentACar.Data;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentACar
{
    public partial class KiralamaDuzenlemeForm : Form
    {
        private readonly DataContext _context;
        private readonly Kiralama _kiralama;
        private readonly Musteri _musteri;
        private DateTime _eskiBitisTarihi;
        public KiralamaDuzenlemeForm(Kiralama kiralama, Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            _musteri = musteri;
            _kiralama = kiralama;
            _eskiBitisTarihi = kiralama.BitisTarihi;
            dtp_bitisTarih.MinDate=DateTime.Now;
        }

        private void KiralamaDuzenlemeForm_Load(object sender, EventArgs e)
        {
            string markaAd = _kiralama.Araba?.Marka?.Ad ?? "";
            string model = _kiralama.Araba?.Model ?? "";
            txt_arac.Text = $"{markaAd} {model}";

            dtp_baslaTarih.Value = _kiralama.BaslangicTarihi.Date;
            dtp_baslaSaat.Value = _kiralama.BaslangicTarihi;
            dtp_bitisTarih.Value=_kiralama.BitisTarihi.Date;
            dtp_bitisSaat.Value = _kiralama.BitisTarihi;
            HesaplaVeGoster();
        }

        private void HesaplaVeGoster()
        {
            DateTime baslangicTarihi = dtp_baslaTarih.Value.Date + dtp_baslaSaat.Value.TimeOfDay;
            DateTime bitisTarihi=dtp_bitisTarih.Value.Date+dtp_bitisSaat.Value.TimeOfDay;

            if (bitisTarihi <= baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeSpan fark = bitisTarihi - baslangicTarihi;
            double toplamSaat = fark.TotalHours;
            double saatlikUcret = _kiralama.Araba?.SaatlikUcret ?? 0;
            double toplamTutar = toplamSaat * saatlikUcret;
            txt_toplamSaat.Text=Math.Round(toplamSaat,2).ToString();
            txt_toplamTutar.Text = toplamTutar.ToString("C2");
        }
        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            HesaplaVeGoster();
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            ArabaForm arabaForm = new ArabaForm(_musteri);
            arabaForm.Show();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
           
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtp_baslaTarih.Value.Date + dtp_baslaSaat.Value.TimeOfDay;
                DateTime yeniBitisTarihi = dtp_bitisTarih.Value.Date + dtp_bitisSaat.Value.TimeOfDay;

                if (yeniBitisTarihi <= baslangicTarihi)
                {
                    MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (yeniBitisTarihi == _eskiBitisTarihi)
                {
                    MessageBox.Show("Tarihte herhangi bir değişiklik yapılmadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                BildirimTipi bildirimTipi = yeniBitisTarihi > _eskiBitisTarihi ? BildirimTipi.TarihUzatma : BildirimTipi.TarihKisaltma;
                var bildirim = new Bildirim()
                {
                    KiralamaId=_kiralama.Id,
                    Tip=bildirimTipi,
                    TalepTarihi=DateTime.Now,
                    YeniBitisTarihi=yeniBitisTarihi,
                    Durum=BildirimDurum.Beklemede
                };

                _context.Bildirimler.Add(bildirim);
                _context.SaveChanges();

                string islemTuru = bildirimTipi == BildirimTipi.TarihUzatma ? "uzatma" : "kısaltma";
                MessageBox.Show($"Tarih {islemTuru} talebiniz Admin'e gönderildi!\n\n" +
                    $"Mevcut Bitiş: {_eskiBitisTarihi:dd.MM.yyyy HH:mm}\n" +
                    $"Talep edilen:{yeniBitisTarihi:dd.MM.yyyy HH:mm}\n\n" +
                    $"Admin onayladığında tarih güncellenecektir.",
                    "Talep gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }
        }
    }
}
