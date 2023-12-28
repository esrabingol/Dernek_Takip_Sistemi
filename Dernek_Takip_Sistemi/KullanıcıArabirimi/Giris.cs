using Dernek_Takip_Sistemi.KullanıcıArabirimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi
{
    public partial class Giris : Form
    {
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;


        public Giris()
        {
           
            InitializeComponent();
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");

        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
         

            this.Hide();

            // Yeni formu oluştur ve göster
            PersonelLogin personelLogin = new PersonelLogin();
            personelLogin.ShowDialog();

  
        }

        private void btn_Uye_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeGirisEkrani uyeGiris = new UyeGirisEkrani();
            uyeGiris.ShowDialog();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            connection.UpdatePaymentSystem();
        }
    }
}
