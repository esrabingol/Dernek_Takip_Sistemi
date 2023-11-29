using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UyeKayıtAlmaEkrani kayıtAlmaEkrani = new UyeKayıtAlmaEkrani();
            kayıtAlmaEkrani.Show();
        }

        private void TSB_Uye_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void KullaniciAdiTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (KullaniciAdiTB.Text == "Kullanıcı Adı")
            {
                KullaniciAdiTB.Text = "";
                KullaniciAdiTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void KullaniciAdiTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KullaniciAdiTB.Text))
            {
                KullaniciAdiTB.Text = "Kullanıcı Adı";
                KullaniciAdiTB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
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
    }
}
