using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawLines.Logic.AlgorithmParametricCurves;

namespace DrawLines.UI
{
    public partial class FrmAlgorithmBSplines : Form
    {
        private static FrmAlgorithmBSplines instance = null;
        BSplineAlgorithm curve = new BSplineAlgorithm();

        public static FrmAlgorithmBSplines Instance
        {
            get
            {
                if (instance == null)
                    instance = new FrmAlgorithmBSplines();
                return instance;
            }
        }

        public FrmAlgorithmBSplines()
        {
            InitializeComponent();
            picCanvas.MouseClick += PicCanvas_MouseClick;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            curve.Reset();
            Redraw();
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curve.AddPoint(e.Location);
                curve.GenerateFullCurve();
                Redraw();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            curve.Reset();
            Redraw();
        }

        private void Redraw()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                foreach (var p in curve.ControlPoints)
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);

                if (curve.ControlPoints.Count > 1)
                    g.DrawLines(Pens.Gray, curve.ControlPoints.ToArray());

                if (curve.GeneratedCurve.Count > 1)
                    g.DrawLines(Pens.Red, curve.GeneratedCurve.ToArray());
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void FrmBSpline_Load(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            curve.Reset();
            Redraw();
        }
    }
}
