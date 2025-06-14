using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public class PaddingNSides
    {
        private List<PointF> PointsList;
        private int nSide;
        private Graphics mGraph;
        private const float SF = 5;
        private Pen mPen;

        private Bitmap canvas;
        private Color fillColor = Color.Red;
        private PictureBox pic;
        private DataGridView table;
        private int ordinal = 1;

        public PaddingNSides()
        {
            PointsList = new List<PointF>();
        }

        public void ReadData(TextBox txtLado)
        {
            if (!int.TryParse(txtLado.Text, out nSide) || nSide < 3)
            {
                MessageBox.Show("Enter an integer greater than or equal to 3", "Error");
                txtLado.Focus();
                txtLado.Clear();
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox picCanvas, DataGridView dvg)
        {
            nSide = 0;

            txtSide.Text = "";

            txtSide.Focus();
            dvg.Rows.Clear();
            picCanvas.Refresh();
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas, DataGridView dgv)
        {
            this.pic = picCanvas;
            this.table = dgv;
            if (canvas == null)
            {
                MessageBox.Show("First draw the figure.");
                return;
            }


            Color targetColor = canvas.GetPixel(x, y);
            await Task.Run(() => FloodFill(x, y, targetColor));
        }

        private void FloodFill(int x, int y, Color targetColor)
        {
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
                return;

            if (canvas.GetPixel(x, y).ToArgb() != targetColor.ToArgb() ||
                canvas.GetPixel(x, y).ToArgb() == fillColor.ToArgb())
                return;

            canvas.SetPixel(x, y, fillColor);

            pic.Invoke((MethodInvoker)(() =>
            {
                pic.Image = canvas;
                table.Rows.Add(ordinal++, x, y);
            }));

            Thread.Sleep(10);


            FloodFill(x, y - 1, targetColor); 
            FloodFill(x + 1, y, targetColor); 
            FloodFill(x, y + 1, targetColor); 
            FloodFill(x - 1, y, targetColor); 
        }

        public float CalculateAngle()
        {
            float angulo = 360 / nSide;
            return angulo;
        }


        public void PlotShape(PictureBox picCanvas)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            canvas = new Bitmap(width, height);
            PointsList.Clear();

            int numLados = nSide;
            float anguloGrados = 360f / numLados;
            float anguloRadianes;
            float radio = 5 * SF;

            int centerX = width / 2;
            int centerY = height / 2;

            using (Graphics g = Graphics.FromImage(canvas)) 
            {
                g.Clear(Color.White);
                mPen = new Pen(Color.Blue, 3);

                for (int i = 0; i < numLados; i++)
                {
                    anguloRadianes = (float)(Math.PI / 180 * (anguloGrados * i));
                    float x = centerX + (float)(radio * Math.Cos(anguloRadianes));
                    float y = centerY + (float)(radio * Math.Sin(anguloRadianes));
                    PointsList.Add(new PointF(x, y));
                }

                for (int j = 0; j < numLados; j++)
                {
                    PointF puntoInicio = PointsList[j];
                    PointF puntoFin = PointsList[(j + 1) % numLados];
                    g.DrawLine(mPen, puntoInicio, puntoFin);
                    System.Threading.Thread.Sleep(70);
                    Application.DoEvents();
                }
            }

            picCanvas.Image = canvas; 
        }

    }
}