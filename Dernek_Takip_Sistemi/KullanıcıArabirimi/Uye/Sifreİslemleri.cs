using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    public partial class Sifreİslemleri : Form
    {
        string tcKimlikNumarasi;
        DataLayer.Baglanti.VeriTabaniBaglantisi connection;
        public Sifreİslemleri(string tcKimlikNumarasi)
        {
            InitializeComponent();
            this.tcKimlikNumarasi = tcKimlikNumarasi;
            connection = new DataLayer.Baglanti.VeriTabaniBaglantisi("Dernek_Takip_Sistemi");
        }

        private void chbox_mevcutParola_CheckedChanged(object sender, EventArgs e)
        {
			if (chbox_mevcutParola.Checked)
            {
				chbox_mevcutParola.Image = Properties.Resources.opened_eye;
				txt_eskiSifre.PasswordChar = '\0';
			}
            else
            {
				chbox_mevcutParola.Image = Properties.Resources.closed_eye;
				txt_eskiSifre.PasswordChar = '*';
			}
		}

		private void chbox_yeniParola_CheckedChanged(object sender, EventArgs e)
        {
			if (chbox_yeniParola.Checked)
			{
				chbox_yeniParola.Image = Properties.Resources.opened_eye;
				txt_yeniSifre.PasswordChar = '\0';
			}
			else
			{
				chbox_yeniParola.Image = Properties.Resources.closed_eye;
				txt_yeniSifre.PasswordChar = '*';
			}
		}

		private void chbox_tekrarParola_CheckedChanged(object sender, EventArgs e)
        {
			if (chbox_tekrarParola.Checked)
			{
				chbox_tekrarParola.Image = Properties.Resources.opened_eye;
				txt_sifreTekrar.PasswordChar = '\0';
			}
			else
			{
				chbox_tekrarParola.Image = Properties.Resources.closed_eye;
				txt_sifreTekrar.PasswordChar = '*';
			}
		}

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string veritabaniSifre;

            // Veritabanından mevcut şifreyi al
            string passwordQuery = $"SELECT UyeSifre FROM UyeKayitTablosu WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
            using (SqlCommand command = new SqlCommand(passwordQuery, connection.Connect()))
            {
                veritabaniSifre = (string)command.ExecuteScalar();
            }

            if (veritabaniSifre != null && txt_eskiSifre.Text == veritabaniSifre)
            {
                // Girilen mevcut şifre, veritabanındaki şifre ile eşleşiyor

                if (txt_yeniSifre.Text == txt_sifreTekrar.Text)
                {
                    // Yeni şifreyi veritabanına güncelle
                    string query = $"UPDATE UyeKayitTablosu SET UyeSifre = '{txt_yeniSifre.Text}' WHERE TCKimlikNumarasi = '{tcKimlikNumarasi}'";
                    using (SqlCommand command = new SqlCommand(query, connection.Connect()))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                    this.Close();
                }
                else
                    MessageBox.Show("Güncellemek istediğiniz şifreler birbiri ile uyuşmuyor!\nLütfen  şifreyi tekrar giriniz.");

            }
            else
                MessageBox.Show("Mevcut şifre hatalı. Lütfen  şifreyi tekrar giriniz");
        }

		private void Sifreİslemleri_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			UyeIslemlerEkrani geriDonİslemi = new UyeIslemlerEkrani(tcKimlikNumarasi);
			geriDonİslemi.ShowDialog();
		}

		private void TSB_GeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
