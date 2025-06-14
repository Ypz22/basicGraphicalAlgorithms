using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DrawLines
{
    public class AlgorithmBresenham
    {
        private int xi;
        private int yi;
        private int x;
        private int y;
        private Graphics mGraph;
        private Pen mPen;

        public AlgorithmBresenham()
        {
            this.xi = 0;
            this.yi = 0;
            this.x = 0;
            this.y = 0;
        }

        public void ReadData(TextBox txtXI, TextBox txtYI, TextBox txtXF, TextBox txtYF)
        {
            try
            {
                xi = int.Parse(txtXI.Text);
                yi = int.Parse(txtYI.Text);
                x = int.Parse(txtXF.Text);
                y = int.Parse(txtYF.Text);
            }
            catch
            {
                MessageBox.Show("Invalid inputs", "Error Message");
            }
        }

        public void InitializeData(TextBox txtXI, TextBox txtYI, TextBox txtXF, TextBox txtYF, PictureBox picCanvas, DataGridView dvg)
        {
            xi = yi = x = y = 0;

            txtXI.Text = ""; txtXF.Text = "";
            txtYI.Text = ""; txtYF.Text = "";

            txtXI.Focus();
            dvg.Rows.Clear();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas, DataGridView dvg)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White); 
            mPen = new Pen(Color.Red, 1);

            dvg.Rows.Clear();

            int dx = x - xi;
            int dy = y - yi;

            int x0 = xi;
            int y0 = yi;
            int x1 = x;
            int y1 = y;

            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);

            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int px = x0;
            int py = y0;


            if (absDx > absDy)
            {
                int p = 2 * absDy - absDx;
                for (int i = 0; i <= absDx; i++)
                {
                    Pen ejePen = new Pen(Color.LightGray, 1);
                    mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
                    mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    dvg.Rows.Add(i,px, py);

                    Thread.Sleep(60);
                    Application.DoEvents();


                    px += sx;
                    if (p < 0)
                    {
                        p += 2 * absDy;
                    }
                    else
                    {
                        py += sy;
                        p += 2 * absDy - 2 * absDx;
                    }
                }
            }
            else
            {
                int p = 2 * absDx - absDy;
                for (int i = 0; i <= absDy; i++)
                {
                    Pen ejePen = new Pen(Color.LightGray, 1);
                    mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
                    mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    dvg.Rows.Add(i, px, py);

                    Thread.Sleep(60);
                    Application.DoEvents();


                    py += sy;
                    if (p < 0)
                    {
                        p += 2 * absDx;
                    }
                    else
                    {
                        px += sx;
                        p += 2 * absDx - 2 * absDy;
                    }
                }
            }
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}