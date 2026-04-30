using RentACar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentACar
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object? sender, EventArgs e)
        {
            string kullaniciAdi =txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boşluk olarak bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var context = new DataContext();
                var admin = context.Adminler.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);

                if (admin != null)
                {
                    MessageBox.Show($"Hoşgeldiniz {admin.AdSoyad}", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var dashboard = new AdminDashboardForm();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                  
                    txtSifre.Focus();//İmleci taşıma işlemi
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
