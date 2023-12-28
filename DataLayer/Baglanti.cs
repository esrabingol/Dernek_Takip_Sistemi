using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Windows.Forms;

namespace DataLayer
{
    public class Baglanti
    {

        public class VeriTabaniBaglantisi
        {
            SqlConnection baglan;
            private string dynamicConnectionString;
            string connectionString = string.Empty;
            public VeriTabaniBaglantisi(string dbName)
            {
                dynamicConnectionString = dbName;
            }
            public SqlConnection Connect()
            {
                if (baglan?.State != ConnectionState.Open)
                {
                    connectionString = $"Data Source=LAPTOP-IPQTP7GR;Initial Catalog={dynamicConnectionString};Integrated Security=True";

                    baglan = new SqlConnection(connectionString);
                    baglan.Open();
                }

                return baglan;
            }

            public void UpdatePaymentSystem()
            {
                VeriTabaniBaglantisi connection = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");

                try
                {
                    // UyeKayitTablosu, AidatTablosu ve BorcTablosu'nu birleştirerek verileri çek
                    string query = @"
                        SELECT u.TCKimlikNumarasi, a.AidatMiktari, a.SonOdemeTarihi, b.BorcMiktari
                        FROM UyeKayitTablosu u
                        LEFT JOIN AidatTablosu a ON u.TCKimlikNumarasi = a.TCKimlikNumarasi
                        LEFT JOIN BorcTablosu b ON u.TCKimlikNumarasi = b.TCKimlikNumarasi";

                    using (SqlCommand command = new SqlCommand(query, connection.Connect()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tcKimlikNumarasi = reader["TCKimlikNumarasi"].ToString();
                                decimal aidatMiktari = Convert.ToDecimal(reader["AidatMiktari"]);
                                decimal borcMiktari = Convert.ToDecimal(reader["BorcMiktari"]);
                                DateTime sonOdemeTarihi = reader.GetDateTime(reader.GetOrdinal("SonOdemeTarihi"));

                                // Bugün
                                //DateTime current = DateTime.Now;
                                DateTime current = new DateTime(2024, 01, 29);
                                // Son Odeme Tarihi Gecmis mi
                                int result = DateTime.Compare(current, sonOdemeTarihi);

                                if (result > 0) //Son odeme tarihini geçince
                                {
                                    // Bir sonraki ay
                                    DateTime nextMonth = new DateTime(current.Year, current.Month, current.Day).AddMonths(1);

                                    // yeni son ödeme tarihi ile güncelle
                                    string updateOdemeTarihiQuery = $"UPDATE AidatTablosu SET SonOdemeTarihi = '{nextMonth:yyyy-MM-dd}' WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                                    using (SqlCommand odemeTarihiCommand = new SqlCommand(updateOdemeTarihiQuery, Connect()))
                                    {
                                        odemeTarihiCommand.ExecuteNonQuery();
                                    }

                                    //Borcu varsa (aidat odenmemisse)
                                    if (borcMiktari > 0)
                                    {
                                        // aidata %5 zam yap
                                        aidatMiktari = aidatMiktari * 1.05m;
                                        string updateAidatMiktariQuery = $"UPDATE AidatTablosu SET AidatMiktari = {aidatMiktari.ToString(System.Globalization.CultureInfo.InvariantCulture)} WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                                        using (SqlCommand aidatMiktariCommand = new SqlCommand(updateAidatMiktariQuery, Connect()))
                                        {
                                            aidatMiktariCommand.ExecuteNonQuery();
                                        }
                                    }

                                    //Borc miktarini yeni aidat miktarini ekleyerek guncele
                                    decimal yeniBorc = borcMiktari + aidatMiktari;
                                    string updateBorcMiktariQuery = $"UPDATE BorcTablosu SET BorcMiktari = {yeniBorc.ToString(System.Globalization.CultureInfo.InvariantCulture)} WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                                    using (SqlCommand borcMiktariCommand = new SqlCommand(updateBorcMiktariQuery, Connect()))
                                    {
                                        borcMiktariCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }
    }

    }

