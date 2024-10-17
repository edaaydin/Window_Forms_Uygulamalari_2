using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _04_StudentProject
{
    public partial class LoginForm : Form
    {
        // Dictionary ile kullanıcı adı ve şifreleri saklıyoruz. Anahtar (key) kullanıcı adı, değer (value) ise şifre.
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "1234" },  // Örnek kullanıcı adı ve şifre
            { "user", "password" }
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            // Giriş kontrolü yapılıyor
            if (LoginOlduMu(userName, password)) // Eğer doğruysa
            {
                // StudentAddForm açılıyor ve kullanıcı adı parametre olarak gönderiliyor.
                StudentAddForm studentForm = new StudentAddForm(userName);
                studentForm.Show();  // StudentAddForm'u göster
                this.Hide();  // Login formunu gizle
            }
            else
            {
                // Yanlış giriş yapılırsa uyarı mesajı gösteriliyor.
                lblBilgi.Text = "Kullanıcı adı veya şifre hatalı!";
            }
        }
        private bool LoginOlduMu(string userName, string password)
        {
            if (userName == "" || password == "")
            {
                lblBilgi.Text = "Lütfen tüm alanları doldurunuz!";
                return false;  // Eğer alanlar boşsa false döndür
            }
            return users.ContainsKey(userName) && users[userName] == password;
        }
    }
}
/*
bir proje içinde 3 form olucak şekilde bu yapılacak

1- Kullanıcı giriş ekranı olucak kullanıcı adı ve sifre olucak.

giris yap butonuna basınca, Form load olurken belirlediğimiz dictionary key value kullanıcı adı şifre bilgilerini kontrol edecek.
alanlar boş mu kontrol edecek. alanlar boş geçilemeyecek.

LoginOlduMu() isminde metot oluştur kullanıcı adı ve şifre içinde var mı yok mu kontrol etsin. kullanıcı yoksa lblBilgi içinde mesaj versin.Kullanıcı varsa StudentAddForm açılsın ve StudentAddForm constructur'a kullanıcı adı bilgisi gönderilsin.

Login formu gizlensin.

2- StudentAddForm formunda öğrenci bilgileri ve resim yükle grupbox ı olsun.
öğrenci bilgileri içinde adı, soyadı, cinsiyeti, bölümü(ComboBox) bilgilerini alacak.
yukarıdaki bilgilerin doğruluğunu onaylıyorum mesajı onaylanırsa öğrenci, kaydet butonuna basabilecek.

Resim yükle alanında bir picturebox, bir tane textbox, bir tane de buton olacak.
seçilen resim yolu adresi textbox ta görünsün. picture box a da seçilen resim gelsin.

yukarıda bir label içinde login sayfasından gönerilen kullanıcı bilgisi hoş geldin ile yazsın.

bilgileri de bir dizi de tutunuz.Ayrıca bu bilgileri txt uzantılı dosyada da yazınız.

3- Öğrenci kaydet butonunun yanına öğrenci listesi butonu gelsin. Bu butona basınca yeni bir form açılsın. bu formun adı StudentListForm olsun. Bu formun içinde listbox'ta txt den veriler çekilerek ekrana yazılsın.
 */