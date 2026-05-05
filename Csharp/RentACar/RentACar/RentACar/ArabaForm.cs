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
    public partial class ArabaForm : Form
    {
        DataContext _context;
        Araba? _kiralikAraba;//? null gelebilir  anlamında Nullable alan olarak belirttik.
        Musteri _musteri;
        public ArabaForm(Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            this._musteri = musteri;
            dtp_kTarih.MinDate = DateTime.Now;//Kiralama tarihinin bugünden önce olmaması için minimum tarih olarak bugünü belirledik.
            dtp_tTarih.MinDate = DateTime.Now.AddDays(1);//Teslim tarihinin kiralama tarihinden sonra olması için minimum tarih olarak kiralama tarihinin bir gün sonrasını belirledik.
        }

        private void ArabaForm_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            cmb_Listele.DataSource = _context.Markalar.ToList();
            cmb_Listele.DisplayMember = "Ad";//Arkaplanda Marka sınıfının Ad özelliğini gösteriyoruz.
            cmb_Listele.ValueMember = "Id";//Arkaplanda Marka sınıfının Id özelliğini değer olarak kullanıyoruz.
            cmb_Listele.SelectedIndex = -1;//Hiçbir marka seçili gelmesin diye -1 yapıyoruz.

            dtp_kTarih.Value = time;
            dtp_kSaat.Value = time;
            dtp_tSaat.Value = time;
            dtp_tTarih.Value = time.AddDays(1);
            YukleAktifAraclar();

        }
        private void YukleAktifAraclar()
        {
            var arabalist = _context.Arabalar.Where(a => a.Aktif)
                .Include(a => a.Marka)
                .Select(a => new
                {
                    Id = a.Id,
                    Marka = a.Marka != null ? a.Marka.Ad : "",
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret

                }).ToList();

            dtg_arabalar.DataSource = arabalist;
            if (dtg_arabalar.Columns.Contains("Id"))
            {
                dtg_arabalar.Columns["Id"].Visible = false;//Id kolonunu gizliyoruz çünkü kullanıcıya göstermeyeceğiz.
            }

        }

        private void btn_arabaGetir_Click(object sender, EventArgs e)
        {
            cmb_Listele.BackColor = Color.White;
            //AsQueryable() ile veritabanından çekilen veriyi sorgulanabilir hale getiriyoruz.
            //Böylece filtreleme, sıralama gibi işlemleri yapabiliriz.
            var arabaList = _context.Arabalar.Where(a => a.Aktif).AsQueryable();

            if (cmb_Listele.SelectedValue != null)
            {
                //Combobox'ta seçilen MarkaId'ye göre arabaList'i filtreliyoruz.
                arabaList = arabaList.Where(x => x.MarkaId == (int)cmb_Listele.SelectedValue);
            }
            var sonuc = arabaList.Include(a => a.Marka)
                .Select(a => new
                {
                    Id = a.Id,
                    Marka = a.Marka != null ? a.Marka.Ad : "",
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret
                }).ToList();

            dtg_arabalar.DataSource = sonuc;
            if (dtg_arabalar.Columns.Contains("Id"))
            {
                dtg_arabalar.Columns["Id"].Visible = false;//Id kolonunu gizliyoruz çünkü kullanıcıya göstermeyeceğiz.
            }
        }

        private void dtg_arabalar_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_arabalar.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dtg_arabalar.SelectedRows[0].Cells["Id"].Value);
                    _kiralikAraba = _context.Arabalar.Include(a => a.Marka).FirstOrDefault(a => a.Id == id);
                    if (_kiralikAraba == null)
                    {
                        MessageBox.Show("Araba bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Null-conditional operator(?.):null ise hata vermez null döner  veya null değilse normal şekilde çalışır.
                    string markaAdi = _kiralikAraba.Marka?.Ad ?? "";
                    //Marka null olabilir o yüzden null kontrolü yapıyoruz. Marka varsa adını al yoksa boş string getir.
                    txt_kAraba.Text = $"{markaAdi} {_kiralikAraba.Model}";
                    MessageBox.Show($"Araç Seçildi:{txt_kAraba.Text}\nŞimdi Tarihleri seçip Hesapla butonuna tıklayın.", "Araç Seçildi"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Kirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (_kiralikAraba == null)
                {
                    MessageBox.Show($"Lütfen bir araç seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime baslangicTarihi = dtp_kTarih.Value.Date + dtp_kSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_tTarih.Value.Date + dtp_tSaat.Value.TimeOfDay;
                if (bitisTarihi <= baslangicTarihi)
                {
                    MessageBox.Show($"Bitiş tarihi, başlangıç tarihinden önce olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool aracMusaitMi = _context.Kiralamalar.Where(k => k.ArabaId == _kiralikAraba.Id)//Bu araça ait kiralamaları getiriyoruz.
                    .Where(k => (baslangicTarihi >= k.BaslangicTarihi && baslangicTarihi < k.BitisTarihi)//Tarih çakışmalarını kontrol ediyoruz.
                    || (bitisTarihi > k.BaslangicTarihi && bitisTarihi <= k.BitisTarihi)
                    || (baslangicTarihi <= k.BaslangicTarihi && bitisTarihi >= k.BitisTarihi))
                    .Count() == 0;//Eğer bu şartlara uyan kiralama yoksa araç müsait demektir.
                if (!aracMusaitMi)
                {
                    MessageBox.Show($"Seçtiğiniz araç bu tarihler arasında müsait değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double toplamTutar = string.IsNullOrEmpty(txt_toplamTutar.Text) ? 0 : Convert.ToDouble(txt_toplamTutar.Text);
                if (toplamTutar <= 0)
                {
                    MessageBox.Show($"Lütfen geçerli tarih aralıkları seçiniz ve Hesapla butonuna tıklayınız!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var yeniKiralama = new Kiralama()
                {
                    MusteriId = _musteri.Id,
                    ArabaId = _kiralikAraba.Id,
                    BaslangicTarihi = baslangicTarihi,
                    BitisTarihi = bitisTarihi,
                    ToplamTutar = toplamTutar
                };
                //Ödeme formunu aç ShowDialog() ile açıyoruz çünkü ödeme işlemi tamamlanmadan diğer işlemlere geçilmesini istemiyoruz.
                var odemeForm = new OdemeForm(yeniKiralama);
                var result = odemeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _kiralikAraba.Aktif = false;//Araba kiralandığı için artık aktif değil.
                    _context.Kiralamalar.Add(yeniKiralama);
                    _context.SaveChanges();
                    MessageBox.Show($"Araç başarıyla kiralandı! Araç:{_kiralikAraba.Marka?.Ad} {_kiralikAraba.Model}\n" +
                        $"Başlangıç: {baslangicTarihi:dd.MM.yyyy HH:mm}\nBitiş: {bitisTarihi:dd.MM.yyyy HH:mm}\nToplam Tutar: {toplamTutar:N2}",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Formatlı tarih zaman dd.MM.yyyy HH:mm şeklinde gösterilir.
                    //Toplam tutar ise N2 formatında yani 2 ondalık basamaklı ve binlik ayracı olan şekilde gösterilir.

                    YukleAktifAraclar();
                    txt_kAraba.Clear();
                    txt_toplamTutar.Clear();
                    txt_toplamSaat.Clear();
                    _kiralikAraba = null;
                }
                else
                {
                    MessageBox.Show($"Ödeme işlemi tamamlanmadı. Kiralama iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Kiralama işlemi sırasında bir hata oluştu. {ex.Message}" +
                    $" Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (_kiralikAraba == null)
                {
                    MessageBox.Show($"Lütfen bir araç seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime baslangicTarihi = dtp_kTarih.Value.Date + dtp_kSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_tTarih.Value.Date + dtp_tSaat.Value.TimeOfDay;
                if(bitisTarihi<=baslangicTarihi)
                {
                    MessageBox.Show($"Bitiş tarihi başlangıç tarihinden önce olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //TimeSpan:İki tarih arasındaki farkı göstermek için kullanılan bir yapıdır. Gün, saat, dakika, saniye gibi zaman birimlerini temsil eder.
                TimeSpan fark = bitisTarihi - baslangicTarihi;
                double toplamSaat = Math.Ceiling(fark.TotalHours);
                txt_toplamSaat.Text = toplamSaat.ToString();
                double toplamTutar = toplamSaat * _kiralikAraba.SaatlikUcret;
                txt_toplamTutar.Text = toplamTutar.ToString("F2");//f2 fixed-point formatında yani 2 ondalık basamaklı şekilde gösterilir.(100.00)
            }
            catch (Exception ex)
            {

               MessageBox.Show($"Hesaplama işlemi sırasında bir hata oluştu. {ex.Message}" +
                    $" Lütfen tarihleri kontrol edip tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Kiralamalar_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralamaForm = new KiralamaForm(_musteri);
            kiralamaForm.Show();
            this.Close();
        }
    }
}
