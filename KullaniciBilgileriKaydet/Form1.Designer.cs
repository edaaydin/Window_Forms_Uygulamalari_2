namespace KullaniciBilgileriKaydet
{
    partial class Form1
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
            grpKisiselBilgiler = new GroupBox();
            lblCinsiyet = new Label();
            rdbErkek = new RadioButton();
            rdbKadin = new RadioButton();
            numYas = new NumericUpDown();
            lblYas = new Label();
            txtAdSoyad = new TextBox();
            lblAdSoyad = new Label();
            grpAdres = new GroupBox();
            rtxtAdresBilgisi = new RichTextBox();
            lblAdres = new Label();
            btnKaydet = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            chkOnay = new CheckBox();
            grpKisiselBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            grpAdres.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpKisiselBilgiler
            // 
            grpKisiselBilgiler.Controls.Add(lblCinsiyet);
            grpKisiselBilgiler.Controls.Add(rdbErkek);
            grpKisiselBilgiler.Controls.Add(rdbKadin);
            grpKisiselBilgiler.Controls.Add(numYas);
            grpKisiselBilgiler.Controls.Add(lblYas);
            grpKisiselBilgiler.Controls.Add(txtAdSoyad);
            grpKisiselBilgiler.Controls.Add(lblAdSoyad);
            grpKisiselBilgiler.Location = new Point(12, 25);
            grpKisiselBilgiler.Name = "grpKisiselBilgiler";
            grpKisiselBilgiler.Size = new Size(367, 243);
            grpKisiselBilgiler.TabIndex = 0;
            grpKisiselBilgiler.TabStop = false;
            grpKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(26, 165);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(60, 20);
            lblCinsiyet.TabIndex = 6;
            lblCinsiyet.Text = "Cinsiyet";
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(198, 163);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(65, 24);
            rdbErkek.TabIndex = 5;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(120, 165);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(68, 24);
            rdbKadin.TabIndex = 5;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // numYas
            // 
            numYas.Location = new Point(120, 102);
            numYas.Name = "numYas";
            numYas.Size = new Size(96, 27);
            numYas.TabIndex = 4;
            numYas.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(49, 109);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(37, 20);
            lblYas.TabIndex = 2;
            lblYas.Text = "Yaş :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(120, 62);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(201, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(6, 65);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(88, 20);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Adı Soyadı :";
            // 
            // grpAdres
            // 
            grpAdres.Controls.Add(rtxtAdresBilgisi);
            grpAdres.Controls.Add(lblAdres);
            grpAdres.Location = new Point(12, 308);
            grpAdres.Name = "grpAdres";
            grpAdres.Size = new Size(367, 155);
            grpAdres.TabIndex = 1;
            grpAdres.TabStop = false;
            grpAdres.Text = "Adres Bilgisi";
            // 
            // rtxtAdresBilgisi
            // 
            rtxtAdresBilgisi.Location = new Point(137, 26);
            rtxtAdresBilgisi.Name = "rtxtAdresBilgisi";
            rtxtAdresBilgisi.Size = new Size(201, 82);
            rtxtAdresBilgisi.TabIndex = 1;
            rtxtAdresBilgisi.Text = "";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(15, 59);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(91, 20);
            lblAdres.TabIndex = 0;
            lblAdres.Text = "Adres Bilgisi";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(178, 504);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(201, 29);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(508, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 307);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 11);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(532, 284);
            listBox1.TabIndex = 0;
            // 
            // chkOnay
            // 
            chkOnay.AutoSize = true;
            chkOnay.Location = new Point(43, 474);
            chkOnay.Name = "chkOnay";
            chkOnay.Size = new Size(336, 24);
            chkOnay.TabIndex = 4;
            chkOnay.Text = "Yukardaki bilgilerin doğruluğunu onaylıyorum.";
            chkOnay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1125, 564);
            Controls.Add(chkOnay);
            Controls.Add(panel1);
            Controls.Add(btnKaydet);
            Controls.Add(grpAdres);
            Controls.Add(grpKisiselBilgiler);
            Name = "Form1";
            Text = "Form1";
            grpKisiselBilgiler.ResumeLayout(false);
            grpKisiselBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            grpAdres.ResumeLayout(false);
            grpAdres.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpKisiselBilgiler;
        private NumericUpDown numYas;
        private Label lblYas;
        private TextBox txtAdSoyad;
        private Label lblAdSoyad;
        private Label lblCinsiyet;
        private RadioButton rdbErkek;
        private RadioButton rdbKadin;
        private GroupBox grpAdres;
        private RichTextBox rtxtAdresBilgisi;
        private Label lblAdres;
        private Button btnKaydet;
        private Panel panel1;
        private ListBox listBox1;
        private CheckBox chkOnay;
    }
}
