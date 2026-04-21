using _47_ManavOtomasyon.Data;
using _47_ManavOtomasyon.Models;
using Microsoft.EntityFrameworkCore;

namespace _47_ManavOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHalKategori.SelectedIndex = 0;
            cmbManavKategori.SelectedIndex = 0;
            GuncelleHalUrunler();
            GuncelleManavUrunler();
            Satis();
        }
        private void GuncelleHalUrunler()
        {
            LstHalUrunler.Items.Clear();
            using (var context = new DataContext())
            {
                string kategori = cmbHalKategori.SelectedItem.ToString();
                var urunler = context.Urunler.Where(u => u.Kategori == kategori).ToList();
                foreach (var urun in urunler)
                {
                    LstHalUrunler.Items.Add($"{urun.Ad} {urun.Stok} kg");
                }
            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavListe.Items.Clear();
            using (var context = new DataContext())
            {
                string kategori = cmbManavKategori.SelectedItem.ToString();
                var urunler = context.Manavlar.Where(u => u.Kategori == kategori).ToList();
                foreach (var urun in urunler)
                {
                    lstManavListe.Items.Add($"{urun.Ad} {urun.Stok} kg");
                }
            }
        }
        private void Satis()
        {
            using (var context = new DataContext())
            {
                var urunler = context.Satislar.Where(a => a.Id == a.Id).ToList();
                foreach (var urun in urunler)
                {
                    lst_Satis.Items.Add($"{urun.UrunAdi} {urun.Miktar} kg Satış Tarihi {urun.SatisTarihi}");
                }

            }
        }

        private void btn_HalEkle_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string urunAdi = txt_urun.Text.ToUpper().Trim();
                string kategori = cmbHalKategori.SelectedItem.ToString();
                if (string.IsNullOrEmpty(urunAdi))
                {
                    MessageBox.Show("Lütfen bir ürün adı giriniz");
                    return;
                }
                if (!int.TryParse(txt_HalKilo.Text, out int miktar) || miktar <= 0)
                {
                    MessageBox.Show("Geçerli bir kilo giriniz");
                    return;
                }
                var urun = context.Urunler.FirstOrDefault(u => u.Ad == urunAdi && u.Kategori == kategori);
                if (urun == null)
                {
                    urun = new Urun { Ad = urunAdi, Kategori = kategori, Stok = 0 };
                    context.Urunler.Add(urun);
                }
                urun.Stok += miktar;
                context.SaveChanges();
                MessageBox.Show($"{urunAdi} {miktar} kilo stoğa eklendi");
                txt_urun.Clear();
                txt_HalKilo.Clear();
                GuncelleHalUrunler();

            }
        }

        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }

        private void btn_ManavAl_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull == null)
                {
                    MessageBox.Show("Hal tarafından bir ürün seçiniz");
                    return;
                }
                if (!int.TryParse(txt_HalKilo.Text, out int alinacakKilo) || alinacakKilo <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilo giriniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split(' ');
                string secilenUrunAdi = urunParts[0].Trim();
                string kategori = cmbHalKategori.SelectedItem?.ToString();
                var halUrun = context.Urunler.FirstOrDefault(m => m.Ad == secilenUrunAdi && m.Kategori == kategori);
                if (halUrun == null)
                {
                    MessageBox.Show("Ürün bulunamadı.");
                    return;
                }
                if (halUrun.Stok < alinacakKilo)
                {
                    MessageBox.Show($"Elimizde yeterli stok yok mevcut miktar {halUrun.Stok} kg");
                    return;
                }
                var manavUrunu = context.Manavlar.FirstOrDefault(m => m.Ad == secilenUrunAdi && m.Kategori == kategori);
                if (manavUrunu == null)
                {
                    manavUrunu = new Manav()
                    {
                        Ad = secilenUrunAdi,
                        Kategori = kategori,
                        Stok = 0
                    };
                    context.Manavlar.Add(manavUrunu);
                }
                halUrun.Stok -= alinacakKilo;
                manavUrunu.Stok += alinacakKilo;
                if (halUrun.Stok == 0)
                {
                    context.Urunler.Remove(halUrun);
                }

                context.SaveChanges();
                MessageBox.Show($"{secilenUrunAdi}-{alinacakKilo} kg manav stoğuna aktarıldı");
                txt_HalKilo.Clear();
                GuncelleHalUrunler();
                GuncelleManavUrunler();

            }
        }

        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }

        private void btn_HalGuncelle_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull == null)
                {
                    MessageBox.Show("Hal tarafından bir ürün seçiniz");
                    return;
                }

                string[] urunParts = secilenUrunFull.Split(' ');
                string secilenUrunAdi = urunParts[0].Trim();
                string kategori = cmbHalKategori.SelectedItem?.ToString();
                var urun = context.Urunler.FirstOrDefault(m => m.Ad == secilenUrunAdi && m.Kategori == kategori);
                if (urun == null)
                {
                    MessageBox.Show("Ürün bulunamadı");
                    return;
                }
                if (!int.TryParse(txt_HalKilo.Text, out int yeniKilo) || yeniKilo <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilo giriniz");
                    return;
                }
                urun.Stok = yeniKilo;
                if (!string.IsNullOrEmpty(txt_urun.Text))
                {
                    urun.Ad = txt_urun.Text.ToUpper().Trim();
                }
                context.SaveChanges();
                MessageBox.Show("Stok başarıyla güncellendi");
                GuncelleHalUrunler();
                txt_HalKilo.Clear();
                txt_urun.Clear();
            }
        }

        private void btn_HalSil_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull == null)
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split(' ');
                string secilenUrun = urunParts[0].Trim();
                var urun = context.Urunler.FirstOrDefault(x => x.Ad == secilenUrun);
                if (urun == null)
                {
                    MessageBox.Show("Ürün Bulunamadı");
                    return;
                }
                DialogResult result = MessageBox.Show($"'{secilenUrun}' ürünü silmek ister misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.Urunler.Remove(urun);
                    context.SaveChanges();
                    MessageBox.Show("Ürün başarıyla silindi");
                    GuncelleHalUrunler();
                }
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_satisyap_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = lstManavListe.SelectedItem?.ToString();
                if (secilenUrunFull == null)
                {
                    MessageBox.Show("Bir ürün seçiniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split(' ');
                string secilenUrun = urunParts[0].Trim();
                if (!int.TryParse(txt_manavKilo.Text, out int kilo) || kilo <= 0)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Kilo Giriniz");
                    return;
                }
                var manavUrunu = context.Manavlar.FirstOrDefault(m => m.Ad == secilenUrun);
                if (manavUrunu == null || manavUrunu.Stok < kilo)
                {
                    MessageBox.Show("Yeterli stok yok");
                    return;
                }
                manavUrunu.Stok -= kilo;
                context.Satislar.Add(new Satis
                {
                    UrunAdi = secilenUrun,
                    Miktar = kilo,
                    SatisTarihi = DateTime.Now
                });
                if (manavUrunu.Stok == 0)
                {
                    context.Manavlar.Remove(manavUrunu);
                }
                lst_Musteri.Items.Add($"{secilenUrun}-{kilo} kg - {DateTime.Now.ToString("HH:mm")}");
                context.SaveChanges();
                MessageBox.Show("Satış başarılı");
                txt_manavKilo.Clear();
                GuncelleManavUrunler();
                Satis();
            }
        }
    }
}
