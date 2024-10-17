using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_StudentProject
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        // Form açıldığında öğrencilerin listelendiği metot
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // Eğer students.txt dosyası varsa verileri okuyoruz
            if (File.Exists("students.txt"))
            {
                // Dosyadaki tüm satırları okuyoruz
                string[] studentData = File.ReadAllLines("students.txt");

                // Her bir satırı listBox'a ekliyoruz
                foreach (var data in studentData)
                {
                    listBoxStudents.Items.Add(data);
                }
            }
            else
            {
                // Eğer dosya yoksa uyarı veriyoruz
                MessageBox.Show("Henüz öğrenci kaydedilmemiş.");
            }

        }

      
    }
}
