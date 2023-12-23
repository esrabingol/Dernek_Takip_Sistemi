using Microsoft.VisualBasic.ApplicationServices;
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
using ZedGraph;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class ZedGraph_AylikYillikOdeme : Form
    {
        VeriTabaniBaglantisi connect;
        public ZedGraph_AylikYillikOdeme()
        {
            InitializeComponent();
        }

        private void ZedGraph_AylikYillikOdeme_Load(object sender, EventArgs e)
        {

            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable dataTable = new DataTable();


            try
            {
                if (connect != null && connect.Connect().State == ConnectionState.Closed)
                {
                    connect.Connect().Open();
                }

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT OdemeMiktari, MONTH(OdemeTarihi) AS Ay FROM OdemeTablosu", connect.Connect()))
                {
                    dataAdapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                    decimal[] aylikGelir = new decimal[12]; // 12 ay için dizi oluşturuyoruz

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int ay = Convert.ToInt32(row["Ay"]);
                        decimal odemeMiktari = Convert.ToDecimal(row["OdemeMiktari"]);

                        // Ayın indisine göre ilgili ayın ödeme miktarını topluyoruz
                        aylikGelir[ay - 1] += odemeMiktari;
                    }

                    // Aylık grafik oluşturma
                    CreateMonthlyGraph(aylikGelir);

                
                }
                else
                {
                    MessageBox.Show("Veritabanından alınacak veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri alımı sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connect != null && connect.Connect().State == ConnectionState.Open)
                {
                    connect.Connect().Close();
                }
            }
        }

        private void CreateMonthlyGraph(decimal[] aylikGelir)
        {
            GraphPane graphPane = zedGraphControl_aylikodeme.GraphPane;
            graphPane.Title.Text = "Aylık Aidat Geliri";
            graphPane.XAxis.Title.Text = "Ay";
            graphPane.YAxis.Title.Text = "Gelir";

            BarItem bar = graphPane.AddBar("Aylık Gelir", null, aylikGelir.Select(gelir => Convert.ToDouble(gelir)).ToArray(), Color.Blue);
            bar.Bar.Fill = new Fill(Color.Blue);
            bar.Label.IsVisible = true; // Sütunların üzerindeki etiketleri göstermek için

            string[] ayAdlari = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            graphPane.XAxis.Scale.TextLabels = ayAdlari; // X ekseni etiketleri olarak ayları kullanma
            graphPane.XAxis.Type = AxisType.Text; // X ekseni tipini metin olarak ayarlama

            zedGraphControl_aylikodeme.AxisChange();
            zedGraphControl_aylikodeme.Invalidate();


        }

        private void TSB_RETURN_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri ublistele = new UyeBilgileriniListelemeİslemleri();
            ublistele.Show();

        }
    }
}
