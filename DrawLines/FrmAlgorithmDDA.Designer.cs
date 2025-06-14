namespace DrawLines
{
    partial class FrmAlgorithmDDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlgorithmDDA));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtXI = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lbXI = new System.Windows.Forms.Label();
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.bntReset = new System.Windows.Forms.Button();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.lbYI = new System.Windows.Forms.Label();
            this.txtYI = new System.Windows.Forms.TextBox();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lbYF = new System.Windows.Forms.Label();
            this.txtYF = new System.Windows.Forms.TextBox();
            this.lbXF = new System.Windows.Forms.Label();
            this.txtXF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(158, 378);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 60);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Draw";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // txtXI
            // 
            this.txtXI.Location = new System.Drawing.Point(198, 121);
            this.txtXI.Name = "txtXI";
            this.txtXI.Size = new System.Drawing.Size(126, 29);
            this.txtXI.TabIndex = 1;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(756, 82);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(844, 824);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            // 
            // lbXI
            // 
            this.lbXI.AutoSize = true;
            this.lbXI.BackColor = System.Drawing.Color.Transparent;
            this.lbXI.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXI.ForeColor = System.Drawing.Color.White;
            this.lbXI.Location = new System.Drawing.Point(37, 121);
            this.lbXI.Name = "lbXI";
            this.lbXI.Size = new System.Drawing.Size(124, 34);
            this.lbXI.TabIndex = 6;
            this.lbXI.Text = "X Inicial";
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.Location = new System.Drawing.Point(12, 473);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.RowHeadersWidth = 72;
            this.dataGridViewPoints.RowTemplate.Height = 31;
            this.dataGridViewPoints.Size = new System.Drawing.Size(676, 452);
            this.dataGridViewPoints.TabIndex = 10;
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReset.Location = new System.Drawing.Point(388, 378);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(150, 60);
            this.bntReset.TabIndex = 11;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle1.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.ForeColor = System.Drawing.Color.White;
            this.lbTitle1.Location = new System.Drawing.Point(65, 31);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(322, 45);
            this.lbTitle1.TabIndex = 12;
            this.lbTitle1.Text = "Initial coordinates";
            // 
            // lbYI
            // 
            this.lbYI.AutoSize = true;
            this.lbYI.BackColor = System.Drawing.Color.Transparent;
            this.lbYI.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYI.ForeColor = System.Drawing.Color.White;
            this.lbYI.Location = new System.Drawing.Point(368, 118);
            this.lbYI.Name = "lbYI";
            this.lbYI.Size = new System.Drawing.Size(123, 34);
            this.lbYI.TabIndex = 14;
            this.lbYI.Text = "Y Inicial";
            // 
            // txtYI
            // 
            this.txtYI.Location = new System.Drawing.Point(529, 118);
            this.txtYI.Name = "txtYI";
            this.txtYI.Size = new System.Drawing.Size(126, 29);
            this.txtYI.TabIndex = 13;
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle2.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.ForeColor = System.Drawing.Color.White;
            this.lbTitle2.Location = new System.Drawing.Point(65, 195);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(302, 45);
            this.lbTitle2.TabIndex = 15;
            this.lbTitle2.Text = "Final coordinates";
            // 
            // lbYF
            // 
            this.lbYF.AutoSize = true;
            this.lbYF.BackColor = System.Drawing.Color.Transparent;
            this.lbYF.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYF.ForeColor = System.Drawing.Color.White;
            this.lbYF.Location = new System.Drawing.Point(368, 279);
            this.lbYF.Name = "lbYF";
            this.lbYF.Size = new System.Drawing.Size(111, 34);
            this.lbYF.TabIndex = 19;
            this.lbYF.Text = "Y FInal";
            // 
            // txtYF
            // 
            this.txtYF.Location = new System.Drawing.Point(529, 279);
            this.txtYF.Name = "txtYF";
            this.txtYF.Size = new System.Drawing.Size(126, 29);
            this.txtYF.TabIndex = 18;
            // 
            // lbXF
            // 
            this.lbXF.AutoSize = true;
            this.lbXF.BackColor = System.Drawing.Color.Transparent;
            this.lbXF.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXF.ForeColor = System.Drawing.Color.White;
            this.lbXF.Location = new System.Drawing.Point(37, 282);
            this.lbXF.Name = "lbXF";
            this.lbXF.Size = new System.Drawing.Size(111, 34);
            this.lbXF.TabIndex = 17;
            this.lbXF.Text = "X Final";
            // 
            // txtXF
            // 
            this.txtXF.Location = new System.Drawing.Point(198, 282);
            this.txtXF.Name = "txtXF";
            this.txtXF.Size = new System.Drawing.Size(126, 29);
            this.txtXF.TabIndex = 16;
            // 
            // FrmAlgorithmDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1628, 962);
            this.Controls.Add(this.lbYF);
            this.Controls.Add(this.txtYF);
            this.Controls.Add(this.lbXF);
            this.Controls.Add(this.txtXF);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.lbYI);
            this.Controls.Add(this.txtYI);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.dataGridViewPoints);
            this.Controls.Add(this.lbXI);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.txtXI);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmAlgorithmDDA";
            this.Text = "FrmAlgorithmDDA";
            this.Load += new System.EventHandler(this.FrmAlgorithmDDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtXI;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lbXI;
        private System.Windows.Forms.DataGridView dataGridViewPoints;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Label lbTitle1;
        private System.Windows.Forms.Label lbYI;
        private System.Windows.Forms.TextBox txtYI;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Label lbYF;
        private System.Windows.Forms.TextBox txtYF;
        private System.Windows.Forms.Label lbXF;
        private System.Windows.Forms.TextBox txtXF;
    }
}