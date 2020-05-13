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
using System.Windows.Forms;

namespace Ndp_Projesi_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)  
        {
            timerZamanlayici1.Enabled = true;    //yazının kaymasını saglayan kod.
            lblBaslik.Text = "     T.C. SAĞLIK BAKANLIĞI CORONAVIRUS ILE MUCADELE PLATFORMU";
        }

        private void timerZamanlayici1_Tick(object sender, EventArgs e) //yazının kaymasını sağlayan kod.
        {
            lblBaslik.Text = lblBaslik.Text.Substring(1) + lblBaslik.Text.Substring(0, 1);
        }

        private void butCorona_Click(object sender, EventArgs e) //ana sayfadan coronatesti sayfasına geçiyor ve ana sayfayı kapatıyor.
        {
            Form1 formgecis = new Form1();
            formgecis.Show();
            this.Hide();
        }

        private void butMaskeAl_Click(object sender, EventArgs e) //ana sayfadan maske sayfasına geçiyor ve ana sayfayı kapatıyor.
        {
            Form3 formgecis = new Form3();
            formgecis.Show();
            this.Hide();
        }
    }
}
