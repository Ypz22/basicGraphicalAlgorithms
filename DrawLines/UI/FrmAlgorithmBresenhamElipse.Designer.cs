namespace DrawLines.UI
{
    partial class FrmAlgorithmBresenhamElipse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlgorithmBresenhamElipse));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridPoints = new System.Windows.Forms.DataGridView();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadioY = new System.Windows.Forms.TextBox();
            this.txtRadioX = new System.Windows.Forms.TextBox();
            this.txtYc = new System.Windows.Forms.TextBox();
            this.txtXc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(361, 275);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 51);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Reset";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(919, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(481, 50);
            this.label5.TabIndex = 47;
            this.label5.Text = "Algoritmo de Bresenham";
            // 
            // dataGridPoints
            // 
            this.dataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPoints.Location = new System.Drawing.Point(63, 375);
            this.dataGridPoints.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPoints.Name = "dataGridPoints";
            this.dataGridPoints.RowHeadersWidth = 51;
            this.dataGridPoints.RowTemplate.Height = 24;
            this.dataGridPoints.Size = new System.Drawing.Size(590, 538);
            this.dataGridPoints.TabIndex = 46;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(119, 275);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(204, 51);
            this.btnGraficar.TabIndex = 41;
            this.btnGraficar.Text = "Draw Line";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click_1);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(755, 177);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(782, 736);
            this.picCanvas.TabIndex = 36;
            this.picCanvas.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(392, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 56;
            this.label4.Text = "Radio Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Radio X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(392, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Y center";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "X center";
            // 
            // txtRadioY
            // 
            this.txtRadioY.Location = new System.Drawing.Point(378, 199);
            this.txtRadioY.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadioY.Name = "txtRadioY";
            this.txtRadioY.Size = new System.Drawing.Size(136, 29);
            this.txtRadioY.TabIndex = 52;
            // 
            // txtRadioX
            // 
            this.txtRadioX.Location = new System.Drawing.Point(128, 199);
            this.txtRadioX.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadioX.Name = "txtRadioX";
            this.txtRadioX.Size = new System.Drawing.Size(136, 29);
            this.txtRadioX.TabIndex = 51;
            // 
            // txtYc
            // 
            this.txtYc.Location = new System.Drawing.Point(378, 97);
            this.txtYc.Margin = new System.Windows.Forms.Padding(4);
            this.txtYc.Name = "txtYc";
            this.txtYc.Size = new System.Drawing.Size(136, 29);
            this.txtYc.TabIndex = 50;
            // 
            // txtXc
            // 
            this.txtXc.Location = new System.Drawing.Point(128, 96);
            this.txtXc.Margin = new System.Windows.Forms.Padding(4);
            this.txtXc.Name = "txtXc";
            this.txtXc.Size = new System.Drawing.Size(136, 29);
            this.txtXc.TabIndex = 49;
            // 
            // FrmAlgorithmBresenhamElipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1576, 974);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadioY);
            this.Controls.Add(this.txtRadioX);
            this.Controls.Add(this.txtYc);
            this.Controls.Add(this.txtXc);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridPoints);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmAlgorithmBresenhamElipse";
            this.Text = "FrmAlgorithmBresenhamElipse";
            this.Load += new System.EventHandler(this.FrmAlgorithmBresenhamElipse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridPoints;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadioY;
        private System.Windows.Forms.TextBox txtRadioX;
        private System.Windows.Forms.TextBox txtYc;
        private System.Windows.Forms.TextBox txtXc;
    }
}