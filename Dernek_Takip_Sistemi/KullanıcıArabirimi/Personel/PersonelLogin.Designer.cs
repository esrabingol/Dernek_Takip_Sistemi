namespace Dernek_Takip_Sistemi
{
    partial class PersonelLogin
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
            this.lbl_personelnumber = new System.Windows.Forms.Label();
            this.lbl_PersonelPassword = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfregorCB = new System.Windows.Forms.CheckBox();
            this.btn_Personellgn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Personel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_personelnumber
            // 
            this.lbl_personelnumber.AutoSize = true;
            this.lbl_personelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelnumber.Location = new System.Drawing.Point(62, 75);
            this.lbl_personelnumber.Name = "lbl_personelnumber";
            this.lbl_personelnumber.Size = new System.Drawing.Size(185, 20);
            this.lbl_personelnumber.TabIndex = 0;
            this.lbl_personelnumber.Text = "Personel Sistem Adı : \r\n";
            // 
            // lbl_PersonelPassword
            // 
            this.lbl_PersonelPassword.AutoSize = true;
            this.lbl_PersonelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelPassword.Location = new System.Drawing.Point(117, 117);
            this.lbl_PersonelPassword.Name = "lbl_PersonelPassword";
            this.lbl_PersonelPassword.Size = new System.Drawing.Size(130, 20);
            this.lbl_PersonelPassword.TabIndex = 1;
            this.lbl_PersonelPassword.Text = "Sistem Şifresi :";
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(253, 117);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.PasswordChar = '*';
            this.SifreTB.Size = new System.Drawing.Size(154, 20);
            this.SifreTB.TabIndex = 3;
            this.SifreTB.TextChanged += new System.EventHandler(this.txtBox_prsonelpassword_TextChanged);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(253, 75);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(154, 20);
            this.KullaniciAdiTB.TabIndex = 5;
            this.KullaniciAdiTB.Text = "Kullanıcı Adı";
            this.KullaniciAdiTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KullaniciAdiTB_MouseClick);
            this.KullaniciAdiTB.TextChanged += new System.EventHandler(this.txtBox_prsonelnumber_TextChanged);
            this.KullaniciAdiTB.Leave += new System.EventHandler(this.KullaniciAdiTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel Giriş Ekranı";
            // 
            // sfregorCB
            // 
            this.sfregorCB.AutoSize = true;
            this.sfregorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfregorCB.Location = new System.Drawing.Point(408, 119);
            this.sfregorCB.Name = "sfregorCB";
            this.sfregorCB.Size = new System.Drawing.Size(93, 17);
            this.sfregorCB.TabIndex = 7;
            this.sfregorCB.Text = "Şifre Göster";
            this.sfregorCB.UseVisualStyleBackColor = true;
            this.sfregorCB.CheckedChanged += new System.EventHandler(this.sfregorCB_CheckedChanged);
            // 
            // btn_Personellgn
            // 
            this.btn_Personellgn.BackColor = System.Drawing.Color.Lime;
            this.btn_Personellgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Personellgn.Location = new System.Drawing.Point(253, 158);
            this.btn_Personellgn.Name = "btn_Personellgn";
            this.btn_Personellgn.Size = new System.Drawing.Size(112, 32);
            this.btn_Personellgn.TabIndex = 8;
            this.btn_Personellgn.Text = "Giriş";
            this.btn_Personellgn.UseVisualStyleBackColor = false;
            this.btn_Personellgn.Click += new System.EventHandler(this.btn_Personellgn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Personel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Personel
            // 
            this.TSB_Personel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Personel.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TSB_Personel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Personel.Name = "TSB_Personel";
            this.TSB_Personel.Size = new System.Drawing.Size(23, 22);
            this.TSB_Personel.Text = "toolStripButton1";
            this.TSB_Personel.Click += new System.EventHandler(this.TSB_Personel_Click);
            // 
            // PersonelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(566, 200);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_Personellgn);
            this.Controls.Add(this.sfregorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.lbl_PersonelPassword);
            this.Controls.Add(this.lbl_personelnumber);
            this.Name = "PersonelLogin";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_personelnumber;
        private System.Windows.Forms.Label lbl_PersonelPassword;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sfregorCB;
        private System.Windows.Forms.Button btn_Personellgn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Personel;
    }
}

