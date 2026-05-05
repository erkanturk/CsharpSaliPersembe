namespace RentACar
{
    partial class ArabaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtg_arabalar = new DataGridView();
            groupBox1 = new GroupBox();
            btn_Hesapla = new Button();
            btn_Kirala = new Button();
            dtp_tSaat = new DateTimePicker();
            dtp_kSaat = new DateTimePicker();
            dtp_tTarih = new DateTimePicker();
            dtp_kTarih = new DateTimePicker();
            txt_toplamTutar = new TextBox();
            txt_toplamSaat = new TextBox();
            txt_kAraba = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_arabaGetir = new Button();
            btn_Kiralamalar = new Button();
            cmb_Listele = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Arabalar";
            // 
            // dtg_arabalar
            // 
            dtg_arabalar.AllowUserToAddRows = false;
            dtg_arabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_arabalar.Location = new Point(1, 109);
            dtg_arabalar.Name = "dtg_arabalar";
            dtg_arabalar.ReadOnly = true;
            dtg_arabalar.Size = new Size(542, 617);
            dtg_arabalar.TabIndex = 1;
            dtg_arabalar.DoubleClick += dtg_arabalar_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Hesapla);
            groupBox1.Controls.Add(btn_Kirala);
            groupBox1.Controls.Add(dtp_tSaat);
            groupBox1.Controls.Add(dtp_kSaat);
            groupBox1.Controls.Add(dtp_tTarih);
            groupBox1.Controls.Add(dtp_kTarih);
            groupBox1.Controls.Add(txt_toplamTutar);
            groupBox1.Controls.Add(txt_toplamSaat);
            groupBox1.Controls.Add(txt_kAraba);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(701, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 739);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Yöntemi";
            // 
            // btn_Hesapla
            // 
            btn_Hesapla.BackColor = Color.SteelBlue;
            btn_Hesapla.FlatStyle = FlatStyle.Flat;
            btn_Hesapla.ForeColor = SystemColors.ControlLightLight;
            btn_Hesapla.Location = new Point(271, 383);
            btn_Hesapla.Name = "btn_Hesapla";
            btn_Hesapla.Size = new Size(100, 33);
            btn_Hesapla.TabIndex = 14;
            btn_Hesapla.Text = "Hesapla";
            btn_Hesapla.UseVisualStyleBackColor = false;
            btn_Hesapla.Click += btn_Hesapla_Click;
            // 
            // btn_Kirala
            // 
            btn_Kirala.BackColor = Color.SteelBlue;
            btn_Kirala.FlatStyle = FlatStyle.Flat;
            btn_Kirala.ForeColor = SystemColors.ControlLightLight;
            btn_Kirala.Location = new Point(152, 383);
            btn_Kirala.Name = "btn_Kirala";
            btn_Kirala.Size = new Size(100, 33);
            btn_Kirala.TabIndex = 13;
            btn_Kirala.Text = "Kirala";
            btn_Kirala.UseVisualStyleBackColor = false;
            btn_Kirala.Click += btn_Kirala_Click;
            // 
            // dtp_tSaat
            // 
            dtp_tSaat.Format = DateTimePickerFormat.Time;
            dtp_tSaat.Location = new Point(271, 188);
            dtp_tSaat.Name = "dtp_tSaat";
            dtp_tSaat.Size = new Size(76, 26);
            dtp_tSaat.TabIndex = 12;
            // 
            // dtp_kSaat
            // 
            dtp_kSaat.Format = DateTimePickerFormat.Time;
            dtp_kSaat.Location = new Point(271, 132);
            dtp_kSaat.Name = "dtp_kSaat";
            dtp_kSaat.Size = new Size(76, 26);
            dtp_kSaat.TabIndex = 11;
            // 
            // dtp_tTarih
            // 
            dtp_tTarih.Format = DateTimePickerFormat.Short;
            dtp_tTarih.Location = new Point(152, 188);
            dtp_tTarih.Name = "dtp_tTarih";
            dtp_tTarih.Size = new Size(113, 26);
            dtp_tTarih.TabIndex = 10;
            // 
            // dtp_kTarih
            // 
            dtp_kTarih.Format = DateTimePickerFormat.Short;
            dtp_kTarih.Location = new Point(152, 132);
            dtp_kTarih.Name = "dtp_kTarih";
            dtp_kTarih.Size = new Size(113, 26);
            dtp_kTarih.TabIndex = 9;
            // 
            // txt_toplamTutar
            // 
            txt_toplamTutar.Location = new Point(152, 315);
            txt_toplamTutar.Name = "txt_toplamTutar";
            txt_toplamTutar.ReadOnly = true;
            txt_toplamTutar.Size = new Size(210, 26);
            txt_toplamTutar.TabIndex = 8;
            // 
            // txt_toplamSaat
            // 
            txt_toplamSaat.Location = new Point(152, 246);
            txt_toplamSaat.Name = "txt_toplamSaat";
            txt_toplamSaat.ReadOnly = true;
            txt_toplamSaat.Size = new Size(210, 26);
            txt_toplamSaat.TabIndex = 7;
            // 
            // txt_kAraba
            // 
            txt_kAraba.Location = new Point(152, 77);
            txt_kAraba.Name = "txt_kAraba";
            txt_kAraba.ReadOnly = true;
            txt_kAraba.Size = new Size(210, 26);
            txt_kAraba.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 315);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 4;
            label6.Text = "Toplam Tutar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 254);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 3;
            label5.Text = "Toplam Saat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 196);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 2;
            label4.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 138);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 1;
            label3.Text = "Kiralama Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 80);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 0;
            label2.Text = "Araç";
            // 
            // btn_arabaGetir
            // 
            btn_arabaGetir.BackColor = Color.SteelBlue;
            btn_arabaGetir.FlatStyle = FlatStyle.Flat;
            btn_arabaGetir.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_arabaGetir.ForeColor = SystemColors.ControlLightLight;
            btn_arabaGetir.Location = new Point(99, 35);
            btn_arabaGetir.Name = "btn_arabaGetir";
            btn_arabaGetir.Size = new Size(95, 28);
            btn_arabaGetir.TabIndex = 3;
            btn_arabaGetir.Text = "Araba Getir";
            btn_arabaGetir.UseVisualStyleBackColor = false;
            btn_arabaGetir.Click += btn_arabaGetir_Click;
            // 
            // btn_Kiralamalar
            // 
            btn_Kiralamalar.BackColor = Color.SteelBlue;
            btn_Kiralamalar.FlatStyle = FlatStyle.Flat;
            btn_Kiralamalar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_Kiralamalar.ForeColor = SystemColors.ControlLightLight;
            btn_Kiralamalar.Location = new Point(99, 69);
            btn_Kiralamalar.Name = "btn_Kiralamalar";
            btn_Kiralamalar.Size = new Size(95, 28);
            btn_Kiralamalar.TabIndex = 4;
            btn_Kiralamalar.Text = "Kiralamalar";
            btn_Kiralamalar.UseVisualStyleBackColor = false;
            btn_Kiralamalar.Click += btn_Kiralamalar_Click;
            // 
            // cmb_Listele
            // 
            cmb_Listele.FormattingEnabled = true;
            cmb_Listele.Location = new Point(87, 6);
            cmb_Listele.Name = "cmb_Listele";
            cmb_Listele.Size = new Size(121, 23);
            cmb_Listele.TabIndex = 5;
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 771);
            Controls.Add(cmb_Listele);
            Controls.Add(btn_Kiralamalar);
            Controls.Add(btn_arabaGetir);
            Controls.Add(groupBox1);
            Controls.Add(dtg_arabalar);
            Controls.Add(label1);
            Name = "ArabaForm";
            Text = "ArabaForm";
            Load += ArabaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_arabalar;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtp_tSaat;
        private DateTimePicker dtp_kSaat;
        private DateTimePicker dtp_tTarih;
        private DateTimePicker dtp_kTarih;
        private TextBox txt_toplamTutar;
        private TextBox txt_toplamSaat;
        private TextBox txt_kAraba;
        private Button btn_Hesapla;
        private Button btn_Kirala;
        private Button btn_arabaGetir;
        private Button btn_Kiralamalar;
        private ComboBox cmb_Listele;
    }
}