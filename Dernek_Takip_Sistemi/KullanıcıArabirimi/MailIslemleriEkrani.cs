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

        private void Mail_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string gonderenMail = PersonelMail_TB.Text;
                string gonderenSifre = "12345";
                string aliciMail = MAdressUye_TB.Text;
                string konu = KonuBasligi_TB.Text;
                string icerik = KonuIcerigi_RTB.Text;

                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"); // Eğer Gmail kullanacaksanız, SMTP sunucu adresi
                mail.From = new MailAddress(gonderenMail);
                mail.To.Add(aliciMail);
                mail.Subject = konu; // Mail konusu
                mail.Body = icerik; // Mail içeriği

                smtpServer.Port = 587; // Gmail için genellikle kullanılan port numarası
                smtpServer.Credentials = new NetworkCredential(gonderenMail, gonderenSifre);
                smtpServer.EnableSsl = true; // SSL/TLS bağlantı şifrelemesi

                smtpServer.Send(mail);
                MessageBox.Show("Mail başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderirken hata oluştu: " + ex.Message);
            }
        }
    }
}
