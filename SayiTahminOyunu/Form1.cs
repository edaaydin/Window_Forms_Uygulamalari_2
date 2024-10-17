namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbarBilgi.Maximum = 60;
            btnTahminEt.Enabled = false; // T�klanamaz yapar.
            panel1.Visible = false;  // Gorunmez yapar.
        }
        int rastgeleSayi;
        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();


            string userName;

            if (frm.GetName(out userName))
            {
                lblKullanici.Text = "Ho�geldin" + " " + userName;
                panel1.Visible = true;

                lblBilgi.Text = "";
                lblMesaj.Text = "";

                Random random = new Random();
                rastgeleSayi = random.Next(1, 101);
                timer1.Start(); // Timer ba�lar. Art�k her 1000ms/1 sn'de bir Tick event'i tetiklenir ve �al��maya baslar.
                btnTahminEt.Enabled = false;

                pbarBilgi.Value = pbarBilgi.Maximum;
                btnTahminEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� girmek zorundas�n !");
            }
        }
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            try
            {
                sayi = int.Parse(txtTahmin.Text); // scopeta tan�mlanan scopede kal�r :)
            }
            catch (Exception)
            {
                MessageBox.Show("Say� girmeyi unutmu�sun !!!");
            }

            if (sayi < rastgeleSayi)
            {
                lblBilgi.Text = "Kucuk Bir Sayi Girdiniz !";
            }
            else if (sayi > rastgeleSayi)
            {
                lblBilgi.Text = "Buyuk Bir Sayi Girdiniz !";
            }
            else
            {
                lblBilgi.Text = "Tebrikler Kazandiniz :)";
                timer1.Stop();
                btnTahminEt.Enabled = false; // t�klanamaz.
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbarBilgi.Value--; // her saniye deger azal�r

            btnTahminEt.Text = $"Tahmin Et ({pbarBilgi.Value})";

            switch (pbarBilgi.Value)
            {
                case 50: lblMesaj.Text = "Galiba Kaybedeceksin"; break;

                case 40: lblMesaj.Text = "Sen kaybetmek i�in yar���yorsun"; break;
                case 30: lblMesaj.Text = "S�ren doluyor art�k"; break;
                case 20: lblMesaj.Text = "Bil art�k"; break;
                case 10: lblMesaj.Text = "Son hakk�n"; break;
                case 0:
                    lblMesaj.Text = "Ne demi�tim ben sana ?\nBir dahaki sefere art�k dostum !"; break;
                    timer1.Stop();
                default:
                    break;
            }
        }
    }
}
