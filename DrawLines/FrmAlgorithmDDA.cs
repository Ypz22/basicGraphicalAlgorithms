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
    public partial class FrmAlgorithmDDA : Form
    {
        AlgorithmDDA algorithmDDA = new AlgorithmDDA();

        private static FrmAlgorithmDDA _instance;

        public static FrmAlgorithmDDA Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmAlgorithmDDA();
                }
                return _instance;
            }
        }
        public FrmAlgorithmDDA()
        {
            InitializeComponent();
        }

        private void InicializeDataGridView()
        {
            dataGridViewPoints.Columns.Clear();
            dataGridViewPoints.Columns.Add("Ordinal", "Ordinal");
            dataGridViewPoints.Columns.Add("X", "X");
            dataGridViewPoints.Columns.Add("Y", "Y");
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            algorithmDDA.InitializeData(txtXI, txtXF, txtYI, txtYF, picCanvas,dataGridViewPoints);
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            algorithmDDA.ReadData(txtXI, txtYI, txtXF, txtYF);
            InicializeDataGridView();
            algorithmDDA.PlotShape(picCanvas, dataGridViewPoints);
        }

        private void FrmAlgorithmDDA_Load(object sender, EventArgs e)
        {
            algorithmDDA.InitializeData(txtXI, txtXF, txtYI, txtYF, picCanvas, dataGridViewPoints);
        }
    }
}
