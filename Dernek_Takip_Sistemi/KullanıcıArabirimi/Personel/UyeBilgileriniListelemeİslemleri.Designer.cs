﻿namespace Dernek_Takip_Sistemi
{
    partial class UyeBilgileriniListelemeİslemleri
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BaslikLB = new System.Windows.Forms.Label();
            this.SehirListele_BTN = new System.Windows.Forms.Button();
            this.KanGrubu_BTN = new System.Windows.Forms.Button();
            this.TumUyeleriGorBTN = new System.Windows.Forms.Button();
            this.DurumBTN = new System.Windows.Forms.Button();
            this.sehirler_CB = new System.Windows.Forms.ComboBox();
            this.ListelemeDGW = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BorcDurumu_BTN = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pdfkaydet_BTN = new System.Windows.Forms.Button();
            this.TSB_Logout = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UyeKayitBTN = new System.Windows.Forms.Button();
            this.UyeSilBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaslikLB
            // 
            this.BaslikLB.AutoSize = true;
            this.BaslikLB.BackColor = System.Drawing.Color.Gainsboro;
            this.BaslikLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslikLB.ForeColor = System.Drawing.Color.Black;
            this.BaslikLB.Location = new System.Drawing.Point(344, 36);
            this.BaslikLB.Name = "BaslikLB";
            this.BaslikLB.Size = new System.Drawing.Size(183, 25);
            this.BaslikLB.TabIndex = 4;
            this.BaslikLB.Text = "Genel Bilgi Ekranı";
            // 
            // SehirListele_BTN
            // 
            this.SehirListele_BTN.BackColor = System.Drawing.Color.White;
            this.SehirListele_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SehirListele_BTN.Location = new System.Drawing.Point(205, 68);
            this.SehirListele_BTN.Name = "SehirListele_BTN";
            this.SehirListele_BTN.Size = new System.Drawing.Size(153, 35);
            this.SehirListele_BTN.TabIndex = 2;
            this.SehirListele_BTN.Text = "2- Şehire Göre Listele\r\n\r\n";
            this.SehirListele_BTN.UseVisualStyleBackColor = false;
            this.SehirListele_BTN.Click += new System.EventHandler(this.SehirListele_BTN_Click);
            // 
            // KanGrubu_BTN
            // 
            this.KanGrubu_BTN.BackColor = System.Drawing.Color.White;
            this.KanGrubu_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KanGrubu_BTN.Location = new System.Drawing.Point(11, 162);
            this.KanGrubu_BTN.Name = "KanGrubu_BTN";
            this.KanGrubu_BTN.Size = new System.Drawing.Size(347, 35);
            this.KanGrubu_BTN.TabIndex = 1;
            this.KanGrubu_BTN.Text = "4- Kan Grubuna Göre Listele\r\n";
            this.KanGrubu_BTN.UseVisualStyleBackColor = false;
            this.KanGrubu_BTN.Click += new System.EventHandler(this.KanGrubu_BTN_Click);
            // 
            // TumUyeleriGorBTN
            // 
            this.TumUyeleriGorBTN.BackColor = System.Drawing.Color.White;
            this.TumUyeleriGorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumUyeleriGorBTN.Location = new System.Drawing.Point(6, 27);
            this.TumUyeleriGorBTN.Name = "TumUyeleriGorBTN";
            this.TumUyeleriGorBTN.Size = new System.Drawing.Size(352, 35);
            this.TumUyeleriGorBTN.TabIndex = 10;
            this.TumUyeleriGorBTN.Text = "1- Tüm Üyeleri Ve Bilgilerini Listele\r\n\r\n";
            this.TumUyeleriGorBTN.UseVisualStyleBackColor = false;
            this.TumUyeleriGorBTN.Click += new System.EventHandler(this.TumUyeleriGorBTN_Click);
            // 
            // DurumBTN
            // 
            this.DurumBTN.BackColor = System.Drawing.Color.White;
            this.DurumBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumBTN.Location = new System.Drawing.Point(11, 121);
            this.DurumBTN.Name = "DurumBTN";
            this.DurumBTN.Size = new System.Drawing.Size(347, 35);
            this.DurumBTN.TabIndex = 3;
            this.DurumBTN.Text = "3- Aktif/ Pasif Durumuna Göre Listele\r\n\r\n\r\n";
            this.DurumBTN.UseVisualStyleBackColor = false;
            this.DurumBTN.Click += new System.EventHandler(this.DurumBTN_Click);
            // 
            // sehirler_CB
            // 
            this.sehirler_CB.FormattingEnabled = true;
            this.sehirler_CB.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.sehirler_CB.Location = new System.Drawing.Point(11, 76);
            this.sehirler_CB.Name = "sehirler_CB";
            this.sehirler_CB.Size = new System.Drawing.Size(174, 21);
            this.sehirler_CB.TabIndex = 12;
            // 
            // ListelemeDGW
            // 
            this.ListelemeDGW.BackgroundColor = System.Drawing.Color.White;
            this.ListelemeDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListelemeDGW.Location = new System.Drawing.Point(457, 20);
            this.ListelemeDGW.Name = "ListelemeDGW";
            this.ListelemeDGW.Size = new System.Drawing.Size(394, 218);
            this.ListelemeDGW.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.BorcDurumu_BTN);
            this.groupBox1.Controls.Add(this.ListelemeDGW);
            this.groupBox1.Controls.Add(this.KanGrubu_BTN);
            this.groupBox1.Controls.Add(this.sehirler_CB);
            this.groupBox1.Controls.Add(this.DurumBTN);
            this.groupBox1.Controls.Add(this.TumUyeleriGorBTN);
            this.groupBox1.Controls.Add(this.SehirListele_BTN);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 267);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LİSTELEME İŞLEMLERİ";
            // 
            // BorcDurumu_BTN
            // 
            this.BorcDurumu_BTN.BackColor = System.Drawing.Color.White;
            this.BorcDurumu_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BorcDurumu_BTN.Location = new System.Drawing.Point(11, 203);
            this.BorcDurumu_BTN.Name = "BorcDurumu_BTN";
            this.BorcDurumu_BTN.Size = new System.Drawing.Size(347, 35);
            this.BorcDurumu_BTN.TabIndex = 13;
            this.BorcDurumu_BTN.Text = "5- Borç Dıurumuna Göre Listele\r\n";
            this.BorcDurumu_BTN.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Logout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(967, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pdfkaydet_BTN
            // 
            this.pdfkaydet_BTN.BackColor = System.Drawing.Color.White;
            this.pdfkaydet_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfkaydet_BTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_3_Filetype_pdf_24;
            this.pdfkaydet_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pdfkaydet_BTN.Location = new System.Drawing.Point(695, 10);
            this.pdfkaydet_BTN.Name = "pdfkaydet_BTN";
            this.pdfkaydet_BTN.Size = new System.Drawing.Size(156, 41);
            this.pdfkaydet_BTN.TabIndex = 17;
            this.pdfkaydet_BTN.Text = "Pdf Olarak Kaydet";
            this.pdfkaydet_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pdfkaydet_BTN.UseVisualStyleBackColor = false;
            this.pdfkaydet_BTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // TSB_Logout
            // 
            this.TSB_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Logout.Image = global::Dernek_Takip_Sistemi.Properties.Resources.logout;
            this.TSB_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Logout.Name = "TSB_Logout";
            this.TSB_Logout.Size = new System.Drawing.Size(23, 22);
            this.TSB_Logout.Text = "toolStripButton1";
            this.TSB_Logout.ToolTipText = "Çıkış Yap";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::Dernek_Takip_Sistemi.Properties.Resources.eposta;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(373, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Mail Gönder";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Iconshock_Real_Vista_Text_Print_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(533, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = " Bilgileri Yazdır";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UyeKayitBTN
            // 
            this.UyeKayitBTN.BackColor = System.Drawing.Color.White;
            this.UyeKayitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeKayitBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.user;
            this.UyeKayitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UyeKayitBTN.Location = new System.Drawing.Point(171, 10);
            this.UyeKayitBTN.Name = "UyeKayitBTN";
            this.UyeKayitBTN.Size = new System.Drawing.Size(187, 38);
            this.UyeKayitBTN.TabIndex = 6;
            this.UyeKayitBTN.Text = "Yeni Üye Kaydetme İşlemi";
            this.UyeKayitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UyeKayitBTN.UseVisualStyleBackColor = false;
            this.UyeKayitBTN.Click += new System.EventHandler(this.UyeKayitBTN_Click);
            // 
            // UyeSilBTN
            // 
            this.UyeSilBTN.BackColor = System.Drawing.Color.White;
            this.UyeSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSilBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.warning;
            this.UyeSilBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UyeSilBTN.Location = new System.Drawing.Point(11, 11);
            this.UyeSilBTN.Name = "UyeSilBTN";
            this.UyeSilBTN.Size = new System.Drawing.Size(148, 37);
            this.UyeSilBTN.TabIndex = 9;
            this.UyeSilBTN.Text = "Üye Silme İşlemi";
            this.UyeSilBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UyeSilBTN.UseVisualStyleBackColor = false;
            this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.UyeSilBTN);
            this.groupBox2.Controls.Add(this.pdfkaydet_BTN);
            this.groupBox2.Controls.Add(this.UyeKayitBTN);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(22, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 54);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // UyeBilgileriniListelemeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(967, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BaslikLB);
            this.Name = "UyeBilgileriniListelemeİslemleri";
            this.Text = "UyeBilgileriniListelemeİslemleri";
            this.Load += new System.EventHandler(this.UyeBilgileriniListelemeİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label BaslikLB;
        private System.Windows.Forms.Button UyeKayitBTN;
        private System.Windows.Forms.Button UyeSilBTN;
        private System.Windows.Forms.Button SehirListele_BTN;
        private System.Windows.Forms.Button KanGrubu_BTN;
        private System.Windows.Forms.Button TumUyeleriGorBTN;
        private System.Windows.Forms.Button DurumBTN;
        private System.Windows.Forms.ComboBox sehirler_CB;
        private System.Windows.Forms.DataGridView ListelemeDGW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BorcDurumu_BTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Logout;
        private System.Windows.Forms.Button pdfkaydet_BTN;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}