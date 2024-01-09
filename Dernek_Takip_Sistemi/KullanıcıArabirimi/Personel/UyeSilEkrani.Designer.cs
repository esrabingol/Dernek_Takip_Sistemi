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
			this.TCgirTB = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_UyeSil = new System.Windows.Forms.ToolStripButton();
			this.guno_goruntule = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UyeSilBTN
			// 
			this.UyeSilBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.UyeSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UyeSilBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.warning;
			this.UyeSilBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.UyeSilBTN.Location = new System.Drawing.Point(371, 320);
			this.UyeSilBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.UyeSilBTN.Name = "UyeSilBTN";
			this.UyeSilBTN.Size = new System.Drawing.Size(151, 38);
			this.UyeSilBTN.TabIndex = 0;
			this.UyeSilBTN.Text = "Üyeyi Sil";
			this.UyeSilBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UyeSilBTN.UseVisualStyleBackColor = false;
			this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
			// 
			// UyeGoruntuleDGW
			// 
			this.UyeGoruntuleDGW.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.UyeGoruntuleDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UyeGoruntuleDGW.Location = new System.Drawing.Point(16, 128);
			this.UyeGoruntuleDGW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.UyeGoruntuleDGW.Name = "UyeGoruntuleDGW";
			this.UyeGoruntuleDGW.RowHeadersWidth = 51;
			this.UyeGoruntuleDGW.Size = new System.Drawing.Size(505, 185);
			this.UyeGoruntuleDGW.TabIndex = 2;
			// 
			// TCgirTB
			// 
			this.TCgirTB.BackColor = System.Drawing.SystemColors.MenuBar;
			this.TCgirTB.ForeColor = System.Drawing.SystemColors.GrayText;
			this.TCgirTB.Location = new System.Drawing.Point(16, 60);
			this.TCgirTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TCgirTB.Name = "TCgirTB";
			this.TCgirTB.Size = new System.Drawing.Size(504, 22);
			this.TCgirTB.TabIndex = 4;
			this.TCgirTB.Text = "TC kimlik numarası giriniz";
			this.TCgirTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TCgirTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TCgirTB_MouseClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_UyeSil});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(535, 31);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_UyeSil
			// 
			this.TSB_UyeSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_UyeSil.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.TSB_UyeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_UyeSil.Name = "TSB_UyeSil";
			this.TSB_UyeSil.Size = new System.Drawing.Size(29, 24);
			this.TSB_UyeSil.Text = "Ana Menüye Dön";
			this.TSB_UyeSil.Click += new System.EventHandler(this.TSB_UyeSil_Click);
			// 
			// guno_goruntule
			// 
			this.guno_goruntule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guno_goruntule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guno_goruntule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_goruntule.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guno_goruntule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guno_goruntule.FillColor = System.Drawing.Color.White;
			this.guno_goruntule.FillColor2 = System.Drawing.Color.Lime;
			this.guno_goruntule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.guno_goruntule.ForeColor = System.Drawing.Color.Black;
			this.guno_goruntule.Location = new System.Drawing.Point(280, 92);
			this.guno_goruntule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guno_goruntule.Name = "guno_goruntule";
			this.guno_goruntule.Size = new System.Drawing.Size(240, 28);
			this.guno_goruntule.TabIndex = 8;
			this.guno_goruntule.Text = "Üyeyi Görüntüle";
			this.guno_goruntule.Click += new System.EventHandler(this.guno_goruntule_Click);
			// 
			// UyeSilGüncelleEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(535, 373);
			this.Controls.Add(this.guno_goruntule);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.TCgirTB);
			this.Controls.Add(this.UyeGoruntuleDGW);
			this.Controls.Add(this.UyeSilBTN);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UyeSilGüncelleEkrani";
			this.Text = "Üye Silme";
			((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UyeSilBTN;
        private System.Windows.Forms.DataGridView UyeGoruntuleDGW;
        private System.Windows.Forms.TextBox TCgirTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_UyeSil;
        private Guna.UI2.WinForms.Guna2GradientButton guno_goruntule;
    }
}