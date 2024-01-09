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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
			this.txt_yeniSifre = new System.Windows.Forms.TextBox();
			this.txt_eskiSifre = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_GeriDon = new System.Windows.Forms.ToolStripButton();
			this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.chbox_mevcutParola = new System.Windows.Forms.CheckBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chbox_tekrarParola
			// 
			this.chbox_tekrarParola.AutoSize = true;
			this.chbox_tekrarParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chbox_tekrarParola.Image = global::Dernek_Takip_Sistemi.Properties.Resources.closed_eye;
			this.chbox_tekrarParola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chbox_tekrarParola.Location = new System.Drawing.Point(279, 219);
			this.chbox_tekrarParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chbox_tekrarParola.Name = "chbox_tekrarParola";
			this.chbox_tekrarParola.Size = new System.Drawing.Size(40, 21);
			this.chbox_tekrarParola.TabIndex = 19;
			this.chbox_tekrarParola.Text = "  ";
			this.chbox_tekrarParola.UseVisualStyleBackColor = true;
			this.chbox_tekrarParola.CheckedChanged += new System.EventHandler(this.chbox_tekrarParola_CheckedChanged);
			// 
			// chbox_yeniParola
			// 
			this.chbox_yeniParola.AutoSize = true;
			this.chbox_yeniParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chbox_yeniParola.Image = global::Dernek_Takip_Sistemi.Properties.Resources.closed_eye;
			this.chbox_yeniParola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chbox_yeniParola.Location = new System.Drawing.Point(279, 154);
			this.chbox_yeniParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chbox_yeniParola.Name = "chbox_yeniParola";
			this.chbox_yeniParola.Size = new System.Drawing.Size(40, 21);
			this.chbox_yeniParola.TabIndex = 18;
			this.chbox_yeniParola.Text = "  ";
			this.chbox_yeniParola.UseVisualStyleBackColor = true;
			this.chbox_yeniParola.CheckedChanged += new System.EventHandler(this.chbox_yeniParola_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(30, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 17);
			this.label3.TabIndex = 16;
			this.label3.Text = "Yeni Parola (Tekrar):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(30, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Yeni Parola:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(30, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Mevcut Parola:";
			// 
			// txt_sifreTekrar
			// 
			this.txt_sifreTekrar.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txt_sifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_sifreTekrar.Location = new System.Drawing.Point(34, 217);
			this.txt_sifreTekrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_sifreTekrar.Name = "txt_sifreTekrar";
			this.txt_sifreTekrar.PasswordChar = '*';
			this.txt_sifreTekrar.Size = new System.Drawing.Size(229, 23);
			this.txt_sifreTekrar.TabIndex = 12;
			// 
			// txt_yeniSifre
			// 
			this.txt_yeniSifre.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txt_yeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_yeniSifre.Location = new System.Drawing.Point(34, 153);
			this.txt_yeniSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_yeniSifre.Name = "txt_yeniSifre";
			this.txt_yeniSifre.PasswordChar = '*';
			this.txt_yeniSifre.Size = new System.Drawing.Size(229, 23);
			this.txt_yeniSifre.TabIndex = 11;
			// 
			// txt_eskiSifre
			// 
			this.txt_eskiSifre.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txt_eskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_eskiSifre.Location = new System.Drawing.Point(34, 86);
			this.txt_eskiSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_eskiSifre.Name = "txt_eskiSifre";
			this.txt_eskiSifre.PasswordChar = '*';
			this.txt_eskiSifre.Size = new System.Drawing.Size(229, 23);
			this.txt_eskiSifre.TabIndex = 10;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_GeriDon});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(360, 27);
			this.toolStrip1.TabIndex = 20;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_GeriDon
			// 
			this.TSB_GeriDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_GeriDon.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.TSB_GeriDon.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_GeriDon.Name = "TSB_GeriDon";
			this.TSB_GeriDon.Size = new System.Drawing.Size(29, 24);
			this.TSB_GeriDon.Text = "Ana Menüye Dön";
			this.TSB_GeriDon.Click += new System.EventHandler(this.TSB_GeriDon_Click);
			// 
			// guna2GradientButton1
			// 
			this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
			this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Lime;
			this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
			this.guna2GradientButton1.Location = new System.Drawing.Point(97, 279);
			this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.ShadowDecoration.BorderRadius = 7;
			this.guna2GradientButton1.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
			this.guna2GradientButton1.Size = new System.Drawing.Size(156, 31);
			this.guna2GradientButton1.TabIndex = 21;
			this.guna2GradientButton1.Text = "KAYDET";
			this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
			// 
			// chbox_mevcutParola
			// 
			this.chbox_mevcutParola.AutoSize = true;
			this.chbox_mevcutParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chbox_mevcutParola.Image = global::Dernek_Takip_Sistemi.Properties.Resources.closed_eye;
			this.chbox_mevcutParola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chbox_mevcutParola.Location = new System.Drawing.Point(279, 86);
			this.chbox_mevcutParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chbox_mevcutParola.Name = "chbox_mevcutParola";
			this.chbox_mevcutParola.Size = new System.Drawing.Size(40, 21);
			this.chbox_mevcutParola.TabIndex = 17;
			this.chbox_mevcutParola.Text = "  ";
			this.chbox_mevcutParola.UseVisualStyleBackColor = true;
			this.chbox_mevcutParola.CheckedChanged += new System.EventHandler(this.chbox_mevcutParola_CheckedChanged);
			// 
			// Sifreİslemleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(360, 332);
			this.Controls.Add(this.guna2GradientButton1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.chbox_tekrarParola);
			this.Controls.Add(this.chbox_yeniParola);
			this.Controls.Add(this.chbox_mevcutParola);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_sifreTekrar);
			this.Controls.Add(this.txt_yeniSifre);
			this.Controls.Add(this.txt_eskiSifre);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Sifreİslemleri";
			this.Text = "Şifre Değiştirme";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sifreİslemleri_FormClosing);
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
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.TextBox txt_eskiSifre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
		private System.Windows.Forms.ToolStripButton TSB_GeriDon;
	}
}