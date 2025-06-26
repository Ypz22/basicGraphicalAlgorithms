using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace DrawLines
{
    public partial class FrmAlgorithmCircumference : Form
    {
        AlgorithmCircumference mDrawCircle = new AlgorithmCircumference();

        private static FrmAlgorithmCircumference _instance;

        public static FrmAlgorithmCircumference Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmAlgorithmCircumference();
                }
                return _instance;
            }
        }
        public FrmAlgorithmCircumference()
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

        private void FrmAlorithmCircumference_Load(object sender, EventArgs e)
        {
            mDrawCircle.InitializeData(txtRadius, txtXCenter, txtYCenter, picCanvas, dataGridViewPoints);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            mDrawCircle.ReadData(txtRadius, txtXCenter, txtYCenter);
            InicializarTabla();
            mDrawCircle.DrawCircleMidPoint(picCanvas, Color.Red, dataGridViewPoints);
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            mDrawCircle.InitializeData(txtRadius, txtXCenter, txtYCenter, picCanvas, dataGridViewPoints);
        }
    }
}
