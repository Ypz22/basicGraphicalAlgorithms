using System;
using System.Windows.Forms;
using DrawLines.UI;

namespace DrawLines
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuLines frm = FrmMenuLines.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuRegionFilling frm = FrmMenuRegionFilling.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnCircunferenceBresenham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuGeometricCutout frm = FrmMenuGeometricCutout.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnPadding_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuParametricCurves frm = FrmMenuParametricCurves.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

    }
}
