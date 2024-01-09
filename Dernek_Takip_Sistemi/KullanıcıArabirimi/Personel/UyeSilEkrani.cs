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
			connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
		}

        private void UyeSilBTN_Click(object sender, EventArgs e)
        {
            string Tckimlik = TCgirTB.Text;
         
            // Kullanıcıya silme işlemi için onay iste
            DialogResult result = MessageBox.Show("Bu üye silinecek. Emin misiniz?", "Üye Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlSorgusu = $"DELETE FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{Tckimlik}'";
                using (SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, connect.Connect()))
                {
                    try
                    {
                        if (sqlCommand.ExecuteNonQuery() > 0)
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
                            MessageBox.Show("Kullanıcı Bulunamadı. Geçerli bir TC kimlik numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda kullanıcıya bilgi ver
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                this.Show();
        }

        private void TSB_UyeSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeBilgileriniListelemeİslemleri geriDonİslemi = new UyeBilgileriniListelemeİslemleri();
            geriDonİslemi.ShowDialog();
        }

        private void TCgirTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (TCgirTB.Text == "TC kimlik numarası giriniz")
            {
				TCgirTB.Text = "";
				TCgirTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
			}
		}

		private void guno_goruntule_Click(object sender, EventArgs e)
        {
            string Tckimlik = TCgirTB.Text;
            
            DataTable UserDT = new DataTable();
            if (String.IsNullOrWhiteSpace(TCgirTB.Text))
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Olamaz!");
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi, UyeAdi, UyeSoyadi FROM UyeKayitTablosu WHERE TCKimlikNumarasi ='{Tckimlik}'", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            UyeGoruntuleDGW.DataSource = UserDT;
        }
    }
}



