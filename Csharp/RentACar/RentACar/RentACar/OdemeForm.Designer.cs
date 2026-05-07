namespace RentACar
{
    partial class OdemeForm
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
            lblTutar = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKartNo = new TextBox();
            txtKartSahibi = new TextBox();
            cmbAy = new ComboBox();
            cmbYil = new ComboBox();
            txtCVV = new TextBox();
            btnOde = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(133, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 0;
            label1.Text = "Kredi Kartı ile Öde";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar.ForeColor = Color.LimeGreen;
            lblTutar.Location = new Point(35, 95);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(172, 22);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "Toplam Tutar: 0 ₺";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(30, 157);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 2;
            label2.Text = "Kart Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(35, 216);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 3;
            label3.Text = "Kart Sahibi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(32, 274);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 4;
            label4.Text = "Son Kullanma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(30, 340);
            label5.Name = "label5";
            label5.Size = new Size(42, 18);
            label5.TabIndex = 5;
            label5.Text = "CVV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(112, 518);
            label6.Name = "label6";
            label6.Size = new Size(224, 15);
            label6.TabIndex = 6;
            label6.Text = "Kart Bilgileriniz güvenli şekilde şifrelenir";
            // 
            // txtKartNo
            // 
            txtKartNo.Location = new Point(154, 155);
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(224, 23);
            txtKartNo.TabIndex = 7;
            txtKartNo.TextChanged += txtKartNo_TextChanged;
            // 
            // txtKartSahibi
            // 
            txtKartSahibi.Location = new Point(154, 216);
            txtKartSahibi.Name = "txtKartSahibi";
            txtKartSahibi.Size = new Size(224, 23);
            txtKartSahibi.TabIndex = 8;
            // 
            // cmbAy
            // 
            cmbAy.FormattingEnabled = true;
            cmbAy.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cmbAy.Location = new Point(154, 274);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(79, 23);
            cmbAy.TabIndex = 9;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Location = new Point(249, 274);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(79, 23);
            cmbYil.TabIndex = 10;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(154, 340);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(79, 23);
            txtCVV.TabIndex = 11;
            // 
            // btnOde
            // 
            btnOde.BackColor = Color.LimeGreen;
            btnOde.FlatStyle = FlatStyle.Flat;
            btnOde.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOde.ForeColor = SystemColors.ControlLightLight;
            btnOde.Location = new Point(154, 410);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(199, 45);
            btnOde.TabIndex = 12;
            btnOde.Text = "Ödemeyi Tamamla";
            btnOde.UseVisualStyleBackColor = false;
            btnOde.Click += btnOde_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.ControlDarkDark;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = SystemColors.ControlLightLight;
            btnIptal.Location = new Point(182, 472);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(123, 31);
            btnIptal.TabIndex = 13;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 559);
            Controls.Add(btnIptal);
            Controls.Add(btnOde);
            Controls.Add(txtCVV);
            Controls.Add(cmbYil);
            Controls.Add(cmbAy);
            Controls.Add(txtKartSahibi);
            Controls.Add(txtKartNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTutar);
            Controls.Add(label1);
            Name = "OdemeForm";
            Text = "OdemeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTutar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKartNo;
        private TextBox txtKartSahibi;
        private ComboBox cmbAy;
        private ComboBox cmbYil;
        private TextBox txtCVV;
        private Button btnOde;
        private Button btnIptal;
    }
}