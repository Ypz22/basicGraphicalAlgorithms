using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Resolvers;

namespace DrawLines
{
    public class AlgorithmDDA
    {
        int xi, yi, x, y;
        int differentialX, differentialY;
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen;
        public AlgorithmDDA()
        {
            this.xi = 0;
            this.yi = 0;
            this.x = 0;
            this.y = 0;
        }

        public void InitializeData(TextBox txtXInitial, TextBox txtXFinal, TextBox txtYInitial, TextBox txtYFinal, PictureBox picCanvas, DataGridView dvg)
        {
            xi = 0;
            yi = 0;
            x = 0;
            y = 0;

            txtXInitial.Text = "";
            txtXFinal.Text = "";
            txtYInitial.Text = "";
            txtYFinal.Text = "";


            txtXInitial.Focus();
            picCanvas.Refresh();
            dvg.Rows.Clear();

        }

        public void ReadData(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf)
        {
            if (txtXi.Text == "" || txtYi.Text == "" || txtXf.Text == "" || txtYf.Text == "")
            {
                throw new ArgumentException("All fields must be filled out.");
            }
            xi = int.Parse(txtXi.Text);
            yi = int.Parse(txtYi.Text);
            x = int.Parse(txtXf.Text);
            y = int.Parse(txtYf.Text);
        }

        public float calculateDifferentialX(int x, int xi)
        {
            if (x == xi)
            {
                throw new DivideByZeroException("The difference in X cannot be zero.");
            }
            differentialX = x - xi;
            return (float)differentialX;
        }

        public float calculateDifferentialY(int y, int yi)
        {
            if (y == yi)
            {
                throw new DivideByZeroException("The difference in Y cannot be zero.");
            }
            differentialY = y - yi;
            return (float)differentialY;
        }


        public float calculateSlope()
        {
            float dx = calculateDifferentialX(x, xi);
            float dy = calculateDifferentialY(y, yi);
            return dy / dx;
        }


        public void PlotShape(PictureBox picCanvas, DataGridView dgv)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            dgv.Rows.Clear();

            int steps = Math.Max(Math.Abs(x - xi), Math.Abs(y - yi));

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            float yAux = yi;
            float xAux = xi;
            float m = calculateSlope();
            float dx = calculateDifferentialX(x, xi);
            float dy = calculateDifferentialY(y, yi);

            for (int i = 0; i <= steps; i++)
            {
                Pen ejePen = new Pen(Color.Black, 2);
                mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
                mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
                int xCanvas = (int)Math.Round(centerX + xAux);
                int yCanvas = (int)Math.Round(centerY - yAux);

                mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);
                Thread.Sleep(100);
                Application.DoEvents();
                dgv.Rows.Add(i, Math.Round(xAux, 2), Math.Round(yAux, 2));

                if (Math.Abs(m) <= 1)
                {
                    if (dx >= 0)
                    {
                        xAux += 1;
                        yAux += m;
                    }
                    else
                    {
                        xAux -= 1;
                        yAux -= m;
                    }
                }
                else
                {
                    if (dy >= 0)
                    {
                        yAux += 1;
                        xAux += 1 / m;
                    }
                    else
                    {
                        yAux -= 1;
                        xAux -= 1 / m;
                    }
                }
            }

        }

    }
}