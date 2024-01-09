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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_Return = new System.Windows.Forms.ToolStripButton();
			this.Guno_btn = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeleme)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker_baslangic
			// 
			this.dateTimePicker_baslangic.Location = new System.Drawing.Point(40, 118);
			this.dateTimePicker_baslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker_baslangic.Name = "dateTimePicker_baslangic";
			this.dateTimePicker_baslangic.Size = new System.Drawing.Size(265, 22);
			this.dateTimePicker_baslangic.TabIndex = 0;
			// 
			// dateTimePicker_bitis
			// 
			this.dateTimePicker_bitis.Location = new System.Drawing.Point(368, 118);
			this.dateTimePicker_bitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker_bitis.Name = "dateTimePicker_bitis";
			this.dateTimePicker_bitis.Size = new System.Drawing.Size(265, 22);
			this.dateTimePicker_bitis.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(36, 85);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Başlangıç Tarihi :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(364, 85);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Bitiş Tarihi :";
			// 
			// dataGridView_listeleme
			// 
			this.dataGridView_listeleme.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataGridView_listeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_listeleme.Location = new System.Drawing.Point(40, 186);
			this.dataGridView_listeleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView_listeleme.Name = "dataGridView_listeleme";
			this.dataGridView_listeleme.RowHeadersWidth = 51;
			this.dataGridView_listeleme.Size = new System.Drawing.Size(595, 185);
			this.dataGridView_listeleme.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(273, 40);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ödemeler";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Return});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(656, 27);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_Return
			// 
			this.TSB_Return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_Return.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.TSB_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Return.Name = "TSB_Return";
			this.TSB_Return.Size = new System.Drawing.Size(29, 24);
			this.TSB_Return.Text = "toolStripButton2";
			this.TSB_Return.Click += new System.EventHandler(this.TSB_Return_Click);
			// 
			// Guno_btn
			// 
			this.Guno_btn.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Guno_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Guno_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Guno_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Guno_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Guno_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Guno_btn.FillColor = System.Drawing.Color.White;
			this.Guno_btn.FillColor2 = System.Drawing.Color.LimeGreen;
			this.Guno_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.Guno_btn.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Guno_btn.Location = new System.Drawing.Point(205, 150);
			this.Guno_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Guno_btn.Name = "Guno_btn";
			this.Guno_btn.Size = new System.Drawing.Size(240, 28);
			this.Guno_btn.TabIndex = 8;
			this.Guno_btn.Text = "LİSTELE";
			this.Guno_btn.Click += new System.EventHandler(this.Guno_btn_Click);
			// 
			// TarihlerArasiOdemeDurumBilgisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(656, 383);
			this.Controls.Add(this.Guno_btn);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView_listeleme);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker_bitis);
			this.Controls.Add(this.dateTimePicker_baslangic);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "TarihlerArasiOdemeDurumBilgisi";
			this.Text = "Ödemeler";
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Return;
        private Guna.UI2.WinForms.Guna2GradientButton Guno_btn;
    }
}