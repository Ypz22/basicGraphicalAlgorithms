namespace DrawLines.UI
{
    partial class FrmMenuParametricCurves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuParametricCurves));
            this.gbBresenham = new System.Windows.Forms.GroupBox();
            this.btnBezier = new System.Windows.Forms.Button();
            this.gbDiferentialAnalyzer = new System.Windows.Forms.GroupBox();
            this.btnBSpines = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbBresenham.SuspendLayout();
            this.gbDiferentialAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBresenham
            // 
            this.gbBresenham.Controls.Add(this.btnBezier);
            this.gbBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBresenham.Location = new System.Drawing.Point(672, 480);
            this.gbBresenham.Name = "gbBresenham";
            this.gbBresenham.Size = new System.Drawing.Size(466, 262);
            this.gbBresenham.TabIndex = 19;
            this.gbBresenham.TabStop = false;
            this.gbBresenham.Text = "Algorithms Bezier Curves";
            // 
            // btnBezier
            // 
            this.btnBezier.Location = new System.Drawing.Point(110, 136);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(255, 81);
            this.btnBezier.TabIndex = 1;
            this.btnBezier.Text = "Enter";
            this.btnBezier.UseVisualStyleBackColor = true;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // gbDiferentialAnalyzer
            // 
            this.gbDiferentialAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiferentialAnalyzer.Controls.Add(this.btnBSpines);
            this.gbDiferentialAnalyzer.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiferentialAnalyzer.Location = new System.Drawing.Point(126, 480);
            this.gbDiferentialAnalyzer.Name = "gbDiferentialAnalyzer";
            this.gbDiferentialAnalyzer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDiferentialAnalyzer.Size = new System.Drawing.Size(466, 262);
            this.gbDiferentialAnalyzer.TabIndex = 18;
            this.gbDiferentialAnalyzer.TabStop = false;
            this.gbDiferentialAnalyzer.Text = "Algorithm B-Spline";
            // 
            // btnBSpines
            // 
            this.btnBSpines.Location = new System.Drawing.Point(91, 136);
            this.btnBSpines.Name = "btnBSpines";
            this.btnBSpines.Size = new System.Drawing.Size(255, 81);
            this.btnBSpines.TabIndex = 0;
            this.btnBSpines.Text = "Enter";
            this.btnBSpines.UseVisualStyleBackColor = true;
            this.btnBSpines.Click += new System.EventHandler(this.btnBSpines_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(70, 235);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1232, 110);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Algorithms Parametric Curves";
            // 
            // FrmMenuParametricCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1554, 980);
            this.Controls.Add(this.gbBresenham);
            this.Controls.Add(this.gbDiferentialAnalyzer);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmMenuParametricCurves";
            this.Text = "FrmMenuParametricCurves";
            this.gbBresenham.ResumeLayout(false);
            this.gbDiferentialAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBresenham;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.GroupBox gbDiferentialAnalyzer;
        private System.Windows.Forms.Button btnBSpines;
        private System.Windows.Forms.Label lbTitle;
    }
}