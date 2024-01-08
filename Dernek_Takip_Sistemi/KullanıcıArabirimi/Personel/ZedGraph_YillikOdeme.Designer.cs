namespace Dernek_Takip_Sistemi.KullanıcıArabirimi.Personel
{
    partial class ZedGraph_YillikOdeme
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
			this.ZGC_YillikOdeme = new ZedGraph.ZedGraphControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSB_RETURN = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ZGC_YillikOdeme
			// 
			this.ZGC_YillikOdeme.Location = new System.Drawing.Point(16, 44);
			this.ZGC_YillikOdeme.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ZGC_YillikOdeme.Name = "ZGC_YillikOdeme";
			this.ZGC_YillikOdeme.ScrollGrace = 0D;
			this.ZGC_YillikOdeme.ScrollMaxX = 0D;
			this.ZGC_YillikOdeme.ScrollMaxY = 0D;
			this.ZGC_YillikOdeme.ScrollMaxY2 = 0D;
			this.ZGC_YillikOdeme.ScrollMinX = 0D;
			this.ZGC_YillikOdeme.ScrollMinY = 0D;
			this.ZGC_YillikOdeme.ScrollMinY2 = 0D;
			this.ZGC_YillikOdeme.Size = new System.Drawing.Size(1551, 495);
			this.ZGC_YillikOdeme.TabIndex = 0;
			this.ZGC_YillikOdeme.UseExtendedPrintDialog = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_RETURN});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1607, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSB_RETURN
			// 
			this.TSB_RETURN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_RETURN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
			this.TSB_RETURN.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_RETURN.Name = "TSB_RETURN";
			this.TSB_RETURN.Size = new System.Drawing.Size(29, 24);
			this.TSB_RETURN.Text = "GERİ DÖN";
			this.TSB_RETURN.Click += new System.EventHandler(this.TSB_RETURN_Click);
			// 
			// ZedGraph_YillikOdeme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1607, 554);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.ZGC_YillikOdeme);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ZedGraph_YillikOdeme";
			this.Text = "Yıllık Ödemeler";
			this.Load += new System.EventHandler(this.ZedGraph_YillikOdeme_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl ZGC_YillikOdeme;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_RETURN;
    }
}