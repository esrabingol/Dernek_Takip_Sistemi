using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    public partial class OdemeIslemleriEkrani : Form
    {
        public OdemeIslemleriEkrani()
        {
            InitializeComponent();
        }

        private void OdenecekTutar_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Giriş yapılan karakter numerik bir karakter (0-9) veya virgül (,) ise izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bu karaktere izin verme
            }

            // Sadece bir tane virgül izin ver
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true; // Birden fazla virgülü engelle
            }
        }
    }
}
