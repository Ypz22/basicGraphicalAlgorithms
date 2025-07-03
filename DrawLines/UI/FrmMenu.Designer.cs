namespace DrawLines
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbDiferentialAnalyzer = new System.Windows.Forms.GroupBox();
            this.btnDDA = new System.Windows.Forms.Button();
            this.gbBresenham = new System.Windows.Forms.GroupBox();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.gbPadding = new System.Windows.Forms.GroupBox();
            this.btnPadding = new System.Windows.Forms.Button();
            this.gbCicunferenceB = new System.Windows.Forms.GroupBox();
            this.btnCircunferenceBresenham = new System.Windows.Forms.Button();
            this.gbDiferentialAnalyzer.SuspendLayout();
            this.gbBresenham.SuspendLayout();
            this.gbPadding.SuspendLayout();
            this.gbCicunferenceB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(40, 54);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1089, 110);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Basic Graphical Algorithms";
            // 
            // gbDiferentialAnalyzer
            // 
            this.gbDiferentialAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiferentialAnalyzer.Controls.Add(this.btnDDA);
            this.gbDiferentialAnalyzer.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiferentialAnalyzer.Location = new System.Drawing.Point(86, 249);
            this.gbDiferentialAnalyzer.Name = "gbDiferentialAnalyzer";
            this.gbDiferentialAnalyzer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDiferentialAnalyzer.Size = new System.Drawing.Size(466, 262);
            this.gbDiferentialAnalyzer.TabIndex = 1;
            this.gbDiferentialAnalyzer.TabStop = false;
            this.gbDiferentialAnalyzer.Text = "Algorithm Lines and Curves";
            // 
            // btnDDA
            // 
            this.btnDDA.Location = new System.Drawing.Point(91, 136);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(255, 81);
            this.btnDDA.TabIndex = 0;
            this.btnDDA.Text = "Enter";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // gbBresenham
            // 
            this.gbBresenham.Controls.Add(this.btnBresenham);
            this.gbBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBresenham.Location = new System.Drawing.Point(632, 249);
            this.gbBresenham.Name = "gbBresenham";
            this.gbBresenham.Size = new System.Drawing.Size(466, 262);
            this.gbBresenham.TabIndex = 2;
            this.gbBresenham.TabStop = false;
            this.gbBresenham.Text = "Algorithms Region Filling";
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(110, 136);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(255, 81);
            this.btnBresenham.TabIndex = 1;
            this.btnBresenham.Text = "Enter";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // gbPadding
            // 
            this.gbPadding.Controls.Add(this.btnPadding);
            this.gbPadding.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPadding.Location = new System.Drawing.Point(632, 597);
            this.gbPadding.Name = "gbPadding";
            this.gbPadding.Size = new System.Drawing.Size(466, 294);
            this.gbPadding.TabIndex = 4;
            this.gbPadding.TabStop = false;
            this.gbPadding.Text = "Algorithms Parametric Curves";
            // 
            // btnPadding
            // 
            this.btnPadding.Location = new System.Drawing.Point(110, 163);
            this.btnPadding.Name = "btnPadding";
            this.btnPadding.Size = new System.Drawing.Size(255, 81);
            this.btnPadding.TabIndex = 2;
            this.btnPadding.Text = "Enter";
            this.btnPadding.UseVisualStyleBackColor = true;
            this.btnPadding.Click += new System.EventHandler(this.btnPadding_Click);
            // 
            // gbCicunferenceB
            // 
            this.gbCicunferenceB.Controls.Add(this.btnCircunferenceBresenham);
            this.gbCicunferenceB.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCicunferenceB.Location = new System.Drawing.Point(86, 597);
            this.gbCicunferenceB.Name = "gbCicunferenceB";
            this.gbCicunferenceB.Size = new System.Drawing.Size(466, 294);
            this.gbCicunferenceB.TabIndex = 3;
            this.gbCicunferenceB.TabStop = false;
            this.gbCicunferenceB.Text = "Algorithms Geometric Cutout";
            // 
            // btnCircunferenceBresenham
            // 
            this.btnCircunferenceBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircunferenceBresenham.Location = new System.Drawing.Point(91, 163);
            this.btnCircunferenceBresenham.Name = "btnCircunferenceBresenham";
            this.btnCircunferenceBresenham.Size = new System.Drawing.Size(255, 81);
            this.btnCircunferenceBresenham.TabIndex = 2;
            this.btnCircunferenceBresenham.Text = "Enter";
            this.btnCircunferenceBresenham.UseVisualStyleBackColor = true;
            this.btnCircunferenceBresenham.Click += new System.EventHandler(this.btnCircunferenceBresenham_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1626, 976);
            this.Controls.Add(this.gbPadding);
            this.Controls.Add(this.gbBresenham);
            this.Controls.Add(this.gbCicunferenceB);
            this.Controls.Add(this.gbDiferentialAnalyzer);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.gbDiferentialAnalyzer.ResumeLayout(false);
            this.gbBresenham.ResumeLayout(false);
            this.gbPadding.ResumeLayout(false);
            this.gbCicunferenceB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbDiferentialAnalyzer;
        private System.Windows.Forms.GroupBox gbBresenham;
        private System.Windows.Forms.GroupBox gbPadding;
        private System.Windows.Forms.GroupBox gbCicunferenceB;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button btnPadding;
        private System.Windows.Forms.Button btnCircunferenceBresenham;
    }
}