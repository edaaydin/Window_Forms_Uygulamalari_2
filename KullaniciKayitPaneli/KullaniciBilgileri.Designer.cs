namespace KullaniciKayitPaneli
{
    partial class KullaniciBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            lblIsim = new Label();
            lblSoyisim = new Label();
            lblTc = new Label();
            lblTelNo = new Label();
            lblEposta = new Label();
            lblCnsiyet = new Label();
            lblDepartman = new Label();
            lblHobi = new Label();
            TumBilgiler = new ListBox();
            panel2 = new Panel();
            txtSoyisim = new TextBox();
            txtIsim = new TextBox();
            txtEposta = new TextBox();
            mtxtTc = new MaskedTextBox();
            mtxtTelNo = new MaskedTextBox();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            cbDepartman = new ComboBox();
            chkHobi = new CheckedListBox();
            btnKaydet = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(82, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 13);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel Bilgileri";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Location = new Point(63, 121);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(62, 20);
            lblIsim.TabIndex = 1;
            lblIsim.Text = "İsminiz :";
            // 
            // lblSoyisim
            // 
            lblSoyisim.AutoSize = true;
            lblSoyisim.Location = new Point(39, 162);
            lblSoyisim.Name = "lblSoyisim";
            lblSoyisim.Size = new Size(86, 20);
            lblSoyisim.TabIndex = 1;
            lblSoyisim.Text = "Soyisminiz :";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(69, 204);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(56, 20);
            lblTc.TabIndex = 1;
            lblTc.Text = "TC No :";
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Location = new Point(349, 117);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(141, 20);
            lblTelNo.TabIndex = 1;
            lblTelNo.Text = "Telefon Numaranız :";
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Location = new Point(360, 159);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(130, 20);
            lblEposta.TabIndex = 1;
            lblEposta.Text = "E-Posta Adresiniz :";
            // 
            // lblCnsiyet
            // 
            lblCnsiyet.AutoSize = true;
            lblCnsiyet.Location = new Point(400, 208);
            lblCnsiyet.Name = "lblCnsiyet";
            lblCnsiyet.Size = new Size(90, 20);
            lblCnsiyet.TabIndex = 1;
            lblCnsiyet.Text = "Cinsiyetiniz :";
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Location = new Point(12, 265);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(135, 20);
            lblDepartman.TabIndex = 1;
            lblDepartman.Text = "Hangi Departman :";
            // 
            // lblHobi
            // 
            lblHobi.AutoSize = true;
            lblHobi.Location = new Point(12, 315);
            lblHobi.Name = "lblHobi";
            lblHobi.Size = new Size(89, 20);
            lblHobi.TabIndex = 1;
            lblHobi.Text = "Hobileriniz :";
            // 
            // TumBilgiler
            // 
            TumBilgiler.FormattingEnabled = true;
            TumBilgiler.HorizontalScrollbar = true;
            TumBilgiler.Location = new Point(6, 10);
            TumBilgiler.Name = "TumBilgiler";
            TumBilgiler.Size = new Size(431, 444);
            TumBilgiler.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(TumBilgiler);
            panel2.Location = new Point(737, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 465);
            panel2.TabIndex = 4;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(163, 155);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(125, 27);
            txtSoyisim.TabIndex = 5;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(163, 114);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(125, 27);
            txtIsim.TabIndex = 5;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(506, 152);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 5;
            // 
            // mtxtTc
            // 
            mtxtTc.Location = new Point(163, 201);
            mtxtTc.Mask = "00000000000";
            mtxtTc.Name = "mtxtTc";
            mtxtTc.Size = new Size(125, 27);
            mtxtTc.TabIndex = 6;
            mtxtTc.ValidatingType = typeof(int);
            // 
            // mtxtTelNo
            // 
            mtxtTelNo.Location = new Point(506, 110);
            mtxtTelNo.Mask = "(999) 000-0000";
            mtxtTelNo.Name = "mtxtTelNo";
            mtxtTelNo.Size = new Size(125, 27);
            mtxtTelNo.TabIndex = 6;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(514, 210);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(68, 24);
            rdbKadin.TabIndex = 7;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadin";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(584, 210);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(65, 24);
            rdbErkek.TabIndex = 7;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // cbDepartman
            // 
            cbDepartman.FormattingEnabled = true;
            cbDepartman.Location = new Point(168, 263);
            cbDepartman.Name = "cbDepartman";
            cbDepartman.Size = new Size(151, 28);
            cbDepartman.TabIndex = 8;
            // 
            // chkHobi
            // 
            chkHobi.FormattingEnabled = true;
            chkHobi.Location = new Point(169, 315);
            chkHobi.Name = "chkHobi";
            chkHobi.Size = new Size(150, 114);
            chkHobi.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(447, 378);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(135, 51);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // KullaniciBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 533);
            Controls.Add(btnKaydet);
            Controls.Add(chkHobi);
            Controls.Add(cbDepartman);
            Controls.Add(rdbErkek);
            Controls.Add(rdbKadin);
            Controls.Add(mtxtTelNo);
            Controls.Add(mtxtTc);
            Controls.Add(txtEposta);
            Controls.Add(txtIsim);
            Controls.Add(txtSoyisim);
            Controls.Add(panel2);
            Controls.Add(lblHobi);
            Controls.Add(lblDepartman);
            Controls.Add(lblCnsiyet);
            Controls.Add(lblEposta);
            Controls.Add(lblTelNo);
            Controls.Add(lblTc);
            Controls.Add(lblSoyisim);
            Controls.Add(lblIsim);
            Controls.Add(panel1);
            Name = "KullaniciBilgileri";
            Text = "KullaniciBilgileri";
            Load += KullaniciBilgileri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblIsim;
        private Label lblSoyisim;
        private Label lblTc;
        private Label lblTelNo;
        private Label lblEposta;
        private Label lblCnsiyet;
        private Label lblDepartman;
        private Label lblHobi;
        private Button btnKaydet;
        private ListBox TumBilgiler;
        private Panel panel2;
        private TextBox txtSoyisim;
        private TextBox txtIsim;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtEposta;
        private MaskedTextBox mtxtTc;
        private MaskedTextBox mtxtTelNo;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private ComboBox cbDepartman;
        private CheckedListBox chkHobi;
    }
}