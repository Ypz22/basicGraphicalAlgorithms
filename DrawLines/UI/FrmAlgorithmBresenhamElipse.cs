using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawLines.Logic.AlgorithmsLinesAndCurves;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrawLines.UI
{
    public partial class FrmAlgorithmBresenhamElipse : Form
    {

        private static FrmAlgorithmBresenhamElipse instance = null;
        BresenhamEllipseAlgorithm elipse = new BresenhamEllipseAlgorithm();

        public static FrmAlgorithmBresenhamElipse Instance
        {
            get
            {
                if (instance == null)
                    instance = new FrmAlgorithmBresenhamElipse();
                return instance;
            }
        }

        public FrmAlgorithmBresenhamElipse()
        {
            InitializeComponent();
        }

        private void ElipseFrm_Load(object sender, EventArgs e)
        {
            elipse.ConfigureTable(dataGridPoints);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            elipse.InitializeData(txtXc, txtYc, txtRadioX, txtRadioY, picCanvas, dataGridPoints);
        }

        private void btnGraficar_Click_1(object sender, EventArgs e)
        {
            elipse.ReadData(txtXc, txtYc, txtRadioX, txtRadioY);
            elipse.PlotShape(picCanvas, dataGridPoints);
        }

        private void FrmAlgorithmBresenhamElipse_Load(object sender, EventArgs e)
        {
            elipse.ConfigureTable(dataGridPoints);
        }
    }
}
