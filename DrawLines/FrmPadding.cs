using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class FrmPadding : Form
    {
        Padding padding = new Padding();

        private static FrmPadding _instance;

        public static FrmPadding Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmPadding();
                }
                return _instance;
            }
        }
        public FrmPadding()
        {
            InitializeComponent();
        }
        private void InicializarDataGridView()
        {
            dataGridViewPoints.Columns.Clear();
            dataGridViewPoints.Columns.Add("Ordinal", "Ordinal");
            dataGridViewPoints.Columns.Add("X", "X");
            dataGridViewPoints.Columns.Add("Y", "Y");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            padding.ReadData(txtSide);
            padding.PlotShape(picCanvas);
        }

        private void bntReset_Click_1(object sender, EventArgs e)
        {
            padding.InitializeData(txtSide, picCanvas, dataGridViewPoints);
        }

        private void FrmPadding_Load_1(object sender, EventArgs e)
        {
            padding.InitializeData(txtSide, picCanvas, dataGridViewPoints);
            InicializarDataGridView();

            picCanvas.MouseClick += async (s, e2) =>
            {
                await padding.FloodFillAsync(e2.X, e2.Y, picCanvas, dataGridViewPoints);
            };
        }
    }
}
