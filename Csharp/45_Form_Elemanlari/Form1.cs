namespace _45_Form_Elemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yapýsýna Hoþgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Form A Giriþ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_Kad.Text == "Erkan" && txt_Sifre.Text == "1453")
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý Veya Þifre Hatalýdýr", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}
