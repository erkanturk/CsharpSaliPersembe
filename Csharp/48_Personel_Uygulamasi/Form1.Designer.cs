namespace _48_Personel_Uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lst_Personellerim = new ListBox();
            groupBox1 = new GroupBox();
            btn_Kayit = new Button();
            txt_YeniTel = new TextBox();
            txt_YeniSoyad = new TextBox();
            txt_YeniEposta = new TextBox();
            txt_YeniAd = new TextBox();
            groupBox2 = new GroupBox();
            btn_Sil = new Button();
            btn_Guncelle = new Button();
            txt_GuncelleAd = new TextBox();
            txt_GuncelleTel = new TextBox();
            txt_GuncelleEposta = new TextBox();
            txt_GuncelleSoyad = new TextBox();
            btn_Listele = new Button();
            btn_Temizle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lst_Personellerim
            // 
            lst_Personellerim.FormattingEnabled = true;
            lst_Personellerim.Location = new Point(10, 15);
            lst_Personellerim.Name = "lst_Personellerim";
            lst_Personellerim.Size = new Size(310, 709);
            lst_Personellerim.TabIndex = 0;
            lst_Personellerim.Click += lst_Personellerim_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Kayit);
            groupBox1.Controls.Add(txt_YeniTel);
            groupBox1.Controls.Add(txt_YeniSoyad);
            groupBox1.Controls.Add(txt_YeniEposta);
            groupBox1.Controls.Add(txt_YeniAd);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(326, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 353);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Personel";
            // 
            // btn_Kayit
            // 
            btn_Kayit.Location = new Point(338, 266);
            btn_Kayit.Name = "btn_Kayit";
            btn_Kayit.Size = new Size(137, 33);
            btn_Kayit.TabIndex = 4;
            btn_Kayit.Text = "Kayıt Et";
            btn_Kayit.UseVisualStyleBackColor = true;
            btn_Kayit.Click += btn_Kayit_Click;
            // 
            // txt_YeniTel
            // 
            txt_YeniTel.Location = new Point(319, 209);
            txt_YeniTel.Name = "txt_YeniTel";
            txt_YeniTel.PlaceholderText = "Telefon";
            txt_YeniTel.Size = new Size(174, 29);
            txt_YeniTel.TabIndex = 3;
            // 
            // txt_YeniSoyad
            // 
            txt_YeniSoyad.Location = new Point(319, 95);
            txt_YeniSoyad.Name = "txt_YeniSoyad";
            txt_YeniSoyad.PlaceholderText = "Soyadınız";
            txt_YeniSoyad.Size = new Size(174, 29);
            txt_YeniSoyad.TabIndex = 1;
            // 
            // txt_YeniEposta
            // 
            txt_YeniEposta.Location = new Point(319, 152);
            txt_YeniEposta.Name = "txt_YeniEposta";
            txt_YeniEposta.PlaceholderText = "Eposta";
            txt_YeniEposta.Size = new Size(174, 29);
            txt_YeniEposta.TabIndex = 2;
            // 
            // txt_YeniAd
            // 
            txt_YeniAd.Location = new Point(319, 38);
            txt_YeniAd.Name = "txt_YeniAd";
            txt_YeniAd.PlaceholderText = "Adınız";
            txt_YeniAd.Size = new Size(174, 29);
            txt_YeniAd.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sil);
            groupBox2.Controls.Add(btn_Guncelle);
            groupBox2.Controls.Add(txt_GuncelleAd);
            groupBox2.Controls.Add(txt_GuncelleTel);
            groupBox2.Controls.Add(txt_GuncelleEposta);
            groupBox2.Controls.Add(txt_GuncelleSoyad);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(326, 374);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 353);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Güncelle";
            // 
            // btn_Sil
            // 
            btn_Sil.Location = new Point(338, 312);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(137, 33);
            btn_Sil.TabIndex = 10;
            btn_Sil.Text = "Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // btn_Guncelle
            // 
            btn_Guncelle.Location = new Point(338, 263);
            btn_Guncelle.Name = "btn_Guncelle";
            btn_Guncelle.Size = new Size(137, 33);
            btn_Guncelle.TabIndex = 9;
            btn_Guncelle.Text = "Güncelle";
            btn_Guncelle.UseVisualStyleBackColor = true;
            btn_Guncelle.Click += btn_Guncelle_Click;
            // 
            // txt_GuncelleAd
            // 
            txt_GuncelleAd.Location = new Point(319, 46);
            txt_GuncelleAd.Name = "txt_GuncelleAd";
            txt_GuncelleAd.PlaceholderText = "Güncellenecek Ad";
            txt_GuncelleAd.Size = new Size(174, 29);
            txt_GuncelleAd.TabIndex = 5;
            // 
            // txt_GuncelleTel
            // 
            txt_GuncelleTel.Location = new Point(319, 217);
            txt_GuncelleTel.Name = "txt_GuncelleTel";
            txt_GuncelleTel.PlaceholderText = "Güncellenecek Telefon";
            txt_GuncelleTel.Size = new Size(174, 29);
            txt_GuncelleTel.TabIndex = 8;
            // 
            // txt_GuncelleEposta
            // 
            txt_GuncelleEposta.Location = new Point(319, 160);
            txt_GuncelleEposta.Name = "txt_GuncelleEposta";
            txt_GuncelleEposta.PlaceholderText = "Güncellenecek Eposta";
            txt_GuncelleEposta.Size = new Size(174, 29);
            txt_GuncelleEposta.TabIndex = 7;
            // 
            // txt_GuncelleSoyad
            // 
            txt_GuncelleSoyad.Location = new Point(319, 103);
            txt_GuncelleSoyad.Name = "txt_GuncelleSoyad";
            txt_GuncelleSoyad.PlaceholderText = "Güncellenecek Soyad";
            txt_GuncelleSoyad.Size = new Size(174, 29);
            txt_GuncelleSoyad.TabIndex = 6;
            // 
            // btn_Listele
            // 
            btn_Listele.Location = new Point(552, 742);
            btn_Listele.Name = "btn_Listele";
            btn_Listele.Size = new Size(137, 33);
            btn_Listele.TabIndex = 11;
            btn_Listele.Text = "Listele";
            btn_Listele.UseVisualStyleBackColor = true;
            btn_Listele.Click += btn_Listele_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Location = new Point(788, 742);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(137, 33);
            btn_Temizle.TabIndex = 12;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 809);
            Controls.Add(btn_Temizle);
            Controls.Add(groupBox2);
            Controls.Add(btn_Listele);
            Controls.Add(groupBox1);
            Controls.Add(lst_Personellerim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Personellerim;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_YeniSoyad;
        private TextBox txt_YeniAd;
        private Button btn_Kayit;
        private TextBox txt_YeniTel;
        private TextBox txt_YeniEposta;
        private Button btn_Sil;
        private Button btn_Guncelle;
        private TextBox txt_GuncelleAd;
        private TextBox txt_GuncelleTel;
        private TextBox txt_GuncelleEposta;
        private TextBox txt_GuncelleSoyad;
        private Button btn_Listele;
        private Button btn_Temizle;
    }
}
