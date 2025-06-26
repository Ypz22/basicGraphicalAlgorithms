using System;
using System.Windows.Forms;

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
            FrmAlgorithmDDA frm = FrmAlgorithmDDA.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmBresenham frm = FrmAlgorithmBresenham.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnCircunferenceBresenham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmCircumference frm = FrmAlgorithmCircumference.Instance;
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

        private void btnNSidesPadding_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaddingNSides frm = FrmPaddingNSides.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
