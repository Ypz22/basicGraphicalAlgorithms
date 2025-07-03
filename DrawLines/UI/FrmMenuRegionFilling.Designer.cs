namespace DrawLines.UI
{
    partial class FrmMenuRegionFilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuRegionFilling));
            this.gbBresenham = new System.Windows.Forms.GroupBox();
            this.btnPadding = new System.Windows.Forms.Button();
            this.gbCicunferenceB = new System.Windows.Forms.GroupBox();
            this.btnPaddingSides = new System.Windows.Forms.Button();
            this.gbDiferentialAnalyzer = new System.Windows.Forms.GroupBox();
            this.btnScanline = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbBresenham.SuspendLayout();
            this.gbCicunferenceB.SuspendLayout();
            this.gbDiferentialAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBresenham
            // 
            this.gbBresenham.Controls.Add(this.btnPadding);
            this.gbBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBresenham.Location = new System.Drawing.Point(613, 247);
            this.gbBresenham.Name = "gbBresenham";
            this.gbBresenham.Size = new System.Drawing.Size(466, 262);
            this.gbBresenham.TabIndex = 12;
            this.gbBresenham.TabStop = false;
            this.gbBresenham.Text = "Algorithms Padding";
            // 
            // btnPadding
            // 
            this.btnPadding.Location = new System.Drawing.Point(110, 136);
            this.btnPadding.Name = "btnPadding";
            this.btnPadding.Size = new System.Drawing.Size(255, 81);
            this.btnPadding.TabIndex = 1;
            this.btnPadding.Text = "Enter";
            this.btnPadding.UseVisualStyleBackColor = true;
            this.btnPadding.Click += new System.EventHandler(this.btnPadding_Click);
            // 
            // gbCicunferenceB
            // 
            this.gbCicunferenceB.Controls.Add(this.btnPaddingSides);
            this.gbCicunferenceB.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCicunferenceB.Location = new System.Drawing.Point(324, 605);
            this.gbCicunferenceB.Name = "gbCicunferenceB";
            this.gbCicunferenceB.Size = new System.Drawing.Size(466, 294);
            this.gbCicunferenceB.TabIndex = 13;
            this.gbCicunferenceB.TabStop = false;
            this.gbCicunferenceB.Text = "Algorithms Padding N Sides";
            // 
            // btnPaddingSides
            // 
            this.btnPaddingSides.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaddingSides.Location = new System.Drawing.Point(91, 163);
            this.btnPaddingSides.Name = "btnPaddingSides";
            this.btnPaddingSides.Size = new System.Drawing.Size(255, 81);
            this.btnPaddingSides.TabIndex = 2;
            this.btnPaddingSides.Text = "Enter";
            this.btnPaddingSides.UseVisualStyleBackColor = true;
            this.btnPaddingSides.Click += new System.EventHandler(this.btnPaddingSides_Click);
            // 
            // gbDiferentialAnalyzer
            // 
            this.gbDiferentialAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiferentialAnalyzer.Controls.Add(this.btnScanline);
            this.gbDiferentialAnalyzer.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiferentialAnalyzer.Location = new System.Drawing.Point(67, 247);
            this.gbDiferentialAnalyzer.Name = "gbDiferentialAnalyzer";
            this.gbDiferentialAnalyzer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDiferentialAnalyzer.Size = new System.Drawing.Size(466, 262);
            this.gbDiferentialAnalyzer.TabIndex = 11;
            this.gbDiferentialAnalyzer.TabStop = false;
            this.gbDiferentialAnalyzer.Text = "Algorithm Scanline";
            // 
            // btnScanline
            // 
            this.btnScanline.Location = new System.Drawing.Point(91, 136);
            this.btnScanline.Name = "btnScanline";
            this.btnScanline.Size = new System.Drawing.Size(255, 81);
            this.btnScanline.TabIndex = 0;
            this.btnScanline.Text = "Enter";
            this.btnScanline.UseVisualStyleBackColor = true;
            this.btnScanline.Click += new System.EventHandler(this.btnScanline_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(21, 52);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1030, 110);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Algorithms Region Filling";
            // 
            // FrmMenuRegionFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1552, 944);
            this.Controls.Add(this.gbBresenham);
            this.Controls.Add(this.gbCicunferenceB);
            this.Controls.Add(this.gbDiferentialAnalyzer);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmMenuRegionFilling";
            this.Text = "FrmRegionFilling";
            this.gbBresenham.ResumeLayout(false);
            this.gbCicunferenceB.ResumeLayout(false);
            this.gbDiferentialAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBresenham;
        private System.Windows.Forms.Button btnPadding;
        private System.Windows.Forms.GroupBox gbCicunferenceB;
        private System.Windows.Forms.Button btnPaddingSides;
        private System.Windows.Forms.GroupBox gbDiferentialAnalyzer;
        private System.Windows.Forms.Button btnScanline;
        private System.Windows.Forms.Label lbTitle;
    }
}