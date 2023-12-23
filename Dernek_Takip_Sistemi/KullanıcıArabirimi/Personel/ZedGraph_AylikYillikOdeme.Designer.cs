namespace Dernek_Takip_Sistemi.KullanıcıArabirimi
{
    partial class ZedGraph_AylikYillikOdeme
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
            this.zedGraphControl_aylikodeme = new ZedGraph.ZedGraphControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_RETURN = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl_aylikodeme
            // 
            this.zedGraphControl_aylikodeme.Location = new System.Drawing.Point(12, 44);
            this.zedGraphControl_aylikodeme.Name = "zedGraphControl_aylikodeme";
            this.zedGraphControl_aylikodeme.ScrollGrace = 0D;
            this.zedGraphControl_aylikodeme.ScrollMaxX = 0D;
            this.zedGraphControl_aylikodeme.ScrollMaxY = 0D;
            this.zedGraphControl_aylikodeme.ScrollMaxY2 = 0D;
            this.zedGraphControl_aylikodeme.ScrollMinX = 0D;
            this.zedGraphControl_aylikodeme.ScrollMinY = 0D;
            this.zedGraphControl_aylikodeme.ScrollMinY2 = 0D;
            this.zedGraphControl_aylikodeme.Size = new System.Drawing.Size(1232, 376);
            this.zedGraphControl_aylikodeme.TabIndex = 2;
            this.zedGraphControl_aylikodeme.UseExtendedPrintDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_RETURN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1261, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_RETURN
            // 
            this.TSB_RETURN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_RETURN.Image = global::Dernek_Takip_Sistemi.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back_16;
            this.TSB_RETURN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_RETURN.Name = "TSB_RETURN";
            this.TSB_RETURN.Size = new System.Drawing.Size(23, 22);
            this.TSB_RETURN.Text = "GERİ DÖN";
            this.TSB_RETURN.Click += new System.EventHandler(this.TSB_RETURN_Click);
            // 
            // ZedGraph_AylikYillikOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 432);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.zedGraphControl_aylikodeme);
            this.Name = "ZedGraph_AylikYillikOdeme";
            this.Text = "ZedGraph_AylikYillikOdeme";
            this.Load += new System.EventHandler(this.ZedGraph_AylikYillikOdeme_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraphControl_aylikodeme;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_RETURN;
    }
}