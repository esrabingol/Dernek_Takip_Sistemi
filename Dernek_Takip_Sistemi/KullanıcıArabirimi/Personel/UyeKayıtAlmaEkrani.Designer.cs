namespace Dernek_Takip_Sistemi
{
    partial class UyeKayıtAlmaEkrani
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
            this.TckimliknoTB = new System.Windows.Forms.TextBox();
            this.lbl_tckimlikno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_kangrubu = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_dogumgunu = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_aktifpasif = new System.Windows.Forms.Label();
            this.lbl_aylikodeme = new System.Windows.Forms.Label();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.lbl_tlfnumarası = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.isimTB = new System.Windows.Forms.TextBox();
            this.soyisimTB = new System.Windows.Forms.TextBox();
            this.KanGrubuLB = new System.Windows.Forms.ComboBox();
            this.TelefonNumarasiTB = new System.Windows.Forms.TextBox();
            this.EPostaTB = new System.Windows.Forms.TextBox();
            this.AylikOdemeTB = new System.Windows.Forms.TextBox();
            this.SehirCB = new System.Windows.Forms.ComboBox();
            this.KaydetBTN = new System.Windows.Forms.Button();
            this.CinsiyetCB = new System.Windows.Forms.ComboBox();
            this.UyelikDurumuCB = new System.Windows.Forms.ComboBox();
            this.DogumtarihiLB = new System.Windows.Forms.Label();
            this.dogumtarihiTB = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBS_UyeKayit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TckimliknoTB
            // 
            this.TckimliknoTB.Location = new System.Drawing.Point(194, 90);
            this.TckimliknoTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TckimliknoTB.Name = "TckimliknoTB";
            this.TckimliknoTB.Size = new System.Drawing.Size(156, 20);
            this.TckimliknoTB.TabIndex = 0;
            this.TckimliknoTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_tckimlikno
            // 
            this.lbl_tckimlikno.AutoSize = true;
            this.lbl_tckimlikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tckimlikno.Location = new System.Drawing.Point(6, 90);
            this.lbl_tckimlikno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tckimlikno.Name = "lbl_tckimlikno";
            this.lbl_tckimlikno.Size = new System.Drawing.Size(168, 17);
            this.lbl_tckimlikno.TabIndex = 1;
            this.lbl_tckimlikno.Text = " TC Kimlik Numarası  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üye Kayıt Ekranı";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(95, 142);
            this.lbl_isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(79, 17);
            this.lbl_isim.TabIndex = 3;
            this.lbl_isim.Text = "Üye İsim :";
            // 
            // lbl_kangrubu
            // 
            this.lbl_kangrubu.AutoSize = true;
            this.lbl_kangrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kangrubu.Location = new System.Drawing.Point(78, 336);
            this.lbl_kangrubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kangrubu.Name = "lbl_kangrubu";
            this.lbl_kangrubu.Size = new System.Drawing.Size(96, 17);
            this.lbl_kangrubu.TabIndex = 4;
            this.lbl_kangrubu.Text = "Kan Grubu :";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(99, 289);
            this.lbl_cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(75, 17);
            this.lbl_cinsiyet.TabIndex = 5;
            this.lbl_cinsiyet.Text = "Cinsiyet :";
            // 
            // lbl_dogumgunu
            // 
            this.lbl_dogumgunu.AutoSize = true;
            this.lbl_dogumgunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dogumgunu.Location = new System.Drawing.Point(59, 236);
            this.lbl_dogumgunu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dogumgunu.Name = "lbl_dogumgunu";
            this.lbl_dogumgunu.Size = new System.Drawing.Size(0, 17);
            this.lbl_dogumgunu.TabIndex = 6;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(68, 187);
            this.lbl_soyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(106, 17);
            this.lbl_soyisim.TabIndex = 7;
            this.lbl_soyisim.Text = "Üye Soyisim :";
            // 
            // lbl_aktifpasif
            // 
            this.lbl_aktifpasif.AutoSize = true;
            this.lbl_aktifpasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktifpasif.Location = new System.Drawing.Point(481, 90);
            this.lbl_aktifpasif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aktifpasif.Name = "lbl_aktifpasif";
            this.lbl_aktifpasif.Size = new System.Drawing.Size(106, 17);
            this.lbl_aktifpasif.TabIndex = 8;
            this.lbl_aktifpasif.Text = "Aktif / Pasif  :";
            // 
            // lbl_aylikodeme
            // 
            this.lbl_aylikodeme.AutoSize = true;
            this.lbl_aylikodeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aylikodeme.Location = new System.Drawing.Point(479, 141);
            this.lbl_aylikodeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aylikodeme.Name = "lbl_aylikodeme";
            this.lbl_aylikodeme.Size = new System.Drawing.Size(108, 17);
            this.lbl_aylikodeme.TabIndex = 9;
            this.lbl_aylikodeme.Text = "Aylık Ödeme :";
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.AutoSize = true;
            this.lbl_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sehir.Location = new System.Drawing.Point(499, 289);
            this.lbl_sehir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(61, 17);
            this.lbl_sehir.TabIndex = 10;
            this.lbl_sehir.Text = "Şehir  :";
            // 
            // lbl_tlfnumarası
            // 
            this.lbl_tlfnumarası.AutoSize = true;
            this.lbl_tlfnumarası.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tlfnumarası.Location = new System.Drawing.Point(440, 236);
            this.lbl_tlfnumarası.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tlfnumarası.Name = "lbl_tlfnumarası";
            this.lbl_tlfnumarası.Size = new System.Drawing.Size(146, 17);
            this.lbl_tlfnumarası.TabIndex = 11;
            this.lbl_tlfnumarası.Text = "Telefon Numarası :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.Location = new System.Drawing.Point(512, 186);
            this.lbl_eposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(75, 17);
            this.lbl_eposta.TabIndex = 12;
            this.lbl_eposta.Text = "E-Posta :";
            // 
            // isimTB
            // 
            this.isimTB.Location = new System.Drawing.Point(194, 141);
            this.isimTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isimTB.Name = "isimTB";
            this.isimTB.Size = new System.Drawing.Size(156, 20);
            this.isimTB.TabIndex = 13;
            // 
            // soyisimTB
            // 
            this.soyisimTB.Location = new System.Drawing.Point(194, 184);
            this.soyisimTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.soyisimTB.Name = "soyisimTB";
            this.soyisimTB.Size = new System.Drawing.Size(156, 20);
            this.soyisimTB.TabIndex = 14;
            // 
            // KanGrubuLB
            // 
            this.KanGrubuLB.BackColor = System.Drawing.Color.White;
            this.KanGrubuLB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KanGrubuLB.FormattingEnabled = true;
            this.KanGrubuLB.Items.AddRange(new object[] {
            "0RH(-)",
            "0RH(+)",
            "ARH(-) ",
            "ARH(+) ",
            "ABRH(-) ",
            "ABRH(+)",
            "BRH(-) ",
            "BRH(+)"});
            this.KanGrubuLB.Location = new System.Drawing.Point(194, 335);
            this.KanGrubuLB.Name = "KanGrubuLB";
            this.KanGrubuLB.Size = new System.Drawing.Size(156, 21);
            this.KanGrubuLB.TabIndex = 18;
            // 
            // TelefonNumarasiTB
            // 
            this.TelefonNumarasiTB.Location = new System.Drawing.Point(594, 239);
            this.TelefonNumarasiTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TelefonNumarasiTB.Name = "TelefonNumarasiTB";
            this.TelefonNumarasiTB.Size = new System.Drawing.Size(156, 20);
            this.TelefonNumarasiTB.TabIndex = 20;
            // 
            // EPostaTB
            // 
            this.EPostaTB.Location = new System.Drawing.Point(594, 186);
            this.EPostaTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EPostaTB.Name = "EPostaTB";
            this.EPostaTB.Size = new System.Drawing.Size(156, 20);
            this.EPostaTB.TabIndex = 21;
            // 
            // AylikOdemeTB
            // 
            this.AylikOdemeTB.Location = new System.Drawing.Point(594, 139);
            this.AylikOdemeTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AylikOdemeTB.Name = "AylikOdemeTB";
            this.AylikOdemeTB.Size = new System.Drawing.Size(156, 20);
            this.AylikOdemeTB.TabIndex = 22;
            // 
            // SehirCB
            // 
            this.SehirCB.BackColor = System.Drawing.Color.White;
            this.SehirCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SehirCB.FormattingEnabled = true;
            this.SehirCB.Items.AddRange(new object[] {
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
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
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
            this.SehirCB.Location = new System.Drawing.Point(594, 289);
            this.SehirCB.Name = "SehirCB";
            this.SehirCB.Size = new System.Drawing.Size(156, 21);
            this.SehirCB.TabIndex = 24;
            // 
            // KaydetBTN
            // 
            this.KaydetBTN.BackColor = System.Drawing.Color.Lime;
            this.KaydetBTN.Location = new System.Drawing.Point(594, 329);
            this.KaydetBTN.Name = "KaydetBTN";
            this.KaydetBTN.Size = new System.Drawing.Size(156, 27);
            this.KaydetBTN.TabIndex = 25;
            this.KaydetBTN.Text = "KAYDET ";
            this.KaydetBTN.UseVisualStyleBackColor = false;
            this.KaydetBTN.Click += new System.EventHandler(this.KaydetBTN_Click_1);
            // 
            // CinsiyetCB
            // 
            this.CinsiyetCB.FormattingEnabled = true;
            this.CinsiyetCB.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
            this.CinsiyetCB.Location = new System.Drawing.Point(194, 289);
            this.CinsiyetCB.Name = "CinsiyetCB";
            this.CinsiyetCB.Size = new System.Drawing.Size(156, 21);
            this.CinsiyetCB.TabIndex = 30;
            // 
            // UyelikDurumuCB
            // 
            this.UyelikDurumuCB.FormattingEnabled = true;
            this.UyelikDurumuCB.Items.AddRange(new object[] {
            "Aktif ",
            "Pasif"});
            this.UyelikDurumuCB.Location = new System.Drawing.Point(594, 86);
            this.UyelikDurumuCB.Name = "UyelikDurumuCB";
            this.UyelikDurumuCB.Size = new System.Drawing.Size(156, 21);
            this.UyelikDurumuCB.TabIndex = 31;
            // 
            // DogumtarihiLB
            // 
            this.DogumtarihiLB.AutoSize = true;
            this.DogumtarihiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogumtarihiLB.Location = new System.Drawing.Point(68, 239);
            this.DogumtarihiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DogumtarihiLB.Name = "DogumtarihiLB";
            this.DogumtarihiLB.Size = new System.Drawing.Size(120, 17);
            this.DogumtarihiLB.TabIndex = 32;
            this.DogumtarihiLB.Text = "Doğum Tarihi  :";
            // 
            // dogumtarihiTB
            // 
            this.dogumtarihiTB.Location = new System.Drawing.Point(194, 233);
            this.dogumtarihiTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dogumtarihiTB.Name = "dogumtarihiTB";
            this.dogumtarihiTB.Size = new System.Drawing.Size(156, 20);
            this.dogumtarihiTB.TabIndex = 33;
            this.dogumtarihiTB.Text = "Yıl/Ay/Gün";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBS_UyeKayit,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TBS_UyeKayit
            // 
            this.TBS_UyeKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBS_UyeKayit.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TBS_UyeKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBS_UyeKayit.Name = "TBS_UyeKayit";
            this.TBS_UyeKayit.Size = new System.Drawing.Size(23, 22);
            this.TBS_UyeKayit.Text = "toolStripButton1";
            this.TBS_UyeKayit.ToolTipText = "Ana Menüye Dön";
            this.TBS_UyeKayit.Click += new System.EventHandler(this.TBS_UyeKayit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Iconshock_Real_Vista_Text_Print_32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Yazdır";
            // 
            // UyeKayıtAlmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(808, 374);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dogumtarihiTB);
            this.Controls.Add(this.DogumtarihiLB);
            this.Controls.Add(this.UyelikDurumuCB);
            this.Controls.Add(this.CinsiyetCB);
            this.Controls.Add(this.KaydetBTN);
            this.Controls.Add(this.SehirCB);
            this.Controls.Add(this.AylikOdemeTB);
            this.Controls.Add(this.EPostaTB);
            this.Controls.Add(this.TelefonNumarasiTB);
            this.Controls.Add(this.KanGrubuLB);
            this.Controls.Add(this.soyisimTB);
            this.Controls.Add(this.isimTB);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.lbl_tlfnumarası);
            this.Controls.Add(this.lbl_sehir);
            this.Controls.Add(this.lbl_aylikodeme);
            this.Controls.Add(this.lbl_aktifpasif);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_dogumgunu);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_kangrubu);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tckimlikno);
            this.Controls.Add(this.TckimliknoTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UyeKayıtAlmaEkrani";
            this.Text = "User_Registiration_Form";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TckimliknoTB;
        private System.Windows.Forms.Label lbl_tckimlikno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_kangrubu;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_dogumgunu;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_aktifpasif;
        private System.Windows.Forms.Label lbl_aylikodeme;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.Label lbl_tlfnumarası;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.TextBox isimTB;
        private System.Windows.Forms.TextBox soyisimTB;
        private System.Windows.Forms.ComboBox KanGrubuLB;
        private System.Windows.Forms.TextBox TelefonNumarasiTB;
        private System.Windows.Forms.TextBox EPostaTB;
        private System.Windows.Forms.TextBox AylikOdemeTB;
        private System.Windows.Forms.ComboBox SehirCB;
        private System.Windows.Forms.Button KaydetBTN;
        private System.Windows.Forms.ComboBox CinsiyetCB;
        private System.Windows.Forms.ComboBox UyelikDurumuCB;
        private System.Windows.Forms.Label DogumtarihiLB;
        private System.Windows.Forms.TextBox dogumtarihiTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBS_UyeKayit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}