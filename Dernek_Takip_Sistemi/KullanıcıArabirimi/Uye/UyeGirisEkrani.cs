using Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye;
using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class UyeGirisEkrani : Form
    {
        public UyeGirisEkrani()
        {

            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UyeKayıtAlmaEkrani kayıtAlmaEkrani = new UyeKayıtAlmaEkrani(false);
            kayıtAlmaEkrani.Show();
        }

        private void TSB_Uye_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
         
        }

        private void KullaniciAdiTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (UKullaniciAdiTB.Text == "Kullanıcı Adı")
            {
                UKullaniciAdiTB.Text = "";
                UKullaniciAdiTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void KullaniciAdiTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UKullaniciAdiTB.Text))
            {
                UKullaniciAdiTB.Text = "Kullanıcı Adı";
                UKullaniciAdiTB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
            }
        }

        private void SifreTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (SifreTB.Text == "Şifre")
            {
                SifreTB.Text = "";
                SifreTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void SifreTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SifreTB.Text))
            {
                SifreTB.Text = "Şifre";
                SifreTB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
            }
        }

        private void btn_Uyelogin_Click(object sender, EventArgs e)
        {
            VeriTabaniBaglantisi connect;
            if (String.IsNullOrEmpty(UKullaniciAdiTB.Text))
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Geçilemez");
                return;

            }
            if (String.IsNullOrEmpty(SifreTB.Text))
            {
                MessageBox.Show("Şifre Alanı Boş Geçilemez");
                return;
            }

            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable kullaniciDataT = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select * from UyeKayitTablosu Where UyeMailAdresi='{UKullaniciAdiTB.Text}'", connect.Connect());

            dataAdapter.Fill(dataTable: kullaniciDataT);

            if(kullaniciDataT.Rows.Count >0)
            {
                var sifre = kullaniciDataT.Rows[0]["UyeSifre"].ToString();
                var kullaniciAdi = kullaniciDataT.Rows[0]["UyeMailAdresi"].ToString();
                var tcKimlikNumarasi = kullaniciDataT.Rows[0]["TCKimlikNumarasi"].ToString();

                if (UKullaniciAdiTB.Text == kullaniciAdi)
                {
                    if(SifreTB.Text == sifre)
                    {
                        MessageBox.Show("Kullanıcı Girişi Başarılı,Hoşgeldiniz.");
                        UyeIslemlerEkrani uye = new UyeIslemlerEkrani(tcKimlikNumarasi);
                        uye.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır.");
                    }
                }
            }
        }

        private void UsfregorCB_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (UsfregorCB.Checked)
            {
                //karakteri göster.
                SifreTB.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                SifreTB.PasswordChar = '*';
            }
        }
    }
}
