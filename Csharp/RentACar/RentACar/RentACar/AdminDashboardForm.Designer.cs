namespace RentACar
{
    partial class AdminDashboardForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvMarkalar = new DataGridView();
            pnlMarkaButtons = new Panel();
            btnMarkaSil = new Button();
            btnMarkaEkle = new Button();
            tabPage2 = new TabPage();
            pnlAracButtons = new Panel();
            btnAracDuzenle = new Button();
            btnAracSil = new Button();
            btnAracEkle = new Button();
            dgvAraclar = new DataGridView();
            tabPage3 = new TabPage();
            dgvBildirimler = new DataGridView();
            panel1 = new Panel();
            btnYenile = new Button();
            btnReddet = new Button();
            btnOnayla = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkalar).BeginInit();
            pnlMarkaButtons.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlAracButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBildirimler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1085, 791);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvMarkalar);
            tabPage1.Controls.Add(pnlMarkaButtons);
            tabPage1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1077, 761);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "🏷️Markalar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMarkalar
            // 
            dgvMarkalar.AllowUserToAddRows = false;
            dgvMarkalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarkalar.Location = new Point(2, 3);
            dgvMarkalar.Name = "dgvMarkalar";
            dgvMarkalar.ReadOnly = true;
            dgvMarkalar.Size = new Size(1079, 692);
            dgvMarkalar.TabIndex = 1;
            // 
            // pnlMarkaButtons
            // 
            pnlMarkaButtons.BackColor = Color.Gainsboro;
            pnlMarkaButtons.Controls.Add(btnMarkaSil);
            pnlMarkaButtons.Controls.Add(btnMarkaEkle);
            pnlMarkaButtons.Location = new Point(0, 682);
            pnlMarkaButtons.Name = "pnlMarkaButtons";
            pnlMarkaButtons.Size = new Size(1078, 74);
            pnlMarkaButtons.TabIndex = 0;
            // 
            // btnMarkaSil
            // 
            btnMarkaSil.BackColor = Color.Firebrick;
            btnMarkaSil.FlatStyle = FlatStyle.Flat;
            btnMarkaSil.ForeColor = SystemColors.ControlLightLight;
            btnMarkaSil.Location = new Point(184, 19);
            btnMarkaSil.Name = "btnMarkaSil";
            btnMarkaSil.Size = new Size(144, 37);
            btnMarkaSil.TabIndex = 1;
            btnMarkaSil.Text = "Marka Sil";
            btnMarkaSil.UseVisualStyleBackColor = false;
            btnMarkaSil.Click += btnMarkaSil_Click;
            // 
            // btnMarkaEkle
            // 
            btnMarkaEkle.BackColor = SystemColors.Highlight;
            btnMarkaEkle.FlatStyle = FlatStyle.Flat;
            btnMarkaEkle.ForeColor = SystemColors.ControlLightLight;
            btnMarkaEkle.Location = new Point(15, 19);
            btnMarkaEkle.Name = "btnMarkaEkle";
            btnMarkaEkle.Size = new Size(147, 37);
            btnMarkaEkle.TabIndex = 0;
            btnMarkaEkle.Text = "Marka Ekle";
            btnMarkaEkle.UseVisualStyleBackColor = false;
            btnMarkaEkle.Click += btnMarkaEkle_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlAracButtons);
            tabPage2.Controls.Add(dgvAraclar);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1077, 761);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "🚗Araçlar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlAracButtons
            // 
            pnlAracButtons.BackColor = Color.LightGray;
            pnlAracButtons.Controls.Add(btnAracDuzenle);
            pnlAracButtons.Controls.Add(btnAracSil);
            pnlAracButtons.Controls.Add(btnAracEkle);
            pnlAracButtons.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            pnlAracButtons.Location = new Point(3, 688);
            pnlAracButtons.Name = "pnlAracButtons";
            pnlAracButtons.Size = new Size(1076, 70);
            pnlAracButtons.TabIndex = 1;
            // 
            // btnAracDuzenle
            // 
            btnAracDuzenle.BackColor = Color.SeaGreen;
            btnAracDuzenle.BackgroundImageLayout = ImageLayout.None;
            btnAracDuzenle.FlatStyle = FlatStyle.Flat;
            btnAracDuzenle.ForeColor = SystemColors.ControlLightLight;
            btnAracDuzenle.Location = new Point(380, 8);
            btnAracDuzenle.Name = "btnAracDuzenle";
            btnAracDuzenle.Size = new Size(152, 48);
            btnAracDuzenle.TabIndex = 0;
            btnAracDuzenle.Text = "Düzenle";
            btnAracDuzenle.UseVisualStyleBackColor = false;
            btnAracDuzenle.Click += btnAracDuzenle_Click;
            // 
            // btnAracSil
            // 
            btnAracSil.BackColor = Color.Firebrick;
            btnAracSil.FlatStyle = FlatStyle.Flat;
            btnAracSil.ForeColor = SystemColors.ControlLightLight;
            btnAracSil.Location = new Point(198, 8);
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Size = new Size(152, 48);
            btnAracSil.TabIndex = 0;
            btnAracSil.Text = "Araç Sil";
            btnAracSil.UseVisualStyleBackColor = false;
            btnAracSil.Click += btnAracSil_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.BackColor = Color.RoyalBlue;
            btnAracEkle.FlatStyle = FlatStyle.Flat;
            btnAracEkle.ForeColor = SystemColors.ControlLightLight;
            btnAracEkle.Location = new Point(19, 8);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(152, 48);
            btnAracEkle.TabIndex = 0;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.UseVisualStyleBackColor = false;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // dgvAraclar
            // 
            dgvAraclar.AllowUserToAddRows = false;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(-2, 1);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.ReadOnly = true;
            dgvAraclar.Size = new Size(1083, 681);
            dgvAraclar.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvBildirimler);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1077, 761);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "🔔Bildirimler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvBildirimler
            // 
            dgvBildirimler.AllowUserToAddRows = false;
            dgvBildirimler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBildirimler.Location = new Point(-4, 0);
            dgvBildirimler.Name = "dgvBildirimler";
            dgvBildirimler.ReadOnly = true;
            dgvBildirimler.Size = new Size(1078, 680);
            dgvBildirimler.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnYenile);
            panel1.Controls.Add(btnReddet);
            panel1.Controls.Add(btnOnayla);
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panel1.Location = new Point(0, 686);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 75);
            panel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.RoyalBlue;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.ForeColor = SystemColors.ControlLightLight;
            btnYenile.Location = new Point(338, 18);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(129, 37);
            btnYenile.TabIndex = 2;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.Firebrick;
            btnReddet.FlatStyle = FlatStyle.Flat;
            btnReddet.ForeColor = SystemColors.ControlLightLight;
            btnReddet.Location = new Point(182, 18);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(129, 37);
            btnReddet.TabIndex = 1;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.SeaGreen;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.ForeColor = SystemColors.ControlLightLight;
            btnOnayla.Location = new Point(26, 18);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(129, 37);
            btnOnayla.TabIndex = 0;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 793);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "AdminDashboardForm";
            Text = "Admin Panel";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMarkalar).EndInit();
            pnlMarkaButtons.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            pnlAracButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBildirimler).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pnlMarkaButtons;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnMarkaSil;
        private Button btnMarkaEkle;
        private DataGridView dgvMarkalar;
        private Panel pnlAracButtons;
        private Button btnAracDuzenle;
        private Button btnAracSil;
        private Button btnAracEkle;
        private DataGridView dgvAraclar;
        private Panel panel1;
        private Button btnYenile;
        private Button btnReddet;
        private Button btnOnayla;
        private DataGridView dgvBildirimler;
    }
}