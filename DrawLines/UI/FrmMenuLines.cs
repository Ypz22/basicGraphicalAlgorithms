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
    public partial class FrmMenuLines : Form
    {
        public FrmMenuLines()
        {
            InitializeComponent();
        }

        private static FrmMenuLines _instance;

        public static FrmMenuLines Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmMenuLines();
                }
                return _instance;
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void gbBresenham_Enter(object sender, EventArgs e)
        {

        }

        private void gbCicunferenceB_Enter(object sender, EventArgs e)
        {

        }

        private void gbDiferentialAnalyzer_Enter(object sender, EventArgs e)
        {

        }

        private void gbPadding_Enter(object sender, EventArgs e)
        {

        }

        private void btnBresenhamLine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmBresenham frm = FrmAlgorithmBresenham.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnBresenhamElipse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmBresenhamElipse frm = FrmAlgorithmBresenhamElipse.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnCircunference_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmCircumference frm = FrmAlgorithmCircumference.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlgorithmDDA frm = FrmAlgorithmDDA.Instance;
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
