namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    partial class UyeSilGüncelleEkrani
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
            this.UyeSilBTN = new System.Windows.Forms.Button();
            this.UyeGoruntuleDGW = new System.Windows.Forms.DataGridView();
            this.UyeGoruntuleBTN = new System.Windows.Forms.Button();
            this.TCgirTB = new System.Windows.Forms.TextBox();
            this.UyeGuncelleBTN = new System.Windows.Forms.Button();
            this.GeriDonBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // UyeSilBTN
            // 
            this.UyeSilBTN.BackColor = System.Drawing.Color.Red;
            this.UyeSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSilBTN.Location = new System.Drawing.Point(262, 240);
            this.UyeSilBTN.Name = "UyeSilBTN";
            this.UyeSilBTN.Size = new System.Drawing.Size(129, 26);
            this.UyeSilBTN.TabIndex = 0;
            this.UyeSilBTN.Text = "Üyeyi Sil";
            this.UyeSilBTN.UseVisualStyleBackColor = false;
            this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
            // 
            // UyeGoruntuleDGW
            // 
            this.UyeGoruntuleDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyeGoruntuleDGW.Location = new System.Drawing.Point(12, 84);
            this.UyeGoruntuleDGW.Name = "UyeGoruntuleDGW";
            this.UyeGoruntuleDGW.Size = new System.Drawing.Size(379, 150);
            this.UyeGoruntuleDGW.TabIndex = 2;
            // 
            // UyeGoruntuleBTN
            // 
            this.UyeGoruntuleBTN.BackColor = System.Drawing.Color.White;
            this.UyeGoruntuleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeGoruntuleBTN.ForeColor = System.Drawing.Color.Black;
            this.UyeGoruntuleBTN.Location = new System.Drawing.Point(262, 38);
            this.UyeGoruntuleBTN.Name = "UyeGoruntuleBTN";
            this.UyeGoruntuleBTN.Size = new System.Drawing.Size(129, 23);
            this.UyeGoruntuleBTN.TabIndex = 3;
            this.UyeGoruntuleBTN.Text = "Üyeyi Görüntüle";
            this.UyeGoruntuleBTN.UseVisualStyleBackColor = false;
            this.UyeGoruntuleBTN.Click += new System.EventHandler(this.UyeGoruntuleBTN_Click);
            // 
            // TCgirTB
            // 
            this.TCgirTB.Location = new System.Drawing.Point(12, 12);
            this.TCgirTB.Name = "TCgirTB";
            this.TCgirTB.Size = new System.Drawing.Size(379, 20);
            this.TCgirTB.TabIndex = 4;
            this.TCgirTB.Text = "Üyenin TC numarasını giriniz ve görüntüleyiniz.\r\n";
            // 
            // UyeGuncelleBTN
            // 
            this.UyeGuncelleBTN.BackColor = System.Drawing.Color.Lime;
            this.UyeGuncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeGuncelleBTN.Location = new System.Drawing.Point(127, 240);
            this.UyeGuncelleBTN.Name = "UyeGuncelleBTN";
            this.UyeGuncelleBTN.Size = new System.Drawing.Size(129, 26);
            this.UyeGuncelleBTN.TabIndex = 5;
            this.UyeGuncelleBTN.Text = "Üyeyi Güncelle";
            this.UyeGuncelleBTN.UseVisualStyleBackColor = false;
            this.UyeGuncelleBTN.Click += new System.EventHandler(this.UyeGuncelleBTN_Click);
            // 
            // GeriDonBTN
            // 
            this.GeriDonBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriDonBTN.Location = new System.Drawing.Point(12, 243);
            this.GeriDonBTN.Name = "GeriDonBTN";
            this.GeriDonBTN.Size = new System.Drawing.Size(109, 23);
            this.GeriDonBTN.TabIndex = 6;
            this.GeriDonBTN.Text = "  <-----";
            this.GeriDonBTN.UseVisualStyleBackColor = true;
            this.GeriDonBTN.Click += new System.EventHandler(this.GeriDonBTN_Click);
            // 
            // UyeSilGüncelleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 281);
            this.Controls.Add(this.GeriDonBTN);
            this.Controls.Add(this.UyeGuncelleBTN);
            this.Controls.Add(this.TCgirTB);
            this.Controls.Add(this.UyeGoruntuleBTN);
            this.Controls.Add(this.UyeGoruntuleDGW);
            this.Controls.Add(this.UyeSilBTN);
            this.Name = "UyeSilGüncelleEkrani";
            this.Text = "UyeSilmeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UyeSilBTN;
        private System.Windows.Forms.DataGridView UyeGoruntuleDGW;
        private System.Windows.Forms.Button UyeGoruntuleBTN;
        private System.Windows.Forms.TextBox TCgirTB;
        private System.Windows.Forms.Button UyeGuncelleBTN;
        private System.Windows.Forms.Button GeriDonBTN;
    }
}