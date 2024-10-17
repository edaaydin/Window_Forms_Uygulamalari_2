namespace _04_StudentProject
{
    partial class StudentAddForm
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
            lblad = new Label();
            lblSoyad = new Label();
            lblYol = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtImagePath = new TextBox();
            lblCimsiyet = new Label();
            pictureBox = new PictureBox();
            chkConfirm = new CheckBox();
            cmbGender = new ComboBox();
            lblBolum = new Label();
            cmbDepartment = new ComboBox();
            btnSave = new Button();
            btnBrowse = new Button();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(91, 113);
            lblad.Name = "lblad";
            lblad.Size = new Size(35, 20);
            lblad.TabIndex = 0;
            lblad.Text = "Ad :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(69, 149);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(57, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblYol
            // 
            lblYol.AutoSize = true;
            lblYol.Location = new Point(408, 219);
            lblYol.Name = "lblYol";
            lblYol.Size = new Size(88, 20);
            lblYol.TabIndex = 2;
            lblYol.Text = "Resim Yolu :";
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 110);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Adınız :";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(154, 149);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Soyisminiz :";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 3;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(502, 212);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.PlaceholderText = "Resim Yolunuz :";
            txtImagePath.Size = new Size(125, 27);
            txtImagePath.TabIndex = 3;
            // 
            // lblCimsiyet
            // 
            lblCimsiyet.AutoSize = true;
            lblCimsiyet.Location = new Point(63, 201);
            lblCimsiyet.Name = "lblCimsiyet";
            lblCimsiyet.Size = new Size(67, 20);
            lblCimsiyet.TabIndex = 2;
            lblCimsiyet.Text = "Cinsiyet :";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(438, 46);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(189, 160);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // chkConfirm
            // 
            chkConfirm.AutoSize = true;
            chkConfirm.Location = new Point(63, 281);
            chkConfirm.Name = "chkConfirm";
            chkConfirm.Size = new Size(216, 24);
            chkConfirm.TabIndex = 6;
            chkConfirm.Text = "Yukarıdaki bilgiler doğrudur";
            chkConfirm.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(154, 198);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(125, 28);
            cmbGender.TabIndex = 7;
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(63, 239);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(59, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bölüm :";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(154, 239);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(125, 28);
            cmbDepartment.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(502, 262);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(125, 29);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Yükle";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(91, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 0;
            // 
            // StudentAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbGender);
            Controls.Add(chkConfirm);
            Controls.Add(pictureBox);
            Controls.Add(txtImagePath);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblBolum);
            Controls.Add(lblCimsiyet);
            Controls.Add(lblYol);
            Controls.Add(lblSoyad);
            Controls.Add(lblWelcome);
            Controls.Add(lblad);
            Name = "StudentAddForm";
            Text = "StudentAddForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblad;
        private Label lblSoyad;
        private Label lblYol;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtImagePath;
        private Label lblCimsiyet;
        private PictureBox pictureBox;
        private CheckBox chkConfirm;
        private ComboBox cmbGender;
        private Label lblBolum;
        private ComboBox cmbDepartment;
        private Button btnSave;
        private Button btnBrowse;
        private Label lblWelcome;
    }
}