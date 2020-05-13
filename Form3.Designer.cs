namespace Ndp_Projesi_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butEDevlet = new System.Windows.Forms.Button();
            this.lblUcretsizMaske = new System.Windows.Forms.Label();
            this.lblUcretliMaske = new System.Windows.Forms.Label();
            this.lblCerrahiMaske = new System.Windows.Forms.Label();
            this.lblBezMaske = new System.Windows.Forms.Label();
            this.lblN95Maske = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.comboBoxCerrahi = new System.Windows.Forms.ComboBox();
            this.comboBoxBez = new System.Windows.Forms.ComboBox();
            this.comboBoxN95 = new System.Windows.Forms.ComboBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.butOdemeEkrani = new System.Windows.Forms.Button();
            this.txtCerrahifiyat = new System.Windows.Forms.TextBox();
            this.txtBezfiyat = new System.Windows.Forms.TextBox();
            this.txtN95fiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMaskeFiyat = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.lblYasiniziGirin = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butEDevlet
            // 
            this.butEDevlet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEDevlet.BackgroundImage")));
            this.butEDevlet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEDevlet.Location = new System.Drawing.Point(122, 158);
            this.butEDevlet.Name = "butEDevlet";
            this.butEDevlet.Size = new System.Drawing.Size(173, 50);
            this.butEDevlet.TabIndex = 1;
            this.butEDevlet.UseVisualStyleBackColor = true;
            this.butEDevlet.Click += new System.EventHandler(this.butEDevlet_Click);
            // 
            // lblUcretsizMaske
            // 
            this.lblUcretsizMaske.AutoSize = true;
            this.lblUcretsizMaske.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcretsizMaske.Location = new System.Drawing.Point(31, 53);
            this.lblUcretsizMaske.Name = "lblUcretsizMaske";
            this.lblUcretsizMaske.Size = new System.Drawing.Size(357, 19);
            this.lblUcretsizMaske.TabIndex = 2;
            this.lblUcretsizMaske.Text = "5 Adet Ücretsiz Maskenizi Almak İçin Yaşınızı Giriniz";
            // 
            // lblUcretliMaske
            // 
            this.lblUcretliMaske.AutoSize = true;
            this.lblUcretliMaske.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcretliMaske.Location = new System.Drawing.Point(499, 53);
            this.lblUcretliMaske.Name = "lblUcretliMaske";
            this.lblUcretliMaske.Size = new System.Drawing.Size(402, 19);
            this.lblUcretliMaske.TabIndex = 3;
            this.lblUcretliMaske.Text = "5 Adet Ücretsiz Maske Hakkınız Dolduysa Satın Almak İçin";
            // 
            // lblCerrahiMaske
            // 
            this.lblCerrahiMaske.AutoSize = true;
            this.lblCerrahiMaske.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCerrahiMaske.Location = new System.Drawing.Point(520, 128);
            this.lblCerrahiMaske.Name = "lblCerrahiMaske";
            this.lblCerrahiMaske.Size = new System.Drawing.Size(103, 19);
            this.lblCerrahiMaske.TabIndex = 4;
            this.lblCerrahiMaske.Text = "Cerrahi Maske";
            // 
            // lblBezMaske
            // 
            this.lblBezMaske.AutoSize = true;
            this.lblBezMaske.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBezMaske.Location = new System.Drawing.Point(520, 158);
            this.lblBezMaske.Name = "lblBezMaske";
            this.lblBezMaske.Size = new System.Drawing.Size(80, 19);
            this.lblBezMaske.TabIndex = 5;
            this.lblBezMaske.Text = "Bez Maske";
            // 
            // lblN95Maske
            // 
            this.lblN95Maske.AutoSize = true;
            this.lblN95Maske.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN95Maske.Location = new System.Drawing.Point(520, 190);
            this.lblN95Maske.Name = "lblN95Maske";
            this.lblN95Maske.Size = new System.Drawing.Size(36, 19);
            this.lblN95Maske.TabIndex = 6;
            this.lblN95Maske.Text = "N95";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(706, 91);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(42, 19);
            this.lblAdet.TabIndex = 7;
            this.lblAdet.Text = "Adet";
            // 
            // comboBoxCerrahi
            // 
            this.comboBoxCerrahi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCerrahi.FormattingEnabled = true;
            this.comboBoxCerrahi.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "25",
            "50"});
            this.comboBoxCerrahi.Location = new System.Drawing.Point(710, 125);
            this.comboBoxCerrahi.Name = "comboBoxCerrahi";
            this.comboBoxCerrahi.Size = new System.Drawing.Size(38, 21);
            this.comboBoxCerrahi.TabIndex = 8;
            this.comboBoxCerrahi.SelectedIndexChanged += new System.EventHandler(this.comboBoxCerrahi_SelectedIndexChanged_1);
            // 
            // comboBoxBez
            // 
            this.comboBoxBez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBez.FormattingEnabled = true;
            this.comboBoxBez.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "25",
            "50"});
            this.comboBoxBez.Location = new System.Drawing.Point(710, 158);
            this.comboBoxBez.Name = "comboBoxBez";
            this.comboBoxBez.Size = new System.Drawing.Size(38, 21);
            this.comboBoxBez.TabIndex = 9;
            this.comboBoxBez.SelectedIndexChanged += new System.EventHandler(this.comboBoxBez_SelectedIndexChanged);
            // 
            // comboBoxN95
            // 
            this.comboBoxN95.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxN95.FormattingEnabled = true;
            this.comboBoxN95.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "25",
            "50"});
            this.comboBoxN95.Location = new System.Drawing.Point(710, 191);
            this.comboBoxN95.Name = "comboBoxN95";
            this.comboBoxN95.Size = new System.Drawing.Size(38, 21);
            this.comboBoxN95.TabIndex = 10;
            this.comboBoxN95.SelectedIndexChanged += new System.EventHandler(this.comboBoxN95_SelectedIndexChanged);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(706, 235);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(61, 19);
            this.lblUcret.TabIndex = 11;
            this.lblUcret.Text = "Toplam";
            // 
            // butOdemeEkrani
            // 
            this.butOdemeEkrani.Location = new System.Drawing.Point(612, 267);
            this.butOdemeEkrani.Name = "butOdemeEkrani";
            this.butOdemeEkrani.Size = new System.Drawing.Size(136, 36);
            this.butOdemeEkrani.TabIndex = 12;
            this.butOdemeEkrani.Text = "Ödeme Ekranına Geçiniz";
            this.butOdemeEkrani.UseVisualStyleBackColor = true;
            this.butOdemeEkrani.Click += new System.EventHandler(this.butOdemeEkrani_Click);
            // 
            // txtCerrahifiyat
            // 
            this.txtCerrahifiyat.Location = new System.Drawing.Point(773, 126);
            this.txtCerrahifiyat.Name = "txtCerrahifiyat";
            this.txtCerrahifiyat.ReadOnly = true;
            this.txtCerrahifiyat.Size = new System.Drawing.Size(69, 20);
            this.txtCerrahifiyat.TabIndex = 13;
            // 
            // txtBezfiyat
            // 
            this.txtBezfiyat.Location = new System.Drawing.Point(773, 159);
            this.txtBezfiyat.Name = "txtBezfiyat";
            this.txtBezfiyat.ReadOnly = true;
            this.txtBezfiyat.Size = new System.Drawing.Size(69, 20);
            this.txtBezfiyat.TabIndex = 13;
            // 
            // txtN95fiyat
            // 
            this.txtN95fiyat.Location = new System.Drawing.Point(773, 192);
            this.txtN95fiyat.Name = "txtN95fiyat";
            this.txtN95fiyat.ReadOnly = true;
            this.txtN95fiyat.Size = new System.Drawing.Size(69, 20);
            this.txtN95fiyat.TabIndex = 13;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(782, 235);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 19);
            this.lblFiyat.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(172, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblMaskeFiyat
            // 
            this.lblMaskeFiyat.AutoSize = true;
            this.lblMaskeFiyat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaskeFiyat.Location = new System.Drawing.Point(761, 91);
            this.lblMaskeFiyat.Name = "lblMaskeFiyat";
            this.lblMaskeFiyat.Size = new System.Drawing.Size(93, 19);
            this.lblMaskeFiyat.TabIndex = 15;
            this.lblMaskeFiyat.Text = "Maske Fiyatı";
            // 
            // txtYas
            // 
            this.txtYas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYas.Location = new System.Drawing.Point(203, 114);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(56, 20);
            this.txtYas.TabIndex = 16;
            this.txtYas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYas_KeyPress);
            // 
            // lblYasiniziGirin
            // 
            this.lblYasiniziGirin.AutoSize = true;
            this.lblYasiniziGirin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasiniziGirin.Location = new System.Drawing.Point(60, 115);
            this.lblYasiniziGirin.Name = "lblYasiniziGirin";
            this.lblYasiniziGirin.Size = new System.Drawing.Size(116, 19);
            this.lblYasiniziGirin.TabIndex = 17;
            this.lblYasiniziGirin.Text = "Yaşınızı Giriniz :";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL.Location = new System.Drawing.Point(827, 235);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(27, 19);
            this.lblTL.TabIndex = 18;
            this.lblTL.Text = "TL";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(913, 495);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblYasiniziGirin);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.lblMaskeFiyat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtN95fiyat);
            this.Controls.Add(this.txtBezfiyat);
            this.Controls.Add(this.txtCerrahifiyat);
            this.Controls.Add(this.butOdemeEkrani);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.comboBoxN95);
            this.Controls.Add(this.comboBoxBez);
            this.Controls.Add(this.comboBoxCerrahi);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblN95Maske);
            this.Controls.Add(this.lblBezMaske);
            this.Controls.Add(this.lblCerrahiMaske);
            this.Controls.Add(this.lblUcretliMaske);
            this.Controls.Add(this.lblUcretsizMaske);
            this.Controls.Add(this.butEDevlet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butEDevlet;
        private System.Windows.Forms.Label lblUcretsizMaske;
        private System.Windows.Forms.Label lblUcretliMaske;
        private System.Windows.Forms.Label lblCerrahiMaske;
        private System.Windows.Forms.Label lblBezMaske;
        private System.Windows.Forms.Label lblN95Maske;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ComboBox comboBoxCerrahi;
        private System.Windows.Forms.ComboBox comboBoxBez;
        private System.Windows.Forms.ComboBox comboBoxN95;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button butOdemeEkrani;
        private System.Windows.Forms.TextBox txtCerrahifiyat;
        private System.Windows.Forms.TextBox txtBezfiyat;
        private System.Windows.Forms.TextBox txtN95fiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMaskeFiyat;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label lblYasiniziGirin;
        private System.Windows.Forms.Label lblTL;
    }
}