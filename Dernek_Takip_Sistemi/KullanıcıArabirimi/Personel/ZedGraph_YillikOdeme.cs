using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel
{
    public partial class ZedGraph_YillikOdeme : Form
    {
        VeriTabaniBaglantisi connect;
        public ZedGraph_YillikOdeme()
        {
            InitializeComponent();
        }

        private void ZedGraph_YillikOdeme_Load(object sender, EventArgs e)
        {
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable dataTable = new DataTable();



            try
            {
                if (connect != null && connect.Connect().State == ConnectionState.Closed)
                {
                    connect.Connect().Open();
                }

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT YEAR(OdemeTarihi) AS Yil, SUM(OdemeMiktari) AS ToplamOdeme FROM OdemeTablosu GROUP BY YEAR(OdemeTarihi)", connect.Connect()))
                {
                    dataAdapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                    decimal[] yillikToplam = new decimal[dataTable.Rows.Count];
                    string[] yillar = new string[dataTable.Rows.Count];

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        yillar[i] = dataTable.Rows[i]["Yil"].ToString();
                        yillikToplam[i] = Convert.ToDecimal(dataTable.Rows[i]["ToplamOdeme"]);
                    }

                    CreateYearlyGraph(yillikToplam, yillar);
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

        private void CreateYearlyGraph( decimal[] yillikToplam, string [] yillar)
        {
            GraphPane yillikGrafik = ZGC_YillikOdeme.GraphPane;
            yillikGrafik.Title.Text = "Yıllık Toplam Ödeme Miktarı";
            yillikGrafik.XAxis.Title.Text = "Yıllar";
            yillikGrafik.YAxis.Title.Text = "Toplam Gelir";

            BarItem bar = yillikGrafik.AddBar("Yıl", null, yillikToplam.Select(toplam => (double)toplam).ToArray(), Color.Red);
            yillikGrafik.XAxis.Scale.TextLabels = yillar;
            yillikGrafik.XAxis.Type = AxisType.Text;
         

            ZGC_YillikOdeme.AxisChange();
            ZGC_YillikOdeme.Invalidate();
        }

        private void TSB_RETURN_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri uyeBilgileriniListelemeİslemleri = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListelemeİslemleri.Show();
        }
    }
}
