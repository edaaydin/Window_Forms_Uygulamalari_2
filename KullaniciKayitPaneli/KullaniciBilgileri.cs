using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KullaniciKayitPaneli
{
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtIsim.Text == "" || txtSoyisim.Text == "" || mtxtTelNo.Text == "" || mtxtTc.Text == "" || txtEposta.Text == "" || cbDepartman.SelectedIndex == -1 || !(rdbErkek.Checked || rdbKadin.Checked)
                || chkHobi.CheckedItems.Count == 0)
                MessageBox.Show("Doldurulması Zorunlu Alanlar !, Lutfen bos gecmeyiniz !!!");
            else
                MessageBox.Show("İsleminiz Basariyla Tamamlanmistir :)");

            string cinsiyet = rdbKadin.Checked ? "Kadın" : "Erkek";
            List<string> hobiler = new List<string>();
            foreach (var item in chkHobi.CheckedItems)
            {
                hobiler.Add(item.ToString());
            }
            string personelBilgisi = $"Adı : {txtIsim.Text} Soyadı : {txtSoyisim.Text} TC: {mtxtTc.Text} E-posta: {txtEposta.Text} Telefon: {mtxtTelNo.Text} Departman: {cbDepartman.SelectedItem} Cinsiyet: {cinsiyet}, Hobiler: {string.Join(", ", hobiler)}";

            TumBilgiler.Items.Add(personelBilgisi);


            txtIsim.Clear();
            txtSoyisim.Clear();
            mtxtTc.Clear();
            mtxtTelNo.Clear();
            txtEposta.Clear();
            cbDepartman.SelectedIndex = -1;

            rdbErkek.Checked = false;
            rdbKadin.Checked = false;

            // CheckedListBox'taki tüm seçimleri temizle
            for (int i = 0; i < chkHobi.Items.Count; i++)
            {
                chkHobi.SetItemChecked(i, false);
            }
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            cbDepartman.Items.Add("Muhasebe");
            cbDepartman.Items.Add("İnsan Kaynakları");
            cbDepartman.Items.Add("Satış");
            cbDepartman.Items.Add("IT");
            cbDepartman.Items.Add("Pazarlama");

            chkHobi.Items.Add("Futbol");
            chkHobi.Items.Add("Yüzme");
            chkHobi.Items.Add("Satranç");
            chkHobi.Items.Add("Fotoğrafçılık");
            chkHobi.Items.Add("Kitap Okuma");
        }
    }
}
