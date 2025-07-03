using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawLines.Logic.AlgorithmRegionFilling;

namespace DrawLines.UI
{
    public partial class FrmAlgorithmScanline : Form
    {
        private static FrmAlgorithmScanline instance = null;
        ScanlineAlgorithm objFiguraRelleno = new ScanlineAlgorithm();
        public static FrmAlgorithmScanline Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmAlgorithmScanline();
                return instance;
            }
        }
        public FrmAlgorithmScanline()
        {
            InitializeComponent();
        }

        private void FrmAlgorithmScanline_Load(object sender, EventArgs e)
        {
            objFiguraRelleno.InitializeData(txtSide, picCanvas);

            picCanvas.MouseClick += async (s, e2) =>
            {
                await objFiguraRelleno.ScanlineFillAsync(e2.X, e2.Y, picCanvas);
            };
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            objFiguraRelleno.ReadData(txtSide);
            objFiguraRelleno.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objFiguraRelleno.InitializeData(txtSide, picCanvas);
        }
    }
}
