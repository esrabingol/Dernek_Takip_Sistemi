using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dernek_Takip_Sistemi.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Dernek_Takip_Sistemi
{
    public partial class PersonelLogin : Form
    {
        public PersonelLogin()
        {
            InitializeComponent();
        }

        private void txtBox_prsonelnumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBox_prsonelpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            VeriTabaniBaglantisi connect;

            if (String.IsNullOrWhiteSpace(KullaniciAdiTB.Text))
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Olamaz!");
                return;
            }
            if (String.IsNullOrWhiteSpace(SifreTB.Text))
            {
                MessageBox.Show("Şifre Alanı Boş Olamaz!");
                return;
            }
            connect = new VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
            DataTable kullaniciDataT = new DataTable();//veri görüntülemek için datatable oluşturulur
                                                       //sql deki tablonun c deki karşılığı bu tabloda olacaktır.
            SqlDataAdapter da = new SqlDataAdapter($"Select * from PersonelTablosu Where PersonelKullaniciAdi = '{KullaniciAdiTB.Text}'", connect.Connect()); // sql connection dan connect() fonk çağrılır

            da.Fill(dataTable: kullaniciDataT); //kullaniciDataT doldurmak(fill) için



            if (kullaniciDataT.Rows.Count > 0)//kullaniciDataT getirilen satır sayısı >0 ise kullanıcı adı doğru
            {
                var sifre = kullaniciDataT.Rows[0]["PersonelSifresi"].ToString();

                if (KullaniciAdiTB.Text == "Admin") //admin girişi
                {
                    if (SifreTB.Text == sifre)
                    {

                        MessageBox.Show("Personel Giriş Başarılı, Hoşgeldiniz");
                        UyeKayıtAlmaEkrani frm = new UyeKayıtAlmaEkrani();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }




            }
        }

        private void sfregorCB_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (sfregorCB.Checked)
            {
                //karakteri göster.
                SifreTB.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                SifreTB.PasswordChar = '*';
            }
        }
    }
}
