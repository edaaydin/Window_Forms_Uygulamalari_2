namespace KullaniciKayitPaneli
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text == "")
            {
                MessageBox.Show("Kullanici Adi bos Gecilmez !");
            }
            else if (txtSifre.Text == "")
            {
                MessageBox.Show("Kullanici sifre bos Gecilmez !");
            }
            else
            {
                if (txtKullaniciAd.Text != "Admin")
                    MessageBox.Show("Kullanici adi yanlis, Lutfen tekrar deneyiniz !");
                else if (txtSifre.Text != "123")
                    MessageBox.Show("Kullanici sifresi yanlis, Lutfen tekrar deneyiniz !");
                else
                    Giris(txtKullaniciAd.Text, txtSifre.Text);
            }
           
            KullaniciBilgileri kullanicigirisbilgileri = new KullaniciBilgileri(); // Diger forma gecis yapmak icin yazilan kodlarimiz.
            kullanicigirisbilgileri.Show();
            this.Hide();

        }
        private bool Giris(string KullaniciAdi, string KullaniciSifre)
        {
            if (KullaniciAdi == "Admin" && KullaniciSifre == "123")
                return true;
            return false;
        }
    }
}
