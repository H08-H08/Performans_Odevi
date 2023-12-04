using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans_Odevi
{
    public partial class Form1 : Form
    {
        List <Ogrenci> ogrenciler = new List<Ogrenci>();
        List <Okul> okullar = new List<Okul>();
        List <Enstruman> enstrumanlar = new List<Enstruman>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydetOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            try
            {
               
                ogrenci.Ad = txtOgrenciAd.Text;
                ogrenci.DogumTarihi = dtDogumTarihi.Value;
                ogrenci.Kurslar = txtKurslar.Text;
                if (radioButton1.Checked) ogrenci.Cinsiyet = radioButton1.Text;
                else if (radioButton2.Checked) ogrenci.Cinsiyet = radioButton2.Text;
                ogrenciler.Add(ogrenci);
                cmbOgrenciler.Items.Add(ogrenciler);
                cmbOgrenciler.DisplayMember = "Ogrencii.Ad";
                MessageBox.Show("Başarıyla Kaydetti !!!","OLUMLU !!!");
            }
            catch(Exception message) 
            {
                MessageBox.Show("Hatalı İşlem !!! \n" +message.Message,"HATA MESAJI !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            {
            }
        }

        private void btnKaydetOkul_Click(object sender, EventArgs e)
        {
            try
            {
                Okul okul = new Okul();
                okul.Ad = txtOkulAdi.Text;
                okul.Sinif = cmbSinif.SelectedText;
                okul.No = txtOkulNo.Text;
                okullar.Add(okul);
                MessageBox.Show("Başarıyla Kaydetti !!!", "OLUMLU !!!");
            }
            catch (Exception message)
            {
                MessageBox.Show("Hatalı İşlem !!! \n" + message.Message, "HATA MESAJI !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydetEnstruman_Click(object sender, EventArgs e)
        {
            try
            {
                Enstruman enstruman = new Enstruman();
                enstruman.EnstrumanTuru = cmbEnstrumanTuru.SelectedText;
                if (txtDiger.Text != null) enstruman.Enstrumanlar = cmbEnstrumanlar.SelectedText;
                else enstruman.Enstrumanlar = txtDiger.Text;
                enstrumanlar.Add(enstruman);
                lbxListe.Items.Add (enstruman.Okull.Ogrencii.Ad+" "+enstruman.Enstrumanlar+" "+enstruman.Okull.No+" "+enstruman.Okull.Sinif+" "+enstruman.Okull.Ad);
                MessageBox.Show("Başarıyla Kaydetti !!!", "OLUMLU !!!");
            }
            catch (Exception message)
            {
                MessageBox.Show("Hatalı İşlem !!! \n" + message.Message, "HATA MESAJI !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void cmbEnstrumanTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEnstrumanTuru.SelectedItem.ToString() == "Telli")
            {
                cmbEnstrumanlar.Items.Clear();
                cmbEnstrumanlar.Items.Add("Solist (Tiz)");
                cmbEnstrumanlar.Items.Add("Solist (Pes)");
                cmbEnstrumanlar.Items.Add("Kısa Sap Bağlama");
                cmbEnstrumanlar.Items.Add("Uzun Sap Bağlama");
                cmbEnstrumanlar.Items.Add("Keman");
                cmbEnstrumanlar.Items.Add("Elektro Gitar (Solo)");
                cmbEnstrumanlar.Items.Add("Elektro Gitar (Akor)");
                cmbEnstrumanlar.Items.Add("Bass Gitar");
                cmbEnstrumanlar.Items.Add("Klasik - Akustik Gitar");
                cmbEnstrumanlar.Items.Add("Ukulele");
                cmbEnstrumanlar.Items.Add("-> Diğer <-");
            }
            if (cmbEnstrumanTuru.SelectedItem.ToString() == "Üflemeli")
            {
                cmbEnstrumanlar.Items.Clear();
                cmbEnstrumanlar.Items.Add("-> Diğer <-");
                
            }
            if (cmbEnstrumanTuru.SelectedItem.ToString() == "Ritimli")
            {
                cmbEnstrumanlar.Items.Clear();
                cmbEnstrumanlar.Items.Add("Bateri");
                cmbEnstrumanlar.Items.Add("Bendir");
                cmbEnstrumanlar.Items.Add("Darbuka");
                cmbEnstrumanlar.Items.Add("Kuba");
                cmbEnstrumanlar.Items.Add("Davul");
                cmbEnstrumanlar.Items.Add("Zil");
                cmbEnstrumanlar.Items.Add("Kaşık");
                cmbEnstrumanlar.Items.Add("Zilli Def");
                cmbEnstrumanlar.Items.Add("-> Diğer <-");
            }
            if (cmbEnstrumanTuru.SelectedItem.ToString() == "Tuşlu")
            {
                cmbEnstrumanlar.Items.Clear();
                cmbEnstrumanlar.Items.Add("Piyano - Org");
                cmbEnstrumanlar.Items.Add("-> Diğer <-");

            }
        }

        private void cmbEnstrumanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEnstrumanlar.SelectedItem.ToString() == "-> Diğer <-")
            {
                label10.Visible = true;
                txtDiger.Visible = true;
            }
            else
            {
                label10.Visible = false;
                txtDiger.Visible = false;
            }
        }
    }
}
