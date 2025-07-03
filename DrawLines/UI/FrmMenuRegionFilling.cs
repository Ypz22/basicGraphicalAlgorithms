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
    public partial class FrmMenuRegionFilling : Form
    {
        public FrmMenuRegionFilling()
        {
            InitializeComponent();
        }

        private static FrmMenuRegionFilling _instance;

        public static FrmMenuRegionFilling Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmMenuRegionFilling();
                }
                return _instance;
            }
        }
        private void btnScanline_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmScanline frm = FrmAlgorithmScanline.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnPadding_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPadding frm = FrmPadding.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnPaddingSides_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaddingNSides frm = FrmPaddingNSides.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
    
}
