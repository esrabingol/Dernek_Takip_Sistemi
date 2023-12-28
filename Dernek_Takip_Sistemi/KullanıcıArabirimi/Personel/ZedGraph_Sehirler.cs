using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    public partial class ZedGraph_Sehirler : Form
    { VeriTabaniBaglantisi connect;

        public ZedGraph_Sehirler()
        {
           
            InitializeComponent();
        }
       


        private void ZedGraph_Sehirler_Load(object sender, EventArgs e)
        {
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UyeAdi, UyeSehir FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            if (UserDT != null && UserDT.Rows.Count > 0)
            {
                Dictionary<string, int> sehirSayisi = new Dictionary<string, int>();

                foreach (DataRow row in UserDT.Rows)
                {
                    string sehir = row["UyeSehir"].ToString();
                    if (!sehirSayisi.ContainsKey(sehir))
                    {
                        sehirSayisi.Add(sehir, 1);
                    }
                    else
                    {
                        sehirSayisi[sehir]++;
                    }
                }

                PointPairList pointPairList = new PointPairList();

                int x = 1; // Sütunlar arasındaki boşluğu sağlamak için 1'den başlatıyoruz
                foreach (var kvp in sehirSayisi)
                {
                    string sehir = kvp.Key;
                    int kullaniciSayisi = kvp.Value;

                    pointPairList.Add(x, kullaniciSayisi, sehir);
                    x += 2; // Her sütun sonrası 1 boşluk bırakmak için
                }

                CreateGraphics(zedGraphControl1, pointPairList);
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
            }
        }

        private void CreateGraphics(ZedGraphControl zedGraphControl1, PointPairList pointPairs)
        {
            GraphPane graphPane = zedGraphControl1.GraphPane;

            graphPane.Title.Text = "Üyelerin Şehirlere Göre Dağılımı";
            graphPane.XAxis.Title.Text = "Şehir";
            graphPane.YAxis.Title.Text = "Üye Sayısı";

            BarItem bar = graphPane.AddBar("Üye Sayısı", pointPairs, Color.Green);
            bar.Bar.Fill = new Fill(Color.Blue);

            graphPane.XAxis.Type = AxisType.Text; // X eksenini metin tipine ayarla

            // X ekseninde şehir isimlerini gösterme
            string[] labels = new string[pointPairs.Count];
            for (int i = 0; i < pointPairs.Count; i++)
            {
                labels[i] = pointPairs[i].Tag.ToString();
            }
            graphPane.XAxis.Scale.TextLabels = labels;

            // Y eksenini int formatına ayarla
            graphPane.YAxis.Scale.Format = "F0"; // Y eksenindeki sayıları tam sayı olarak göstermek için
            graphPane.YAxis.Scale.MajorStep = 1; // Y eksenindeki büyük çizgilerin aralığını ayarla
            graphPane.YAxis.Type = AxisType.Linear; // Y eksenini lineer tipine ayarla

            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            zedGraphControl1.AxisChange();
            //GraphPane graphPane = zedGraphControl1.GraphPane;

            //graphPane.Title.Text = "Üyelerin Şehirlere Göre Dağılımı";
            //graphPane.XAxis.Title.Text = "Şehir";
            //graphPane.YAxis.Title.Text = "Üye Sayısı";

            //BarItem bar = graphPane.AddBar("Üye Sayısı", pointPairs, Color.Green);
            //bar.Bar.Fill = new Fill(Color.Blue);

            //graphPane.XAxis.Type = AxisType.Text; // X eksenini metin tipine ayarla

            //// X ekseninde şehir isimlerini gösterme
            //string[] labels = new string[pointPairs.Count];
            //for (int i = 0; i < pointPairs.Count; i++)
            //{
            //    labels[i] = pointPairs[i].Tag.ToString();
            //}
            //graphPane.XAxis.Scale.TextLabels = labels;

            //graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            //zedGraphControl1.AxisChange();
        }

        private void geridon_TSB_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri uyeBilgileriniListeleme = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListeleme.Show();
        }
    }
}
