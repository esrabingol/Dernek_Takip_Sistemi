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
            this.sfregorCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Uyelogin = new System.Windows.Forms.Button();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.lbl_PersonelPassword = new System.Windows.Forms.Label();
            this.lbl_personelnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Uye = new System.Windows.Forms.ToolStripButton();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfregorCB
            // 
            this.sfregorCB.AutoSize = true;
            this.sfregorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfregorCB.Location = new System.Drawing.Point(364, 132);
            this.sfregorCB.Name = "sfregorCB";
            this.sfregorCB.Size = new System.Drawing.Size(93, 17);
            this.sfregorCB.TabIndex = 14;
            this.sfregorCB.Text = "Şifre Göster";
            this.sfregorCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Üye Giriş Ekranı";
            // 
            // btn_Uyelogin
            // 
            this.btn_Uyelogin.BackColor = System.Drawing.Color.Lime;
            this.btn_Uyelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Uyelogin.Location = new System.Drawing.Point(234, 214);
            this.btn_Uyelogin.Name = "btn_Uyelogin";
            this.btn_Uyelogin.Size = new System.Drawing.Size(100, 26);
            this.btn_Uyelogin.TabIndex = 11;
            this.btn_Uyelogin.Text = "Giriş Yap";
            this.btn_Uyelogin.UseVisualStyleBackColor = false;
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(209, 130);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(154, 20);
            this.SifreTB.TabIndex = 10;
            this.SifreTB.Text = "Şifre";
            this.SifreTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SifreTB_MouseClick);
            this.SifreTB.MouseLeave += new System.EventHandler(this.SifreTB_MouseLeave);
            // 
            // lbl_PersonelPassword
            // 
            this.lbl_PersonelPassword.AutoSize = true;
            this.lbl_PersonelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelPassword.Location = new System.Drawing.Point(108, 128);
            this.lbl_PersonelPassword.Name = "lbl_PersonelPassword";
            this.lbl_PersonelPassword.Size = new System.Drawing.Size(62, 20);
            this.lbl_PersonelPassword.TabIndex = 9;
            this.lbl_PersonelPassword.Text = " Şifre :";
            // 
            // lbl_personelnumber
            // 
            this.lbl_personelnumber.AutoSize = true;
            this.lbl_personelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelnumber.Location = new System.Drawing.Point(18, 88);
            this.lbl_personelnumber.Name = "lbl_personelnumber";
            this.lbl_personelnumber.Size = new System.Drawing.Size(152, 20);
            this.lbl_personelnumber.TabIndex = 8;
            this.lbl_personelnumber.Text = "Üye Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kayıtlı Değil Misiniz ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(251, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KAYIT OL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Uye});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(519, 25);
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
            this.TSB_Uye.Text = "toolStripButton1";
            this.TSB_Uye.Click += new System.EventHandler(this.TSB_Uye_Click);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(209, 88);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(154, 20);
            this.KullaniciAdiTB.TabIndex = 12;
            this.KullaniciAdiTB.Text = "Kullanıcı Adı";
            this.KullaniciAdiTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KullaniciAdiTB_MouseClick);
            this.KullaniciAdiTB.MouseLeave += new System.EventHandler(this.KullaniciAdiTB_MouseLeave);
            // 
            // UyeGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(519, 252);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfregorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.btn_Uyelogin);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.lbl_PersonelPassword);
            this.Controls.Add(this.lbl_personelnumber);
            this.Name = "UyeGirisEkrani";
            this.Text = "UyeGirisEkrani";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sfregorCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Uyelogin;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label lbl_PersonelPassword;
        private System.Windows.Forms.Label lbl_personelnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Uye;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
    }
}