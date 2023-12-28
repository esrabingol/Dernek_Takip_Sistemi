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

        private void BTN_Listele_Click(object sender, EventArgs e)
        {
            DateTime BaslangicTarihi = dateTimePicker_baslangic.Value;
            DateTime BitisTarihi = dateTimePicker_bitis.Value;

            try
            {
                string updateQuery = $"SELECT * FROM OdemeTablosu WHERE OdemeTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi";
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
                MessageBox.Show("İstenilen Tarihler arası ödeme yapılmamıştır.: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TSB_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            UyeBilgileriniListelemeİslemleri uyeislemleri = new UyeBilgileriniListelemeİslemleri();
            uyeislemleri.Show();
        }
    }
}
