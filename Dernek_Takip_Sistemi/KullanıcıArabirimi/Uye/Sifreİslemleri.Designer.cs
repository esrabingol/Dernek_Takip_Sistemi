namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    partial class Sifreİslemleri
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
            this.chbox_tekrarParola = new System.Windows.Forms.CheckBox();
            this.chbox_yeniParola = new System.Windows.Forms.CheckBox();
            this.chbox_mevcutParola = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.txt_eskiSifre = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GeriDon_BTN = new System.Windows.Forms.ToolStripButton();
            this.CKS_BTN = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbox_tekrarParola
            // 
            this.chbox_tekrarParola.AutoSize = true;
            this.chbox_tekrarParola.Location = new System.Drawing.Point(207, 162);
            this.chbox_tekrarParola.Margin = new System.Windows.Forms.Padding(2);
            this.chbox_tekrarParola.Name = "chbox_tekrarParola";
            this.chbox_tekrarParola.Size = new System.Drawing.Size(77, 17);
            this.chbox_tekrarParola.TabIndex = 19;
            this.chbox_tekrarParola.Text = "şifre göster";
            this.chbox_tekrarParola.UseVisualStyleBackColor = true;
            this.chbox_tekrarParola.Click += new System.EventHandler(this.chbox_tekrarParola_CheckedChanged);
            // 
            // chbox_yeniParola
            // 
            this.chbox_yeniParola.AutoSize = true;
            this.chbox_yeniParola.Location = new System.Drawing.Point(207, 109);
            this.chbox_yeniParola.Margin = new System.Windows.Forms.Padding(2);
            this.chbox_yeniParola.Name = "chbox_yeniParola";
            this.chbox_yeniParola.Size = new System.Drawing.Size(77, 17);
            this.chbox_yeniParola.TabIndex = 18;
            this.chbox_yeniParola.Text = "şifre göster";
            this.chbox_yeniParola.UseVisualStyleBackColor = true;
            this.chbox_yeniParola.Click += new System.EventHandler(this.chbox_yeniParola_CheckedChanged);
            // 
            // chbox_mevcutParola
            // 
            this.chbox_mevcutParola.AutoSize = true;
            this.chbox_mevcutParola.Location = new System.Drawing.Point(207, 41);
            this.chbox_mevcutParola.Margin = new System.Windows.Forms.Padding(2);
            this.chbox_mevcutParola.Name = "chbox_mevcutParola";
            this.chbox_mevcutParola.Size = new System.Drawing.Size(77, 17);
            this.chbox_mevcutParola.TabIndex = 17;
            this.chbox_mevcutParola.Text = "şifre göster";
            this.chbox_mevcutParola.UseVisualStyleBackColor = true;
            this.chbox_mevcutParola.Click += new System.EventHandler(this.chbox_mevcutParola_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yeni Parola (Tekrar):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mevcut Parola:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Lime;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(81, 201);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(115, 28);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_sifreTekrar
            // 
            this.txt_sifreTekrar.Location = new System.Drawing.Point(23, 160);
            this.txt_sifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifreTekrar.Name = "txt_sifreTekrar";
            this.txt_sifreTekrar.PasswordChar = '*';
            this.txt_sifreTekrar.Size = new System.Drawing.Size(173, 20);
            this.txt_sifreTekrar.TabIndex = 12;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(23, 108);
            this.txt_yeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.PasswordChar = '*';
            this.txt_yeniSifre.Size = new System.Drawing.Size(173, 20);
            this.txt_yeniSifre.TabIndex = 11;
            // 
            // txt_eskiSifre
            // 
            this.txt_eskiSifre.Location = new System.Drawing.Point(23, 39);
            this.txt_eskiSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_eskiSifre.Name = "txt_eskiSifre";
            this.txt_eskiSifre.PasswordChar = '*';
            this.txt_eskiSifre.Size = new System.Drawing.Size(173, 20);
            this.txt_eskiSifre.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeriDon_BTN,
            this.CKS_BTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(371, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GeriDon_BTN
            // 
            this.GeriDon_BTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GeriDon_BTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.GeriDon_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GeriDon_BTN.Name = "GeriDon_BTN";
            this.GeriDon_BTN.Size = new System.Drawing.Size(23, 22);
            this.GeriDon_BTN.Text = "GERİ DÖN";
            this.GeriDon_BTN.Click += new System.EventHandler(this.GeriDon_BTN_Click);
            // 
            // CKS_BTN
            // 
            this.CKS_BTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CKS_BTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CKS_BTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.logout;
            this.CKS_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CKS_BTN.Name = "CKS_BTN";
            this.CKS_BTN.Size = new System.Drawing.Size(23, 22);
            this.CKS_BTN.Text = "Çıkış Yap";
            this.CKS_BTN.Click += new System.EventHandler(this.CKS_BTN_Click);
            // 
            // Sifreİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 255);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chbox_tekrarParola);
            this.Controls.Add(this.chbox_yeniParola);
            this.Controls.Add(this.chbox_mevcutParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sifreTekrar);
            this.Controls.Add(this.txt_yeniSifre);
            this.Controls.Add(this.txt_eskiSifre);
            this.Name = "Sifreİslemleri";
            this.Text = "Sifreİslemleri";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbox_tekrarParola;
        private System.Windows.Forms.CheckBox chbox_yeniParola;
        private System.Windows.Forms.CheckBox chbox_mevcutParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.TextBox txt_eskiSifre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GeriDon_BTN;
        private System.Windows.Forms.ToolStripButton CKS_BTN;
    }
}