using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    public partial class OdemeIslemleriEkrani : Form
    {
        String tcKimlikNumarasi;
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;

        public OdemeIslemleriEkrani(string tcKimlikNumarasi)
        {
            InitializeComponent();
            this.tcKimlikNumarasi = tcKimlikNumarasi;
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OdenecekTutar_TB.Text))
            {
                OdenecekTutar_TB.Text = "0,0";
                OdenecekTutar_TB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
            }

            try
            {
                string query = @"
					SELECT 
						COALESCE(BorcTablosu.BorcMiktari, 0) AS BorcMiktari,
						COALESCE(AidatTablosu.AidatMiktari, 0) AS AidatMiktari
					FROM 
						BorcTablosu
					FULL OUTER JOIN 
						AidatTablosu ON BorcTablosu.TCKimlikNumarasi = AidatTablosu.TCKimlikNumarasi
					WHERE 
						BorcTablosu.TCKimlikNumarasi = @TCKimlikNumarasi
						OR AidatTablosu.TCKimlikNumarasi = @TCKimlikNumarasi;
				";

                using (SqlCommand command = new SqlCommand(query, connection.Connect()))
                {
                    command.Parameters.AddWithValue("@TCKimlikNumarasi", tcKimlikNumarasi);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal borcMiktari = reader.GetDecimal(0);
                        decimal aidatMiktari = reader.GetDecimal(1);

                        lbl_borc.Text = $"{borcMiktari:C}";
                        lbl_aidat.Text = $"{aidatMiktari:C}";
                    }
                    else
                    {
                        lbl_borc.Text = "Borç bilgisi bulunamadı";
                        lbl_aidat.Text = "Aidat bilgisi bulunamadı";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aidat bilgisi çekilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OdenecekTutar_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Giriş yapılan karakter numerik bir karakter (0-9) veya virgül (,) ise izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bu karaktere izin verme
            }

            // Sadece bir tane virgül izin ver
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; // Birden fazla virgülü engelle
            }
        }

        private void OdenecekTutar_TB_MouseClick(object sender, MouseEventArgs e)
        {
            if (OdenecekTutar_TB.Text == "0,0")
            {
                OdenecekTutar_TB.Text = "";
                OdenecekTutar_TB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
			UyeIslemlerEkrani uyeIslemlerEkrani = new UyeIslemlerEkrani(tcKimlikNumarasi);
            uyeIslemlerEkrani.OpenTab2();
			uyeIslemlerEkrani.Show();
		}

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (OdenecekTutar_TB.Text != null)
            {
                try
                {
                    // OdemeTablosu'na yeni ödeme ekle
                    string odemeQuery = "INSERT INTO Odeme_Tablosu (TCKimlikNumarasi, OdemeMiktari, OdemeTarihi) VALUES (@TCKimlikNumarasi, @OdemeMiktari, @OdemeTarihi)";
                    using (SqlCommand insertCommand = new SqlCommand(odemeQuery, connection.Connect()))
                    {
                        insertCommand.Parameters.AddWithValue("@TCKimlikNumarasi", tcKimlikNumarasi);
                        insertCommand.Parameters.AddWithValue("@OdemeMiktari", Convert.ToDecimal(OdenecekTutar_TB.Text));
                        insertCommand.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Ödemeniz başarıyla gerçekleştirildi.");
                    }

                    //BorcTablosu'nu güncelle
                    string updateQuery = $"UPDATE BorcTablosu SET BorcMiktari = BorcMiktari - @OdenenMiktar WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection.Connect()))
                    {
                        updateCommand.Parameters.AddWithValue("@OdenenMiktar", Convert.ToDecimal(OdenecekTutar_TB.Text));
                        updateCommand.ExecuteNonQuery();
                    }

                    this.Close();
				}
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Ödenecek tutar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

		private void OdemeIslemleriEkrani_FormClosing(object sender, FormClosingEventArgs e)
		{
            UyeIslemlerEkrani uyeIslemlerEkrani = new UyeIslemlerEkrani(tcKimlikNumarasi);
            uyeIslemlerEkrani.Show();
		}
	}
}
