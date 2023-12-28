namespace Dernek_Takip_Sistemi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Uye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.Location = new System.Drawing.Point(137, 9);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(220, 20);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "NES Dernek Takip Sistemi";
            // 
            // btn_Personel
            // 
            this.btn_Personel.BackColor = System.Drawing.Color.Lime;
            this.btn_Personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Personel.Location = new System.Drawing.Point(79, 206);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(168, 44);
            this.btn_Personel.TabIndex = 1;
            this.btn_Personel.Text = "PERSONEL GİRİŞİ";
            this.btn_Personel.UseVisualStyleBackColor = false;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Uye
            // 
            this.btn_Uye.BackColor = System.Drawing.Color.Lime;
            this.btn_Uye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Uye.Location = new System.Drawing.Point(261, 206);
            this.btn_Uye.Name = "btn_Uye";
            this.btn_Uye.Size = new System.Drawing.Size(148, 44);
            this.btn_Uye.TabIndex = 3;
            this.btn_Uye.Text = "ÜYE GİRİŞİ";
            this.btn_Uye.UseVisualStyleBackColor = false;
            this.btn_Uye.Click += new System.EventHandler(this.btn_Uye_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(485, 287);
            this.Controls.Add(this.btn_Uye);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Personel);
            this.Controls.Add(this.lbl_baslik);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Uye;
    }
}