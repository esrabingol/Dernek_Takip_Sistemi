﻿namespace Dernek_Takip_Sistemi
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
			this.CinsiyetCB = new System.Windows.Forms.ComboBox();
			this.UyelikDurumuCB = new System.Windows.Forms.ComboBox();
			this.DogumtarihiLB = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.UKayitReturn = new System.Windows.Forms.ToolStripButton();
			this.UyeYazdir_BTN = new System.Windows.Forms.ToolStripButton();
			this.txt_Sifre = new System.Windows.Forms.TextBox();
			this.lbl_Sifre = new System.Windows.Forms.Label();
			this.date_dogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.lbl_sifreTekrar = new System.Windows.Forms.Label();
			this.chbox_parola = new System.Windows.Forms.CheckBox();
			this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
			this.guno_kaydet = new Guna.UI2.WinForms.Guna2GradientButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TckimliknoTB
			// 
			this.TckimliknoTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.TckimliknoTB.Location = new System.Drawing.Point(194, 92);
			this.TckimliknoTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TckimliknoTB.Name = "TckimliknoTB";
			this.TckimliknoTB.Size = new System.Drawing.Size(156, 23);
			this.TckimliknoTB.TabIndex = 0;
			this.TckimliknoTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lbl_tckimlikno
			// 
			this.lbl_tckimlikno.AutoSize = true;
			this.lbl_tckimlikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_tckimlikno.Location = new System.Drawing.Point(0, 95);
			this.lbl_tckimlikno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tckimlikno.Name = "lbl_tckimlikno";
			this.lbl_tckimlikno.Size = new System.Drawing.Size(194, 20);
			this.lbl_tckimlikno.TabIndex = 1;
			this.lbl_tckimlikno.Text = " TC Kimlik Numarası :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(304, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 39);
			this.label2.TabIndex = 2;
			this.label2.Text = "Üye Kaydı";
			// 
			// lbl_isim
			// 
			this.lbl_isim.AutoSize = true;
			this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_isim.Location = new System.Drawing.Point(96, 135);
			this.lbl_isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_isim.Name = "lbl_isim";
			this.lbl_isim.Size = new System.Drawing.Size(94, 20);
			this.lbl_isim.TabIndex = 3;
			this.lbl_isim.Text = "Üye İsim :";
			// 
			// lbl_kangrubu
			// 
			this.lbl_kangrubu.AutoSize = true;
			this.lbl_kangrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_kangrubu.Location = new System.Drawing.Point(80, 305);
			this.lbl_kangrubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_kangrubu.Name = "lbl_kangrubu";
			this.lbl_kangrubu.Size = new System.Drawing.Size(110, 20);
			this.lbl_kangrubu.TabIndex = 4;
			this.lbl_kangrubu.Text = "Kan Grubu :";
			// 
			// lbl_cinsiyet
			// 
			this.lbl_cinsiyet.AutoSize = true;
			this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_cinsiyet.Location = new System.Drawing.Point(101, 262);
			this.lbl_cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_cinsiyet.Name = "lbl_cinsiyet";
			this.lbl_cinsiyet.Size = new System.Drawing.Size(89, 20);
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
			this.lbl_dogumgunu.Size = new System.Drawing.Size(0, 20);
			this.lbl_dogumgunu.TabIndex = 6;
			// 
			// lbl_soyisim
			// 
			this.lbl_soyisim.AutoSize = true;
			this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_soyisim.Location = new System.Drawing.Point(65, 176);
			this.lbl_soyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_soyisim.Name = "lbl_soyisim";
			this.lbl_soyisim.Size = new System.Drawing.Size(125, 20);
			this.lbl_soyisim.TabIndex = 7;
			this.lbl_soyisim.Text = "Üye Soyisim :";
			// 
			// lbl_aktifpasif
			// 
			this.lbl_aktifpasif.AutoSize = true;
			this.lbl_aktifpasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_aktifpasif.Location = new System.Drawing.Point(70, 351);
			this.lbl_aktifpasif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_aktifpasif.Name = "lbl_aktifpasif";
			this.lbl_aktifpasif.Size = new System.Drawing.Size(120, 20);
			this.lbl_aktifpasif.TabIndex = 8;
			this.lbl_aktifpasif.Text = "Aktif / Pasif :";
			// 
			// lbl_aylikodeme
			// 
			this.lbl_aylikodeme.AutoSize = true;
			this.lbl_aylikodeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_aylikodeme.Location = new System.Drawing.Point(445, 95);
			this.lbl_aylikodeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_aylikodeme.Name = "lbl_aylikodeme";
			this.lbl_aylikodeme.Size = new System.Drawing.Size(126, 20);
			this.lbl_aylikodeme.TabIndex = 9;
			this.lbl_aylikodeme.Text = "Aylık Ödeme :";
			// 
			// lbl_sehir
			// 
			this.lbl_sehir.AutoSize = true;
			this.lbl_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_sehir.Location = new System.Drawing.Point(503, 176);
			this.lbl_sehir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_sehir.Name = "lbl_sehir";
			this.lbl_sehir.Size = new System.Drawing.Size(65, 20);
			this.lbl_sehir.TabIndex = 10;
			this.lbl_sehir.Text = "Şehir :";
			// 
			// lbl_tlfnumarası
			// 
			this.lbl_tlfnumarası.AutoSize = true;
			this.lbl_tlfnumarası.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_tlfnumarası.Location = new System.Drawing.Point(402, 216);
			this.lbl_tlfnumarası.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tlfnumarası.Name = "lbl_tlfnumarası";
			this.lbl_tlfnumarası.Size = new System.Drawing.Size(169, 20);
			this.lbl_tlfnumarası.TabIndex = 11;
			this.lbl_tlfnumarası.Text = "Telefon Numarası :";
			// 
			// lbl_eposta
			// 
			this.lbl_eposta.AutoSize = true;
			this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_eposta.Location = new System.Drawing.Point(483, 135);
			this.lbl_eposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_eposta.Name = "lbl_eposta";
			this.lbl_eposta.Size = new System.Drawing.Size(88, 20);
			this.lbl_eposta.TabIndex = 12;
			this.lbl_eposta.Text = "E-Posta :";
			// 
			// isimTB
			// 
			this.isimTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.isimTB.Location = new System.Drawing.Point(194, 132);
			this.isimTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.isimTB.Name = "isimTB";
			this.isimTB.Size = new System.Drawing.Size(156, 23);
			this.isimTB.TabIndex = 13;
			// 
			// soyisimTB
			// 
			this.soyisimTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.soyisimTB.Location = new System.Drawing.Point(191, 173);
			this.soyisimTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.soyisimTB.Name = "soyisimTB";
			this.soyisimTB.Size = new System.Drawing.Size(159, 23);
			this.soyisimTB.TabIndex = 14;
			// 
			// KanGrubuLB
			// 
			this.KanGrubuLB.BackColor = System.Drawing.Color.WhiteSmoke;
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
			this.KanGrubuLB.Location = new System.Drawing.Point(191, 302);
			this.KanGrubuLB.Name = "KanGrubuLB";
			this.KanGrubuLB.Size = new System.Drawing.Size(159, 25);
			this.KanGrubuLB.TabIndex = 18;
			// 
			// TelefonNumarasiTB
			// 
			this.TelefonNumarasiTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.TelefonNumarasiTB.Location = new System.Drawing.Point(579, 213);
			this.TelefonNumarasiTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TelefonNumarasiTB.Name = "TelefonNumarasiTB";
			this.TelefonNumarasiTB.Size = new System.Drawing.Size(156, 23);
			this.TelefonNumarasiTB.TabIndex = 20;
			// 
			// EPostaTB
			// 
			this.EPostaTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.EPostaTB.Location = new System.Drawing.Point(579, 132);
			this.EPostaTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.EPostaTB.Name = "EPostaTB";
			this.EPostaTB.Size = new System.Drawing.Size(156, 23);
			this.EPostaTB.TabIndex = 21;
			// 
			// AylikOdemeTB
			// 
			this.AylikOdemeTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.AylikOdemeTB.Location = new System.Drawing.Point(579, 94);
			this.AylikOdemeTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AylikOdemeTB.Name = "AylikOdemeTB";
			this.AylikOdemeTB.Size = new System.Drawing.Size(156, 23);
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
			this.SehirCB.Location = new System.Drawing.Point(579, 171);
			this.SehirCB.Name = "SehirCB";
			this.SehirCB.Size = new System.Drawing.Size(156, 25);
			this.SehirCB.TabIndex = 24;
			// 
			// CinsiyetCB
			// 
			this.CinsiyetCB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.CinsiyetCB.FormattingEnabled = true;
			this.CinsiyetCB.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
			this.CinsiyetCB.Location = new System.Drawing.Point(191, 257);
			this.CinsiyetCB.Name = "CinsiyetCB";
			this.CinsiyetCB.Size = new System.Drawing.Size(159, 25);
			this.CinsiyetCB.TabIndex = 30;
			// 
			// UyelikDurumuCB
			// 
			this.UyelikDurumuCB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.UyelikDurumuCB.FormattingEnabled = true;
			this.UyelikDurumuCB.Items.AddRange(new object[] {
            "Aktif ",
            "Pasif"});
			this.UyelikDurumuCB.Location = new System.Drawing.Point(191, 346);
			this.UyelikDurumuCB.Name = "UyelikDurumuCB";
			this.UyelikDurumuCB.Size = new System.Drawing.Size(159, 25);
			this.UyelikDurumuCB.TabIndex = 31;
			// 
			// DogumtarihiLB
			// 
			this.DogumtarihiLB.AutoSize = true;
			this.DogumtarihiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DogumtarihiLB.Location = new System.Drawing.Point(56, 216);
			this.DogumtarihiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DogumtarihiLB.Name = "DogumtarihiLB";
			this.DogumtarihiLB.Size = new System.Drawing.Size(134, 20);
			this.DogumtarihiLB.TabIndex = 32;
			this.DogumtarihiLB.Text = "Doğum Tarihi :";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UKayitReturn,
            this.UyeYazdir_BTN});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(808, 27);
			this.toolStrip1.TabIndex = 34;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// UKayitReturn
			// 
			this.UKayitReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.UKayitReturn.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.UKayitReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.UKayitReturn.Name = "UKayitReturn";
			this.UKayitReturn.Size = new System.Drawing.Size(29, 28);
			this.UKayitReturn.Text = "Geri";
			this.UKayitReturn.Click += new System.EventHandler(this.UKayitReturn_Click);
			// 
			// UyeYazdir_BTN
			// 
			this.UyeYazdir_BTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.UyeYazdir_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.UyeYazdir_BTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Iconshock_Real_Vista_Text_Print_32;
			this.UyeYazdir_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.UyeYazdir_BTN.Name = "UyeYazdir_BTN";
			this.UyeYazdir_BTN.Size = new System.Drawing.Size(29, 28);
			this.UyeYazdir_BTN.Text = "Yazdır";
			this.UyeYazdir_BTN.Click += new System.EventHandler(this.UyeYazdir_BTN_Click);
			// 
			// txt_Sifre
			// 
			this.txt_Sifre.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txt_Sifre.Location = new System.Drawing.Point(579, 257);
			this.txt_Sifre.Name = "txt_Sifre";
			this.txt_Sifre.PasswordChar = '*';
			this.txt_Sifre.Size = new System.Drawing.Size(156, 23);
			this.txt_Sifre.TabIndex = 35;
			// 
			// lbl_Sifre
			// 
			this.lbl_Sifre.AutoSize = true;
			this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_Sifre.Location = new System.Drawing.Point(507, 262);
			this.lbl_Sifre.Name = "lbl_Sifre";
			this.lbl_Sifre.Size = new System.Drawing.Size(61, 20);
			this.lbl_Sifre.TabIndex = 36;
			this.lbl_Sifre.Text = "Şifre :";
			// 
			// date_dogumTarihi
			// 
			this.date_dogumTarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
			this.date_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_dogumTarihi.Location = new System.Drawing.Point(191, 213);
			this.date_dogumTarihi.Name = "date_dogumTarihi";
			this.date_dogumTarihi.Size = new System.Drawing.Size(159, 23);
			this.date_dogumTarihi.TabIndex = 38;
			this.date_dogumTarihi.Value = new System.DateTime(2023, 12, 20, 18, 57, 39, 0);
			// 
			// lbl_sifreTekrar
			// 
			this.lbl_sifreTekrar.AutoSize = true;
			this.lbl_sifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_sifreTekrar.Location = new System.Drawing.Point(442, 307);
			this.lbl_sifreTekrar.Name = "lbl_sifreTekrar";
			this.lbl_sifreTekrar.Size = new System.Drawing.Size(129, 20);
			this.lbl_sifreTekrar.TabIndex = 44;
			this.lbl_sifreTekrar.Text = "Şifre (Tekrar):";
			// 
			// chbox_parola
			// 
			this.chbox_parola.AutoSize = true;
			this.chbox_parola.Image = global::Dernek_Takip_Sistemi.Properties.Resources.closed_eye;
			this.chbox_parola.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.chbox_parola.Location = new System.Drawing.Point(747, 308);
			this.chbox_parola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chbox_parola.Name = "chbox_parola";
			this.chbox_parola.Size = new System.Drawing.Size(40, 21);
			this.chbox_parola.TabIndex = 43;
			this.chbox_parola.Text = "  ";
			this.chbox_parola.UseVisualStyleBackColor = true;
			this.chbox_parola.CheckedChanged += new System.EventHandler(this.chbox_parola_CheckedChanged);
			// 
			// txt_sifreTekrar
			// 
			this.txt_sifreTekrar.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txt_sifreTekrar.Location = new System.Drawing.Point(579, 304);
			this.txt_sifreTekrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_sifreTekrar.Name = "txt_sifreTekrar";
			this.txt_sifreTekrar.PasswordChar = '*';
			this.txt_sifreTekrar.Size = new System.Drawing.Size(156, 23);
			this.txt_sifreTekrar.TabIndex = 42;
			// 
			// guno_kaydet
			// 
			this.guno_kaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_kaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_kaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_kaydet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_kaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_kaydet.FillColor = System.Drawing.Color.White;
			this.guno_kaydet.FillColor2 = System.Drawing.Color.Lime;
			this.guno_kaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.guno_kaydet.ForeColor = System.Drawing.Color.Black;
			this.guno_kaydet.Location = new System.Drawing.Point(601, 346);
			this.guno_kaydet.Name = "guno_kaydet";
			this.guno_kaydet.Size = new System.Drawing.Size(134, 32);
			this.guno_kaydet.TabIndex = 45;
			this.guno_kaydet.Text = "KAYDET";
			this.guno_kaydet.Click += new System.EventHandler(this.guno_kaydet_Click);
			// 
			// UyeKayıtAlmaEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(808, 423);
			this.Controls.Add(this.guno_kaydet);
			this.Controls.Add(this.lbl_sifreTekrar);
			this.Controls.Add(this.chbox_parola);
			this.Controls.Add(this.txt_sifreTekrar);
			this.Controls.Add(this.date_dogumTarihi);
			this.Controls.Add(this.lbl_Sifre);
			this.Controls.Add(this.txt_Sifre);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.DogumtarihiLB);
			this.Controls.Add(this.UyelikDurumuCB);
			this.Controls.Add(this.CinsiyetCB);
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
			this.Text = "Üye Kaydı";
			this.Load += new System.EventHandler(this.UyeKayıtAlmaEkrani_Load);
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
        private System.Windows.Forms.ComboBox CinsiyetCB;
        private System.Windows.Forms.ComboBox UyelikDurumuCB;
        private System.Windows.Forms.Label DogumtarihiLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UKayitReturn;
        private System.Windows.Forms.ToolStripButton UyeYazdir_BTN;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.DateTimePicker date_dogumTarihi;
        private System.Windows.Forms.Label lbl_sifreTekrar;
        private System.Windows.Forms.CheckBox chbox_parola;
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private Guna.UI2.WinForms.Guna2GradientButton guno_kaydet;
	}
}