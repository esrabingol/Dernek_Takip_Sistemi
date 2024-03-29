﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel
{ 
    public partial class TarihlerArasiOdemeDurumBilgisi : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;

        public TarihlerArasiOdemeDurumBilgisi()
        {
            InitializeComponent();
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
        }


        private void TSB_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri uyeislemleri = new UyeBilgileriniListelemeİslemleri();
            uyeislemleri.Show();
        }

        private void Guno_btn_Click(object sender, EventArgs e)
        {
            DateTime BaslangicTarihi = dateTimePicker_baslangic.Value;
            DateTime BitisTarihi = dateTimePicker_bitis.Value;

            try
            {
                string updateQuery = $"SELECT TCKimlikNumarasi, OdemeMiktari, OdemeTarihi FROM Odeme_Tablosu WHERE OdemeTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection.Connect()))
                {
                    updateCommand.Parameters.AddWithValue("@BaslangicTarihi", BaslangicTarihi);
                    updateCommand.Parameters.AddWithValue("@BitisTarihi", BitisTarihi);
                    updateCommand.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(updateCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView_listeleme.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstenilen tarihler arası ödeme yapılmamıştır." + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
