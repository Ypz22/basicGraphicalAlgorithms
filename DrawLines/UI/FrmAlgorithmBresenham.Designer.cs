namespace DrawLines
{
    partial class FrmAlgorithmBresenham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlgorithmBresenham));
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lbYF = new System.Windows.Forms.Label();
            this.txtYF = new System.Windows.Forms.TextBox();
            this.lbXF = new System.Windows.Forms.Label();
            this.txtXF = new System.Windows.Forms.TextBox();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lbYI = new System.Windows.Forms.Label();
            this.txtYI = new System.Windows.Forms.TextBox();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.lbXI = new System.Windows.Forms.Label();
            this.txtXI = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.Location = new System.Drawing.Point(40, 487);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.RowHeadersWidth = 72;
            this.dataGridViewPoints.RowTemplate.Height = 31;
            this.dataGridViewPoints.Size = new System.Drawing.Size(676, 412);
            this.dataGridViewPoints.TabIndex = 22;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(762, 40);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(838, 838);
            this.picCanvas.TabIndex = 17;
            this.picCanvas.TabStop = false;
            // 
            // lbYF
            // 
            this.lbYF.AutoSize = true;
            this.lbYF.BackColor = System.Drawing.Color.Transparent;
            this.lbYF.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYF.ForeColor = System.Drawing.Color.White;
            this.lbYF.Location = new System.Drawing.Point(386, 288);
            this.lbYF.Name = "lbYF";
            this.lbYF.Size = new System.Drawing.Size(111, 34);
            this.lbYF.TabIndex = 34;
            this.lbYF.Text = "Y FInal";
            // 
            // txtYF
            // 
            this.txtYF.Location = new System.Drawing.Point(547, 288);
            this.txtYF.Name = "txtYF";
            this.txtYF.Size = new System.Drawing.Size(126, 29);
            this.txtYF.TabIndex = 33;
            // 
            // lbXF
            // 
            this.lbXF.AutoSize = true;
            this.lbXF.BackColor = System.Drawing.Color.Transparent;
            this.lbXF.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXF.ForeColor = System.Drawing.Color.White;
            this.lbXF.Location = new System.Drawing.Point(55, 291);
            this.lbXF.Name = "lbXF";
            this.lbXF.Size = new System.Drawing.Size(111, 34);
            this.lbXF.TabIndex = 32;
            this.lbXF.Text = "X Final";
            // 
            // txtXF
            // 
            this.txtXF.Location = new System.Drawing.Point(216, 291);
            this.txtXF.Name = "txtXF";
            this.txtXF.Size = new System.Drawing.Size(126, 29);
            this.txtXF.TabIndex = 31;
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle2.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.ForeColor = System.Drawing.Color.White;
            this.lbTitle2.Location = new System.Drawing.Point(83, 204);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(302, 45);
            this.lbTitle2.TabIndex = 30;
            this.lbTitle2.Text = "Final coordinates";
            // 
            // lbYI
            // 
            this.lbYI.AutoSize = true;
            this.lbYI.BackColor = System.Drawing.Color.Transparent;
            this.lbYI.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYI.ForeColor = System.Drawing.Color.White;
            this.lbYI.Location = new System.Drawing.Point(386, 127);
            this.lbYI.Name = "lbYI";
            this.lbYI.Size = new System.Drawing.Size(123, 34);
            this.lbYI.TabIndex = 29;
            this.lbYI.Text = "Y Inicial";
            // 
            // txtYI
            // 
            this.txtYI.Location = new System.Drawing.Point(547, 127);
            this.txtYI.Name = "txtYI";
            this.txtYI.Size = new System.Drawing.Size(126, 29);
            this.txtYI.TabIndex = 28;
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle1.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.ForeColor = System.Drawing.Color.White;
            this.lbTitle1.Location = new System.Drawing.Point(83, 40);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(322, 45);
            this.lbTitle1.TabIndex = 27;
            this.lbTitle1.Text = "Initial coordinates";
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReset.Location = new System.Drawing.Point(406, 387);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(150, 60);
            this.bntReset.TabIndex = 26;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click_1);
            // 
            // lbXI
            // 
            this.lbXI.AutoSize = true;
            this.lbXI.BackColor = System.Drawing.Color.Transparent;
            this.lbXI.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXI.ForeColor = System.Drawing.Color.White;
            this.lbXI.Location = new System.Drawing.Point(55, 130);
            this.lbXI.Name = "lbXI";
            this.lbXI.Size = new System.Drawing.Size(124, 34);
            this.lbXI.TabIndex = 25;
            this.lbXI.Text = "X Inicial";
            // 
            // txtXI
            // 
            this.txtXI.Location = new System.Drawing.Point(216, 130);
            this.txtXI.Name = "txtXI";
            this.txtXI.Size = new System.Drawing.Size(126, 29);
            this.txtXI.TabIndex = 24;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(176, 387);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 60);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Draw";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // FrmAlgorithmBresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1632, 920);
            this.Controls.Add(this.lbYF);
            this.Controls.Add(this.txtYF);
            this.Controls.Add(this.lbXF);
            this.Controls.Add(this.txtXF);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.lbYI);
            this.Controls.Add(this.txtYI);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.lbXI);
            this.Controls.Add(this.txtXI);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridViewPoints);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmAlgorithmBresenham";
            this.Text = "FrmAlgorithmBresenham";
            this.Load += new System.EventHandler(this.FrmAlgorithmBresenham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPoints;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lbYF;
        private System.Windows.Forms.TextBox txtYF;
        private System.Windows.Forms.Label lbXF;
        private System.Windows.Forms.TextBox txtXF;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Label lbYI;
        private System.Windows.Forms.TextBox txtYI;
        private System.Windows.Forms.Label lbTitle1;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Label lbXI;
        private System.Windows.Forms.TextBox txtXI;
        private System.Windows.Forms.Button btnCalculate;
    }
}