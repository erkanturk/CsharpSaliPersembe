namespace _46_BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        #region Tahmin Ödev
        //Kullanýcýya 5 hak tanýmlayacaðýz kullanýcý random oluþturulan sayýyý bu 5 hak ile arayacakk eðer 
        //hak kýsmý dolmadan bilirse tebrikler deyip random sayýyý göstereceðiz 
        //eðer kullanýcý 5 hakký dolarsa hakkýnýz doldu deyip random sayýyý göstereceðiz
        //kullanýcý 1 ila 100 arasýnda sayýyý tahmin etmeye çalýþacak
        //Örneðin oluþturulan random sayý deðeri 50 kullanýcý 25 girdi girdiðiniz sayý oluþturulan sayýdan küçüktür
        // uyarýsý verilip kullanýcý yönlendirilecek  kullanýcý 75 girdi girilen sayý büyüktür deyip yönlendirilecek
        //eðer sayýlar birbirine eþitse þanslý sayýyý buldunuz diyecek ve 5 hakta bu iþlemi yapacak.
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Islem_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            if (cmb_Islem.Text == "+")
            {
                cmb_Islem.BackColor = Color.White;
                sayi1 = Convert.ToDouble(mtxt_Sayi1.Text);
                sayi2 = Convert.ToDouble(mtxt_Sayi2.Text);
                sonuc = sayi1 + sayi2;
                lst_Sonuc.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text == "-")
            {
                cmb_Islem.BackColor = Color.White;
                sayi1 = Convert.ToDouble(mtxt_Sayi1.Text);
                sayi2 = Convert.ToDouble(mtxt_Sayi2.Text);
                sonuc = sayi1 - sayi2;
                lst_Sonuc.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text == "*")
            {
                cmb_Islem.BackColor = Color.White;
                sayi1 = Convert.ToDouble(mtxt_Sayi1.Text);
                sayi2 = Convert.ToDouble(mtxt_Sayi2.Text);
                sonuc = sayi1 * sayi2;
                lst_Sonuc.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text == "/")
            {
                cmb_Islem.BackColor = Color.White;
                sayi1 = Convert.ToDouble(mtxt_Sayi1.Text);
                sayi2 = Convert.ToDouble(mtxt_Sayi2.Text);
                if (sayi2 == 0)
                {
                    MessageBox.Show("Sayý sýfýra bölünemez");
                }
                else
                {
                    sonuc = sayi1 + sayi2;
                    lst_Sonuc.Items.Add(sonuc.ToString());
                }

            }
            else
            {
                MessageBox.Show("Bir iþlem türü seçiniz");
                cmb_Islem.BackColor = Color.Red;
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            lst_Sonuc.Items.Clear();
            mtxt_Sayi1.Clear();
            mtxt_Sayi2.Clear();
            cmb_Islem.SelectedIndex = -1;
        }
    }
}
