namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    partial class MailIslemleriEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UyeMail_LB = new System.Windows.Forms.Label();
            this.PersonelMail_LB = new System.Windows.Forms.Label();
            this.KonuBasligi_LB = new System.Windows.Forms.Label();
            this.KonuIcerigi_LB = new System.Windows.Forms.Label();
            this.KonuBasligi_TB = new System.Windows.Forms.TextBox();
            this.KonuIcerigi_RTB = new System.Windows.Forms.RichTextBox();
            this.Mail_BTN = new System.Windows.Forms.Button();
            this.Baslik_LB = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AnaEkranaDon_TSB = new System.Windows.Forms.ToolStripButton();
            this.Temizle_TSB = new System.Windows.Forms.ToolStripButton();
            this.logout_TSB = new System.Windows.Forms.ToolStripButton();
            this.MAdressUye_TB = new System.Windows.Forms.TextBox();
            this.PersonelMail_TB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UyeMail_LB
            // 
            this.UyeMail_LB.AutoSize = true;
            this.UyeMail_LB.Location = new System.Drawing.Point(37, 141);
            this.UyeMail_LB.Name = "UyeMail_LB";
            this.UyeMail_LB.Size = new System.Drawing.Size(86, 13);
            this.UyeMail_LB.TabIndex = 0;
            this.UyeMail_LB.Text = "Üye Mail Adresi :";
            // 
            // PersonelMail_LB
            // 
            this.PersonelMail_LB.AutoSize = true;
            this.PersonelMail_LB.Location = new System.Drawing.Point(15, 95);
            this.PersonelMail_LB.Name = "PersonelMail_LB";
            this.PersonelMail_LB.Size = new System.Drawing.Size(108, 13);
            this.PersonelMail_LB.TabIndex = 1;
            this.PersonelMail_LB.Text = "Personel Mail Adresi :";
            // 
            // KonuBasligi_LB
            // 
            this.KonuBasligi_LB.AutoSize = true;
            this.KonuBasligi_LB.Location = new System.Drawing.Point(52, 191);
            this.KonuBasligi_LB.Name = "KonuBasligi_LB";
            this.KonuBasligi_LB.Size = new System.Drawing.Size(71, 13);
            this.KonuBasligi_LB.TabIndex = 2;
            this.KonuBasligi_LB.Text = "Konu Başlığı :";
            // 
            // KonuIcerigi_LB
            // 
            this.KonuIcerigi_LB.AutoSize = true;
            this.KonuIcerigi_LB.Location = new System.Drawing.Point(54, 241);
            this.KonuIcerigi_LB.Name = "KonuIcerigi_LB";
            this.KonuIcerigi_LB.Size = new System.Drawing.Size(69, 13);
            this.KonuIcerigi_LB.TabIndex = 3;
            this.KonuIcerigi_LB.Text = "Konu İçeriği :";
            // 
            // KonuBasligi_TB
            // 
            this.KonuBasligi_TB.Location = new System.Drawing.Point(129, 188);
            this.KonuBasligi_TB.Name = "KonuBasligi_TB";
            this.KonuBasligi_TB.Size = new System.Drawing.Size(197, 20);
            this.KonuBasligi_TB.TabIndex = 6;
            // 
            // KonuIcerigi_RTB
            // 
            this.KonuIcerigi_RTB.Location = new System.Drawing.Point(129, 238);
            this.KonuIcerigi_RTB.Name = "KonuIcerigi_RTB";
            this.KonuIcerigi_RTB.Size = new System.Drawing.Size(197, 82);
            this.KonuIcerigi_RTB.TabIndex = 7;
            this.KonuIcerigi_RTB.Text = "";
            // 
            // Mail_BTN
            // 
            this.Mail_BTN.BackColor = System.Drawing.Color.Lime;
            this.Mail_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mail_BTN.Location = new System.Drawing.Point(150, 353);
            this.Mail_BTN.Name = "Mail_BTN";
            this.Mail_BTN.Size = new System.Drawing.Size(112, 32);
            this.Mail_BTN.TabIndex = 8;
            this.Mail_BTN.Text = "Gönder";
            this.Mail_BTN.UseVisualStyleBackColor = false;
            this.Mail_BTN.Click += new System.EventHandler(this.Mail_BTN_Click);
            // 
            // Baslik_LB
            // 
            this.Baslik_LB.AutoSize = true;
            this.Baslik_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslik_LB.Location = new System.Drawing.Point(145, 40);
            this.Baslik_LB.Name = "Baslik_LB";
            this.Baslik_LB.Size = new System.Drawing.Size(129, 25);
            this.Baslik_LB.TabIndex = 9;
            this.Baslik_LB.Text = "Mail Gönder";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnaEkranaDon_TSB,
            this.Temizle_TSB,
            this.logout_TSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AnaEkranaDon_TSB
            // 
            this.AnaEkranaDon_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AnaEkranaDon_TSB.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.AnaEkranaDon_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnaEkranaDon_TSB.Name = "AnaEkranaDon_TSB";
            this.AnaEkranaDon_TSB.Size = new System.Drawing.Size(23, 22);
            this.AnaEkranaDon_TSB.Text = "Ana Menüye Dön";
            this.AnaEkranaDon_TSB.Click += new System.EventHandler(this.AnaEkranaDon_TSB_Click);
            // 
            // Temizle_TSB
            // 
            this.Temizle_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Temizle_TSB.Image = global::Dernek_Takip_Sistemi.Properties.Resources.warning;
            this.Temizle_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Temizle_TSB.Name = "Temizle_TSB";
            this.Temizle_TSB.Size = new System.Drawing.Size(23, 22);
            this.Temizle_TSB.Text = "Taslağı Sil";
            this.Temizle_TSB.Click += new System.EventHandler(this.Temizle_TSB_Click);
            // 
            // logout_TSB
            // 
            this.logout_TSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logout_TSB.CheckOnClick = true;
            this.logout_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logout_TSB.Image = global::Dernek_Takip_Sistemi.Properties.Resources.logout;
            this.logout_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logout_TSB.Name = "logout_TSB";
            this.logout_TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logout_TSB.Size = new System.Drawing.Size(23, 22);
            this.logout_TSB.Text = "ÇIKIŞ YAP";
            this.logout_TSB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout_TSB.Click += new System.EventHandler(this.logout_TSB_Click);
            // 
            // MAdressUye_TB
            // 
            this.MAdressUye_TB.Location = new System.Drawing.Point(129, 141);
            this.MAdressUye_TB.Name = "MAdressUye_TB";
            this.MAdressUye_TB.Size = new System.Drawing.Size(197, 20);
            this.MAdressUye_TB.TabIndex = 5;
            // 
            // PersonelMail_TB
            // 
            this.PersonelMail_TB.Location = new System.Drawing.Point(129, 95);
            this.PersonelMail_TB.Name = "PersonelMail_TB";
            this.PersonelMail_TB.Size = new System.Drawing.Size(197, 20);
            this.PersonelMail_TB.TabIndex = 11;
            // 
            // MailIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(392, 397);
            this.Controls.Add(this.PersonelMail_TB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Baslik_LB);
            this.Controls.Add(this.Mail_BTN);
            this.Controls.Add(this.KonuIcerigi_RTB);
            this.Controls.Add(this.KonuBasligi_TB);
            this.Controls.Add(this.MAdressUye_TB);
            this.Controls.Add(this.KonuIcerigi_LB);
            this.Controls.Add(this.KonuBasligi_LB);
            this.Controls.Add(this.PersonelMail_LB);
            this.Controls.Add(this.UyeMail_LB);
            this.Name = "MailIslemleriEkrani";
            this.Text = "MailIslemleriEkrani";
            this.Load += new System.EventHandler(this.MailIslemleriEkrani_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UyeMail_LB;
        private System.Windows.Forms.Label PersonelMail_LB;
        private System.Windows.Forms.Label KonuBasligi_LB;
        private System.Windows.Forms.Label KonuIcerigi_LB;
        private System.Windows.Forms.TextBox KonuBasligi_TB;
        private System.Windows.Forms.RichTextBox KonuIcerigi_RTB;
        private System.Windows.Forms.Button Mail_BTN;
        private System.Windows.Forms.Label Baslik_LB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AnaEkranaDon_TSB;
        private System.Windows.Forms.TextBox MAdressUye_TB;
        private System.Windows.Forms.ToolStripButton Temizle_TSB;
        private System.Windows.Forms.TextBox PersonelMail_TB;
        private System.Windows.Forms.ToolStripButton logout_TSB;
    }
}