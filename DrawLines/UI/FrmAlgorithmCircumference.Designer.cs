namespace DrawLines
{
    partial class FrmAlgorithmCircumference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlgorithmCircumference));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.lbYCenter = new System.Windows.Forms.Label();
            this.txtYCenter = new System.Windows.Forms.TextBox();
            this.lbXCenter = new System.Windows.Forms.Label();
            this.txtXCenter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(750, 81);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(850, 792);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.Location = new System.Drawing.Point(31, 397);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.RowHeadersWidth = 72;
            this.dataGridViewPoints.RowTemplate.Height = 31;
            this.dataGridViewPoints.Size = new System.Drawing.Size(676, 476);
            this.dataGridViewPoints.TabIndex = 9;
            // 
            // lbYCenter
            // 
            this.lbYCenter.AutoSize = true;
            this.lbYCenter.BackColor = System.Drawing.Color.Transparent;
            this.lbYCenter.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYCenter.ForeColor = System.Drawing.Color.White;
            this.lbYCenter.Location = new System.Drawing.Point(385, 145);
            this.lbYCenter.Name = "lbYCenter";
            this.lbYCenter.Size = new System.Drawing.Size(137, 34);
            this.lbYCenter.TabIndex = 26;
            this.lbYCenter.Text = "Y Center";
            // 
            // txtYCenter
            // 
            this.txtYCenter.Location = new System.Drawing.Point(546, 145);
            this.txtYCenter.Name = "txtYCenter";
            this.txtYCenter.Size = new System.Drawing.Size(126, 29);
            this.txtYCenter.TabIndex = 25;
            // 
            // lbXCenter
            // 
            this.lbXCenter.AutoSize = true;
            this.lbXCenter.BackColor = System.Drawing.Color.Transparent;
            this.lbXCenter.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXCenter.ForeColor = System.Drawing.Color.White;
            this.lbXCenter.Location = new System.Drawing.Point(54, 148);
            this.lbXCenter.Name = "lbXCenter";
            this.lbXCenter.Size = new System.Drawing.Size(138, 34);
            this.lbXCenter.TabIndex = 24;
            this.lbXCenter.Text = "X Center";
            // 
            // txtXCenter
            // 
            this.txtXCenter.Location = new System.Drawing.Point(215, 148);
            this.txtXCenter.Name = "txtXCenter";
            this.txtXCenter.Size = new System.Drawing.Size(126, 29);
            this.txtXCenter.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Initial coordinates";
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReset.Location = new System.Drawing.Point(403, 300);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(150, 60);
            this.bntReset.TabIndex = 21;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(173, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 60);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Draw";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.BackColor = System.Drawing.Color.Transparent;
            this.lbRadius.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRadius.ForeColor = System.Drawing.Color.White;
            this.lbRadius.Location = new System.Drawing.Point(218, 213);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(101, 34);
            this.lbRadius.TabIndex = 28;
            this.lbRadius.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(379, 213);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(126, 29);
            this.txtRadius.TabIndex = 27;
            // 
            // FrmAlgorithmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1626, 928);
            this.Controls.Add(this.lbRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lbYCenter);
            this.Controls.Add(this.txtYCenter);
            this.Controls.Add(this.lbXCenter);
            this.Controls.Add(this.txtXCenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridViewPoints);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmAlgorithmCircumference";
            this.Text = "FrmAlgorithmCircumference";
            this.Load += new System.EventHandler(this.FrmAlorithmCircumference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.DataGridView dataGridViewPoints;
        private System.Windows.Forms.Label lbYCenter;
        private System.Windows.Forms.TextBox txtYCenter;
        private System.Windows.Forms.Label lbXCenter;
        private System.Windows.Forms.TextBox txtXCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.TextBox txtRadius;
    }
}