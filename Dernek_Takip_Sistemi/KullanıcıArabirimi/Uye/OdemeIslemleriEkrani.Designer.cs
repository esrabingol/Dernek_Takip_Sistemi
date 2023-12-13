namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Uye
{
    partial class OdemeIslemleriEkrani
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
            this.AylikOdeme_LB = new System.Windows.Forms.Label();
            this.KalanBorcu_LB = new System.Windows.Forms.Label();
            this.OdenecekTutar_LB = new System.Windows.Forms.Label();
            this.OdemeBaslik_LB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OdenecekTutar_TB = new System.Windows.Forms.TextBox();
            this.lbl_aidat = new System.Windows.Forms.Label();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AylikOdeme_LB
            // 
            this.AylikOdeme_LB.AutoSize = true;
            this.AylikOdeme_LB.Location = new System.Drawing.Point(69, 76);
            this.AylikOdeme_LB.Name = "AylikOdeme_LB";
            this.AylikOdeme_LB.Size = new System.Drawing.Size(102, 13);
            this.AylikOdeme_LB.TabIndex = 0;
            this.AylikOdeme_LB.Text = "Aylık Ödeme Tutarı :";
            // 
            // KalanBorcu_LB
            // 
            this.KalanBorcu_LB.AutoSize = true;
            this.KalanBorcu_LB.Location = new System.Drawing.Point(68, 131);
            this.KalanBorcu_LB.Name = "KalanBorcu_LB";
            this.KalanBorcu_LB.Size = new System.Drawing.Size(103, 13);
            this.KalanBorcu_LB.TabIndex = 1;
            this.KalanBorcu_LB.Text = "Kalan Toplam Borç :";
            // 
            // OdenecekTutar_LB
            // 
            this.OdenecekTutar_LB.AutoSize = true;
            this.OdenecekTutar_LB.Location = new System.Drawing.Point(44, 104);
            this.OdenecekTutar_LB.Name = "OdenecekTutar_LB";
            this.OdenecekTutar_LB.Size = new System.Drawing.Size(127, 13);
            this.OdenecekTutar_LB.TabIndex = 2;
            this.OdenecekTutar_LB.Text = "Ödenecek Tutarı Giriniz  :";
            // 
            // OdemeBaslik_LB
            // 
            this.OdemeBaslik_LB.AutoSize = true;
            this.OdemeBaslik_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdemeBaslik_LB.Location = new System.Drawing.Point(103, 41);
            this.OdemeBaslik_LB.Name = "OdemeBaslik_LB";
            this.OdemeBaslik_LB.Size = new System.Drawing.Size(143, 20);
            this.OdemeBaslik_LB.TabIndex = 3;
            this.OdemeBaslik_LB.Text = "Ödeme İşlemleri ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(88, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tamamla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdenecekTutar_TB
            // 
            this.OdenecekTutar_TB.Location = new System.Drawing.Point(180, 104);
            this.OdenecekTutar_TB.Name = "OdenecekTutar_TB";
            this.OdenecekTutar_TB.Size = new System.Drawing.Size(80, 20);
            this.OdenecekTutar_TB.TabIndex = 5;
            this.OdenecekTutar_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OdenecekTutar_TB_KeyPress);
            // 
            // lbl_aidat
            // 
            this.lbl_aidat.AutoSize = true;
            this.lbl_aidat.Location = new System.Drawing.Point(177, 76);
            this.lbl_aidat.Name = "lbl_aidat";
            this.lbl_aidat.Size = new System.Drawing.Size(102, 13);
            this.lbl_aidat.TabIndex = 6;
            this.lbl_aidat.Text = "(Aylık Ödeme Tutarı)";
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Location = new System.Drawing.Point(177, 131);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(103, 13);
            this.lbl_borc.TabIndex = 7;
            this.lbl_borc.Text = "(Kalan Toplam Borç)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(357, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Geri Dön";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // OdemeIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(357, 243);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_borc);
            this.Controls.Add(this.lbl_aidat);
            this.Controls.Add(this.OdenecekTutar_TB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OdemeBaslik_LB);
            this.Controls.Add(this.OdenecekTutar_LB);
            this.Controls.Add(this.KalanBorcu_LB);
            this.Controls.Add(this.AylikOdeme_LB);
            this.Name = "OdemeIslemleriEkrani";
            this.Text = "OdemeIslemleriEkrani";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AylikOdeme_LB;
        private System.Windows.Forms.Label KalanBorcu_LB;
        private System.Windows.Forms.Label OdenecekTutar_LB;
        private System.Windows.Forms.Label OdemeBaslik_LB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OdenecekTutar_TB;
        private System.Windows.Forms.Label lbl_aidat;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}