namespace KullaniciBilgileriKaydet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string yas = numYas.Text;
            string cinsiyet = rdbErkek.Checked ? "Erkek" : "Kadýn";
            string adres = rtxtAdresBilgisi.Text;

            string bilgiler = ($"Adý Soyadý : {adSoyad} Yaþý : {yas}  CÝnsiyeti : {cinsiyet} Adresi : {adres}");

            if (chkOnay.Checked)
            {
                listBox1.Items.Add(bilgiler);
            }
            else
            {
                MessageBox.Show("Lutfen Onaylama Yapýnýz !");
            }
        }
    }
}
