using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines.UI
{
    public partial class FrmMenuParametricCurves : Form
    {

        private static FrmMenuParametricCurves _instance;

        public static FrmMenuParametricCurves Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmMenuParametricCurves();
                }
                return _instance;
            }
        }
        public FrmMenuParametricCurves()
        {
            InitializeComponent();
        }

        private void btnBSpines_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmBSplines frm = FrmAlgorithmBSplines.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmBezier frm = FrmAlgorithmBezier.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
