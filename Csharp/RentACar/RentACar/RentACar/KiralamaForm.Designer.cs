namespace RentACar
{
    partial class KiralamaForm
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
            dtg_kiralamalar = new DataGridView();
            btn_YeniKiralama = new Button();
            btn_KiralamaDuzenle = new Button();
            btn_KiralamaSil = new Button();
            btn_Kapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 0;
            label1.Text = "Kiralama İşlemleri";
            // 
            // dtg_kiralamalar
            // 
            dtg_kiralamalar.AllowUserToAddRows = false;
            dtg_kiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kiralamalar.Location = new Point(1, 29);
            dtg_kiralamalar.Name = "dtg_kiralamalar";
            dtg_kiralamalar.ReadOnly = true;
            dtg_kiralamalar.Size = new Size(853, 465);
            dtg_kiralamalar.TabIndex = 1;
            dtg_kiralamalar.CellDoubleClick += dtg_kiralamalar_CellDoubleClick;
            dtg_kiralamalar.SelectionChanged += dtg_kiralamalar_SelectionChanged;
            // 
            // btn_YeniKiralama
            // 
            btn_YeniKiralama.BackColor = Color.ForestGreen;
            btn_YeniKiralama.FlatStyle = FlatStyle.Flat;
            btn_YeniKiralama.Font = new Font("Arial", 11.25F);
            btn_YeniKiralama.ForeColor = SystemColors.ControlLightLight;
            btn_YeniKiralama.Location = new Point(12, 500);
            btn_YeniKiralama.Name = "btn_YeniKiralama";
            btn_YeniKiralama.Size = new Size(120, 37);
            btn_YeniKiralama.TabIndex = 2;
            btn_YeniKiralama.Text = "Yeni Kiralama";
            btn_YeniKiralama.UseVisualStyleBackColor = false;
            btn_YeniKiralama.Click += btn_YeniKiralama_Click;
            // 
            // btn_KiralamaDuzenle
            // 
            btn_KiralamaDuzenle.BackColor = Color.RoyalBlue;
            btn_KiralamaDuzenle.FlatStyle = FlatStyle.Flat;
            btn_KiralamaDuzenle.Font = new Font("Arial", 11.25F);
            btn_KiralamaDuzenle.ForeColor = SystemColors.ControlLightLight;
            btn_KiralamaDuzenle.Location = new Point(171, 500);
            btn_KiralamaDuzenle.Name = "btn_KiralamaDuzenle";
            btn_KiralamaDuzenle.Size = new Size(120, 37);
            btn_KiralamaDuzenle.TabIndex = 2;
            btn_KiralamaDuzenle.Text = "Düzenle";
            btn_KiralamaDuzenle.UseVisualStyleBackColor = false;
            btn_KiralamaDuzenle.Click += btn_KiralamaDuzenle_Click;
            // 
            // btn_KiralamaSil
            // 
            btn_KiralamaSil.BackColor = Color.Firebrick;
            btn_KiralamaSil.FlatStyle = FlatStyle.Flat;
            btn_KiralamaSil.Font = new Font("Arial", 11.25F);
            btn_KiralamaSil.ForeColor = SystemColors.ControlLightLight;
            btn_KiralamaSil.Location = new Point(336, 500);
            btn_KiralamaSil.Name = "btn_KiralamaSil";
            btn_KiralamaSil.Size = new Size(120, 37);
            btn_KiralamaSil.TabIndex = 2;
            btn_KiralamaSil.Text = "Sil";
            btn_KiralamaSil.UseVisualStyleBackColor = false;
            btn_KiralamaSil.Click += btn_KiralamaSil_Click;
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.Orange;
            btn_Kapat.FlatStyle = FlatStyle.Flat;
            btn_Kapat.Font = new Font("Arial", 11.25F);
            btn_Kapat.ForeColor = SystemColors.ControlLightLight;
            btn_Kapat.Location = new Point(723, 500);
            btn_Kapat.Name = "btn_Kapat";
            btn_Kapat.Size = new Size(120, 37);
            btn_Kapat.TabIndex = 2;
            btn_Kapat.Text = "Kapat";
            btn_Kapat.UseVisualStyleBackColor = false;
            btn_Kapat.Click += btn_Kapat_Click;
            // 
            // KiralamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 549);
            Controls.Add(btn_Kapat);
            Controls.Add(btn_KiralamaSil);
            Controls.Add(btn_KiralamaDuzenle);
            Controls.Add(btn_YeniKiralama);
            Controls.Add(dtg_kiralamalar);
            Controls.Add(label1);
            Name = "KiralamaForm";
            Text = "KiralamaForm";
            Load += KiralamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_kiralamalar;
        private Button btn_YeniKiralama;
        private Button btn_KiralamaDuzenle;
        private Button btn_KiralamaSil;
        private Button btn_Kapat;
    }
}