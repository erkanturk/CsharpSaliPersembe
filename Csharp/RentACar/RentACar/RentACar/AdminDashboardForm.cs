using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using var context = new DataContext();
            dgvMarkalar.DataSource = context.Markalar.ToList();
            dgvAraclar.DataSource = context.Arabalar
                .Include(a => a.Marka)
                .Select(a => new
                {
                    a.Id,
                    Marka = a.Marka != null ? a.Marka.Ad : "",//MArka varsa adına al yoksa boş getir.
                    a.Model,
                    a.Plaka,
                    a.Yil,
                    a.SaatlikUcret,
                    Durum = a.Aktif ? "Aktif" : "Pasif"
                }).ToList();
            dgvBildirimler.DataSource = context.Bildirimler
                .Include(b => b.Kiralama)
                .ThenInclude(k => k.Musteri)
                .Include(b => b.Kiralama.Araba)
                .OrderByDescending(b => b.Id).Select(b => new
                {
                    b.Id,
                    Musteri = b.Kiralama.Musteri != null ? b.Kiralama.Musteri.AdSoyad : "",
                    Arac = b.Kiralama.Araba != null ? b.Kiralama.Araba.Model : "",
                    Tip = b.Tip.ToString(),
                    b.TalepTarihi,
                    b.YeniBitisTarihi,
                    Durum = b.Durum.ToString()


                }).ToList();
        }
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            string markaAd = Interaction.InputBox("Marka adını girin:", "Yeni Marka");//Kullanıcıdan metin girişi al
            if (!string.IsNullOrWhiteSpace(markaAd))
            {
                using var context = new DataContext();
                context.Markalar.Add(new Marka { Ad = markaAd });
                context.SaveChanges();
                LoadData();
                MessageBox.Show("Marka eklendi", "Başarılı");
            }
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (dgvMarkalar.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvMarkalar.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Bu markayı silmek istediğinizden emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var context = new DataContext();
                var marka = context.Markalar.Find(id);
                if (marka != null)
                {
                    context.Markalar.Remove(marka);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Marka silindi");
                }
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            var form = new AracEkleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Bu aracı silmek istediğinizden emin misiniz ?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var context = new DataContext();
                var arac = context.Arabalar.Find(id);
                if (arac != null)
                {
                    context.Arabalar.Remove(arac);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Araç Silindi");
                }
            }

        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["Id"].Value);
            var form = new AracEkleForm(id);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dgvBildirimler.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvBildirimler.SelectedRows[0].Cells["Id"].Value);
            using var context = new DataContext();
            var bildirim = context.Bildirimler.Include(b => b.Kiralama).FirstOrDefault(b => b.Id == id);
            if (bildirim is not null)
            {
                bildirim.Durum = BildirimDurum.Onaylandi;
                bildirim.DegerlendirilmeTarihi = DateTime.Now;
                if (bildirim.Tip == BildirimTipi.TarihUzatma && bildirim.YeniBitisTarihi.HasValue)
                {
                    bildirim.Kiralama.BitisTarihi = bildirim.YeniBitisTarihi.Value;
                }
                else if(bildirim.Tip==BildirimTipi.TarihKisaltma&&bildirim.YeniBitisTarihi.HasValue)
                {
                    bildirim.Kiralama.BitisTarihi = bildirim.YeniBitisTarihi.Value;
                }
                context.SaveChanges();
                LoadData();
                MessageBox.Show("Talep Onaylandı.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dgvBildirimler.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvBildirimler.SelectedRows[0].Cells["Id"].Value);
            using var context = new DataContext();
            var bildirim = context.Bildirimler.Find(id);
            if (bildirim != null)
            {
                string redNedeni = Interaction.InputBox(
                    "Lütfen red nedenini giriniz",
                    "Ret nedeni",
                    "Uygun Görülmedi"
                    );
                bildirim.Durum = BildirimDurum.Reddedildi;
                bildirim.DegerlendirilmeTarihi = DateTime.Now;
                bildirim.AdminNotu = redNedeni;
                context.SaveChanges();
                LoadData();
                MessageBox.Show("Talep reddedildi");
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
