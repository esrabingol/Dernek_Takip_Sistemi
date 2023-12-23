namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel
{
    partial class TarihlerArasiOdemeDurumBilgisi
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
            this.dateTimePicker_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_bitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_listeleme = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Listele = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Return = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeleme)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_baslangic
            // 
            this.dateTimePicker_baslangic.Location = new System.Drawing.Point(30, 96);
            this.dateTimePicker_baslangic.Name = "dateTimePicker_baslangic";
            this.dateTimePicker_baslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_baslangic.TabIndex = 0;
            // 
            // dateTimePicker_bitis
            // 
            this.dateTimePicker_bitis.Location = new System.Drawing.Point(276, 96);
            this.dateTimePicker_bitis.Name = "dateTimePicker_bitis";
            this.dateTimePicker_bitis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_bitis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // dataGridView_listeleme
            // 
            this.dataGridView_listeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeleme.Location = new System.Drawing.Point(30, 151);
            this.dataGridView_listeleme.Name = "dataGridView_listeleme";
            this.dataGridView_listeleme.Size = new System.Drawing.Size(446, 150);
            this.dataGridView_listeleme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(126, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üye Ödemeleri Durum Bilgisi";
            // 
            // BTN_Listele
            // 
            this.BTN_Listele.BackColor = System.Drawing.Color.Lime;
            this.BTN_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Listele.Location = new System.Drawing.Point(144, 122);
            this.BTN_Listele.Name = "BTN_Listele";
            this.BTN_Listele.Size = new System.Drawing.Size(190, 23);
            this.BTN_Listele.TabIndex = 6;
            this.BTN_Listele.Text = "LİSTELE";
            this.BTN_Listele.UseVisualStyleBackColor = false;
            this.BTN_Listele.Click += new System.EventHandler(this.BTN_Listele_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Return});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Return
            // 
            this.TSB_Return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Return.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TSB_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Return.Name = "TSB_Return";
            this.TSB_Return.Size = new System.Drawing.Size(23, 22);
            this.TSB_Return.Text = "toolStripButton2";
            this.TSB_Return.Click += new System.EventHandler(this.TSB_Return_Click);
            // 
            // TarihlerArasiOdemeDurumBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 311);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTN_Listele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_listeleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_bitis);
            this.Controls.Add(this.dateTimePicker_baslangic);
            this.Name = "TarihlerArasiOdemeDurumBilgisi";
            this.Text = "TarihlerArasiOdemeDurumBilgisi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeleme)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_baslangic;
        private System.Windows.Forms.DateTimePicker dateTimePicker_bitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_listeleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Listele;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Return;
    }
}