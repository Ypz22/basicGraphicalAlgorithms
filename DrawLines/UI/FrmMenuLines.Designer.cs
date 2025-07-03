namespace DrawLines.UI
{
    partial class FrmMenuLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuLines));
            this.gbPadding = new System.Windows.Forms.GroupBox();
            this.btnDDA = new System.Windows.Forms.Button();
            this.gbBresenham = new System.Windows.Forms.GroupBox();
            this.btnBresenhamElipse = new System.Windows.Forms.Button();
            this.gbCicunferenceB = new System.Windows.Forms.GroupBox();
            this.btnCircunference = new System.Windows.Forms.Button();
            this.gbDiferentialAnalyzer = new System.Windows.Forms.GroupBox();
            this.btnBresenhamLine = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbPadding.SuspendLayout();
            this.gbBresenham.SuspendLayout();
            this.gbCicunferenceB.SuspendLayout();
            this.gbDiferentialAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPadding
            // 
            this.gbPadding.Controls.Add(this.btnDDA);
            this.gbPadding.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPadding.Location = new System.Drawing.Point(621, 620);
            this.gbPadding.Name = "gbPadding";
            this.gbPadding.Size = new System.Drawing.Size(466, 294);
            this.gbPadding.TabIndex = 9;
            this.gbPadding.TabStop = false;
            this.gbPadding.Text = "Algorithms DDA";
            this.gbPadding.Enter += new System.EventHandler(this.gbPadding_Enter);
            // 
            // btnDDA
            // 
            this.btnDDA.Location = new System.Drawing.Point(110, 163);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(255, 81);
            this.btnDDA.TabIndex = 2;
            this.btnDDA.Text = "Enter";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // gbBresenham
            // 
            this.gbBresenham.Controls.Add(this.btnBresenhamElipse);
            this.gbBresenham.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBresenham.Location = new System.Drawing.Point(621, 272);
            this.gbBresenham.Name = "gbBresenham";
            this.gbBresenham.Size = new System.Drawing.Size(466, 262);
            this.gbBresenham.TabIndex = 7;
            this.gbBresenham.TabStop = false;
            this.gbBresenham.Text = "Algorithms Bresenham Elipse";
            this.gbBresenham.Enter += new System.EventHandler(this.gbBresenham_Enter);
            // 
            // btnBresenhamElipse
            // 
            this.btnBresenhamElipse.Location = new System.Drawing.Point(110, 136);
            this.btnBresenhamElipse.Name = "btnBresenhamElipse";
            this.btnBresenhamElipse.Size = new System.Drawing.Size(255, 81);
            this.btnBresenhamElipse.TabIndex = 1;
            this.btnBresenhamElipse.Text = "Enter";
            this.btnBresenhamElipse.UseVisualStyleBackColor = true;
            this.btnBresenhamElipse.Click += new System.EventHandler(this.btnBresenhamElipse_Click);
            // 
            // gbCicunferenceB
            // 
            this.gbCicunferenceB.Controls.Add(this.btnCircunference);
            this.gbCicunferenceB.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCicunferenceB.Location = new System.Drawing.Point(75, 620);
            this.gbCicunferenceB.Name = "gbCicunferenceB";
            this.gbCicunferenceB.Size = new System.Drawing.Size(466, 294);
            this.gbCicunferenceB.TabIndex = 8;
            this.gbCicunferenceB.TabStop = false;
            this.gbCicunferenceB.Text = "Algorithms Circunference";
            this.gbCicunferenceB.Enter += new System.EventHandler(this.gbCicunferenceB_Enter);
            // 
            // btnCircunference
            // 
            this.btnCircunference.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircunference.Location = new System.Drawing.Point(91, 163);
            this.btnCircunference.Name = "btnCircunference";
            this.btnCircunference.Size = new System.Drawing.Size(255, 81);
            this.btnCircunference.TabIndex = 2;
            this.btnCircunference.Text = "Enter";
            this.btnCircunference.UseVisualStyleBackColor = true;
            this.btnCircunference.Click += new System.EventHandler(this.btnCircunference_Click);
            // 
            // gbDiferentialAnalyzer
            // 
            this.gbDiferentialAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiferentialAnalyzer.Controls.Add(this.btnBresenhamLine);
            this.gbDiferentialAnalyzer.Font = new System.Drawing.Font("MV Boli", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiferentialAnalyzer.Location = new System.Drawing.Point(75, 272);
            this.gbDiferentialAnalyzer.Name = "gbDiferentialAnalyzer";
            this.gbDiferentialAnalyzer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDiferentialAnalyzer.Size = new System.Drawing.Size(466, 262);
            this.gbDiferentialAnalyzer.TabIndex = 6;
            this.gbDiferentialAnalyzer.TabStop = false;
            this.gbDiferentialAnalyzer.Text = "Algorithm Bresenham Line";
            this.gbDiferentialAnalyzer.Enter += new System.EventHandler(this.gbDiferentialAnalyzer_Enter);
            // 
            // btnBresenhamLine
            // 
            this.btnBresenhamLine.Location = new System.Drawing.Point(91, 136);
            this.btnBresenhamLine.Name = "btnBresenhamLine";
            this.btnBresenhamLine.Size = new System.Drawing.Size(255, 81);
            this.btnBresenhamLine.TabIndex = 0;
            this.btnBresenhamLine.Text = "Enter";
            this.btnBresenhamLine.UseVisualStyleBackColor = true;
            this.btnBresenhamLine.Click += new System.EventHandler(this.btnBresenhamLine_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(29, 77);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1178, 110);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Algorithms Lines and Curves";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // FrmMenuLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1554, 1006);
            this.Controls.Add(this.gbPadding);
            this.Controls.Add(this.gbBresenham);
            this.Controls.Add(this.gbCicunferenceB);
            this.Controls.Add(this.gbDiferentialAnalyzer);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmMenuLines";
            this.Text = "FrmMenuLines";
            this.gbPadding.ResumeLayout(false);
            this.gbBresenham.ResumeLayout(false);
            this.gbCicunferenceB.ResumeLayout(false);
            this.gbDiferentialAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPadding;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.GroupBox gbBresenham;
        private System.Windows.Forms.Button btnBresenhamElipse;
        private System.Windows.Forms.GroupBox gbCicunferenceB;
        private System.Windows.Forms.Button btnCircunference;
        private System.Windows.Forms.GroupBox gbDiferentialAnalyzer;
        private System.Windows.Forms.Button btnBresenhamLine;
        private System.Windows.Forms.Label lbTitle;
    }
}