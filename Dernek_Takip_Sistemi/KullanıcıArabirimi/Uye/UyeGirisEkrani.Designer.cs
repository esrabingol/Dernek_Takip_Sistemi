namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    partial class UyeGirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Uye = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.UyeKayit_LNK = new System.Windows.Forms.LinkLabel();
            this.UsfregorCB = new System.Windows.Forms.CheckBox();
            this.UKullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_PersonelPassword = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_personelnumber = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Üye Giriş Ekranı";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Uye});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Uye
            // 
            this.TSB_Uye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Uye.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TSB_Uye.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Uye.Name = "TSB_Uye";
            this.TSB_Uye.Size = new System.Drawing.Size(23, 22);
            this.TSB_Uye.Text = "Geri";
            this.TSB_Uye.Click += new System.EventHandler(this.TSB_Uye_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kayıtlı Değil Misiniz ?";
            // 
            // UyeKayit_LNK
            // 
            this.UyeKayit_LNK.AutoSize = true;
            this.UyeKayit_LNK.Location = new System.Drawing.Point(279, 199);
            this.UyeKayit_LNK.Name = "UyeKayit_LNK";
            this.UyeKayit_LNK.Size = new System.Drawing.Size(55, 13);
            this.UyeKayit_LNK.TabIndex = 16;
            this.UyeKayit_LNK.TabStop = true;
            this.UyeKayit_LNK.Text = "KAYIT OL";
            this.UyeKayit_LNK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UsfregorCB
            // 
            this.UsfregorCB.AutoSize = true;
            this.UsfregorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsfregorCB.Location = new System.Drawing.Point(345, 142);
            this.UsfregorCB.Name = "UsfregorCB";
            this.UsfregorCB.Size = new System.Drawing.Size(93, 17);
            this.UsfregorCB.TabIndex = 14;
            this.UsfregorCB.Text = "Şifre Göster";
            this.UsfregorCB.UseVisualStyleBackColor = true;
            this.UsfregorCB.CheckedChanged += new System.EventHandler(this.UsfregorCB_CheckedChanged);
            // 
            // UKullaniciAdiTB
            // 
            this.UKullaniciAdiTB.Location = new System.Drawing.Point(169, 91);
            this.UKullaniciAdiTB.Name = "UKullaniciAdiTB";
            this.UKullaniciAdiTB.Size = new System.Drawing.Size(170, 20);
            this.UKullaniciAdiTB.TabIndex = 12;
            this.UKullaniciAdiTB.Text = "ebingol@gmail.com";
            this.UKullaniciAdiTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KullaniciAdiTB_MouseClick);
            this.UKullaniciAdiTB.MouseLeave += new System.EventHandler(this.KullaniciAdiTB_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(166, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kullanıcı Adınız Eposta Adresinizdir.";
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(169, 142);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(170, 20);
            this.SifreTB.TabIndex = 10;
            this.SifreTB.Text = "1221562585";
            this.SifreTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SifreTB_MouseClick);
            this.SifreTB.MouseLeave += new System.EventHandler(this.SifreTB_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(169, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifreniz TC Kimlik Numaranızdır.";
            // 
            // lbl_PersonelPassword
            // 
            this.lbl_PersonelPassword.AutoSize = true;
            this.lbl_PersonelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelPassword.Location = new System.Drawing.Point(97, 143);
            this.lbl_PersonelPassword.Name = "lbl_PersonelPassword";
            this.lbl_PersonelPassword.Size = new System.Drawing.Size(49, 15);
            this.lbl_PersonelPassword.TabIndex = 9;
            this.lbl_PersonelPassword.Text = " Şifre :";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(199, 243);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(109, 32);
            this.guna2GradientButton1.TabIndex = 20;
            this.guna2GradientButton1.Text = "GİRİŞ ";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // lbl_personelnumber
            // 
            this.lbl_personelnumber.AutoSize = true;
            this.lbl_personelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelnumber.Location = new System.Drawing.Point(23, 91);
            this.lbl_personelnumber.Name = "lbl_personelnumber";
            this.lbl_personelnumber.Size = new System.Drawing.Size(123, 15);
            this.lbl_personelnumber.TabIndex = 8;
            this.lbl_personelnumber.Text = "Üye Kullanıcı Adı :";
            // 
            // UyeGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(457, 301);
            this.Controls.Add(this.lbl_personelnumber);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.lbl_PersonelPassword);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UyeKayit_LNK);
            this.Controls.Add(this.UKullaniciAdiTB);
            this.Controls.Add(this.UsfregorCB);
            this.Name = "UyeGirisEkrani";
            this.Text = "UyeGirisEkrani";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Uye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel UyeKayit_LNK;
        private System.Windows.Forms.CheckBox UsfregorCB;
        private System.Windows.Forms.TextBox UKullaniciAdiTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PersonelPassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label lbl_personelnumber;
    }
}