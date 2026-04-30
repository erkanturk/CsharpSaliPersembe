namespace RentACar
{
    partial class Login
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
            groupBox1 = new GroupBox();
            btn_AdminGiris = new Button();
            btn_GirisYap = new Button();
            txt_GirisSifre = new TextBox();
            txt_GirisTel = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btn_KayitOl = new Button();
            txt_kRePassword = new TextBox();
            txt_kPassword = new TextBox();
            txt_kTelefon = new TextBox();
            txt_kAdSoyad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_AdminGiris);
            groupBox1.Controls.Add(btn_GirisYap);
            groupBox1.Controls.Add(txt_GirisSifre);
            groupBox1.Controls.Add(txt_GirisTel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Arial", 11.25F);
            groupBox1.Location = new Point(20, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // btn_AdminGiris
            // 
            btn_AdminGiris.BackColor = Color.DodgerBlue;
            btn_AdminGiris.FlatStyle = FlatStyle.Flat;
            btn_AdminGiris.ForeColor = SystemColors.ControlLightLight;
            btn_AdminGiris.Location = new Point(98, 185);
            btn_AdminGiris.Name = "btn_AdminGiris";
            btn_AdminGiris.Size = new Size(120, 30);
            btn_AdminGiris.TabIndex = 5;
            btn_AdminGiris.Text = "Admin Girişi";
            btn_AdminGiris.UseVisualStyleBackColor = false;
            btn_AdminGiris.Click += btn_AdminGiris_Click;
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.BackColor = Color.Green;
            btn_GirisYap.FlatStyle = FlatStyle.Flat;
            btn_GirisYap.ForeColor = SystemColors.ControlLightLight;
            btn_GirisYap.Location = new Point(98, 140);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(120, 31);
            btn_GirisYap.TabIndex = 4;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = false;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_GirisSifre
            // 
            txt_GirisSifre.Location = new Point(98, 95);
            txt_GirisSifre.Name = "txt_GirisSifre";
            txt_GirisSifre.PasswordChar = '*';
            txt_GirisSifre.PlaceholderText = "Şifre";
            txt_GirisSifre.Size = new Size(149, 25);
            txt_GirisSifre.TabIndex = 3;
            // 
            // txt_GirisTel
            // 
            txt_GirisTel.Location = new Point(98, 33);
            txt_GirisTel.Name = "txt_GirisTel";
            txt_GirisTel.PlaceholderText = "Telefon";
            txt_GirisTel.Size = new Size(149, 25);
            txt_GirisTel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 97);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 1;
            label6.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 36);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 0;
            label5.Text = "Telefon";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btn_KayitOl);
            groupBox2.Controls.Add(txt_kRePassword);
            groupBox2.Controls.Add(txt_kPassword);
            groupBox2.Controls.Add(txt_kTelefon);
            groupBox2.Controls.Add(txt_kAdSoyad);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Arial", 11.25F);
            groupBox2.Location = new Point(795, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kayıt Form";
            // 
            // btn_KayitOl
            // 
            btn_KayitOl.BackColor = Color.Green;
            btn_KayitOl.FlatStyle = FlatStyle.Flat;
            btn_KayitOl.ForeColor = SystemColors.ControlLightLight;
            btn_KayitOl.Location = new Point(151, 260);
            btn_KayitOl.Name = "btn_KayitOl";
            btn_KayitOl.Size = new Size(112, 38);
            btn_KayitOl.TabIndex = 8;
            btn_KayitOl.Text = "Kayıt Ol";
            btn_KayitOl.UseVisualStyleBackColor = false;
            btn_KayitOl.Click += btn_KayitOl_Click;
            // 
            // txt_kRePassword
            // 
            txt_kRePassword.Location = new Point(140, 210);
            txt_kRePassword.Name = "txt_kRePassword";
            txt_kRePassword.PasswordChar = '*';
            txt_kRePassword.PlaceholderText = "Şifre Tekrarı";
            txt_kRePassword.Size = new Size(143, 25);
            txt_kRePassword.TabIndex = 7;
            // 
            // txt_kPassword
            // 
            txt_kPassword.Location = new Point(140, 154);
            txt_kPassword.Name = "txt_kPassword";
            txt_kPassword.PasswordChar = '*';
            txt_kPassword.PlaceholderText = "Şifre";
            txt_kPassword.Size = new Size(143, 25);
            txt_kPassword.TabIndex = 6;
            // 
            // txt_kTelefon
            // 
            txt_kTelefon.Location = new Point(140, 97);
            txt_kTelefon.Name = "txt_kTelefon";
            txt_kTelefon.PlaceholderText = "Telefon";
            txt_kTelefon.Size = new Size(143, 25);
            txt_kTelefon.TabIndex = 5;
            // 
            // txt_kAdSoyad
            // 
            txt_kAdSoyad.Location = new Point(140, 33);
            txt_kAdSoyad.Name = "txt_kAdSoyad";
            txt_kAdSoyad.PlaceholderText = "Ad Soyad";
            txt_kAdSoyad.Size = new Size(143, 25);
            txt_kAdSoyad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(17, 213);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 3;
            label4.Text = "Şifre Tekrar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(17, 154);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bertan_rent_acar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1155, 762);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_AdminGiris;
        private Button btn_GirisYap;
        private TextBox txt_GirisSifre;
        private TextBox txt_GirisTel;
        private Button btn_KayitOl;
        private TextBox txt_kRePassword;
        private TextBox txt_kPassword;
        private TextBox txt_kTelefon;
        private TextBox txt_kAdSoyad;
    }
}