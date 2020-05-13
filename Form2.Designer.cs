namespace Ndp_Projesi_1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timerZamanlayici1 = new System.Windows.Forms.Timer(this.components);
            this.lblBaslik = new System.Windows.Forms.Label();
            this.butCorona = new System.Windows.Forms.Button();
            this.butMaskeAl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerZamanlayici1
            // 
            this.timerZamanlayici1.Tick += new System.EventHandler(this.timerZamanlayici1_Tick);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaslik.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(63, 48);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(2, 31);
            this.lblBaslik.TabIndex = 0;
            // 
            // butCorona
            // 
            this.butCorona.BackColor = System.Drawing.Color.OrangeRed;
            this.butCorona.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butCorona.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butCorona.Location = new System.Drawing.Point(81, 347);
            this.butCorona.Name = "butCorona";
            this.butCorona.Size = new System.Drawing.Size(260, 51);
            this.butCorona.TabIndex = 1;
            this.butCorona.Text = "CORONAVIRUS TESTI";
            this.butCorona.UseVisualStyleBackColor = false;
            this.butCorona.Click += new System.EventHandler(this.butCorona_Click);
            // 
            // butMaskeAl
            // 
            this.butMaskeAl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butMaskeAl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butMaskeAl.Location = new System.Drawing.Point(552, 347);
            this.butMaskeAl.Name = "butMaskeAl";
            this.butMaskeAl.Size = new System.Drawing.Size(260, 51);
            this.butMaskeAl.TabIndex = 2;
            this.butMaskeAl.Text = "MASKE ALMAK İÇİN TIKLAYINIZ";
            this.butMaskeAl.UseVisualStyleBackColor = false;
            this.butMaskeAl.Click += new System.EventHandler(this.butMaskeAl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(883, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butMaskeAl);
            this.Controls.Add(this.butCorona);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerZamanlayici1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button butCorona;
        private System.Windows.Forms.Button butMaskeAl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}