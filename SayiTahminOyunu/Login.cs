namespace SayiTahminOyunu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string _name; // Field 
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            _name = txtKullaniciAdi.Text;
            if (_name != null)
            {
                this.Hide();
            }
        }
        public bool GetName(out string name)
        {
            name = _name; // Field degerini degiskene atıyorum.
            return _name != null && _name != ""; // Boş degilse true doner.
        }
    }
}
