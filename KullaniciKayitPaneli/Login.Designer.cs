namespace KullaniciKayitPaneli
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGiris = new Button();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullaniciAd = new TextBox();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(127, 161);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(128, 45);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Gİriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(45, 52);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(99, 20);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(98, 107);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(46, 20);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre :";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(191, 52);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(125, 27);
            txtKullaniciAd.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(191, 104);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 328);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnGiris);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAd;
        private TextBox txtSifre;
    }
}
