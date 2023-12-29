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


namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    public partial class UyeIslemlerEkrani : Form
    {
        string tcKimlikNumarasi;
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;
        public UyeIslemlerEkrani(string tcKimlikNumarasi)
        {
            InitializeComponent();
            this.tcKimlikNumarasi= tcKimlikNumarasi;
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");


        }
        public UyeIslemlerEkrani()
        {

        }

        private void UyeIslemlerEkrani_Load(object sender, EventArgs e)
        {

            txt_tcKimlikNo.Text = tcKimlikNumarasi;
            //Profil Tab
            string profileQuery = "SELECT UyeAdi,UyeSoyadi,UyeCinsiyet,UyeKanGrubu,UyeSehir,UyeninDurumBilgisi,UyeMailAdresi,UyeTelefonNumarasi,UyeDogumTarihi " +
                                    $"FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
            using (SqlCommand command = new SqlCommand(profileQuery, connection.Connect()))
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txt_ad.Text = reader["UyeAdi"].ToString();
                    txt_soyad.Text = reader["UyeSoyadi"].ToString();
                    txt_cinsiyet.Text = reader["UyeCinsiyet"].ToString();
                    txt_kanGrubu.Text = reader["UyeKanGrubu"].ToString();
                    txt_sehir.Text = reader["UyeSehir"].ToString();
                    txt_mail.Text = reader["UyeMailAdresi"].ToString();
                    txt_telefonNo.Text = reader["UyeTelefonNumarasi"].ToString();
                    txt_dogumTarihi.Text = reader["UyeDogumTarihi"].ToString();
                    cbox_aktiflik.SelectedItem = reader["UyeninDurumBilgisi"].ToString();
                }
                reader.Close();
            }

            txt_ad.Enabled = false;
            txt_soyad.Enabled = false;
            txt_cinsiyet.Enabled = false;
            txt_kanGrubu.Enabled = false;
            txt_dogumTarihi.Enabled = false;
            txt_tcKimlikNo.Enabled = false;


            //Hesap Hareketleri Tab

            //Borç Bilgisi ve Son Odeme Tarihi goruntuleme
            string query = $@"
                        SELECT a.SonOdemeTarihi, b.BorcMiktari
                        FROM AidatTablosu a
                        LEFT JOIN BorcTablosu b ON a.TCKimlikNumarasi = b.TCKimlikNumarasi  WHERE a.TCKimlikNumarasi = '{tcKimlikNumarasi}'";
            using (SqlCommand command = new SqlCommand(query, connection.Connect()))
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // DateTime olarak tarihi al
                    DateTime sonOdemeTarihi = reader.GetDateTime(reader.GetOrdinal("SonOdemeTarihi"));

                    // Sadece gün, ay ve yıl bilgilerini al
                    string formattedDate = sonOdemeTarihi.ToString("dd.MM.yyyy");

                    lbl_borc.Text = reader["BorcMiktari"].ToString();
                    lbl_tarih.Text = formattedDate;

                }
                reader.Close();
            }

            //Odeme Gecmisi Tablosu
            DataTable OdemeDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT OdemeTarihi, OdemeMiktari FROM OdemeTablosu WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'", connection.Connect()))
            {
                dataAdapter.Fill(OdemeDT);
            }

            // DataGridView'e veriyi bağla
            dgv_odemeler.DataSource = OdemeDT;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            Sifreİslemleri sifre = new Sifreİslemleri(tcKimlikNumarasi);
            sifre.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            if (cbox_aktiflik.SelectedItem != null || string.IsNullOrEmpty(txt_sehir.Text) || string.IsNullOrEmpty(txt_mail.Text) || string.IsNullOrEmpty(txt_telefonNo.Text))
            {
                try
                {
                    string updateQuery = $"UPDATE UyeKayitTablosu SET UyeninDurumBilgisi = @UyeninDurumBilgisi,UyeSehir = @UyeSehir,UyeMailAdresi = @UyeMailAdresi,UyeTelefonNumarasi = @UyeTelefonNumarasi WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection.Connect()))
                    {
                        updateCommand.Parameters.AddWithValue("@UyeninDurumBilgisi", cbox_aktiflik.SelectedItem);
                        updateCommand.Parameters.AddWithValue("@UyeSehir", txt_sehir.Text);
                        updateCommand.Parameters.AddWithValue("@UyeMailAdresi", txt_mail.Text);
                        updateCommand.Parameters.AddWithValue("@UyeTelefonNumarasi", txt_telefonNo.Text);
                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Başarıyla güncellendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Alanı Seçiniz...");
            }

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            OdemeIslemleriEkrani odemeIslemleriEkrani = new OdemeIslemleriEkrani(tcKimlikNumarasi);
            odemeIslemleriEkrani.Show();
        }
    }
}
