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
                PointPairList pointPairList = new PointPairList();

                for (int i = 0; i < UserDT.Rows.Count; i++)
                {
                    string x = UserDT.Rows[i]["UyeAdi"].ToString();
                    double y = i + 1; // Her şehir için artan bir sayı değeri

                    pointPairList.Add(i, y, x);
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

            // Grafik ayarları
            graphPane.Title.Text = "Üyelerin Şehirlere Göre Dağılımı";
            graphPane.XAxis.Title.Text = "Üye"; // Üye adları X ekseni
            graphPane.YAxis.Title.Text = "Şehir"; // Şehirler Y ekseni

            // Nokta grafiği oluşturma ve noktaların etiketlenmesi
            LineItem myCurve = graphPane.AddCurve("Veri", pointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            myCurve.Line.IsVisible = false; // Çizgiyi gizleyerek sadece noktaları gösterme
            myCurve.Symbol.Fill = new Fill(Color.Blue); // Noktaların rengini belirleme

            // Noktaların etiketlerini ekleme
            for (int i = 0; i < pointPairs.Count; i++)
            {
                TextObj text = new TextObj(pointPairs[i].Tag.ToString(), pointPairs[i].X, pointPairs[i].Y, CoordType.AxisXYScale, AlignH.Left, AlignV.Center);
                text.FontSpec.FontColor = Color.Black; // Etiket rengini belirleme
                text.FontSpec.Size = 8; // Etiket boyutunu ayarlama
                graphPane.GraphObjList.Add(text);
            }

            // Grafik görünümü ayarları
            graphPane.Chart.Fill = new Fill(System.Drawing.Color.White, System.Drawing.Color.LightGray, 45.0f);
            zedGraphControl1.AxisChange();
        }

        private void geridon_TSB_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri uyeBilgileriniListeleme = new UyeBilgileriniListelemeİslemleri();
            uyeBilgileriniListeleme.Show();
        }
    }
}
