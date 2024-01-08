using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataLayer;



namespace Dernek_Takip_Sistemi
{
    public partial class PersonelLogin : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;
        public PersonelLogin()
        {
            InitializeComponent();
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
        }

        private void sfregorCB_CheckedChanged(object sender, EventArgs e)
        {
			if (sfregorCB.Checked)
			{
				sfregorCB.Image = Properties.Resources.opened_eye;
				SifreTB.PasswordChar = '\0';
			}
			else
			{
				sfregorCB.Image = Properties.Resources.closed_eye;
				SifreTB.PasswordChar = '*';
			}
		}



        private void TSB_Personel_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void KullaniciAdiTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (PersonelAdiTB.Text == "Kullanıcı Adı")
            {
                PersonelAdiTB.Text = "";
                PersonelAdiTB.ForeColor = System.Drawing.SystemColors.WindowText; // Varsayılan metin rengi
            }
        }

        private void KullaniciAdiTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PersonelAdiTB.Text))
            {
                PersonelAdiTB.Text = "Kullanıcı Adı";
                PersonelAdiTB.ForeColor = System.Drawing.SystemColors.GrayText; // Gri renk ile göster
            }
        }

        private void guno_GirisBTN_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(PersonelAdiTB.Text))
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Olamaz!");
                return;
            }
            if (String.IsNullOrWhiteSpace(SifreTB.Text))
            {
                MessageBox.Show("Şifre Alanı Boş Olamaz!");
                return;
            }
            DataTable personelDataT = new DataTable();//veri görüntülemek için datatable oluşturulur
                                                      //sql deki tablonun c deki karşılığı bu tabloda olacaktır.
            SqlDataAdapter da = new SqlDataAdapter($"Select * from PersonelTablosu Where PersonelKullaniciAdi = '{PersonelAdiTB.Text}'", connection.Connect()); // sql connection dan connect() fonk çağrılır

            da.Fill(dataTable: personelDataT); //personelDataT doldurmak(fill) için



            if (personelDataT.Rows.Count > 0)//personelDataT getirilen satır sayısı >0 ise kullanıcı adı doğru
            {
                var sifre = personelDataT.Rows[0]["PersonelSifresi"].ToString();

                if (PersonelAdiTB.Text == "Personel1") //personel girişi
                {
                    if (SifreTB.Text == sifre)
                    {
                        UyeBilgileriniListelemeİslemleri listelemeİslemleri = new UyeBilgileriniListelemeİslemleri();
                        listelemeİslemleri.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
