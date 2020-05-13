/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: PROJE
** ÖĞRENCİ ADI............: MERT BATIKAN KIRILAN
** ÖĞRENCİ NUMARASI.......: B181200019
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ndp_Projesi_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

            

        private void butOdemeTamamla_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(maskedTextBoxKartNumarasi.Text))  //alanlar boş kalınca ödeme yapılamıyor.
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
                else if (string.IsNullOrEmpty(txtAdveSoyad.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
                else if (string.IsNullOrEmpty(maskedTextBoxSonKullanma.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
                else if (string.IsNullOrEmpty(maskedTextBoxCVC.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
            else
            {
                MessageBox.Show("Ödemeniz tamamlanmıştır. Bu mesajı kapatıp aynı sekme üzerinden size en yakın eczanenin adını yazarak qr kodunuza erişebilirsiniz, bu kod ile size en yakın eczaneden maskenizi temin edebilirsiniz.");

            }



        }

        private void butEczaneOgren_Click(object sender, EventArgs e)
            //bu metod ile google maps aracılığı ile en yakın eczaneyi ögreniyoruz.
        {
            ProcessStartInfo eczaneogren = new ProcessStartInfo("https://www.google.com/maps/search/Eczaneler/");
            Process.Start(eczaneogren);
        }

        private void butQRCode_Click(object sender, EventArgs e)
            //nuGet'ten Zen.Barcode.Rendering.Framework adındaki paket ile QR Kod oluşturdum.
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBoxQRCode.Image = qrcode.Draw(txtEczaneAdi.Text, 50);
        }
    }
}
