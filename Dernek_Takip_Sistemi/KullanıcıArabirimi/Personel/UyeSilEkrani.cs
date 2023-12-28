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
    public partial class UyeSilGüncelleEkrani : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connect;
        public UyeSilGüncelleEkrani()
        {
            InitializeComponent();
        }


        private void UyeGoruntuleBTN_Click(object sender, EventArgs e)
        {
            string Tckimlik = TCgirTB.Text;
            connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();
            if (String.IsNullOrWhiteSpace(TCgirTB.Text))
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Olamaz!");
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM UyeKayitTablosu WHERE TCKimlikNumarasi ='{Tckimlik}'", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);

            }
            UyeGoruntuleDGW.DataSource = UserDT;
        }

        private void UyeSilBTN_Click(object sender, EventArgs e)
        {
            string Tckimlik = TCgirTB.Text;
         
            // Kullanıcıya silme işlemi için onay iste
            DialogResult result = MessageBox.Show("Bu üye silinecek. Emin misiniz?", "Üye Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string dynamicConnectionString = "Dernek_Takip_Sistemi";
                string connectionString = $"Data Source=LAPTOP-IPQTP7GR;Initial Catalog={dynamicConnectionString};Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL sorgusunu hazırla
                    string sqlSorgusu = $"DELETE FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{Tckimlik}'";

                    // SQL sorgusunu çalıştır
                    using (SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, connection))
                    {
                        try
                        {
                            // Veritabanı bağlantısını aç
                            connection.Open();

                            // İşlemi gerçekleştir
                            int etkilenenSatırSayısı = sqlCommand.ExecuteNonQuery();

                            if (etkilenenSatırSayısı > 0)
                            {
                                // İşlem başarılıysa kullanıcıya bilgi ver
                                MessageBox.Show("Üye başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // UyeBilgileriniListelemeİslemleri formunu aç
                                UyeBilgileriniListelemeİslemleri listelemeIslemleri = new UyeBilgileriniListelemeİslemleri();
                                listelemeIslemleri.Show();

                                // Mevcut formu gizle
                                this.Hide();
                            }
                            else
                            {

                                // İşlem başarısızsa kullanıcıya hata mesajı ver
                                MessageBox.Show("Uygun Kullanıcı Bulunamadı.Tc yi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hata durumunda kullanıcıya bilgi ver
                            MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Veritabanı bağlantısını kapat
                            connection.Close();
                        }
                    }
                }
            }

            else
            {
                // Kullanıcı "Hayır" dediyse, mevcut formu göster
                this.Show();
            }
        }

        private void UyeSilGüncelleEkrani_Load(object sender, EventArgs e)
        {

        }

        private void TSB_UyeSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeBilgileriniListelemeİslemleri geriDonİslemi = new UyeBilgileriniListelemeİslemleri();
            geriDonİslemi.ShowDialog();
        }

        private void TCgirTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCgirTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (TCgirTB.Text == "Kullanıcı TC Numarası")
            {
                TCgirTB.Text = "";
                TCgirTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void TCgirTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TCgirTB.Text))
            {
                TCgirTB.Text = "Kullanıcı TC Numarası";
                TCgirTB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
            }
        }

        private void guno_goruntule_Click(object sender, EventArgs e)
        {
            string Tckimlik = TCgirTB.Text;
            connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();
            if (String.IsNullOrWhiteSpace(TCgirTB.Text))
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Olamaz!");
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM UyeKayitTablosu WHERE TCKimlikNumarasi ='{Tckimlik}'", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);

            }
            UyeGoruntuleDGW.DataSource = UserDT;
        }
    }
}



