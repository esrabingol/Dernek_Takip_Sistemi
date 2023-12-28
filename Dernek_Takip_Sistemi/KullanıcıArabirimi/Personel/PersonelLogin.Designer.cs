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
            this.PersonelAdiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfregorCB = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Personel = new System.Windows.Forms.ToolStripButton();
            this.guno_GirisBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_personelnumber
            // 
            this.lbl_personelnumber.AutoSize = true;
            this.lbl_personelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelnumber.Location = new System.Drawing.Point(12, 74);
            this.lbl_personelnumber.Name = "lbl_personelnumber";
            this.lbl_personelnumber.Size = new System.Drawing.Size(168, 17);
            this.lbl_personelnumber.TabIndex = 0;
            this.lbl_personelnumber.Text = "Personel Sistem Adı : \r\n";
            // 
            // lbl_PersonelPassword
            // 
            this.lbl_PersonelPassword.AutoSize = true;
            this.lbl_PersonelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonelPassword.Location = new System.Drawing.Point(67, 116);
            this.lbl_PersonelPassword.Name = "lbl_PersonelPassword";
            this.lbl_PersonelPassword.Size = new System.Drawing.Size(117, 17);
            this.lbl_PersonelPassword.TabIndex = 1;
            this.lbl_PersonelPassword.Text = "Sistem Şifresi :";
            // 
            // SifreTB
            // 
            this.SifreTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SifreTB.Location = new System.Drawing.Point(203, 116);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.PasswordChar = '*';
            this.SifreTB.Size = new System.Drawing.Size(154, 20);
            this.SifreTB.TabIndex = 3;
            this.SifreTB.TextChanged += new System.EventHandler(this.txtBox_prsonelpassword_TextChanged);
            // 
            // PersonelAdiTB
            // 
            this.PersonelAdiTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PersonelAdiTB.Location = new System.Drawing.Point(203, 74);
            this.PersonelAdiTB.Name = "PersonelAdiTB";
            this.PersonelAdiTB.Size = new System.Drawing.Size(154, 20);
            this.PersonelAdiTB.TabIndex = 5;
            this.PersonelAdiTB.Text = "Kullanıcı Adı";
            this.PersonelAdiTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KullaniciAdiTB_MouseClick);
            this.PersonelAdiTB.TextChanged += new System.EventHandler(this.txtBox_prsonelnumber_TextChanged);
            this.PersonelAdiTB.Leave += new System.EventHandler(this.KullaniciAdiTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel Giriş Ekranı";
            // 
            // sfregorCB
            // 
            this.sfregorCB.AutoSize = true;
            this.sfregorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfregorCB.Location = new System.Drawing.Point(382, 119);
            this.sfregorCB.Name = "sfregorCB";
            this.sfregorCB.Size = new System.Drawing.Size(93, 17);
            this.sfregorCB.TabIndex = 7;
            this.sfregorCB.Text = "Şifre Göster";
            this.sfregorCB.UseVisualStyleBackColor = true;
            this.sfregorCB.CheckedChanged += new System.EventHandler(this.sfregorCB_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Personel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(482, 25);
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
            // guno_GirisBTN
            // 
            this.guno_GirisBTN.BorderColor = System.Drawing.Color.Aquamarine;
            this.guno_GirisBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guno_GirisBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guno_GirisBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guno_GirisBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guno_GirisBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guno_GirisBTN.FillColor = System.Drawing.Color.White;
            this.guno_GirisBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guno_GirisBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guno_GirisBTN.ForeColor = System.Drawing.Color.Black;
            this.guno_GirisBTN.Location = new System.Drawing.Point(233, 159);
            this.guno_GirisBTN.Name = "guno_GirisBTN";
            this.guno_GirisBTN.Size = new System.Drawing.Size(94, 29);
            this.guno_GirisBTN.TabIndex = 10;
            this.guno_GirisBTN.Text = "Giriş";
            this.guno_GirisBTN.Click += new System.EventHandler(this.guno_GirisBTN_Click);
            // 
            // PersonelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 200);
            this.Controls.Add(this.guno_GirisBTN);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sfregorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonelAdiTB);
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
        private System.Windows.Forms.TextBox PersonelAdiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sfregorCB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Personel;
        private Guna.UI2.WinForms.Guna2GradientButton guno_GirisBTN;
    }
}

