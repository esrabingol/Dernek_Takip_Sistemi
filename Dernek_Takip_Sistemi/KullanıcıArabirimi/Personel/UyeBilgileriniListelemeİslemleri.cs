using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel;
using iText.Layout;
using iText.Layout.Element;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi
{
    public partial class UyeBilgileriniListelemeİslemleri : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connect;
        public UyeBilgileriniListelemeİslemleri()
        {
            InitializeComponent();
			connect = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
		}

        private void UyeKayitBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Yeni formu oluştur ve göster
            UyeKayıtAlmaEkrani kayitAl = new UyeKayıtAlmaEkrani(true);
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
                                string cellValue = cell.Value.ToString(); // Hücre değerini string'e dönüştür

                                table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                            }
                            else
                            {
                                // Eğer hücre değeri null ise, nasıl işlem yapılacağını belirleyin
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

        private void TSB_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }

        private void BilgiYazdirBTN_Click(object sender, EventArgs e)
        {
            if(ListelemeDGW.Rows.Count>0)
            {       // Veritabanından verileri çekmiş olduğunuz DataGridView'i kullanarak yazdırma işlemini gerçekleştirin.
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yazdırmak İstediğiniz Tabloyu Listeleyiniz.");
            }
      
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

        private void guno_TumUyelerBTN_Click(object sender, EventArgs e)
        {
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT " +
                $"TCKimlikNumarasi,UyeAdi,UyeSoyadi,UyeCinsiyet,UyeKanGrubu,UyeSehir,UyeninDurumBilgisi,UyeninAylıkOdemeMiktari,UyeMailAdresi,UyeTelefonNumarasi,UyeDogumTarihi" +
                " FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }

        private void guno_SehreGoreListeleBtn_Click(object sender, EventArgs e)
        {
         
            if (sehirler_CB.SelectedItem != null)
            {
                string secilenSehir = sehirler_CB.SelectedItem.ToString(); // Seçilen şehri al
                DataTable UserDT = new DataTable();


                using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeSoyadi,UyeSehir FROM UyeKayitTablosu WHERE UyeSehir = '{secilenSehir}'", connect.Connect()))
                {
                    dataAdapter.Fill(UserDT);
                }

                if (UserDT.Rows.Count > 0)
                    ListelemeDGW.DataSource = UserDT;
                else
                    MessageBox.Show("Seçilen şehire ait kullanıcı bulunamadı.");
            }
            else
                MessageBox.Show("Lütfen bir şehir seçiniz.");
        }

        private void guno_TC_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TC_TBX.Text))
            {
                string tckimlik = TC_TBX.Text.ToString();
                DataTable UserDT = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT " +
                    $"TCKimlikNumarasi,UyeAdi,UyeSoyadi,UyeCinsiyet,UyeKanGrubu,UyeSehir,UyeninDurumBilgisi,UyeninAylıkOdemeMiktari,UyeMailAdresi,UyeTelefonNumarasi,UyeDogumTarihi " +
                    $"FROM UyeKayitTablosu WHERE TCKimlikNumarasi ='{tckimlik}'", connect.Connect()))
                {
                    dataAdapter.Fill(UserDT);
                }
                if (UserDT.Rows.Count > 0)
                    ListelemeDGW.DataSource = UserDT;
                else
                    MessageBox.Show("Girilen TC kimlik numarasına ait kullanıcı bulunamadı!");
            }
            else
                MessageBox.Show("Lütfen TC Kimlik Numarası Giriniz..");
        }

        private void guno_durumaGore_Click(object sender, EventArgs e)
        {
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeSoyadi, UyeninDurumBilgisi FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }

        private void guno_KanGrubu_Click(object sender, EventArgs e)
        {
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT TCKimlikNumarasi,UyeAdi,UyeSoyadi,UyeKanGrubu FROM UyeKayitTablosu", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }

            ListelemeDGW.DataSource = UserDT;
        }

        private void guno_BorcDurumu_Click(object sender, EventArgs e)
        {
            DataTable UserDT = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM BorcTablosu WHERE BorcMiktari <> 0", connect.Connect()))
            {
                dataAdapter.Fill(UserDT);
            }
            ListelemeDGW.DataSource = UserDT;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZedGraph_Sehirler zedGraph_Sehirler = new ZedGraph_Sehirler();
            zedGraph_Sehirler.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            TarihlerArasiOdemeDurumBilgisi durumBilgisi = new TarihlerArasiOdemeDurumBilgisi();
            durumBilgisi.Show();
        }

        private void guno_AylikZ_Click(object sender, EventArgs e)
        {
            this.Close();
            ZedGraph_AylikYillikOdeme zedGraph_AylikYillikOdeme = new ZedGraph_AylikYillikOdeme();
            zedGraph_AylikYillikOdeme.Show();
        }

        private void guno_YıillikZ_Click(object sender, EventArgs e)
        {
            this.Close();
            ZedGraph_YillikOdeme graph_YillikOdeme = new ZedGraph_YillikOdeme();
            graph_YillikOdeme.Show();
        }
    }
}