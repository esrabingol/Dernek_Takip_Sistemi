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
            this.OdenecekTutar_TB = new System.Windows.Forms.TextBox();
            this.lbl_aidat = new System.Windows.Forms.Label();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AylikOdeme_LB
            // 
            this.AylikOdeme_LB.AutoSize = true;
            this.AylikOdeme_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AylikOdeme_LB.Location = new System.Drawing.Point(43, 85);
            this.AylikOdeme_LB.Name = "AylikOdeme_LB";
            this.AylikOdeme_LB.Size = new System.Drawing.Size(156, 17);
            this.AylikOdeme_LB.TabIndex = 0;
            this.AylikOdeme_LB.Text = "Aylık Ödeme Tutarı :";
            // 
            // KalanBorcu_LB
            // 
            this.KalanBorcu_LB.AutoSize = true;
            this.KalanBorcu_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalanBorcu_LB.Location = new System.Drawing.Point(43, 140);
            this.KalanBorcu_LB.Name = "KalanBorcu_LB";
            this.KalanBorcu_LB.Size = new System.Drawing.Size(155, 17);
            this.KalanBorcu_LB.TabIndex = 1;
            this.KalanBorcu_LB.Text = "Kalan Toplam Borç :";
            // 
            // OdenecekTutar_LB
            // 
            this.OdenecekTutar_LB.AutoSize = true;
            this.OdenecekTutar_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdenecekTutar_LB.Location = new System.Drawing.Point(0, 113);
            this.OdenecekTutar_LB.Name = "OdenecekTutar_LB";
            this.OdenecekTutar_LB.Size = new System.Drawing.Size(196, 17);
            this.OdenecekTutar_LB.TabIndex = 2;
            this.OdenecekTutar_LB.Text = "Ödenecek Tutarı Giriniz  :";
            // 
            // OdemeBaslik_LB
            // 
            this.OdemeBaslik_LB.AutoSize = true;
            this.OdemeBaslik_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdemeBaslik_LB.Location = new System.Drawing.Point(152, 37);
            this.OdemeBaslik_LB.Name = "OdemeBaslik_LB";
            this.OdemeBaslik_LB.Size = new System.Drawing.Size(174, 25);
            this.OdemeBaslik_LB.TabIndex = 3;
            this.OdemeBaslik_LB.Text = "Ödeme İşlemleri ";
            // 
            // OdenecekTutar_TB
            // 
            this.OdenecekTutar_TB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.OdenecekTutar_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdenecekTutar_TB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.OdenecekTutar_TB.Location = new System.Drawing.Point(222, 110);
            this.OdenecekTutar_TB.Name = "OdenecekTutar_TB";
            this.OdenecekTutar_TB.Size = new System.Drawing.Size(80, 23);
            this.OdenecekTutar_TB.TabIndex = 5;
            this.OdenecekTutar_TB.Text = "0,0";
            this.OdenecekTutar_TB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OdenecekTutar_TB_MouseClick);
            this.OdenecekTutar_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OdenecekTutar_TB_KeyPress);
            // 
            // lbl_aidat
            // 
            this.lbl_aidat.AutoSize = true;
            this.lbl_aidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aidat.Location = new System.Drawing.Point(218, 87);
            this.lbl_aidat.Name = "lbl_aidat";
            this.lbl_aidat.Size = new System.Drawing.Size(158, 17);
            this.lbl_aidat.TabIndex = 6;
            this.lbl_aidat.Text = "(Aylık Ödeme Tutarı)";
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_borc.Location = new System.Drawing.Point(218, 144);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(157, 17);
            this.lbl_borc.TabIndex = 7;
            this.lbl_borc.Text = "(Kalan Toplam Borç)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 25);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.LimeGreen;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(348, 215);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(121, 34);
            this.guna2GradientButton1.TabIndex = 11;
            this.guna2GradientButton1.Text = "ÖDEMEYİ TAMAMLA";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // OdemeIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 260);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_borc);
            this.Controls.Add(this.lbl_aidat);
            this.Controls.Add(this.OdenecekTutar_TB);
            this.Controls.Add(this.OdemeBaslik_LB);
            this.Controls.Add(this.OdenecekTutar_LB);
            this.Controls.Add(this.KalanBorcu_LB);
            this.Controls.Add(this.AylikOdeme_LB);
            this.Name = "OdemeIslemleriEkrani";
            this.Text = "OdemeIslemleriEkrani";
            this.Load += new System.EventHandler(this.Odeme_Load);
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
        private System.Windows.Forms.TextBox OdenecekTutar_TB;
        private System.Windows.Forms.Label lbl_aidat;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}