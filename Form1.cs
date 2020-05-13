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
using System.Data.SqlClient;


namespace Ndp_Projesi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;             //Toplam hastayı saydırabilmek için sayaçları tanımladım.
        int sayacTest = 0;
        int sayacKarantina = 0;


        SqlConnection baglanti = new SqlConnection("Data Source=XXBATIHD;Initial Catalog=NdpProje1;Integrated Security=True"); //database baglantısı olusturuyoruz.
       

        private void butSil_Click(object sender, EventArgs e)     // Ad listbox'ına tıklayınca satır halinde silebiliyoruz.
        {

            int ad = listAd.SelectedIndex;
            listSonuc.SelectedIndex = ad;

            if (ad > -1)
            {
                if (listSonuc.Text == "Test")                          // Aynı zamanda sayaçlar hastanın durumuna bağlı olarak azalıyor.
                {
                    sayac = sayac - 1;
                    lblSayac.Text = sayac.ToString();

                    sayacTest = sayacTest - 1;
                    lblSayacTest.Text = sayacTest.ToString();
                }
                else if (listSonuc.Text == "Karantina")
                {
                    sayac = sayac - 1;
                    lblSayac.Text = sayac.ToString();

                    sayacKarantina = sayacKarantina - 1;
                    lblSayacKarantina.Text = sayacKarantina.ToString();

                }
                listAd.Items.RemoveAt(ad);
                listSoyad.Items.RemoveAt(ad);
                listTC.Items.RemoveAt(ad);
                listTelefon.Items.RemoveAt(ad);
                listSonuc.Items.RemoveAt(ad);

            }


        }
        private string Sonuc;//listbox'taki degeri tutmak icin degisken atadık.

        private void butTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTC.Text))
            {
                MessageBox.Show("Lütfen TC'yi girip tekrar deneyiniz.");
            }
            else
            {
                try
                {

                    if (checkAtes.Checked == true & checkOksuruk.Checked == false & checkNefesDarligi.Checked == false)
                    {
                        MessageBox.Show("Hasta teste alinmali");
                        listAd.Items.Add(txtAd.Text);                          // TextBox'tan girilen veri, listBox'a kaydediliyor.
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();


                        txtAd.Text = "";                                 // Kayıt işlemi tamamlandığında textBox'ı da tekrar girilebilmesi için temizliyor.
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;                               // Her bir hasta kaydolduğunda sayaç bir artıyor.
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;                       // Belirtiler doğrultusunda teste girecek hasta sayısı bir artıyor.
                        lblSayacTest.Text = sayacTest.ToString();
                    }
                    else if (checkAtes.Checked == false & checkOksuruk.Checked == true & checkNefesDarligi.Checked == false)

                    {  // Hasta teste alınmalı mesajı gelen durumlara tekrardan açıklama satırını ilk durumda yazdığım için yinelemedim ancak aşağıdaki farklı uyarılar veren durumlar için yazdım.

                        MessageBox.Show("Hasta teste alinmali");


                        listAd.Items.Add(txtAd.Text);
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();

                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;
                        lblSayacTest.Text = sayacTest.ToString();
                        
                    }
                    else if (checkAtes.Checked == false & checkOksuruk.Checked == false & checkNefesDarligi.Checked == true)
                    {
                        MessageBox.Show("Hasta teste alinmali");


                        listAd.Items.Add(txtAd.Text);
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();

                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;
                        lblSayacTest.Text = sayacTest.ToString();

                    }
                    else if (checkAtes.Checked == true & checkOksuruk.Checked == true & checkNefesDarligi.Checked == true)
                    {
                        MessageBox.Show("HASTA DERHAL 14 GUN KARANTINA ALTINA ALINMALI!");       //Belirtilerin hepsi var hastanın durum mesajı geliyor.


                        listAd.Items.Add(txtAd.Text);                              // textBox'tan alınan veri listBox'a kaydediliyor.
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Karantina");
                        Sonuc = "Karantina";
                        HastaEkle();

                        txtAd.Text = "";                                           // işlem tamamlandıktan sonra tekrar kayıt alınabilmesi için textBox'ın içi temizleniyor.
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;                                             // Her bir hasta kaydolduğunda sayaç 1 artıyor.
                        lblSayac.Text = sayac.ToString();

                        sayacKarantina = sayacKarantina + 1;                            // Belirtiler doğrultusunda karantinaya alınması gereken hasta sayısı 1 artıyor.
                        lblSayacKarantina.Text = sayacKarantina.ToString();


                    }
                    else if (checkAtes.Checked == true & checkOksuruk.Checked == true & checkNefesDarligi.Checked == false)
                    {
                        MessageBox.Show("Hasta teste alinmali");


                        listAd.Items.Add(txtAd.Text);
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();

                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;
                        lblSayacTest.Text = sayacTest.ToString();

                    }
                    else if (checkAtes.Checked == true & checkOksuruk.Checked == false & checkNefesDarligi.Checked == true)
                    {
                        MessageBox.Show("Hasta teste alinmali");


                        listAd.Items.Add(txtAd.Text);
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();

                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";

                        sayac = sayac + 1;
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;
                        lblSayacTest.Text = sayacTest.ToString();

                    }
                    else if (checkAtes.Checked == false & checkOksuruk.Checked == true & checkNefesDarligi.Checked == true)
                    {
                        MessageBox.Show("Hasta teste alinmali");

                        listAd.Items.Add(txtAd.Text);
                        listSoyad.Items.Add(txtSoyad.Text);
                        listTC.Items.Add(txtTC.Text);
                        listTelefon.Items.Add(txtTelefon.Text);
                        listSonuc.Items.Add("Test");
                        Sonuc = "Test";
                        HastaEkle();

                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";



                        sayac = sayac + 1;
                        lblSayac.Text = sayac.ToString();

                        sayacTest = sayacTest + 1;
                        lblSayacTest.Text = sayacTest.ToString();


                    }
                    else
                    {
                        // Belirtilerin hiçbiri olmadığından kayıt açmaya gerek yok mesajı geliyor. Veritabanına da kaydetmiyoruz.
                        MessageBox.Show("Hastada herhangi bir problem gorulmemistir. Evden takip edilecektir. Kayda gerek yoktur.");

                        txtAd.Text = "";                                  // Daha sonrasında tekrar hasta kaydı alabilmek için textBox'ı temizliyor.
                        txtSoyad.Text = "";
                        txtTC.Text = "";
                        txtTelefon.Text = "";


                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen değerleri doğru girip tekrar deneyiniz.");
                }
            }


        }

        private void HastaEkle() //veritabanına bu metod ile kaydediyoruz.
        {
            baglanti.Open();
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "Insert Into hastaInfo(Ad,Soyad,TCKimlikNO,TelefonNumarasi,TestSonucu)values ('" + txtAd.Text + "','" + txtSoyad.Text + "', '" + txtTC.Text + "', '" + txtTelefon.Text + "', '" + Sonuc + "') ";


            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi için.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi için.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void butMaskeAlOpsiyonel_Click(object sender, EventArgs e) //daha sonrasında maske almak isteyenler için maske sayfasına yönlendiriyor.
        {
            Form3 formgecis = new Form3();
            formgecis.Show();
            this.Hide();
        }
    }     
}