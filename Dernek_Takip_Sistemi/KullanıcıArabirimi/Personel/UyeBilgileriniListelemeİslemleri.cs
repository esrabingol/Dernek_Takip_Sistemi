using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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
using System.Xml.Linq;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi
{
    public partial class UyeBilgileriniListelemeİslemleri : Form
    {
        VeriTabaniBaglantisi connect;
        Boolean personelGirisMi;
        public UyeBilgileriniListelemeİslemleri()
        {
            InitializeComponent();
            this.personelGirisMi = true;
        }

        private void KanGrubu_BTN_Click(object sender, EventArgs e)
        {
            string kanGrubu;
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT UyeAdi,UyeKanGrubu FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);

            }

            ListelemeDGW.DataSource = UserDT;



        }

        private void SehirListele_BTN_Click(object sender, EventArgs e)
        {
            //string UyeSehirleri;

            if (sehirler_CB.SelectedItem != null)
            {
                string secilenSehir = sehirler_CB.SelectedItem.ToString(); // Seçilen şehri al
                connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
                DataTable UserDT = new DataTable();


                using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT UyeAdi,UyeSehir FROM UyeKayitTablosu WHERE UyeSehir = '{secilenSehir}'", connect.Connect()))
                {
                    dataAdapter.Fill(UserDT);
                }

                if(UserDT.Rows.Count>0)
                {
                    ListelemeDGW.DataSource = UserDT;

                }
                else
                {
                    MessageBox.Show("Seçilen Şehire ait kullanıcı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şehir seçin.");
            }
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
            UyeKayıtAlmaEkrani kayitAl = new UyeKayıtAlmaEkrani(personelGirisMi);
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

        private void UyeBilgileriniListelemeİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // PDF dosyası oluştur
                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Tablo oluştur
                Table table = new Table(ListelemeDGW.Columns.Count);

                // Sütun başlıklarını ekle
                foreach (DataGridViewColumn column in ListelemeDGW.Columns)
                {
                    Cell cell = new Cell().Add(new Paragraph(column.HeaderText));
                    table.AddHeaderCell(cell);
                }

                // DataGridView verilerini tabloya ekle
                foreach (DataGridViewRow row in ListelemeDGW.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString())));
                    }
                }

                // PDF'e tabloyu ekle
                document.Add(table);

                // PDF dosyasını kapat
                document.Close();
                pdf.Close();
            }
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "PDF Files|*.pdf";
            //saveFileDialog.Title = "Save as PDF";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = saveFileDialog.FileName;

            //    // DataGridView içeriğini PDF olarak kaydet
            //    using (PdfWriter writer = new PdfWriter(filePath)) //dosya yolu
            //    {
            //        using (PdfDocument pdf = new PdfDocument(writer))
            //        {
            //            Document document = new Document(pdf);

            //            // DataGridView içeriğini PDF'e ekle
            //            DataTable dataTable = new DataTable();
            //            foreach (DataGridViewColumn column in ListelemeDGW.Columns)
            //            {
            //                dataTable.Columns.Add(column.HeaderText);
            //            }

            //            foreach (DataGridViewRow row in ListelemeDGW.Rows)
            //            {
            //                DataRow dataRow = dataTable.NewRow();
            //                foreach (DataGridViewCell cell in row.Cells)
            //                {
            //                    dataRow[cell.ColumnIndex] = cell.Value;
            //                }
            //                dataTable.Rows.Add(dataRow);
            //            }

            //            foreach (DataRow dataRow in dataTable.Rows)
            //            {
            //                foreach (object item in dataRow.ItemArray)
            //                {
            //                    document.Add(new Paragraph(item.ToString()));
            //                }
            //            }
            //        }
            //    }
            //}
        }

        private void MailGonderBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailIslemleriEkrani mailIslemleri = new MailIslemleriEkrani();
            mailIslemleri.ShowDialog();
        }

        private void BorcDurumu_BTN_Click(object sender, EventArgs e)
        {

            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM BorcTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }
    }
}

