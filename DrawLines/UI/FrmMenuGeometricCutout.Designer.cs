namespace DrawLines.UI
{
    partial class FrmMenuGeometricCutout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuGeometricCutout));
            this.gbBresenham = new System.Windows.Forms.GroupBox();
            this.btnShutterland = new System.Windows.Forms.Button();
            this.gbDiferentialAnalyzer = new System.Windows.Forms.GroupBox();
            this.btnCohen = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbBresenham.SuspendLayout();
            this.gbDiferentialAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBresenham
            // 
            this.gbBresenham.Controls.Add(this.btnShutterland);
            this.gbBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBresenham.Location = new System.Drawing.Point(652, 445);
            this.gbBresenham.Name = "gbBresenham";
            this.gbBresenham.Size = new System.Drawing.Size(466, 262);
            this.gbBresenham.TabIndex = 16;
            this.gbBresenham.TabStop = false;
            this.gbBresenham.Text = "Algorithms Shuterland Hodgman";
            // 
            // btnShutterland
            // 
            this.btnShutterland.Location = new System.Drawing.Point(110, 136);
            this.btnShutterland.Name = "btnShutterland";
            this.btnShutterland.Size = new System.Drawing.Size(255, 81);
            this.btnShutterland.TabIndex = 1;
            this.btnShutterland.Text = "Enter";
            this.btnShutterland.UseVisualStyleBackColor = true;
            this.btnShutterland.Click += new System.EventHandler(this.btnShutterland_Click);
            // 
            // gbDiferentialAnalyzer
            // 
            this.gbDiferentialAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiferentialAnalyzer.Controls.Add(this.btnCohen);
            this.gbDiferentialAnalyzer.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiferentialAnalyzer.Location = new System.Drawing.Point(106, 445);
            this.gbDiferentialAnalyzer.Name = "gbDiferentialAnalyzer";
            this.gbDiferentialAnalyzer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDiferentialAnalyzer.Size = new System.Drawing.Size(466, 262);
            this.gbDiferentialAnalyzer.TabIndex = 15;
            this.gbDiferentialAnalyzer.TabStop = false;
            this.gbDiferentialAnalyzer.Text = "Algorithm Cohen Shutterland";
            // 
            // btnCohen
            // 
            this.btnCohen.Location = new System.Drawing.Point(91, 136);
            this.btnCohen.Name = "btnCohen";
            this.btnCohen.Size = new System.Drawing.Size(255, 81);
            this.btnCohen.TabIndex = 0;
            this.btnCohen.Text = "Enter";
            this.btnCohen.UseVisualStyleBackColor = true;
            this.btnCohen.Click += new System.EventHandler(this.btnCohen_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(50, 200);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1230, 110);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Algorithms Geometric Cutout";
            // 
            // FrmMenuGeometricCutout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1598, 1010);
            this.Controls.Add(this.gbBresenham);
            this.Controls.Add(this.gbDiferentialAnalyzer);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmMenuGeometricCutout";
            this.Text = "FrmGeometricCutout";
            this.Load += new System.EventHandler(this.FrmMenuGeometricCutout_Load);
            this.gbBresenham.ResumeLayout(false);
            this.gbDiferentialAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBresenham;
        private System.Windows.Forms.Button btnShutterland;
        private System.Windows.Forms.GroupBox gbDiferentialAnalyzer;
        private System.Windows.Forms.Button btnCohen;
        private System.Windows.Forms.Label lbTitle;
    }
}