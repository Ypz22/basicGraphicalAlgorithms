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
    public partial class FrmPaddingNSides : Form
    {
        PaddingNSides paddingNSides = new PaddingNSides();

        private static FrmPaddingNSides _instance;

        public static FrmPaddingNSides Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmPaddingNSides();
                }
                return _instance;
            }
        }
        public FrmPaddingNSides()
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
            paddingNSides.ReadData(txtSide);
            paddingNSides.PlotShape(picCanvas);
        }

        private void bntReset_Click_1(object sender, EventArgs e)
        {
            paddingNSides.InitializeData(txtSide, picCanvas, dataGridViewPoints);

        }

        private void FrmPaddingNSides_Load(object sender, EventArgs e)
        {
            paddingNSides.InitializeData(txtSide, picCanvas, dataGridViewPoints);
            InicializarDataGridView();

            picCanvas.MouseClick += async (s, e2) =>
            {
                await paddingNSides.FloodFillAsync(e2.X, e2.Y, picCanvas, dataGridViewPoints);
            };
        }
    }
}
