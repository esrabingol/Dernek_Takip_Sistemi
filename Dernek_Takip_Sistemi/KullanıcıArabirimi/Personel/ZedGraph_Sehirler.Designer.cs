namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    partial class ZedGraph_Sehirler
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
			this.components = new System.ComponentModel.Container();
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.geridon_TSB = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// zedGraphControl1
			// 
			this.zedGraphControl1.Location = new System.Drawing.Point(16, 64);
			this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.zedGraphControl1.Name = "zedGraphControl1";
			this.zedGraphControl1.ScrollGrace = 0D;
			this.zedGraphControl1.ScrollMaxX = 0D;
			this.zedGraphControl1.ScrollMaxY = 0D;
			this.zedGraphControl1.ScrollMaxY2 = 0D;
			this.zedGraphControl1.ScrollMinX = 0D;
			this.zedGraphControl1.ScrollMinY = 0D;
			this.zedGraphControl1.ScrollMinY2 = 0D;
			this.zedGraphControl1.Size = new System.Drawing.Size(939, 475);
			this.zedGraphControl1.TabIndex = 0;
			this.zedGraphControl1.UseExtendedPrintDialog = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geridon_TSB});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// geridon_TSB
			// 
			this.geridon_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.geridon_TSB.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.geridon_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.geridon_TSB.Name = "geridon_TSB";
			this.geridon_TSB.Size = new System.Drawing.Size(29, 24);
			this.geridon_TSB.Tag = "";
			this.geridon_TSB.Text = "Geri Dön";
			this.geridon_TSB.Click += new System.EventHandler(this.geridon_TSB_Click);
			// 
			// ZedGraph_Sehirler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.zedGraphControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ZedGraph_Sehirler";
			this.Text = "Şehirler";
			this.Load += new System.EventHandler(this.ZedGraph_Sehirler_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton geridon_TSB;
    }
}