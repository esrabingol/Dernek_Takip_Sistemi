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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_UyeSil = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UyeSilBTN
            // 
            this.UyeSilBTN.BackColor = System.Drawing.Color.White;
            this.UyeSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSilBTN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.warning;
            this.UyeSilBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UyeSilBTN.Location = new System.Drawing.Point(284, 260);
            this.UyeSilBTN.Name = "UyeSilBTN";
            this.UyeSilBTN.Size = new System.Drawing.Size(107, 30);
            this.UyeSilBTN.TabIndex = 0;
            this.UyeSilBTN.Text = "Üyeyi Sil";
            this.UyeSilBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UyeSilBTN.UseVisualStyleBackColor = false;
            this.UyeSilBTN.Click += new System.EventHandler(this.UyeSilBTN_Click);
            // 
            // UyeGoruntuleDGW
            // 
            this.UyeGoruntuleDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyeGoruntuleDGW.Location = new System.Drawing.Point(12, 104);
            this.UyeGoruntuleDGW.Name = "UyeGoruntuleDGW";
            this.UyeGoruntuleDGW.Size = new System.Drawing.Size(379, 150);
            this.UyeGoruntuleDGW.TabIndex = 2;
            // 
            // UyeGoruntuleBTN
            // 
            this.UyeGoruntuleBTN.BackColor = System.Drawing.Color.White;
            this.UyeGoruntuleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeGoruntuleBTN.ForeColor = System.Drawing.Color.Black;
            this.UyeGoruntuleBTN.Location = new System.Drawing.Point(262, 75);
            this.UyeGoruntuleBTN.Name = "UyeGoruntuleBTN";
            this.UyeGoruntuleBTN.Size = new System.Drawing.Size(129, 23);
            this.UyeGoruntuleBTN.TabIndex = 3;
            this.UyeGoruntuleBTN.Text = "Üyeyi Görüntüle";
            this.UyeGoruntuleBTN.UseVisualStyleBackColor = false;
            this.UyeGoruntuleBTN.Click += new System.EventHandler(this.UyeGoruntuleBTN_Click);
            // 
            // TCgirTB
            // 
            this.TCgirTB.Location = new System.Drawing.Point(12, 49);
            this.TCgirTB.Name = "TCgirTB";
            this.TCgirTB.Size = new System.Drawing.Size(379, 20);
            this.TCgirTB.TabIndex = 4;
            this.TCgirTB.Text = "Üyenin TC numarasını giriniz ve görüntüleyiniz.\r\n";
            this.TCgirTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_UyeSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(402, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_UyeSil
            // 
            this.TSB_UyeSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_UyeSil.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TSB_UyeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_UyeSil.Name = "TSB_UyeSil";
            this.TSB_UyeSil.Size = new System.Drawing.Size(23, 22);
            this.TSB_UyeSil.Text = "Ana Menüye Dön";
            this.TSB_UyeSil.Click += new System.EventHandler(this.TSB_UyeSil_Click);
            // 
            // UyeSilGüncelleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 303);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TCgirTB);
            this.Controls.Add(this.UyeGoruntuleBTN);
            this.Controls.Add(this.UyeGoruntuleDGW);
            this.Controls.Add(this.UyeSilBTN);
            this.Name = "UyeSilGüncelleEkrani";
            this.Text = "UyeSilmeEkrani";
            this.Load += new System.EventHandler(this.UyeSilGüncelleEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UyeGoruntuleDGW)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UyeSilBTN;
        private System.Windows.Forms.DataGridView UyeGoruntuleDGW;
        private System.Windows.Forms.Button UyeGoruntuleBTN;
        private System.Windows.Forms.TextBox TCgirTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_UyeSil;
    }
}