namespace _47_ManavOtomasyon
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_HalSil = new Button();
            btn_HalGuncelle = new Button();
            btn_ManavAl = new Button();
            btn_HalEkle = new Button();
            txt_HalKilo = new TextBox();
            txt_urun = new TextBox();
            LstHalUrunler = new ListBox();
            cmbHalKategori = new ComboBox();
            tabPage2 = new TabPage();
            btn_satisyap = new Button();
            label7 = new Label();
            label6 = new Label();
            lst_Satis = new ListBox();
            lst_Musteri = new ListBox();
            label5 = new Label();
            Kilo = new Label();
            txt_manavKilo = new TextBox();
            lstManavListe = new ListBox();
            cmbManavKategori = new ComboBox();
            btn_cikis = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 532);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_HalSil);
            tabPage1.Controls.Add(btn_HalGuncelle);
            tabPage1.Controls.Add(btn_ManavAl);
            tabPage1.Controls.Add(btn_HalEkle);
            tabPage1.Controls.Add(txt_HalKilo);
            tabPage1.Controls.Add(txt_urun);
            tabPage1.Controls.Add(LstHalUrunler);
            tabPage1.Controls.Add(cmbHalKategori);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hal-Toptancı";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(155, 302);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 10;
            label3.Text = "Ürün Kilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(34, 302);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Ürün Ekle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Kategori";
            // 
            // btn_HalSil
            // 
            btn_HalSil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_HalSil.Location = new Point(136, 405);
            btn_HalSil.Name = "btn_HalSil";
            btn_HalSil.Size = new Size(110, 23);
            btn_HalSil.TabIndex = 7;
            btn_HalSil.Text = "Sil";
            btn_HalSil.UseVisualStyleBackColor = true;
            btn_HalSil.Click += btn_HalSil_Click;
            // 
            // btn_HalGuncelle
            // 
            btn_HalGuncelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_HalGuncelle.Location = new Point(16, 405);
            btn_HalGuncelle.Name = "btn_HalGuncelle";
            btn_HalGuncelle.Size = new Size(110, 23);
            btn_HalGuncelle.TabIndex = 6;
            btn_HalGuncelle.Text = "Güncelle";
            btn_HalGuncelle.UseVisualStyleBackColor = true;
            btn_HalGuncelle.Click += btn_HalGuncelle_Click;
            // 
            // btn_ManavAl
            // 
            btn_ManavAl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_ManavAl.Location = new Point(136, 367);
            btn_ManavAl.Name = "btn_ManavAl";
            btn_ManavAl.Size = new Size(110, 23);
            btn_ManavAl.TabIndex = 5;
            btn_ManavAl.Text = "Manav Al";
            btn_ManavAl.UseVisualStyleBackColor = true;
            btn_ManavAl.Click += btn_ManavAl_Click;
            // 
            // btn_HalEkle
            // 
            btn_HalEkle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_HalEkle.Location = new Point(16, 367);
            btn_HalEkle.Name = "btn_HalEkle";
            btn_HalEkle.Size = new Size(110, 23);
            btn_HalEkle.TabIndex = 4;
            btn_HalEkle.Text = "Hal Ekle";
            btn_HalEkle.UseVisualStyleBackColor = true;
            btn_HalEkle.Click += btn_HalEkle_Click;
            // 
            // txt_HalKilo
            // 
            txt_HalKilo.Location = new Point(136, 329);
            txt_HalKilo.Name = "txt_HalKilo";
            txt_HalKilo.Size = new Size(110, 23);
            txt_HalKilo.TabIndex = 3;
            // 
            // txt_urun
            // 
            txt_urun.Location = new Point(16, 329);
            txt_urun.Name = "txt_urun";
            txt_urun.Size = new Size(114, 23);
            txt_urun.TabIndex = 2;
            // 
            // LstHalUrunler
            // 
            LstHalUrunler.FormattingEnabled = true;
            LstHalUrunler.Location = new Point(16, 63);
            LstHalUrunler.Name = "LstHalUrunler";
            LstHalUrunler.Size = new Size(230, 229);
            LstHalUrunler.TabIndex = 1;
            // 
            // cmbHalKategori
            // 
            cmbHalKategori.FormattingEnabled = true;
            cmbHalKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbHalKategori.Location = new Point(114, 19);
            cmbHalKategori.Name = "cmbHalKategori";
            cmbHalKategori.Size = new Size(132, 23);
            cmbHalKategori.TabIndex = 0;
            cmbHalKategori.SelectedIndexChanged += cmbHalKategori_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_satisyap);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(lst_Satis);
            tabPage2.Controls.Add(lst_Musteri);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(Kilo);
            tabPage2.Controls.Add(txt_manavKilo);
            tabPage2.Controls.Add(lstManavListe);
            tabPage2.Controls.Add(cmbManavKategori);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 504);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manav";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_satisyap
            // 
            btn_satisyap.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_satisyap.Location = new Point(92, 452);
            btn_satisyap.Name = "btn_satisyap";
            btn_satisyap.Size = new Size(98, 23);
            btn_satisyap.TabIndex = 9;
            btn_satisyap.Text = "Satış Yap";
            btn_satisyap.UseVisualStyleBackColor = true;
            btn_satisyap.Click += btn_satisyap_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(379, 325);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 8;
            label7.Text = "Satılan Ürünler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(468, 34);
            label6.Name = "label6";
            label6.Size = new Size(193, 21);
            label6.TabIndex = 7;
            label6.Text = "Müşterinin Aldığı Ürünler";
            // 
            // lst_Satis
            // 
            lst_Satis.FormattingEnabled = true;
            lst_Satis.Location = new Point(379, 361);
            lst_Satis.Name = "lst_Satis";
            lst_Satis.Size = new Size(318, 124);
            lst_Satis.TabIndex = 6;
            // 
            // lst_Musteri
            // 
            lst_Musteri.FormattingEnabled = true;
            lst_Musteri.Location = new Point(450, 71);
            lst_Musteri.Name = "lst_Musteri";
            lst_Musteri.Size = new Size(247, 169);
            lst_Musteri.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(27, 31);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 4;
            label5.Text = "Kategori";
            // 
            // Kilo
            // 
            Kilo.AutoSize = true;
            Kilo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Kilo.Location = new Point(46, 414);
            Kilo.Name = "Kilo";
            Kilo.Size = new Size(38, 21);
            Kilo.TabIndex = 3;
            Kilo.Text = "Kilo";
            // 
            // txt_manavKilo
            // 
            txt_manavKilo.Location = new Point(92, 411);
            txt_manavKilo.Name = "txt_manavKilo";
            txt_manavKilo.Size = new Size(120, 23);
            txt_manavKilo.TabIndex = 2;
            // 
            // lstManavListe
            // 
            lstManavListe.FormattingEnabled = true;
            lstManavListe.Location = new Point(27, 71);
            lstManavListe.Name = "lstManavListe";
            lstManavListe.Size = new Size(230, 304);
            lstManavListe.TabIndex = 1;
            // 
            // cmbManavKategori
            // 
            cmbManavKategori.FormattingEnabled = true;
            cmbManavKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbManavKategori.Location = new Point(106, 31);
            cmbManavKategori.Name = "cmbManavKategori";
            cmbManavKategori.Size = new Size(121, 23);
            cmbManavKategori.TabIndex = 0;
            cmbManavKategori.SelectedIndexChanged += cmbManavKategori_SelectedIndexChanged;
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(700, 548);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(75, 23);
            btn_cikis.TabIndex = 1;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = true;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 583);
            Controls.Add(btn_cikis);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox LstHalUrunler;
        private ComboBox cmbHalKategori;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_HalSil;
        private Button btn_HalGuncelle;
        private Button btn_ManavAl;
        private Button btn_HalEkle;
        private TextBox txt_HalKilo;
        private TextBox txt_urun;
        private Button btn_cikis;
        private Button btn_satisyap;
        private Label label7;
        private Label label6;
        private ListBox lst_Satis;
        private ListBox lst_Musteri;
        private Label label5;
        private Label Kilo;
        private TextBox txt_manavKilo;
        private ListBox lstManavListe;
        private ComboBox cmbManavKategori;
    }
}
