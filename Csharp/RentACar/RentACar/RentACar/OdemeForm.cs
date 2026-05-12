using RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RentACar
{
    public partial class OdemeForm : Form
    {
        private readonly Kiralama _kiralama;
        public OdemeForm(Kiralama kiralama)
        {
            _kiralama = kiralama;
            InitializeComponent();
            lblTutar.Text = $"Toplam Tutar: {_kiralama.ToplamTutar:C2} ₺";
            YilEkle();
            cmbAy.SelectedIndex = 0;
            cmbYil.SelectedIndex = 0;

        }
        private void YilEkle()
        {
            for (int i = 0; i < 10; i++)
            {
                DateTime time = DateTime.Now.AddYears(i);
                cmbYil.Items.Add(time.Year);
            }
        }
        private void txtKartNo_TextChanged(object sender, EventArgs e)
        {
            string text = new string(txtKartNo.Text.Where(char.IsDigit).ToArray());

            var formatted = new StringBuilder();
            for (int i = 0; i < text.Length && i < 16; i++)
            {
                if (i > 0 && i % 4 == 0) formatted.Append(' ');
                formatted.Append(text[i]);
            }
            int cursorPos = txtKartNo.SelectionStart;
            txtKartNo.Text = formatted.ToString();
            //İki değerden küçük olanla başla
            txtKartNo.SelectionStart = Math.Min(cursorPos + 1, txtKartNo.Text.Length);

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            string kartNo = new string(txtKartNo.Text.Where(char.IsDigit).ToArray());
            if (kartNo.Length != 16)
            {
                MessageBox.Show("Geçerli bir kart numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKartSahibi.Text))
            {
                MessageBox.Show("Kart sahibi adını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("Geçerli bir Cvv giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedKartNo = HashKartNo(kartNo);

            var result = MessageBox.Show($"Ödeme Özeti:\n\n" +
                $"Tutar:{_kiralama.ToplamTutar:N2}₺\n" +
                $"Kart:**** **** **** {kartNo.Substring(12)}\n" +
                $"Kart Sahibi: {txtKartSahibi.Text}\n\n" +
                $"Ödemeyi Onaylıyor Musunuz?",
                $"Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Ödeme Başarılı:\n\n" +
                $"İşlem No:{Guid.NewGuid().ToString().Substring(0,8).ToUpper()}₺\n" +
                $"Tutar: {_kiralama.ToplamTutar:N2}\n",
                $"Ödemeyi Başarılı",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }
        private static string HashKartNo(string kartNo)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(kartNo));
            return Convert.ToBase64String(bytes);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
