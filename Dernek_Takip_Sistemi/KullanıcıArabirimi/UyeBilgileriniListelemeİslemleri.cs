using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi
{
    public partial class UyeBilgileriniListelemeİslemleri : Form
    {
        VeriTabaniBaglantisi connect;

        public UyeBilgileriniListelemeİslemleri()
        {
            InitializeComponent();
        }

        private void KanGrubu_BTN_Click(object sender, EventArgs e)
        {
            string kanGrubu;
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT UyeAdi,UyeKanGrubu FROM UyeKayitTablosu",connect.Connect()))
            {
                dataAdapter.Fill(UserDT);

            }    

            ListelemeDGW.DataSource= UserDT;



        }

        private void SehirListele_BTN_Click(object sender, EventArgs e)
        {
            string UyeSehirleri;
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT UyeAdi,UyeSehir FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }

        private void DurumBTN_Click(object sender, EventArgs e)
        {
            string UyeDurum;
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT UyeAdi,UyeninDurumBilgisi FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }

     
        private void UyeKayitBTN_Click(object sender, EventArgs e)
        {
          

            this.Hide();

            // Yeni formu oluştur ve göster
            UyeKayıtAlmaEkrani kayitAl = new UyeKayıtAlmaEkrani();
            kayitAl.ShowDialog();

            // Form2 kapatıldığında tekrar Form1'i göster
            this.Show();

        }

        private void UyeSilBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            UyeSilGüncelleEkrani uyeSilme = new UyeSilGüncelleEkrani();
            uyeSilme.ShowDialog();

        }

        private void UyeGuncelleBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            UyeSilGüncelleEkrani uyeGuncelle = new UyeSilGüncelleEkrani();
            uyeGuncelle.ShowDialog();
        }

        private void TumUyeleriGorBTN_Click(object sender, EventArgs e)
        {
           
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;

        }
    }
}
