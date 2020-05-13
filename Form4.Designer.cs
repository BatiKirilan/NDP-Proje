namespace Ndp_Projesi_1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblKartNumarasi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxKartNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdveSoyad = new System.Windows.Forms.TextBox();
            this.lblSonKullanma = new System.Windows.Forms.Label();
            this.maskedTextBoxSonKullanma = new System.Windows.Forms.MaskedTextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.maskedTextBoxCVC = new System.Windows.Forms.MaskedTextBox();
            this.butOdemeTamamla = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.txtEczaneAdi = new System.Windows.Forms.TextBox();
            this.butEczaneOgren = new System.Windows.Forms.Button();
            this.butQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKartNumarasi
            // 
            this.lblKartNumarasi.AutoSize = true;
            this.lblKartNumarasi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNumarasi.Location = new System.Drawing.Point(58, 38);
            this.lblKartNumarasi.Name = "lblKartNumarasi";
            this.lblKartNumarasi.Size = new System.Drawing.Size(170, 19);
            this.lblKartNumarasi.TabIndex = 0;
            this.lblKartNumarasi.Text = "Kart Numarasını Giriniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBoxKartNumarasi
            // 
            this.maskedTextBoxKartNumarasi.Location = new System.Drawing.Point(59, 117);
            this.maskedTextBoxKartNumarasi.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxKartNumarasi.Name = "maskedTextBoxKartNumarasi";
            this.maskedTextBoxKartNumarasi.Size = new System.Drawing.Size(163, 20);
            this.maskedTextBoxKartNumarasi.TabIndex = 2;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(55, 161);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(267, 19);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Kartın Üzerindeki Ad ve Soyadı Giriniz";
            // 
            // txtAdveSoyad
            // 
            this.txtAdveSoyad.Location = new System.Drawing.Point(59, 202);
            this.txtAdveSoyad.Name = "txtAdveSoyad";
            this.txtAdveSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtAdveSoyad.TabIndex = 4;
            // 
            // lblSonKullanma
            // 
            this.lblSonKullanma.AutoSize = true;
            this.lblSonKullanma.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonKullanma.Location = new System.Drawing.Point(55, 244);
            this.lblSonKullanma.Name = "lblSonKullanma";
            this.lblSonKullanma.Size = new System.Drawing.Size(252, 19);
            this.lblSonKullanma.TabIndex = 5;
            this.lblSonKullanma.Text = "Kartın Son Kullanma Tarihini Giriniz";
            // 
            // maskedTextBoxSonKullanma
            // 
            this.maskedTextBoxSonKullanma.Location = new System.Drawing.Point(59, 279);
            this.maskedTextBoxSonKullanma.Mask = "00 00";
            this.maskedTextBoxSonKullanma.Name = "maskedTextBoxSonKullanma";
            this.maskedTextBoxSonKullanma.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxSonKullanma.TabIndex = 6;
            this.maskedTextBoxSonKullanma.ValidatingType = typeof(System.DateTime);
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCVC.Location = new System.Drawing.Point(55, 326);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(118, 19);
            this.lblCVC.TabIndex = 7;
            this.lblCVC.Text = "CVC/CVV Giriniz";
            // 
            // maskedTextBoxCVC
            // 
            this.maskedTextBoxCVC.Location = new System.Drawing.Point(59, 363);
            this.maskedTextBoxCVC.Mask = "000";
            this.maskedTextBoxCVC.Name = "maskedTextBoxCVC";
            this.maskedTextBoxCVC.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxCVC.TabIndex = 8;
            // 
            // butOdemeTamamla
            // 
            this.butOdemeTamamla.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butOdemeTamamla.Location = new System.Drawing.Point(59, 401);
            this.butOdemeTamamla.Name = "butOdemeTamamla";
            this.butOdemeTamamla.Size = new System.Drawing.Size(112, 40);
            this.butOdemeTamamla.TabIndex = 9;
            this.butOdemeTamamla.Text = "Ödemeyi Tamamla";
            this.butOdemeTamamla.UseVisualStyleBackColor = true;
            this.butOdemeTamamla.Click += new System.EventHandler(this.butOdemeTamamla_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(540, 44);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(212, 158);
            this.pictureBoxQRCode.TabIndex = 10;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // txtEczaneAdi
            // 
            this.txtEczaneAdi.Location = new System.Drawing.Point(540, 230);
            this.txtEczaneAdi.Name = "txtEczaneAdi";
            this.txtEczaneAdi.Size = new System.Drawing.Size(212, 20);
            this.txtEczaneAdi.TabIndex = 11;
            // 
            // butEczaneOgren
            // 
            this.butEczaneOgren.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butEczaneOgren.Location = new System.Drawing.Point(540, 279);
            this.butEczaneOgren.Name = "butEczaneOgren";
            this.butEczaneOgren.Size = new System.Drawing.Size(105, 50);
            this.butEczaneOgren.TabIndex = 12;
            this.butEczaneOgren.Text = "Size En Yakın Eczaneyi Öğrenin";
            this.butEczaneOgren.UseVisualStyleBackColor = true;
            this.butEczaneOgren.Click += new System.EventHandler(this.butEczaneOgren_Click);
            // 
            // butQRCode
            // 
            this.butQRCode.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butQRCode.Location = new System.Drawing.Point(651, 279);
            this.butQRCode.Name = "butQRCode";
            this.butQRCode.Size = new System.Drawing.Size(101, 50);
            this.butQRCode.TabIndex = 13;
            this.butQRCode.Text = "QR Kodunuzu Öğrenin";
            this.butQRCode.UseVisualStyleBackColor = true;
            this.butQRCode.Click += new System.EventHandler(this.butQRCode_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(811, 485);
            this.Controls.Add(this.butQRCode);
            this.Controls.Add(this.butEczaneOgren);
            this.Controls.Add(this.txtEczaneAdi);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.butOdemeTamamla);
            this.Controls.Add(this.maskedTextBoxCVC);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.maskedTextBoxSonKullanma);
            this.Controls.Add(this.lblSonKullanma);
            this.Controls.Add(this.txtAdveSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.maskedTextBoxKartNumarasi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKartNumarasi);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKartNumarasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKartNumarasi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdveSoyad;
        private System.Windows.Forms.Label lblSonKullanma;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSonKullanma;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCVC;
        private System.Windows.Forms.Button butOdemeTamamla;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.TextBox txtEczaneAdi;
        private System.Windows.Forms.Button butEczaneOgren;
        private System.Windows.Forms.Button butQRCode;
    }
}