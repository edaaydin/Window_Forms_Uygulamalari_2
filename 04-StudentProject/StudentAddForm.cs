using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _04_StudentProject
{
    public partial class StudentAddForm : Form
    {
        private string username;

        public StudentAddForm(string userName)
        {
            InitializeComponent();
            this.username = userName;  // Parametre olarak gelen kullanıcı adı saklanıyor
            lblWelcome.Text = $"Hoş geldin, {userName}";  // Hoş geldin mesajı ayarlanıyor
            LoadComboBoxData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // OpenFileDialog: Kullanıcıdan dosya seçmesini isteyen bir pencere açılıyor
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";  // Yalnızca resim dosyaları seçilebilir
            if (ofd.ShowDialog() == DialogResult.OK)  // Eğer dosya seçilirse
            {
                txtImagePath.Text = ofd.FileName;  // Seçilen dosya yolunu TextBox'a yazıyoruz
                pictureBox.ImageLocation = ofd.FileName;  // Seçilen resmi PictureBox'ta gösteriyoruz
            }
        }
        private void LoadComboBoxData()
        {
            // Cinsiyet ComboBox'ına seçenekleri ekliyoruz
            cmbGender.Items.Add("Kadın");
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Diğer");

            // Bölüm ComboBox'ına seçenekleri ekliyoruz
            cmbDepartment.Items.Add("Yazılım");
            cmbDepartment.Items.Add("Programlama");
            cmbDepartment.Items.Add("Robotik");
            cmbDepartment.Items.Add("Yapay Zeka");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerin doğruluğunu onayladı mı?
            if (chkConfirm.Checked)
            {
                // Öğrenci bilgilerini bir diziye kaydediyoruz
                string[] studentInfo = {
                    txtName.Text,  // Ad
                    txtSurname.Text,  // Soyad
                    cmbGender.SelectedItem.ToString(),  // Cinsiyet
                    cmbDepartment.SelectedItem.ToString(),  // Bölüm
                    txtImagePath.Text  // Resim yolu
                };

                // Bilgileri students.txt dosyasına ekliyoruz
                File.AppendAllLines("students.txt", studentInfo);

                // Kayıt işlemi başarılı mesajı
                MessageBox.Show("Öğrenci kaydedildi!");
            }
            else
            {
                // Eğer checkbox işaretlenmemişse uyarı mesajı gösteriyoruz
                MessageBox.Show("Lütfen bilgilerin doğruluğunu onaylayınız.");
            }
        }
    }
}
