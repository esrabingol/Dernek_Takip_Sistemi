//using iText.IO.Font.Constants;
//using iText.Kernel.Pdf;
using iTextSharp.text;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
//using System.Linq;
//using System.Runtime.Remoting.Contexts;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Dernek_Takip_Sistemi.Class1;


namespace Dernek_Takip_Sistemi
{
    public partial class UyeKayıtAlmaEkrani : Form
    {
        VeriTabaniBaglantisi connect;
        Boolean personelGirismi = false;
        public UyeKayıtAlmaEkrani(Boolean personelGirismi)
        {
            InitializeComponent();
            this.personelGirismi = personelGirismi;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KaydetBTN_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TckimliknoTB.Text)) //eğer null deseydik " " yani boş stringi veri kabul eder ve null olmazdı. Nulll olması için isNullOr..olur.
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(isimTB.Text))
                MessageBox.Show("isim Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(soyisimTB.Text))
                MessageBox.Show("Soyisim Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(dogumtarihiTB.Text))
                MessageBox.Show("Doğum Tarihi Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(CinsiyetCB.Text))
                MessageBox.Show("Cinsiyet Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(KanGrubuLB.Text))
                MessageBox.Show("Kan Grubu  Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(UyelikDurumuCB.Text))
                MessageBox.Show("Uyelik Durumu  Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(AylikOdemeTB.Text))
                MessageBox.Show("Aylık Odeme  Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(EPostaTB.Text))
                MessageBox.Show("E-Posta  Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(TelefonNumarasiTB.Text))
                MessageBox.Show("Telefon Numarası  Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(SehirCB.Text))
                MessageBox.Show("Şehir  Alanı Boş Olamaz!");
            else
            {
                connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
                DataTable personelDataT = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{TckimliknoTB.Text}'", connect.Connect());

                da.Fill(personelDataT);

                if (personelDataT.Rows.Count > 0)
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik Numarası sisteme kayıtlıdır. Lütfen tekrar kontrol ediniz!");
                }
                else
                {
                    try
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO UyeKayitTablosu (TCKimlikNumarasi, UyeAdi, UyeSoyadi, UyeDogumTarihi, UyeCinsiyet, UyeKanGrubu, UyeSehir, UyeninDurumBilgisi, UyeninAylıkOdemeMiktari, UyeMailAdresi, UyeTelefonNumarasi, UyeSifre) " +
                                                                       "VALUES (@TCKimlikNumarasi, @UyeAdi, @UyeSoyadi, @UyeDogumTarihi, @UyeCinsiyet, @UyeKanGrubu, @UyeSehir, @UyeninDurumBilgisi, @UyeninAylıkOdemeMiktari, @UyeMailAdresi, @UyeTelefonNumarasi, @UyeSifre)", connect.Connect()))
                        {
                            sqlCommand.Parameters.AddWithValue("@TCKimlikNumarasi", TckimliknoTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeAdi", isimTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeSoyadi", soyisimTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeDogumTarihi", dogumtarihiTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeCinsiyet", CinsiyetCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeKanGrubu", KanGrubuLB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeSehir", SehirCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeninDurumBilgisi", UyelikDurumuCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeninAylıkOdemeMiktari", AylikOdemeTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeMailAdresi", EPostaTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeTelefonNumarasi", TelefonNumarasiTB.Text);

                            if(personelGirismi)
                                txt_Sifre.Text = TckimliknoTB.Text;

                            sqlCommand.Parameters.AddWithValue("@UyeSifre", txt_Sifre.Text);

                            sqlCommand.ExecuteNonQuery();

                            
                        }

                        string insertQuery = $"INSERT INTO BorcTablosu (TCKimlikNumarasi, BorcMiktari) VALUES ('{TckimliknoTB.Text}', 0)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connect.Connect()))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Dernek Sistemine Kayıt Başarılı.");

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void UKayitReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeBilgileriniListelemeİslemleri giris = new UyeBilgileriniListelemeİslemleri();
            giris.ShowDialog();

        }

        private void UyeYazdir_BTN_Click(object sender, EventArgs e)
        {
            // Bilgileri metin formatında bir değişkene topla
            string Tckimlik = TckimliknoTB.Text;
            string isim = isimTB.Text;
            string soyisim = soyisimTB.Text;
            string DogumTarihi = dogumtarihiTB.Text;
            string cinsiyet = CinsiyetCB.Text;
            string UyeKanGrubu = KanGrubuLB.Text;
            string sehir = SehirCB.Text;
            string UyelikDurumu = UyelikDurumuCB.Text;
            string AylikOdeme = AylikOdemeTB.Text;
            string EPosta = EPostaTB.Text;
            string TelefonNumarasi = TelefonNumarasiTB.Text;

            string textToPrint = $"TC Kimlik Numarasi: {Tckimlik}\n" +
                                 $"Isim: {isim}\n" +
                                 $"Soyisim: {soyisim}\n" +
                                 $"Dogum Tarihi: {DogumTarihi}\n" +
                                 $"Cinsiyet: {cinsiyet}\n" +
                                 $"Uye Kan Grubu: {UyeKanGrubu}\n" +
                                 $"Uyelik Durumu: {UyelikDurumu}\n" +
                                 $"Aylik Odeme : {AylikOdeme}\n" +
                                 $"Uye Eposta: {EPosta}\n" +
                                 $"Telefon Numarasi : {TelefonNumarasi}\n";

            // Kullanıcıya dosya kaydetme penceresi aç
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Seçilen dosya yoluna bilgileri yaz
                File.WriteAllText(filePath, textToPrint);
            }

        }

        private void UyeKayıtAlmaEkrani_Load(object sender, EventArgs e)
        {
            if (personelGirismi == true)
            {
                txt_Sifre.Visible = false;
                lbl_Sifre.Visible = false;
            }
        }
    }
}
