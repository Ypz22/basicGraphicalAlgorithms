namespace DrawLines.UI
{
    partial class FrmAlgorithmSutherlandHodgman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlgorithmSutherlandHodgman));
            this.Reset = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(683, 814);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(165, 53);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(145, 91);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1246, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            // 
            // FrmAlgorithmSutherlandHodgman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1536, 958);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmAlgorithmSutherlandHodgman";
            this.Text = "FrmAlgorithmSutherlandHodgman";
            this.Load += new System.EventHandler(this.FrmAlgorithmSutherlandHodgman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}