using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dernek_Takip_Sistemi.Class1;

namespace Dernek_Takip_Sistemi
{
    public partial class UyeKayıtAlmaEkrani : Form
    {
        VeriTabaniBaglantisi connect;
        public UyeKayıtAlmaEkrani()
        {
            InitializeComponent();
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
                        using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO UyeKayitTablosu (TCKimlikNumarasi, UyeAdi, UyeSoyadi, UyeDogumTarihi, UyeCinsiyet, UyeKanGrubu, UyeSehir, UyeninDurumBilgisi, UyeninAylıkOdemeMiktari, UyeMailAdresi, UyeTelefonNumarasi) " +
                                                                       "VALUES (@TCKimlikNumarasi, @UyeAdi, @UyeSoyadi, @UyeDogumTarihi, @UyeCinsiyet, @UyeKanGrubu, @UyeSehir, @UyeninDurumBilgisi, @UyeninAylıkOdemeMiktari, @UyeMailAdresi, @UyeTelefonNumarasi)", connect.Connect()))
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

                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Dernek Sistemine Kayıt Başarılı.");

                            UyeBilgileriniListelemeİslemleri frm = new UyeBilgileriniListelemeİslemleri();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


            //else
            //{

            //    connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            //    DataTable personelDataT = new DataTable();//veri görüntülemek için datatable oluşturulur
            //    //sql deki tablonun c deki karşılığı bu tabloda olacaktır.
            //    SqlDataAdapter da = new SqlDataAdapter($"Select * from UyeKayitTablosu Where TCKimlikNumarasi = '{TckimliknoTB.Text}'", connect.Connect()); // sql connection dan connect() fonk çağrılır

            //    //ezber kullanım sqldataadapter 
            //    da.Fill(dataTable: personelDataT); //personelDataT doldurmak(fill) için 
            //    if (personelDataT.Rows.Count > 0)//personelDataT getirilen satır sayısı >0 ise demek ki önceden kayıt oluşturulmuş demektir
            //    {
            //        MessageBox.Show("Girdiğiniz TC Kimlik Numarası sisteme kayıtlıdır tekrar kontrol ediniz!");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            SqlDataAdapter daInsert = new SqlDataAdapter();
            //            string command = ($"INSERT INTO UyeKayitTablosu (TCKimlikNumarasi, UyeAdi, UyeSoyadi, UyeDogumTarihi,UyeCinsiyet,UyeKanGrubu,UyeSehir,UyeninDurumBilgisi,UyeninAylıkOdemeMiktari,UyeMailAdresi,UyeTelefonNumarasi) " +
            //                $"VALUES ('{TckimliknoTB.Text}', '{isimTB.Text}', '{soyisimTB.Text}', '{dogumtarihiTB.Text}','{CinsiyetCB.Text}','{KanGrubuLB.Text}','{UyelikDurumuCB.Text}',{AylikOdemeTB.Text},'{EPostaTB.Text}','{TelefonNumarasiTB.Text}','{SehirCB.Text}')");
            //            daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
            //            daInsert.InsertCommand.ExecuteNonQuery();//yazılan sorgu çalıştırıldı
            //            MessageBox.Show("Dernek Sistemine Kayıt Başarılı.");
            //            UyeBilgileriniListelemeİslemleri frm = new UyeBilgileriniListelemeİslemleri();
            //            frm.Show();
            //            this.Hide();

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //}

        }
    }
    }

