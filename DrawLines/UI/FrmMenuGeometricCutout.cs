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
    public partial class FrmMenuGeometricCutout : Form
    {

        private static FrmMenuGeometricCutout _instance;

        public static FrmMenuGeometricCutout Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmMenuGeometricCutout();
                }
                return _instance;
            }
        }
        public FrmMenuGeometricCutout()
        {
            InitializeComponent();
        }

        private void btnCohen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmCohenShutterland frm = FrmAlgorithmCohenShutterland.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnShutterland_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmSutherlandHodgman frm = FrmAlgorithmSutherlandHodgman.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void FrmMenuGeometricCutout_Load(object sender, EventArgs e)
        {

        }
    }
}
