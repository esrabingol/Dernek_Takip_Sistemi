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

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class UyeGirisEkrani : Form
    {
		DataLayer.Baglanti.VeriTabaniBaglantisi connect;

		public UyeGirisEkrani()
        {
            InitializeComponent();
			connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
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

        private void UsfregorCB_CheckedChanged(object sender, EventArgs e)
        {
			if (UsfregorCB.Checked)
			{
				UsfregorCB.Image = Properties.Resources.opened_eye;
				SifreTB.PasswordChar = '\0';
			}
			else
			{
				UsfregorCB.Image = Properties.Resources.closed_eye;
				SifreTB.PasswordChar = '*';
			}
		}

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
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

            DataTable kullaniciDataT = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select * from UyeKayitTablosu Where UyeMailAdresi='{UKullaniciAdiTB.Text}'", connect.Connect());

            dataAdapter.Fill(dataTable: kullaniciDataT);

            if (kullaniciDataT.Rows.Count > 0)
            {
                var sifre = kullaniciDataT.Rows[0]["UyeSifre"].ToString();
                var kullaniciAdi = kullaniciDataT.Rows[0]["UyeMailAdresi"].ToString();
                var tcKimlikNumarasi = kullaniciDataT.Rows[0]["TCKimlikNumarasi"].ToString();

                if (UKullaniciAdiTB.Text == kullaniciAdi)
                {
                    if (SifreTB.Text == sifre)
                    {
                        UyeIslemlerEkrani uye = new UyeIslemlerEkrani(tcKimlikNumarasi);
                        uye.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır.");
                }
            }
        }

		private void UKullaniciAdiTB_MouseClick(object sender, MouseEventArgs e)
		{
			if (UKullaniciAdiTB.Text == "Kullanıcı adınız e-posta adresinizdir")
			{
				UKullaniciAdiTB.Text = "";
				UKullaniciAdiTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
			}
		}

        private void SifreTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (SifreTB.Text == "İlk şifreniz TC Kimlik numaranızdır")
            {
                SifreTB.PasswordChar = '*';
                SifreTB.Text = "";
                SifreTB.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
	}
}
