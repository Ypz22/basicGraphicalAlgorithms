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
    public partial class FrmAlgorithmBresenham : Form
    {
        AlgorithmBresenham algorithmBresenham = new AlgorithmBresenham();

        private static FrmAlgorithmBresenham _instance;

        public static FrmAlgorithmBresenham Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmAlgorithmBresenham();
                }
                return _instance;
            }
        }
        public FrmAlgorithmBresenham()
        {
            InitializeComponent();
        }

        private void InicializarTabla()
        {
            dataGridViewPoints.Columns.Clear();
            dataGridViewPoints.Columns.Add("Ordinal", "Ordinal");
            dataGridViewPoints.Columns.Add("X", "X");
            dataGridViewPoints.Columns.Add("Y", "Y");
        }
        private void btCalculate_Click(object sender, EventArgs e)
        {
            algorithmBresenham.ReadData(txtXI, txtYI, txtXF, txtYF);
            InicializarTabla();
            algorithmBresenham.PlotShape(picCanvas, dataGridViewPoints);
        }

        private void FrmAlgorithmBresenham_Load(object sender, EventArgs e)
        {
            algorithmBresenham.InitializeData(txtXI, txtYI, txtXF, txtYF, picCanvas, dataGridViewPoints);
        }

        private void bntReset_Click_1(object sender, EventArgs e)
        {
            algorithmBresenham.InitializeData(txtXI, txtYI, txtXF, txtYF, picCanvas, dataGridViewPoints);
        }
    }
}
