using _48_Personel_Uygulamasi.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _48_Personel_Uygulamasi
{
    public partial class Login : Form
    {
        private readonly BusinessLayer _BLL;
        public Login()
        {
            InitializeComponent();
            _BLL = new BusinessLayer();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            int result = _BLL.SistemGirisKontrol(txt_Giris.Text.ToUpper(), txt_Sifre.Text.ToUpper());
            if (result == -100)
            {
                MessageBox.Show("Giriş bilgilerinizi doldurunuz");
            }
            else if (result == 0)
            {
                MessageBox.Show("Giriş bilgileri hatalı");
            }
            else
            {
                MessageBox.Show($"Hoşgeldiniz {txt_Giris.Text}");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
