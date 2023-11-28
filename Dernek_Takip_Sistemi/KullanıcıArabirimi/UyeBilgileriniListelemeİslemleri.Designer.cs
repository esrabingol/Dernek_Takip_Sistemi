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
            this.ListelemeDGW = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.KanGrubu_BTN = new System.Windows.Forms.Button();
            this.SehirListele_BTN = new System.Windows.Forms.Button();
            this.DurumBTN = new System.Windows.Forms.Button();
            this.BaslikLB = new System.Windows.Forms.Label();
            this.UyeKayitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UyeGuncelleBTN = new System.Windows.Forms.Button();
            this.UyeSilBTN = new System.Windows.Forms.Button();
            this.TumUyeleriGorBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // ListelemeDGW
            // 
            this.ListelemeDGW.BackgroundColor = System.Drawing.Color.White;
            this.ListelemeDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListelemeDGW.Location = new System.Drawing.Point(366, 65);
            this.ListelemeDGW.Name = "ListelemeDGW";
            this.ListelemeDGW.Size = new System.Drawing.Size(434, 171);
            this.ListelemeDGW.TabIndex = 0;
            // 
            // KanGrubu_BTN
            // 
            this.KanGrubu_BTN.BackColor = System.Drawing.Color.White;
            this.KanGrubu_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KanGrubu_BTN.Location = new System.Drawing.Point(29, 65);
            this.KanGrubu_BTN.Name = "KanGrubu_BTN";
            this.KanGrubu_BTN.Size = new System.Drawing.Size(283, 35);
            this.KanGrubu_BTN.TabIndex = 1;
            this.KanGrubu_BTN.Text = "1- Kan Grubuna Göre Listelemek İçin Tıklayınız.\r\n";
            this.KanGrubu_BTN.UseVisualStyleBackColor = false;
            this.KanGrubu_BTN.Click += new System.EventHandler(this.KanGrubu_BTN_Click);
            // 
            // SehirListele_BTN
            // 
            this.SehirListele_BTN.BackColor = System.Drawing.Color.White;
            this.SehirListele_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SehirListele_BTN.Location = new System.Drawing.Point(29, 106);
            this.SehirListele_BTN.Name = "SehirListele_BTN";
            this.SehirListele_BTN.Size = new System.Drawing.Size(283, 35);
            this.SehirListele_BTN.TabIndex = 2;
            this.SehirListele_BTN.Text = "2- Şehire Göre Listelemek İçin Tıklayınız.\r\n";
            this.SehirListele_BTN.UseVisualStyleBackColor = false;
            this.SehirListele_BTN.Click += new System.EventHandler(this.SehirListele_BTN_Click);
            // 
            // DurumBTN
            // 
            this.DurumBTN.BackColor = System.Drawing.Color.White;
            this.DurumBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumBTN.Location = new System.Drawing.Point(29, 156);
            this.DurumBTN.Name = "DurumBTN";
            this.DurumBTN.Size = new System.Drawing.Size(283, 35);
            this.DurumBTN.TabIndex = 3;
            this.DurumBTN.Text = "3- Aktif/ Pasif Durumuna Göre Listelemek İçin Tıklayınız.\r\n";
            this.DurumBTN.UseVisualStyleBackColor = false;
            this.DurumBTN.Click += new System.EventHandler(this.DurumBTN_Click);
            // 
            // BaslikLB
            // 
            this.BaslikLB.AutoSize = true;
            this.BaslikLB.BackColor = System.Drawing.Color.Gainsboro;
            this.BaslikLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslikLB.ForeColor = System.Drawing.Color.Black;
            this.BaslikLB.Location = new System.Drawing.Point(266, 9);
            this.BaslikLB.Name = "BaslikLB";
            this.BaslikLB.Size = new System.Drawing.Size(240, 25);
            this.BaslikLB.TabIndex = 4;
            this.BaslikLB.Text = "Üye Listeleme İşlemleri ";
            // 
            // UyeKayitBTN
            // 
            this.UyeKayitBTN.BackColor = System.Drawing.Color.White;
            this.UyeKayitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeKayitBTN.Location = new System.Drawing.Point(188, 361);
            this.UyeKayitBTN.Name = "UyeKayitBTN";
            this.UyeKayitBTN.Size = new System.Drawing.Size(124, 41);
            this.UyeKayitBTN.TabIndex = 6;
            this.UyeKayitBTN.Text = "Yeni Üye Kaydetme İşlemi";
            this.UyeKayitBTN.UseVisualStyleBackColor = false;
            this.UyeKayitBTN.Click += new System.EventHandler(this.UyeKayitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yapmak İstediğiniz İşlemi Seçiniz :";
            // 
            // UyeGuncelleBTN
            // 
            this.UyeGuncelleBTN.BackColor = System.Drawing.Color.White;
            this.UyeGuncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeGuncelleBTN.Location = new System.Drawing.Point(348, 361);
            this.UyeGuncelleBTN.Name = "UyeGuncelleBTN";
            this.UyeGuncelleBTN.Size = new System.Drawing.Size(124, 41);
            this.UyeGuncelleBTN.TabIndex = 8;
            this.UyeGuncelleBTN.Text = "Üye Güncelleme İşlemi";
            this.UyeGuncelleBTN.UseVisualStyleBackColor = false;
            this.UyeGuncelleBTN.Click += new System.EventHandler(this.UyeGuncelleBTN_Click);
            // 
            // UyeSilBTN
            // 
            this.UyeSilBTN.BackColor = System.Drawing.Color.White;
            this.UyeSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSilBTN.Location = new System.Drawing.Point(43, 361);
            this.UyeSilBTN.Name = "UyeSilBTN";
            this.UyeSilBTN.Size = new System.Drawing.Size(113, 41);
            this.UyeSilBTN.TabIndex = 9;
            this.UyeSilBTN.Text = "Üye Silme İşlemi";
            this.UyeSilBTN.UseVisualStyleBackColor = false;
            this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
            // 
            // TumUyeleriGorBTN
            // 
            this.TumUyeleriGorBTN.BackColor = System.Drawing.Color.White;
            this.TumUyeleriGorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumUyeleriGorBTN.Location = new System.Drawing.Point(29, 201);
            this.TumUyeleriGorBTN.Name = "TumUyeleriGorBTN";
            this.TumUyeleriGorBTN.Size = new System.Drawing.Size(283, 35);
            this.TumUyeleriGorBTN.TabIndex = 10;
            this.TumUyeleriGorBTN.Text = "4- Tüm Üyeleri Ve Bilgilerini Listelemek İçin Tıklayınız.\r\n";
            this.TumUyeleriGorBTN.UseVisualStyleBackColor = false;
            this.TumUyeleriGorBTN.Click += new System.EventHandler(this.TumUyeleriGorBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yeni Üye Kaydet",
            " Üye Sil",
            "Üye Güncelle",
            "Mail Gönder",
            "Üye aktif/pasif Durumunu Belirle"});
            this.comboBox1.Location = new System.Drawing.Point(43, 313);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // UyeBilgileriniListelemeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(801, 489);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TumUyeleriGorBTN);
            this.Controls.Add(this.UyeSilBTN);
            this.Controls.Add(this.UyeGuncelleBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UyeKayitBTN);
            this.Controls.Add(this.BaslikLB);
            this.Controls.Add(this.DurumBTN);
            this.Controls.Add(this.SehirListele_BTN);
            this.Controls.Add(this.KanGrubu_BTN);
            this.Controls.Add(this.ListelemeDGW);
            this.Name = "UyeBilgileriniListelemeİslemleri";
            this.Text = "Listing_Screens";
            ((System.ComponentModel.ISupportInitialize)(this.ListelemeDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListelemeDGW;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button KanGrubu_BTN;
        private System.Windows.Forms.Button SehirListele_BTN;
        private System.Windows.Forms.Button DurumBTN;
        private System.Windows.Forms.Label BaslikLB;
        private System.Windows.Forms.Button UyeKayitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UyeGuncelleBTN;
        private System.Windows.Forms.Button UyeSilBTN;
        private System.Windows.Forms.Button TumUyeleriGorBTN;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}