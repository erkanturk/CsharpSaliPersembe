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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string telefon = txt_GirisTel.Text.Trim();
            string sifre = txt_GirisSifre.Text;
            if (string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boşluk olarak bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var context = new DataContext();
                var musteri = context.Musteriler.FirstOrDefault(m => m.Telefon == telefon && m.Password == sifre);
                if (musteri != null)
                {
                    MessageBox.Show($"Hoşgeldiniz {musteri.AdSoyad}", "Giriş başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var arabaForm = new ArabaForm(musteri);
                    arabaForm.Show();
                }
                else
                {
                    MessageBox.Show($"Telefon no veya şifre hatalı", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_GirisSifre.Clear();
                    txt_GirisTel.Clear();
                    txt_GirisSifre.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata {ex.Message}", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearKayitFields()
        {
            txt_kAdSoyad.Clear();
            txt_kPassword.Clear();
            txt_kRePassword.Clear();
            txt_kTelefon.Clear();
        }

        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            var adminLoginForm= new AdminLoginForm();
            adminLoginForm.Show();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_kPassword.Text != txt_kRePassword.Text)
                {
                    MessageBox.Show($"Şifreler Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_kRePassword.Clear();
                    txt_kPassword.Clear();
                    txt_kPassword.Focus();
                    return;
                }
                using var context = new DataContext();
                var customer = context.Musteriler.FirstOrDefault(i => i.Telefon == txt_kTelefon.Text);
                if (customer != null)
                {
                    MessageBox.Show($"bu telefon numarasına kayıtlı bir üyelik bulunmakta", 
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_kTelefon.Clear();
                    return;
                }
                var musteri = new Musteri()
                {
                    Telefon = txt_kTelefon.Text,
                    Bakiye = 0,
                    AdSoyad=txt_kAdSoyad.Text,
                    Password = txt_kPassword.Text,
                };
                context.Musteriler.Add(musteri);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show($"Kayıt Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearKayitFields();
                }
                else
                {
                    MessageBox.Show($"Kayıt Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata {ex.Message}", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearKayitFields();
               
            }
        }
    }
}
