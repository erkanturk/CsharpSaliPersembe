using _48_Personel_Uygulamasi.BLL;
using _48_Personel_Uygulamasi.Entities;

namespace _48_Personel_Uygulamasi
{
    public partial class Form1 : Form
    {
        private readonly BusinessLayer _BLL;
        int sonuc;
        public Form1()
        {
            InitializeComponent();
            _BLL = new BusinessLayer();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            sonuc = _BLL.PersonelKayit(txt_YeniAd.Text, txt_YeniSoyad.Text, txt_YeniEposta.Text, txt_YeniTel.Text);
            if (sonuc == -100)
            {
                MessageBox.Show("Boþ alanlarý doldurun");
                return;
            }
            else if (sonuc == -101)
            {
                MessageBox.Show("Bu eposta veya telefon kullanýlýyor");
                return;
            }
            else if (sonuc == 1)
            {
                MessageBox.Show("Kayýt baþarýlý");
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Bilinmeyen hata sonra tekrar deneyin");
            }


        }
        private void PersonelDoldur()
        {
            try
            {
                List<Personel> personeller = _BLL.PersonelListele();
                lst_Personellerim.DataSource = null;
                lst_Personellerim.DataSource = personeller;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);

            }
        }

        private void PersonelDoldur1()
        {
            try
            {
                List<Personel1> personeller = _BLL.PersonelListele1();
                lst_Personellerim.DataSource = null;
                lst_Personellerim.DataSource = personeller;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (lst_Personellerim.SelectedItem == null)
            {
                MessageBox.Show("Lütfen personel seçin");
                return;
            }
            Personel seciliPersonel = (Personel)lst_Personellerim.SelectedItem;
            int sonuc = _BLL.PersonelSil(seciliPersonel.Id);
            if (sonuc > 0)
            {
                MessageBox.Show("Silme iþlemi baþarýlý");
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Silme sýrasýnda hata oluþtu");
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (lst_Personellerim.SelectedItem == null)
            {
                MessageBox.Show("Lütfen personel seçiniz");
                return;
            }
            if (string.IsNullOrEmpty(txt_GuncelleAd.Text) || string.IsNullOrEmpty(txt_GuncelleSoyad.Text) || string.IsNullOrEmpty(txt_GuncelleEposta.Text) || string.IsNullOrEmpty(txt_GuncelleTel.Text))
            {
                MessageBox.Show("Boþ alanlarý doldurun");
                return;
            }
            Personel seciliPersonel = (Personel)lst_Personellerim.SelectedItem;
            sonuc = _BLL.PersonelGuncelle(
                seciliPersonel.Id,
                txt_GuncelleAd.Text,
                txt_GuncelleSoyad.Text,
                txt_GuncelleEposta.Text,
                txt_GuncelleTel.Text

                );
            if (sonuc > 0)
            {
                MessageBox.Show("Güncelleme baþarýlý");
                PersonelDoldur();
                txt_GuncelleAd.Clear();
                txt_GuncelleSoyad.Clear();
                txt_GuncelleEposta.Clear();
                txt_GuncelleTel.Clear();
            }
            else
            {
                MessageBox.Show("Güncelleme sýrasýnda hata oluþtu");
            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            PersonelDoldur1();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_GuncelleAd.Clear();
            txt_GuncelleSoyad.Clear();
            txt_GuncelleEposta.Clear();
            txt_GuncelleTel.Clear();
            txt_YeniAd.Clear();
            txt_YeniEposta.Clear();
            txt_YeniSoyad.Clear();
            txt_YeniTel.Clear();
        }



        private void lst_Personellerim_Click(object sender, EventArgs e)
        {
            Personel personel = (Personel)lst_Personellerim.SelectedItem;
            txt_GuncelleAd.Text = personel.Isim;
            txt_GuncelleSoyad.Text = personel.SoyIsim;
            txt_GuncelleEposta.Text = personel.Email;
            txt_GuncelleTel.Text = personel.Telefon;
        }
    }
}
