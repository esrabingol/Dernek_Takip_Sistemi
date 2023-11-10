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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelLogin));
            this.lbl_personelnumber = new System.Windows.Forms.Label();
            this.lbl_PersonelPassword = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfregorCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_personelnumber
            // 
            this.lbl_personelnumber.AutoSize = true;
            this.lbl_personelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelnumber.Location = new System.Drawing.Point(71, 74);
            this.lbl_personelnumber.Name = "lbl_personelnumber";
            this.lbl_personelnumber.Size = new System.Drawing.Size(185, 20);
            this.lbl_personelnumber.TabIndex = 0;
            this.lbl_personelnumber.Text = "Personel Sistem Adı : \r\n";
            // 
            // lbl_PersonelPassword
            // 
            this.lbl_PersonelPassword.AutoSize = true;
            this.lbl_PersonelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelPassword.Location = new System.Drawing.Point(126, 116);
            this.lbl_PersonelPassword.Name = "lbl_PersonelPassword";
            this.lbl_PersonelPassword.Size = new System.Drawing.Size(130, 20);
            this.lbl_PersonelPassword.TabIndex = 1;
            this.lbl_PersonelPassword.Text = "Sistem Şifresi :";
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(262, 116);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(154, 20);
            this.SifreTB.TabIndex = 3;
            this.SifreTB.TextChanged += new System.EventHandler(this.txtBox_prsonelpassword_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(195, 164);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 34);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(262, 74);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(154, 20);
            this.KullaniciAdiTB.TabIndex = 5;
            this.KullaniciAdiTB.TextChanged += new System.EventHandler(this.txtBox_prsonelnumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel Giriş Ekranı";
            // 
            // sfregorCB
            // 
            this.sfregorCB.AutoSize = true;
            this.sfregorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfregorCB.Location = new System.Drawing.Point(417, 118);
            this.sfregorCB.Name = "sfregorCB";
            this.sfregorCB.Size = new System.Drawing.Size(93, 17);
            this.sfregorCB.TabIndex = 7;
            this.sfregorCB.Text = "Şifre Göster";
            this.sfregorCB.UseVisualStyleBackColor = true;
            this.sfregorCB.CheckedChanged += new System.EventHandler(this.sfregorCB_CheckedChanged);
            // 
            // PersonelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(536, 215);
            this.Controls.Add(this.sfregorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.lbl_PersonelPassword);
            this.Controls.Add(this.lbl_personelnumber);
            this.Name = "PersonelLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_personelnumber;
        private System.Windows.Forms.Label lbl_PersonelPassword;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sfregorCB;
    }
}

