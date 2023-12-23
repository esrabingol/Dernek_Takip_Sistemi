using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeKanGrubu FROM UyeKayitTablosu", connect.Connect()))
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


                using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeSehir FROM UyeKayitTablosu WHERE UyeSehir = '{secilenSehir}'", connect.Connect()))
                {
                    dataAdapter.Fill(UserDT);
                }

                if (UserDT.Rows.Count > 0)
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

        private void Listele_BTN_Click(object sender, EventArgs e)
        {
            if (TC_TBX.Text != null)
            {
                string tckimlik = TC_TBX.Text.ToString();
                connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
                DataTable UserDT = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select* from UyeKayitTablosu WHERE TCKimlikNumarasi ='{tckimlik}'", connect.Connect()))
                {
                    dataAdapter.Fill(UserDT);
                }
                if (UserDT.Rows.Count > 0)
                {
                    ListelemeDGW.DataSource = UserDT;
                }
                else
                {
                    MessageBox.Show("Seçilen Tc Numarasına ait kullanıcı Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Tc Kimlik Numarası Giriniz ..");
            }
            }
        

        private void DurumBTN_Click(object sender, EventArgs e)
        {
            string UyeDurum;
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeninDurumBilgisi FROM UyeKayitTablosu", connect.Connect()))
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
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // PDF dosyası oluştur
                    iText.Kernel.Pdf.PdfWriter writer = new iText.Kernel.Pdf.PdfWriter(filePath);
                    iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Tablo oluştur
                    Table table = new Table(ListelemeDGW.Columns.Count);

                    // Sütun başlıklarını ekle
                    foreach (DataGridViewColumn column in ListelemeDGW.Columns)
                    {
                        Cell cell = new Cell().Add(new Paragraph(column.HeaderText));
                        table.AddHeaderCell(cell);
                    }

                    foreach (DataGridViewRow row in ListelemeDGW.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                // Örnek olarak, string bir türe dönüştürme işlemi:
                                string cellValue = cell.Value.ToString(); // Hücre değerini string'e dönüştür

                                // Burada cellValue değerini PDF'e eklemek için kullanabilirsiniz
                                table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                            }
                            else
                            {
                                // Eğer hücre değeri null ise, nasıl işlem yapılacağını belirleyin
                                // Örneğin, boş bir değer ekleyebilirsiniz:
                                table.AddCell(new Cell().Add(new Paragraph("")));
                            }
                        }
                    }

                    // PDF'e tabloyu ekle
                    document.Add(table);

                    // PDF dosyasını kapat
                    document.Close();
                    pdf.Close();

                    MessageBox.Show("PDF dosyası başarıyla oluşturuldu!");
                }
            }
            catch (PdfException ex)
            {
                MessageBox.Show("PDF oluşturma hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
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

        private void ZG_Sehirler_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZedGraph_Sehirler zedGraph_Sehirler = new ZedGraph_Sehirler();
            zedGraph_Sehirler.Show();
        }

        private void TSB_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }

        private void BilgiYazdirBTN_Click(object sender, EventArgs e)
        {
            // Veritabanından verileri çekmiş olduğunuz DataGridView'i kullanarak yazdırma işlemini gerçekleştirin.
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // DataGridView'deki verileri almak için bir DataTable kullandığınızı varsayalım
            DataTable table = (DataTable)ListelemeDGW.DataSource;

            float currentY = 0;
            int rowHeight = 0;
            int columnIndex = 0;

            // Sütun başlıklarını yazdır
            foreach (DataGridViewColumn column in ListelemeDGW.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, ListelemeDGW.Font, Brushes.Black, new PointF(columnIndex * 100, currentY));
                columnIndex++;
            }
            currentY += ListelemeDGW.ColumnHeadersHeight;

            // Her satırı yazdır
            foreach (DataRow row in table.Rows)
            {
                columnIndex = 0;
                foreach (DataColumn col in table.Columns)
                {
                    e.Graphics.DrawString(row[col].ToString(), ListelemeDGW.Font, Brushes.Black, new PointF(columnIndex * 100, currentY));
                    columnIndex++;
                }
                rowHeight = ListelemeDGW.Rows[0].Height;
                currentY += rowHeight;
            }
        }

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_ODEMEDURUM_Click(object sender, EventArgs e)
        {
            this.Close();
            TarihlerArasiOdemeDurumBilgisi durumBilgisi = new TarihlerArasiOdemeDurumBilgisi();
            durumBilgisi.Show();


        }

        private void BTN_AylikYillikZedgraph_Click(object sender, EventArgs e)
        {
            this.Close();
            ZedGraph_AylikYillikOdeme graph_AylikYillikOdeme = new ZedGraph_AylikYillikOdeme();
            graph_AylikYillikOdeme.Show();
        }
    }
}


