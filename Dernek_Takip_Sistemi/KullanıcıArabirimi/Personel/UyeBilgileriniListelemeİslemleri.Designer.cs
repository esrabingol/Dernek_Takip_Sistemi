namespace Dernek_Takip_Sistemi
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
			this.sehirler_CB = new System.Windows.Forms.ComboBox();
			this.ListelemeDGW = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.guno_YıillikZ = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_AylikZ = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_BorcDurumu = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_KanGrubu = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_durumaGore = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_TC = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_SehreGoreListeleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guno_TumUyelerBTN = new Guna.UI2.WinForms.Guna2GradientButton();
			this.TC_TBX = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_Logout = new System.Windows.Forms.ToolStripButton();
			this.pdfkaydet_BTN = new System.Windows.Forms.Button();
			this.MailGonderBTN = new System.Windows.Forms.Button();
			this.BilgiYazdirBTN = new System.Windows.Forms.Button();
			this.UyeKayitBTN = new System.Windows.Forms.Button();
			this.UyeSilBTN = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BaslikLB
			// 
			this.BaslikLB.AutoSize = true;
			this.BaslikLB.BackColor = System.Drawing.Color.Transparent;
			this.BaslikLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BaslikLB.ForeColor = System.Drawing.Color.Black;
			this.BaslikLB.Location = new System.Drawing.Point(451, 39);
			this.BaslikLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.BaslikLB.Name = "BaslikLB";
			this.BaslikLB.Size = new System.Drawing.Size(0, 33);
			this.BaslikLB.TabIndex = 4;
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
			this.sehirler_CB.Location = new System.Drawing.Point(24, 75);
			this.sehirler_CB.Margin = new System.Windows.Forms.Padding(4);
			this.sehirler_CB.Name = "sehirler_CB";
			this.sehirler_CB.Size = new System.Drawing.Size(231, 25);
			this.sehirler_CB.TabIndex = 12;
			// 
			// ListelemeDGW
			// 
			this.ListelemeDGW.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.ListelemeDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListelemeDGW.Location = new System.Drawing.Point(532, 41);
			this.ListelemeDGW.Margin = new System.Windows.Forms.Padding(4);
			this.ListelemeDGW.Name = "ListelemeDGW";
			this.ListelemeDGW.RowHeadersWidth = 51;
			this.ListelemeDGW.Size = new System.Drawing.Size(628, 359);
			this.ListelemeDGW.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.groupBox1.Controls.Add(this.guno_YıillikZ);
			this.groupBox1.Controls.Add(this.guno_AylikZ);
			this.groupBox1.Controls.Add(this.guna2GradientButton2);
			this.groupBox1.Controls.Add(this.guna2GradientButton1);
			this.groupBox1.Controls.Add(this.guno_BorcDurumu);
			this.groupBox1.Controls.Add(this.guno_KanGrubu);
			this.groupBox1.Controls.Add(this.guno_durumaGore);
			this.groupBox1.Controls.Add(this.guno_TC);
			this.groupBox1.Controls.Add(this.guno_SehreGoreListeleBtn);
			this.groupBox1.Controls.Add(this.guno_TumUyelerBTN);
			this.groupBox1.Controls.Add(this.TC_TBX);
			this.groupBox1.Controls.Add(this.ListelemeDGW);
			this.groupBox1.Controls.Add(this.sehirler_CB);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(29, 47);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1179, 421);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LİSTELEME İŞLEMLERİ";
			// 
			// guno_YıillikZ
			// 
			this.guno_YıillikZ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_YıillikZ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_YıillikZ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_YıillikZ.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_YıillikZ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_YıillikZ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_YıillikZ.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_YıillikZ.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_YıillikZ.ForeColor = System.Drawing.Color.Black;
			this.guno_YıillikZ.Location = new System.Drawing.Point(24, 375);
			this.guno_YıillikZ.Margin = new System.Windows.Forms.Padding(4);
			this.guno_YıillikZ.Name = "guno_YıillikZ";
			this.guno_YıillikZ.Size = new System.Drawing.Size(463, 26);
			this.guno_YıillikZ.TabIndex = 29;
			this.guno_YıillikZ.Text = "10 - Aidat Miktarı Yıllık ZedGraph";
			this.guno_YıillikZ.Click += new System.EventHandler(this.guno_YıillikZ_Click);
			// 
			// guno_AylikZ
			// 
			this.guno_AylikZ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_AylikZ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_AylikZ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_AylikZ.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_AylikZ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_AylikZ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_AylikZ.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_AylikZ.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_AylikZ.ForeColor = System.Drawing.Color.Black;
			this.guno_AylikZ.Location = new System.Drawing.Point(24, 342);
			this.guno_AylikZ.Margin = new System.Windows.Forms.Padding(4);
			this.guno_AylikZ.Name = "guno_AylikZ";
			this.guno_AylikZ.Size = new System.Drawing.Size(463, 26);
			this.guno_AylikZ.TabIndex = 28;
			this.guno_AylikZ.Text = "9 - Aidat Miktarı Aylık ZedGraph";
			this.guno_AylikZ.Click += new System.EventHandler(this.guno_AylikZ_Click);
			// 
			// guna2GradientButton2
			// 
			this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guna2GradientButton2.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
			this.guna2GradientButton2.Location = new System.Drawing.Point(24, 303);
			this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GradientButton2.Name = "guna2GradientButton2";
			this.guna2GradientButton2.Size = new System.Drawing.Size(463, 26);
			this.guna2GradientButton2.TabIndex = 27;
			this.guna2GradientButton2.Text = "8-Ödeme Durum Bilgisi Listeleme";
			this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
			// 
			// guna2GradientButton1
			// 
			this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guna2GradientButton1.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
			this.guna2GradientButton1.Location = new System.Drawing.Point(24, 267);
			this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new System.Drawing.Size(463, 26);
			this.guna2GradientButton1.TabIndex = 26;
			this.guna2GradientButton1.Text = "7-Üyelerin Şehilere Göre Dağılımı Zedgraph";
			this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
			// 
			// guno_BorcDurumu
			// 
			this.guno_BorcDurumu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_BorcDurumu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_BorcDurumu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_BorcDurumu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_BorcDurumu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_BorcDurumu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_BorcDurumu.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_BorcDurumu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_BorcDurumu.ForeColor = System.Drawing.Color.Black;
			this.guno_BorcDurumu.Location = new System.Drawing.Point(24, 228);
			this.guno_BorcDurumu.Margin = new System.Windows.Forms.Padding(4);
			this.guno_BorcDurumu.Name = "guno_BorcDurumu";
			this.guno_BorcDurumu.Size = new System.Drawing.Size(463, 26);
			this.guno_BorcDurumu.TabIndex = 25;
			this.guno_BorcDurumu.Text = "6- Borç Durumuna Göre Listele";
			this.guno_BorcDurumu.Click += new System.EventHandler(this.guno_BorcDurumu_Click);
			// 
			// guno_KanGrubu
			// 
			this.guno_KanGrubu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_KanGrubu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_KanGrubu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_KanGrubu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_KanGrubu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_KanGrubu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_KanGrubu.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_KanGrubu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_KanGrubu.ForeColor = System.Drawing.Color.Black;
			this.guno_KanGrubu.Location = new System.Drawing.Point(24, 195);
			this.guno_KanGrubu.Margin = new System.Windows.Forms.Padding(4);
			this.guno_KanGrubu.Name = "guno_KanGrubu";
			this.guno_KanGrubu.Size = new System.Drawing.Size(463, 26);
			this.guno_KanGrubu.TabIndex = 24;
			this.guno_KanGrubu.Text = "5-Kan Grubuna Göre Listele";
			this.guno_KanGrubu.Click += new System.EventHandler(this.guno_KanGrubu_Click);
			// 
			// guno_durumaGore
			// 
			this.guno_durumaGore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_durumaGore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_durumaGore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_durumaGore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_durumaGore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_durumaGore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_durumaGore.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_durumaGore.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_durumaGore.ForeColor = System.Drawing.Color.Black;
			this.guno_durumaGore.Location = new System.Drawing.Point(24, 156);
			this.guno_durumaGore.Margin = new System.Windows.Forms.Padding(4);
			this.guno_durumaGore.Name = "guno_durumaGore";
			this.guno_durumaGore.Size = new System.Drawing.Size(463, 26);
			this.guno_durumaGore.TabIndex = 23;
			this.guno_durumaGore.Text = "4-Aktif/ Pasif Duruma Göre Listele";
			this.guno_durumaGore.Click += new System.EventHandler(this.guno_durumaGore_Click);
			// 
			// guno_TC
			// 
			this.guno_TC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_TC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_TC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_TC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_TC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_TC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_TC.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_TC.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_TC.ForeColor = System.Drawing.Color.Black;
			this.guno_TC.Location = new System.Drawing.Point(264, 107);
			this.guno_TC.Margin = new System.Windows.Forms.Padding(4);
			this.guno_TC.Name = "guno_TC";
			this.guno_TC.Size = new System.Drawing.Size(223, 26);
			this.guno_TC.TabIndex = 22;
			this.guno_TC.Text = "3-TC\'ye Göre Kullanıcı Bul";
			this.guno_TC.Click += new System.EventHandler(this.guno_TC_Click);
			// 
			// guno_SehreGoreListeleBtn
			// 
			this.guno_SehreGoreListeleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_SehreGoreListeleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_SehreGoreListeleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_SehreGoreListeleBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_SehreGoreListeleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_SehreGoreListeleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_SehreGoreListeleBtn.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_SehreGoreListeleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_SehreGoreListeleBtn.ForeColor = System.Drawing.Color.Black;
			this.guno_SehreGoreListeleBtn.Location = new System.Drawing.Point(264, 75);
			this.guno_SehreGoreListeleBtn.Margin = new System.Windows.Forms.Padding(4);
			this.guno_SehreGoreListeleBtn.Name = "guno_SehreGoreListeleBtn";
			this.guno_SehreGoreListeleBtn.Size = new System.Drawing.Size(223, 26);
			this.guno_SehreGoreListeleBtn.TabIndex = 21;
			this.guno_SehreGoreListeleBtn.Text = "2- Şehire Göre Listele";
			this.guno_SehreGoreListeleBtn.Click += new System.EventHandler(this.guno_SehreGoreListeleBtn_Click);
			// 
			// guno_TumUyelerBTN
			// 
			this.guno_TumUyelerBTN.BackColor = System.Drawing.Color.Sienna;
			this.guno_TumUyelerBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_TumUyelerBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_TumUyelerBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_TumUyelerBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_TumUyelerBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_TumUyelerBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guno_TumUyelerBTN.FillColor2 = System.Drawing.Color.LightSteelBlue;
			this.guno_TumUyelerBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guno_TumUyelerBTN.ForeColor = System.Drawing.Color.Black;
			this.guno_TumUyelerBTN.Location = new System.Drawing.Point(24, 41);
			this.guno_TumUyelerBTN.Margin = new System.Windows.Forms.Padding(4);
			this.guno_TumUyelerBTN.Name = "guno_TumUyelerBTN";
			this.guno_TumUyelerBTN.Size = new System.Drawing.Size(463, 26);
			this.guno_TumUyelerBTN.TabIndex = 20;
			this.guno_TumUyelerBTN.Text = "1- Tüm Üyeleri Ve Bilgilerini Listele";
			this.guno_TumUyelerBTN.Click += new System.EventHandler(this.guno_TumUyelerBTN_Click);
			// 
			// TC_TBX
			// 
			this.TC_TBX.Location = new System.Drawing.Point(24, 108);
			this.TC_TBX.Margin = new System.Windows.Forms.Padding(4);
			this.TC_TBX.Name = "TC_TBX";
			this.TC_TBX.Size = new System.Drawing.Size(231, 23);
			this.TC_TBX.TabIndex = 15;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Logout});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(1239, 27);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_Logout
			// 
			this.TSB_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_Logout.Image = global::Dernek_Takip_Sistemi.Properties.Resources.logout;
			this.TSB_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Logout.Name = "TSB_Logout";
			this.TSB_Logout.Size = new System.Drawing.Size(29, 24);
			this.TSB_Logout.Text = "toolStripButton1";
			this.TSB_Logout.ToolTipText = "Çıkış Yap";
			this.TSB_Logout.Click += new System.EventHandler(this.TSB_Logout_Click);
			// 
			// pdfkaydet_BTN
			// 
			this.pdfkaydet_BTN.BackColor = System.Drawing.Color.White;
			this.pdfkaydet_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.pdfkaydet_BTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_3_Filetype_pdf_24;
			this.pdfkaydet_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.pdfkaydet_BTN.Location = new System.Drawing.Point(952, 12);
			this.pdfkaydet_BTN.Margin = new System.Windows.Forms.Padding(4);
			this.pdfkaydet_BTN.Name = "pdfkaydet_BTN";
			this.pdfkaydet_BTN.Size = new System.Drawing.Size(208, 52);
			this.pdfkaydet_BTN.TabIndex = 17;
			this.pdfkaydet_BTN.Text = "Pdf Olarak Kaydet";
			this.pdfkaydet_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.pdfkaydet_BTN.UseVisualStyleBackColor = false;
			this.pdfkaydet_BTN.Click += new System.EventHandler(this.button3_Click);
			// 
			// MailGonderBTN
			// 
			this.MailGonderBTN.BackColor = System.Drawing.Color.White;
			this.MailGonderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.MailGonderBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MailGonderBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.eposta;
			this.MailGonderBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.MailGonderBTN.Location = new System.Drawing.Point(532, 12);
			this.MailGonderBTN.Margin = new System.Windows.Forms.Padding(4);
			this.MailGonderBTN.Name = "MailGonderBTN";
			this.MailGonderBTN.Size = new System.Drawing.Size(167, 52);
			this.MailGonderBTN.TabIndex = 15;
			this.MailGonderBTN.Text = "Mail Gönder";
			this.MailGonderBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.MailGonderBTN.UseVisualStyleBackColor = false;
			this.MailGonderBTN.Click += new System.EventHandler(this.MailGonderBTN_Click);
			// 
			// BilgiYazdirBTN
			// 
			this.BilgiYazdirBTN.BackColor = System.Drawing.Color.White;
			this.BilgiYazdirBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BilgiYazdirBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Iconshock_Real_Vista_Text_Print_32;
			this.BilgiYazdirBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.BilgiYazdirBTN.Location = new System.Drawing.Point(742, 12);
			this.BilgiYazdirBTN.Margin = new System.Windows.Forms.Padding(4);
			this.BilgiYazdirBTN.Name = "BilgiYazdirBTN";
			this.BilgiYazdirBTN.Size = new System.Drawing.Size(177, 52);
			this.BilgiYazdirBTN.TabIndex = 14;
			this.BilgiYazdirBTN.Text = " Bilgileri Yazdır";
			this.BilgiYazdirBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BilgiYazdirBTN.UseVisualStyleBackColor = false;
			this.BilgiYazdirBTN.Click += new System.EventHandler(this.BilgiYazdirBTN_Click);
			// 
			// UyeKayitBTN
			// 
			this.UyeKayitBTN.BackColor = System.Drawing.Color.White;
			this.UyeKayitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UyeKayitBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.user;
			this.UyeKayitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UyeKayitBTN.Location = new System.Drawing.Point(249, 12);
			this.UyeKayitBTN.Margin = new System.Windows.Forms.Padding(4);
			this.UyeKayitBTN.Name = "UyeKayitBTN";
			this.UyeKayitBTN.Size = new System.Drawing.Size(249, 52);
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
			this.UyeSilBTN.Location = new System.Drawing.Point(15, 12);
			this.UyeSilBTN.Margin = new System.Windows.Forms.Padding(4);
			this.UyeSilBTN.Name = "UyeSilBTN";
			this.UyeSilBTN.Size = new System.Drawing.Size(197, 52);
			this.UyeSilBTN.TabIndex = 9;
			this.UyeSilBTN.Text = "Üye Silme İşlemi";
			this.UyeSilBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UyeSilBTN.UseVisualStyleBackColor = false;
			this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
			this.groupBox2.Controls.Add(this.UyeSilBTN);
			this.groupBox2.Controls.Add(this.pdfkaydet_BTN);
			this.groupBox2.Controls.Add(this.UyeKayitBTN);
			this.groupBox2.Controls.Add(this.MailGonderBTN);
			this.groupBox2.Controls.Add(this.BilgiYazdirBTN);
			this.groupBox2.Location = new System.Drawing.Point(29, 476);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1179, 72);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// UyeBilgileriniListelemeİslemleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1239, 561);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BaslikLB);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UyeBilgileriniListelemeİslemleri";
			this.Text = "Personel Anasayfa";
			((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox sehirler_CB;
        private System.Windows.Forms.DataGridView ListelemeDGW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BilgiYazdirBTN;
        private System.Windows.Forms.Button MailGonderBTN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Logout;
        private System.Windows.Forms.Button pdfkaydet_BTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox TC_TBX;
        private Guna.UI2.WinForms.Guna2GradientButton guno_TumUyelerBTN;
        private Guna.UI2.WinForms.Guna2GradientButton guno_SehreGoreListeleBtn;
        private Guna.UI2.WinForms.Guna2GradientButton guno_TC;
        private Guna.UI2.WinForms.Guna2GradientButton guno_durumaGore;
        private Guna.UI2.WinForms.Guna2GradientButton guno_KanGrubu;
        private Guna.UI2.WinForms.Guna2GradientButton guno_BorcDurumu;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guno_YıillikZ;
        private Guna.UI2.WinForms.Guna2GradientButton guno_AylikZ;
    }
}