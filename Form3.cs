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
using System.Linq.Expressions;

namespace Ndp_Projesi_1
{

    public partial class Form3 : Form
    {
        public Form3() //ürün sınıfından fiyatı ürünlere fiyat belirledik.
        {
            InitializeComponent();
            Urunler CerrahiMaske = new Urunler();
            CerrahiMaske.fiyat = 1;

            Urunler BezMaske = new Urunler();
            BezMaske.fiyat = 5;

            Urunler N95Maske = new Urunler();
            N95Maske.fiyat = 25;
        }



        private void butEDevlet_Click(object sender, EventArgs e)

        {
            try
            {
                int yas = Convert.ToInt32(txtYas.Text); //eğer maske almak isteyen kişinin yaşı 20<x<65 ise alabiliyor yoksa sistem e-devlete yönlendirmiyor

                if (yas > 20 && yas < 65)
                {
                    //bu metod ile siyeye yönlendirmeyi gerçekleştiriyoruz.
                    ProcessStartInfo redirect = new ProcessStartInfo("https://giris.turkiye.gov.tr/Giris/");
                    Process.Start(redirect);

                }
                else
                {
                    MessageBox.Show("Maskeleri ücretsiz alabilmeniz için 20 ile 65 yaş arasında olmalısınız.");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen yaşınızı giriniz."); //yaş girilmeden e-devlete girmek istenirse bu hata veriliyor.
            }
         
        }
            
        private void butOdemeEkrani_Click(object sender, EventArgs e)
        {
            if (fiyat >0 )
            {

                Form4 formgecis = new Form4(); //form 4'e geçiyoruz ancak bu sayfayı kapatmıyoruz işlem tamamlandığında ne alındığı belli olması amacıyla.
                formgecis.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz"); //ürün seçmeden devam etmek isterse kişi devam edemiyor.
            }
            
        }

        int fiyat; //labela fiyat toplamını gösterebilmek için degisken atiyoruz.
        int cerrahf, bezf, n95f;

        private void comboBoxCerrahi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cerrahf = ((Convert.ToInt32(comboBoxCerrahi.Text)) * 1);
            txtCerrahifiyat.Text =cerrahf.ToString();
            fiyat = n95f + cerrahf + bezf;
            lblFiyat.Text = fiyat.ToString();
        }
        private void comboBoxBez_SelectedIndexChanged(object sender, EventArgs e)
        {
            bezf = ((Convert.ToInt32(comboBoxBez.Text)) * 5);
            txtBezfiyat.Text = bezf.ToString();
            fiyat = n95f + cerrahf + bezf;
            lblFiyat.Text = fiyat.ToString();
        }

        private void comboBoxN95_SelectedIndexChanged(object sender, EventArgs e)
        {
            n95f = ((Convert.ToInt32(comboBoxN95.Text)) * 25);
            txtN95fiyat.Text = n95f.ToString();
            fiyat = n95f + cerrahf + bezf;
            lblFiyat.Text = fiyat.ToString();
        }


        private void txtYas_KeyPress(object sender, KeyPressEventArgs e) 
            //Sadece sayı girebilmek için.
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
    }
}
