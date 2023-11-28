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
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
         

            this.Hide();

            // Yeni formu oluştur ve göster
            PersonelLogin personelLogin = new PersonelLogin();
            personelLogin.ShowDialog();

  
        }
    }
}
