using Microsoft.EntityFrameworkCore;
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
    public partial class KiralamaForm : Form
    {
        DataContext _context;
        Musteri? _musteri;
        Kiralama? _secilenKiralama;
        public KiralamaForm(Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            _musteri = musteri;
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            dtg_kiralamalar.CellDoubleClick += dtg_kiralamalar_CellDoubleClick;//Doubleclick olayını elle bağlama
            dtg_kiralamalar.ReadOnly = true;//Grid ayarı tıklamayı kolaylaştır
            dtg_kiralamalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Tüm satırı seç

            this.Height += 50;//Formu uzat
            dtg_kiralamalar.Top += 30;//Grid'i 30 px aşağı kaydır
            dtg_kiralamalar.Height -= 30;//Taşmasını engelle

            Label lblBilgi = new Label();
            lblBilgi.Text = "Bilgi:Detayları görmek için satıra çift tıklayınız.";
            lblBilgi.AutoSize = true;
            lblBilgi.ForeColor = Color.DarkBlue;
            lblBilgi.Location = new Point(dtg_kiralamalar.Left, dtg_kiralamalar.Top - 25);
            this.Controls.Add(lblBilgi);
            KiralamalariYukle();
        }
        private void KiralamalariYukle()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Kiralama No", typeof(int));
                dataTable.Columns.Add("Başlangıç Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Bitiş Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Toplam Tutar (₺)", typeof(double));
                dataTable.Columns.Add("Araç", typeof(string));
                dataTable.Columns.Add("Müşteri", typeof(string));
                dataTable.Columns.Add("Durum", typeof(string));

                var kiralamaListesi = _context.Kiralamalar
                    .Where(i => _musteri != null || i.MusteriId == _musteri.Id)
                    .Include(i => i.Araba)
                    .ThenInclude(a => a.Marka)
                    .Include(i => i.Musteri)
                    .Include(b => b.Bildirimler).ToList();

                foreach (var kiralama in kiralamaListesi)
                {
                    string aracBilgisi = kiralama.Araba != null && kiralama.Araba.Marka != null ?
                        $"{kiralama.Araba.Model}" : "Bilinmiyor";
                    string musteriBilgisi = kiralama.Musteri != null ?
                        $"{kiralama.Musteri.AdSoyad} {kiralama.Musteri.Telefon}" : "Bilinmiyor";

                    string durumBilgisi = "Aktif";
                    var sonBildirim = kiralama.Bildirimler?
                        .OrderByDescending(b => b.Id).FirstOrDefault();
                    if (sonBildirim != null)
                    {
                        switch (sonBildirim.Durum)
                        {
                            case BildirimDurum.Beklemede:
                                durumBilgisi = "İnceleniyor"; break;
                            case BildirimDurum.Reddedildi: durumBilgisi = "Talep Reddedildi"; break;
                            case BildirimDurum.Onaylandi:
                                if (kiralama.BitisTarihi.Date < DateTime.Now && kiralama.BaslangicTarihi < kiralama.BitisTarihi)
                                    durumBilgisi = "Tamamlandı";
                                else
                                    durumBilgisi = "Aktif(Onaylandı)"; break;
                        }
                    }
                    else if (kiralama.BitisTarihi.Date < DateTime.Now && kiralama.BaslangicTarihi.Date < kiralama.BitisTarihi.Date)
                    {
                        durumBilgisi = "Tamamlandı";
                    }

                    dataTable.Rows.Add(
                        kiralama.Id,
                        kiralama.BaslangicTarihi,
                        kiralama.BitisTarihi,
                        kiralama.ToplamTutar,
                        aracBilgisi,
                        musteriBilgisi,
                        durumBilgisi

                        );
                }
                dtg_kiralamalar.DataSource = dataTable;
                dtg_kiralamalar.Columns["Toplam Tutar (₺)"].DefaultCellStyle.Format = "C2";
                if (dtg_kiralamalar.Rows.Count > 0)
                {
                    dtg_kiralamalar.ClearSelection();
                }
                _secilenKiralama = null;
                btn_KiralamaDuzenle.Enabled = false;
                btn_KiralamaSil.Enabled = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Yüklenecek araç bilgisi bulunamadı", ex.Message);
            }
        }



        private void btn_YeniKiralama_Click(object sender, EventArgs e)
        {
            ArabaForm arabaForm;
            if (_musteri != null)
            {
                arabaForm = new ArabaForm(_musteri);
            }
            else
            {
                MessageBox.Show("Yetkiniz yoktur");
                return;
            }
            this.Hide();
            arabaForm.Show();
            KiralamalariYukle();
        }
     

        private void dtg_kiralamalar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtg_kiralamalar.SelectedRows.Count > 0)
                {
                    int kiralamaId = Convert.ToInt32(dtg_kiralamalar.SelectedRows[0].Cells["Kiralama No"].Value);
                    _secilenKiralama = _context.Kiralamalar
                        .Include(k => k.Araba)
                        .Include(k => k.Araba.Marka)
                        .Include(k => k.Musteri)
                        .FirstOrDefault(k => k.Id == kiralamaId);
                    Console.WriteLine($"Seçilen Kiralama Id {kiralamaId}, bulunan: {_secilenKiralama != null}");
                    btn_KiralamaDuzenle.Enabled = _secilenKiralama != null;
                    btn_KiralamaSil.Enabled = _secilenKiralama != null;
                }
                else
                {
                    _secilenKiralama = null;
                    btn_KiralamaDuzenle.Enabled = false;
                    btn_KiralamaSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Seçim hatası:" + ex.Message);
                _secilenKiralama = null;
                btn_KiralamaDuzenle.Enabled = false;
                btn_KiralamaSil.Enabled = false;

            }
        }

        private void btn_KiralamaDuzenle_Click(object sender, EventArgs e)
        {
            if (_secilenKiralama == null)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kiralamayı seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bekleyenBildirim = _context.Bildirimler
                .Where(b => b.KiralamaId == _secilenKiralama.Id && b.Durum == BildirimDurum.Beklemede).FirstOrDefault();
            if (bekleyenBildirim != null)
            {
                MessageBox.Show("Bu kiralama için zaten onay bekleyen bir talep bulunmaktadır.\n\n" +
                    $"Talep Tarihi:{bekleyenBildirim.TalepTarihi:dd.MM.yyyy HH:mm}\n" +
                    "Lütfen talebinizin sonuçlanmasını bekleyin",
                    $"Bekleyen Talep Var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var guncelKiralama = _context.Kiralamalar
                .Include(k => k.Araba)
                .Include(k => k.Araba.Marka)
                .Include(k => k.Musteri)
                .FirstOrDefault(k => k.Id == _secilenKiralama.Id);
            if (guncelKiralama == null)
            {
                MessageBox.Show("Seçilen kiralama kaydı artık mevcut değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KiralamalariYukle();
                return;
            }
            KiralamaDuzenlemeForm duzenlemeForm = new KiralamaDuzenlemeForm(guncelKiralama, _musteri);
            this.Hide();
            duzenlemeForm.ShowDialog();
            this.Show();
            KiralamalariYukle();

        }

        private void btn_KiralamaSil_Click(object sender, EventArgs e)
        {
            if (_secilenKiralama == null)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kiralamayı seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dialog = MessageBox.Show("Bu kiralama kaydını silmek istediğinize emin misiniz ?","Silme onay",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    var araba = _context.Arabalar.Find(_secilenKiralama.ArabaId);
                    if (araba != null)
                    {
                        araba.Aktif = true;
                    }
                    _context.Kiralamalar.Remove(_secilenKiralama);
                    _context.SaveChanges();
                    MessageBox.Show("Kiralama kaydı silindi");
                    KiralamalariYukle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız oldu:"+ex.Message);
                    
                }
            }
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtg_kiralamalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                int kiralamaId = Convert.ToInt32(dtg_kiralamalar.Rows[e.RowIndex].Cells["Kiralama No"].Value);
                using var context = new DataContext();
                var kiralama = context.Kiralamalar
                    .Include(k => k.Araba)
                    .ThenInclude(k => k.Marka)
                    .FirstOrDefault(k => k.Id == kiralamaId);
                if (kiralama == null)
                {
                    MessageBox.Show("Kiralama kaydı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sonBildirim = context.Bildirimler
                    .Where(b => b.KiralamaId == kiralamaId)
                    .OrderByDescending(b => b.Id).FirstOrDefault();

                string baslik = "Talep Durum";
                string mesaj = "";
                MessageBoxIcon icon = MessageBoxIcon.Information;
                if (sonBildirim != null)
                {
                    switch (sonBildirim.Durum)
                    {
                        case BildirimDurum.Reddedildi:
                            baslik = "Talep Reddedildi";
                            mesaj = "Talebiniz admin tarafından reddedildi.\n\n" +
                                $"Talep Tarihi {sonBildirim.TalepTarihi:dd.MM.yyyy HH:mm}\n" +
                                $"Admin Açıklaması:{sonBildirim.AdminNotu ?? "Belirtilmedi"}";
                            icon=MessageBoxIcon.Warning;
                            break;
                        case BildirimDurum.Beklemede:
                            baslik = "İnceleniyor";
                            mesaj = "Talebiniz admin tarafından incelenmesi bekleniyor.\n\n" +
                                $"Talep Tarihi {sonBildirim.TalepTarihi:dd.MM.yyyy HH:mm}\n" +
                                $"Admin Açıklaması:{sonBildirim.AdminNotu}";
                            icon = MessageBoxIcon.Information;
                            break;
                        case BildirimDurum.Onaylandi:
                            baslik = "Onaylandı";
                            mesaj = "Talebiniz Onaylandı\n\n" +
                                $"Talep Tarihi {sonBildirim.TalepTarihi:dd.MM.yyyy HH:mm}\n" +
                                $"Admin Açıklaması:{sonBildirim.AdminNotu}";
                            icon = MessageBoxIcon.Information;
                            break;

                    }
                }
                if (string.IsNullOrEmpty(mesaj))
                {
                    baslik = "Kiralama Detayı";
                    mesaj = $"Araç:{kiralama.Araba?.Marka?.Ad} {kiralama.Araba?.Model}\n" +
                        $"Başlangıç:{kiralama.BaslangicTarihi:dd.MM.yyyy HH:mm}\n" +
                        $"Bitiş:{kiralama.BitisTarihi:dd.MM.yyyy HH:mm}\n" +
                        $"Tutar:{kiralama.ToplamTutar:C2}\n\n" +
                        $"Herhangi bir bekleyen talep veya olumsuz durum yok.";
                }
                MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, icon);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Detay görüntüleme hatası:" + ex.Message);
            }
        }
    }
}
