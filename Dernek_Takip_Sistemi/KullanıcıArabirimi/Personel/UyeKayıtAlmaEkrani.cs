
using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Dernek_Takip_Sistemi
{
    public partial class UyeKayıtAlmaEkrani : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;

     

        Boolean personelGirismi = false;
        public UyeKayıtAlmaEkrani(Boolean personelGirismi)
        {
            InitializeComponent();
            this.personelGirismi = personelGirismi;
       

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void UKayitReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (personelGirismi)
            {
                UyeBilgileriniListelemeİslemleri giris = new UyeBilgileriniListelemeİslemleri();
                giris.ShowDialog();
            }
            else
            {
                UyeGirisEkrani giris = new UyeGirisEkrani();
                giris.ShowDialog();
            }

        }

        private void UyeYazdir_BTN_Click(object sender, EventArgs e)
        {
            // Bilgileri metin formatında bir değişkene topla
            string Tckimlik = TckimliknoTB.Text;
            string isim = isimTB.Text;
            string soyisim = soyisimTB.Text;
            string DogumTarihi = date_dogumTarihi.Text;
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
            if (personelGirismi)
            {
                txt_Sifre.Visible = false;
                lbl_Sifre.Visible = false;
                txt_sifreTekrar.Visible = false;
                lbl_sifreTekrar.Visible = false;
                chbox_parola.Visible= false;
            }
        }

        private void chbox_parola_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_parola.Checked)
            {
                txt_Sifre.PasswordChar = '\0';
                txt_sifreTekrar.PasswordChar = '\0';
            }
            else
            {
                txt_Sifre.PasswordChar = '*';
                txt_sifreTekrar.PasswordChar = '*';
            }
        }

        private void guno_kaydet_Click(object sender, EventArgs e)
        {
            if (personelGirismi)
            {
                txt_Sifre.Text = TckimliknoTB.Text;
                txt_sifreTekrar.Text = TckimliknoTB.Text;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txt_Sifre.Text))
                    MessageBox.Show("Şifre Alanı Boş Olamaz!");
                else if (String.IsNullOrWhiteSpace(txt_sifreTekrar.Text))
                    MessageBox.Show("Lütfen şifreyi tekrar giriniz");
                else if (txt_Sifre.Text != txt_sifreTekrar.Text)
                    MessageBox.Show("Şifreler eşleşmiyor!");
            }


            if (String.IsNullOrWhiteSpace(TckimliknoTB.Text)) //eğer null deseydik " " yani boş stringi veri kabul eder ve null olmazdı. Null olması için isNullOr..olur.
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(isimTB.Text))
                MessageBox.Show("isim Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(soyisimTB.Text))
                MessageBox.Show("Soyisim Alanı Boş Olamaz!");
            else if ((DateTime.Now - date_dogumTarihi.Value).TotalDays / 365 <= 10)
                MessageBox.Show("10 Yaşından Küçükler Üye Olamaz!");
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
                connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
                DataTable personelDataT = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{TckimliknoTB.Text}'", connection.Connect());

                da.Fill(personelDataT);

                if (personelDataT.Rows.Count > 0)
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik Numarası sisteme kayıtlıdır. Lütfen tekrar kontrol ediniz!");
                }
                else
                {
                    try
                    {
                        //uye kayit tablosu
                        using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO UyeKayitTablosu (TCKimlikNumarasi, UyeAdi, UyeSoyadi, UyeDogumTarihi, UyeCinsiyet, UyeKanGrubu, UyeSehir, UyeninDurumBilgisi, UyeninAylıkOdemeMiktari, UyeMailAdresi, UyeTelefonNumarasi, UyeSifre) " +
                                                                       "VALUES (@TCKimlikNumarasi, @UyeAdi, @UyeSoyadi, @UyeDogumTarihi, @UyeCinsiyet, @UyeKanGrubu, @UyeSehir, @UyeninDurumBilgisi, @UyeninAylıkOdemeMiktari, @UyeMailAdresi, @UyeTelefonNumarasi, @UyeSifre)", connection.Connect()))
                        {
                            sqlCommand.Parameters.AddWithValue("@TCKimlikNumarasi", TckimliknoTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeAdi", isimTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeSoyadi", soyisimTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeDogumTarihi", date_dogumTarihi.Value.Date);
                            sqlCommand.Parameters.AddWithValue("@UyeCinsiyet", CinsiyetCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeKanGrubu", KanGrubuLB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeSehir", SehirCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeninDurumBilgisi", UyelikDurumuCB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeninAylıkOdemeMiktari", AylikOdemeTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeMailAdresi", EPostaTB.Text);
                            sqlCommand.Parameters.AddWithValue("@UyeTelefonNumarasi", TelefonNumarasiTB.Text);

                            if (personelGirismi)
                                txt_Sifre.Text = TckimliknoTB.Text;

                            sqlCommand.Parameters.AddWithValue("@UyeSifre", txt_Sifre.Text);

                            sqlCommand.ExecuteNonQuery();


                        }

                        //borc tablosu
                        using (SqlCommand command = new SqlCommand("INSERT INTO BorcTablosu (TCKimlikNumarasi, BorcMiktari)" +
                                                                 $"VALUES ('{TckimliknoTB.Text}', '{AylikOdemeTB.Text}')", connection.Connect()))

                        {
                            command.ExecuteNonQuery();
                        }

                        // Aidat Tablosu
                        using (SqlCommand command = new SqlCommand("INSERT INTO AidatTablosu (TCKimlikNumarasi, AidatMiktari, SonOdemeTarihi)" +
                                                                   $"VALUES ('{TckimliknoTB.Text}', '{AylikOdemeTB.Text}', @SonOdemeTarihi) ", connection.Connect()))

                        {
                            // Şuanki tarihi
                            DateTime current = DateTime.Now;

                            // Bir sonraki ay
                            DateTime nextMonth = new DateTime(current.Year, current.Month, current.Day).AddMonths(1);


                            command.Parameters.AddWithValue("@SonOdemeTarihi", nextMonth);
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
    }
}
