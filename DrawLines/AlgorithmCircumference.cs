using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace DrawLines
{
    public class AlgorithmCircumference
    {
        public event Action<int, int> OnDrawPoint;

        private float mXc;
        private float mYc;
        private float mRadius;
        private Graphics mGraph;
        private Pen mPen;
        private int canvasOffsetX;
        private int canvasOffsetY;

        public AlgorithmCircumference()
        {
            mRadius = 0.0f;
            mXc = 0.0f;
            mYc = 0.0f;
        }

        public void ReadData(TextBox txtRadius, TextBox XC, TextBox YC)
        {
            if (txtRadius.Text == "")
            {
                MessageBox.Show("Enter the radius...", "Error message");
                return;
            }
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                mXc = float.Parse(XC.Text);
                mYc = float.Parse(YC.Text);
                if (mRadius <= 0)
                {
                    MessageBox.Show("The radius must be greater than zero...", "Error message");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid entry...", "Error message");
            }
        }

        public void InitializeData(TextBox txtRadius, TextBox txtXC, TextBox txtYC, PictureBox picCanvas, DataGridView dvg)
        {
            mRadius = 0.0f;
            mXc = 0.0f;
            mYc = 0.0f;

            txtRadius.Text = "";
            txtXC.Text = "";
            txtYC.Text = "";

            txtRadius.Focus();
            dvg.Rows.Clear();
            picCanvas.Refresh();
        }

        public void DrawCircleMidPoint(PictureBox picCanvas, Color color, DataGridView dgv)
        {
            using (Graphics g = picCanvas.CreateGraphics())
            using (SolidBrush brush = new SolidBrush(color))
            {
                dgv.Rows.Clear();
                int paso = 0;

                canvasOffsetX = picCanvas.Width / 2;
                canvasOffsetY = picCanvas.Height / 2;

                float x = 0, y = mRadius;
                float p = 1 - mRadius;
                Pen ejePen = new Pen(Color.Black, 1);
                g.DrawLine(ejePen, 0, canvasOffsetY, picCanvas.Width, canvasOffsetY);
                g.DrawLine(ejePen, canvasOffsetX, 0, canvasOffsetX, picCanvas.Height);

                paso = AddSymmetricPoints(g, mXc, mYc, x, y, brush, dgv, paso);

                while (x < y)
                {
                    x++;
                    if (p < 0)
                    {
                        p += 2 * x + 1;
                    }
                    else
                    {
                        y--;
                        p += 2 * (x - y) + 1;
                    }
                    paso = AddSymmetricPoints(g, mXc, mYc, x, y, brush, dgv, paso);
                }
            }
        }

        private int AddSymmetricPoints(Graphics g, float xc, float yc, float x, float y, Brush brush, DataGridView dgv, int paso)
        {
            PointF[] puntosLogicos = new PointF[]
            {
                new PointF(xc + x, yc + y),
                new PointF(xc - x, yc + y),
                new PointF(xc + x, yc - y),
                new PointF(xc - x, yc - y),
                new PointF(xc + y, yc + x),
                new PointF(xc - y, yc + x),
                new PointF(xc + y, yc - x),
                new PointF(xc - y, yc - x)
            };

            foreach (PointF pt in puntosLogicos)
            {
                Point canvasPoint = ToCanvas(pt.X, pt.Y);
                g.FillRectangle(brush, canvasPoint.X, canvasPoint.Y, 1, 1);

                dgv.Rows.Add(paso++, Math.Round(pt.X, 2), Math.Round(pt.Y, 2));

                Thread.Sleep(30);             
                Application.DoEvents();
            }

            return paso;
        }

        private Point ToCanvas(float x, float y)
        {
            return new Point(
                (int)Math.Round(canvasOffsetX + x),
                (int)Math.Round(canvasOffsetY - y)
            );
        }

        public void CloseForm(Form objcForm)
        {
            objcForm.Close();
        }
    }
}
