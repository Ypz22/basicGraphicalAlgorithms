namespace DrawLines
{
    partial class FrmPadding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadding));
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.Location = new System.Drawing.Point(27, 403);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.RowHeadersWidth = 72;
            this.dataGridViewPoints.RowTemplate.Height = 31;
            this.dataGridViewPoints.Size = new System.Drawing.Size(676, 452);
            this.dataGridViewPoints.TabIndex = 22;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(749, 26);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(846, 838);
            this.picCanvas.TabIndex = 17;
            this.picCanvas.TabStop = false;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("MV Boli", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(93, 172);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(70, 34);
            this.lbSize.TabIndex = 39;
            this.lbSize.Text = "Size";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(238, 172);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(126, 29);
            this.txtSide.TabIndex = 38;
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle2.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.ForeColor = System.Drawing.Color.White;
            this.lbTitle2.Location = new System.Drawing.Point(103, 85);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(322, 45);
            this.lbTitle2.TabIndex = 37;
            this.lbTitle2.Text = "Initial coordinates";
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReset.Location = new System.Drawing.Point(426, 268);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(150, 60);
            this.bntReset.TabIndex = 36;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(196, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 60);
            this.btnCalculate.TabIndex = 35;
            this.btnCalculate.Text = "Draw";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FrmPadding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1624, 908);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridViewPoints);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmPadding";
            this.Text = "FrmPadding";
            this.Load += new System.EventHandler(this.FrmPadding_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPoints;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button btnCalculate;
    }
}