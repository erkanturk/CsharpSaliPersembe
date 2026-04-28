namespace RentACar
{
    partial class AracEkleForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkAktif = new CheckBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            cmbMarka = new ComboBox();
            txtModel = new TextBox();
            txtPlaka = new TextBox();
            numYil = new NumericUpDown();
            numUcret = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUcret).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Marka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(32, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(33, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Plaka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(44, 162);
            label4.Name = "label4";
            label4.Size = new Size(23, 17);
            label4.TabIndex = 3;
            label4.Text = "Yıl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(10, 207);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 4;
            label5.Text = "Saatlik Ücret";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(29, 260);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 5;
            label6.Text = "Durum";
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Font = new Font("Arial", 11.25F);
            chkAktif.Location = new Point(108, 256);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(54, 21);
            chkAktif.TabIndex = 6;
            chkAktif.Text = "Aktif";
            chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.SeaGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Arial", 11.25F);
            btnKaydet.ForeColor = SystemColors.ControlLightLight;
            btnKaydet.Location = new Point(48, 308);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(104, 33);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.ControlDarkDark;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Arial", 11.25F);
            btnIptal.ForeColor = SystemColors.ControlLightLight;
            btnIptal.Location = new Point(193, 308);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(107, 33);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // cmbMarka
            // 
            cmbMarka.Font = new Font("Arial", 11.25F);
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(107, 12);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(192, 25);
            cmbMarka.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Arial", 11.25F);
            txtModel.Location = new Point(107, 61);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(192, 25);
            txtModel.TabIndex = 10;
            // 
            // txtPlaka
            // 
            txtPlaka.Font = new Font("Arial", 11.25F);
            txtPlaka.Location = new Point(107, 105);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(192, 25);
            txtPlaka.TabIndex = 11;
            // 
            // numYil
            // 
            numYil.Font = new Font("Arial", 11.25F);
            numYil.Location = new Point(108, 154);
            numYil.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numYil.Minimum = new decimal(new int[] { 2010, 0, 0, 0 });
            numYil.Name = "numYil";
            numYil.Size = new Size(192, 25);
            numYil.TabIndex = 12;
            numYil.Value = new decimal(new int[] { 2010, 0, 0, 0 });
            // 
            // numUcret
            // 
            numUcret.Font = new Font("Arial", 11.25F);
            numUcret.Location = new Point(108, 199);
            numUcret.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUcret.Name = "numUcret";
            numUcret.Size = new Size(192, 25);
            numUcret.TabIndex = 13;
            numUcret.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // AracEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 370);
            Controls.Add(numUcret);
            Controls.Add(numYil);
            Controls.Add(txtPlaka);
            Controls.Add(txtModel);
            Controls.Add(cmbMarka);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(chkAktif);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AracEkleForm";
            Text = "Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)numYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUcret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkAktif;
        private Button btnKaydet;
        private Button btnIptal;
        private ComboBox cmbMarka;
        private TextBox txtModel;
        private TextBox txtPlaka;
        private NumericUpDown numYil;
        private NumericUpDown numUcret;
    }
}