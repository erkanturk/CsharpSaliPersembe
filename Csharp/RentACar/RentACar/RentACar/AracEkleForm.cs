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
    public partial class AracEkleForm : Form
    {
        private readonly int? _aracId;

        public AracEkleForm()
        {
            _aracId = null;

            InitializeComponent();
            this.Text = "Yeni Araç Ekle";
            LoadMarkalar();

        }
        public AracEkleForm(int aracId)
        {
            _aracId = aracId;
            InitializeComponent();
            this.Text = "Araç Düzenle";
            LoadMarkalar();
            LoadAracBilgileri();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show($"Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var context = new DataContext();
                if (_aracId.HasValue)
                {
                    var arac = context.Arabalar.Find(_aracId.Value);
                    if (arac != null)
                    {
                        arac.MarkaId = (int)cmbMarka.SelectedValue;
                        arac.Model = txtModel.Text;
                        arac.Plaka = txtPlaka.Text;
                        arac.Yil = (int)numYil.Value;
                        arac.SaatlikUcret = (double)numUcret.Value;
                        arac.Aktif = chkAktif.Checked;
                    }
                }
                else
                {
                    var yeniArac = new Araba()
                    {
                        MarkaId = (int)cmbMarka.SelectedValue,
                        Model = txtModel.Text,
                        Plaka = txtPlaka.Text,
                        Yil = (int)numYil.Value,
                        SaatlikUcret = (double)numUcret.Value,
                        Aktif = chkAktif.Checked
                    };
                    context.Arabalar.Add(yeniArac);
                }
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt hatası {ex.Message}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void LoadMarkalar()
        {
            using var context = new DataContext();
            var markalar = context.Markalar.ToList();
            cmbMarka.DisplayMember = "Ad";
            cmbMarka.ValueMember = "Id";
            cmbMarka.DataSource = markalar;
        }
        private void LoadAracBilgileri()
        {
            if (!_aracId.HasValue) return;
            using var context = new DataContext();
            var arac = context.Arabalar.Find(_aracId.Value);
            if (arac != null)
            {
                cmbMarka.SelectedValue = arac.MarkaId;
                txtModel.Text = arac.Model;
                txtPlaka.Text = arac.Plaka;
                numYil.Value = arac.Yil;
                numUcret.Value = (decimal)arac.SaatlikUcret;
                chkAktif.Checked = arac.Aktif;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
