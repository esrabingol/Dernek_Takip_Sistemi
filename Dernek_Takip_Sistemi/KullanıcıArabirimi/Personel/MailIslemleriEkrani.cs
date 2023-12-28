using iText.Commons.Bouncycastle.Cert.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class MailIslemleriEkrani : Form
    {

        public MailIslemleriEkrani()
        {
            InitializeComponent();
        }

        private void AnaEkranaDon_TSB_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeBilgileriniListelemeİslemleri uyeBilgileriniListeleme = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListeleme.ShowDialog();
        }

        private void MailIslemleriEkrani_Load(object sender, EventArgs e)
        {
            // TextBox'in içeriğini atayın (örnek olarak)
            PersonelMail_TB.Text = "personel@gmail.com";

            // TextBox'i salt okunur hale getirin
            PersonelMail_TB.ReadOnly = true;
        }

        private void Temizle_TSB_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox textBox && !textBox.ReadOnly)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox && !richTextBox.ReadOnly)
                {
                    richTextBox.Text = string.Empty;
                }
            }
        }

        private void logout_TSB_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void guno_Mail_BTN_Click(object sender, EventArgs e)
        {
            string gonderenMail = PersonelMail_TB.Text;
            string aliciMail = MAdressUye_TB.Text;
            string konu = KonuBasligi_TB.Text;
            string icerik = KonuIcerigi_RTB.Text;

            if (string.IsNullOrWhiteSpace(gonderenMail) || string.IsNullOrWhiteSpace(aliciMail) ||
                string.IsNullOrWhiteSpace(konu) || string.IsNullOrWhiteSpace(icerik))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            MessageBox.Show("Mail Başarı ile  gönderildi.");
        }
    }
}
