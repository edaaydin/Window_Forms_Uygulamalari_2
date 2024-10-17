namespace SayiTahminOyunu
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
            components = new System.ComponentModel.Container();
            lblKullanici = new Label();
            btnOyunuBaslat = new Button();
            panel1 = new Panel();
            lblMesaj = new Label();
            pbarBilgi = new ProgressBar();
            lblBilgi = new Label();
            btnTahminEt = new Button();
            txtTahmin = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(57, 40);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(0, 20);
            lblKullanici.TabIndex = 0;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(57, 89);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(419, 62);
            btnOyunuBaslat.TabIndex = 1;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMesaj);
            panel1.Controls.Add(pbarBilgi);
            panel1.Controls.Add(lblBilgi);
            panel1.Controls.Add(btnTahminEt);
            panel1.Controls.Add(txtTahmin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(57, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 351);
            panel1.TabIndex = 2;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(14, 263);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(55, 20);
            lblMesaj.TabIndex = 5;
            lblMesaj.Text = "Mesaj :";
            // 
            // pbarBilgi
            // 
            pbarBilgi.Location = new Point(14, 192);
            pbarBilgi.Name = "pbarBilgi";
            pbarBilgi.Size = new Size(364, 29);
            pbarBilgi.TabIndex = 4;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.ForeColor = Color.Maroon;
            lblBilgi.Location = new Point(14, 144);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(39, 20);
            lblBilgi.TabIndex = 3;
            lblBilgi.Text = "Bilgi";
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(14, 85);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(364, 29);
            btnTahminEt.TabIndex = 2;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(253, 25);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(125, 27);
            txtTahmin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "1-100 arasında bir sayı giriniz";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(528, 565);
            Controls.Add(panel1);
            Controls.Add(btnOyunuBaslat);
            Controls.Add(lblKullanici);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullanici;
        private Button btnOyunuBaslat;
        private Panel panel1;
        private Label label1;
        private Label lblMesaj;
        private ProgressBar pbarBilgi;
        private Label lblBilgi;
        private Button btnTahminEt;
        private TextBox txtTahmin;
        private System.Windows.Forms.Timer timer1;
    }
}
