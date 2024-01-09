using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using iText.Commons.Bouncycastle.Cert.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class MailIslemleriEkrani : Form
    {

        DataLayer.Baglanti.VeriTabaniBaglantisi connect;
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "dernek-takip-sistemi";
        List<string> aliciMailler = new List<string>(); // Alıcı mailleri listesi
        public MailIslemleriEkrani()
        {
            InitializeComponent();
            connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
        }
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        private void AnaEkranaDon_TSB_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeBilgileriniListelemeİslemleri uyeBilgileriniListeleme = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListeleme.ShowDialog();
        }

        private void MailIslemleriEkrani_Load(object sender, EventArgs e)
        {
            PersonelMail_TB.Text = "nesdernek@gmail.com";
            PersonelMail_TB.Enabled = false;

            string sqlQuery = @"
                    SELECT 
                        U.UyeMailAdresi, B.BorcMiktari
                    FROM
                        BorcTablosu B
                    JOIN
                        UyeKayitTablosu U ON B.TCKimlikNumarasi = U.TCKimlikNumarasi;
                ";

            using (SqlCommand command = new SqlCommand(sqlQuery, connect.Connect()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal borcMiktari = Convert.ToDecimal(reader["BorcMiktari"]);

                        if (borcMiktari > 0) //borcu varsa
                        {
                            string mailAdresi = reader["UyeMailAdresi"].ToString();
                            aliciMailler.Add(mailAdresi);

                            // alıcı mail adreslerini textboxa yazdirir
                            MAdressUye_TB.AppendText($"{mailAdresi},");
                        }
                    }
                }
            }
        }

        private void Temizle_TSB_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && !textBox.ReadOnly)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox && !richTextBox.ReadOnly)
                {
                    richTextBox.Text = string.Empty;
                }
            }
        }

        private void guno_Mail_BTN_Click(object sender, EventArgs e)
        {
            //credentials dosyasını oku
            UserCredential credential;
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }

            // Her bir alıcıya mail gönder
            foreach (string mail in aliciMailler)
            {
                string message = $"To: {mail}\r\nSubject: {KonuBasligi_TB.Text}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{KonuIcerigi_RTB.Text}</h1>";

                // gmail servisi çağır
                var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
                var msg = new Google.Apis.Gmail.v1.Data.Message();
                msg.Raw = Base64UrlEncode(message.ToString());
                service.Users.Messages.Send(msg, "me").Execute();
            }
			MessageBox.Show("Mail başarıyla gönderildi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            UyeBilgileriniListelemeİslemleri uyeBilgileriniListeleme = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListeleme.ShowDialog();
        }

        private void logout_TSB_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }
    }
}
