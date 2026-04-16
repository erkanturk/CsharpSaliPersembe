namespace _46_BasitHesapMakinesi
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
            label1 = new Label();
            label2 = new Label();
            mtxt_Sayi1 = new MaskedTextBox();
            mtxt_Sayi2 = new MaskedTextBox();
            btn_Islem = new Button();
            btn_Temizle = new Button();
            lst_Sonuc = new ListBox();
            label3 = new Label();
            cmb_Islem = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "1.Sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "2.Sayı";
            // 
            // mtxt_Sayi1
            // 
            mtxt_Sayi1.Location = new Point(60, 31);
            mtxt_Sayi1.Mask = "000000000";
            mtxt_Sayi1.Name = "mtxt_Sayi1";
            mtxt_Sayi1.Size = new Size(114, 23);
            mtxt_Sayi1.TabIndex = 0;
            // 
            // mtxt_Sayi2
            // 
            mtxt_Sayi2.Location = new Point(60, 64);
            mtxt_Sayi2.Mask = "000000000";
            mtxt_Sayi2.Name = "mtxt_Sayi2";
            mtxt_Sayi2.Size = new Size(114, 23);
            mtxt_Sayi2.TabIndex = 1;
            mtxt_Sayi2.ValidatingType = typeof(int);
            // 
            // btn_Islem
            // 
            btn_Islem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_Islem.Location = new Point(74, 138);
            btn_Islem.Name = "btn_Islem";
            btn_Islem.Size = new Size(75, 23);
            btn_Islem.TabIndex = 3;
            btn_Islem.Text = "İşlem Yap";
            btn_Islem.UseVisualStyleBackColor = true;
            btn_Islem.Click += btn_Islem_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_Temizle.Location = new Point(74, 167);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(75, 23);
            btn_Temizle.TabIndex = 4;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // lst_Sonuc
            // 
            lst_Sonuc.FormattingEnabled = true;
            lst_Sonuc.Location = new Point(198, 29);
            lst_Sonuc.Name = "lst_Sonuc";
            lst_Sonuc.Size = new Size(120, 139);
            lst_Sonuc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "İşlem";
            // 
            // cmb_Islem
            // 
            cmb_Islem.FormattingEnabled = true;
            cmb_Islem.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmb_Islem.Location = new Point(61, 101);
            cmb_Islem.Name = "cmb_Islem";
            cmb_Islem.Size = new Size(113, 23);
            cmb_Islem.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 298);
            Controls.Add(cmb_Islem);
            Controls.Add(lst_Sonuc);
            Controls.Add(btn_Temizle);
            Controls.Add(btn_Islem);
            Controls.Add(mtxt_Sayi2);
            Controls.Add(mtxt_Sayi1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox mtxt_Sayi1;
        private MaskedTextBox mtxt_Sayi2;
        private Button btn_Islem;
        private Button btn_Temizle;
        private ListBox lst_Sonuc;
        private Label label3;
        private ComboBox cmb_Islem;
    }
}
