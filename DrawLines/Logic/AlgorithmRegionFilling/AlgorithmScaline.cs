using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines.Logic.AlgorithmRegionFilling
{
    public class ScanlineAlgorithm
    {
        private List<PointF> pointList;
        private int sideCount;
        private const float SCALE_FACTOR = 20;
        private Pen pen;
        private Bitmap canvas;
        private Color fillColor = Color.Red;
        private PictureBox pictureBox;

        public ScanlineAlgorithm()
        {
            pointList = new List<PointF>();
        }

        public bool ReadData(TextBox txtSides)
        {
            if (string.IsNullOrWhiteSpace(txtSides.Text))
            {
                MessageBox.Show("Enter the number of sides.", "Empty field");
                txtSides.Focus();
                return false;
            }

            bool isNumber = int.TryParse(txtSides.Text, out sideCount);

            if (!isNumber)
            {
                MessageBox.Show("Enter only positive integers.", "Input error");
                txtSides.Clear();
                txtSides.Focus();
                return false;
            }

            if (sideCount < 3)
            {
                MessageBox.Show("The minimum number of sides must be 3.", "Invalid input");
                txtSides.Clear();
                txtSides.Focus();
                return false;
            }

            return true;
        }

        public void InitializeData(TextBox txtSides, PictureBox picCanvas)
        {
            sideCount = 0;
            txtSides.Text = "";
            txtSides.Focus();
            picCanvas.Image = null;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            canvas = new Bitmap(width, height);
            pointList.Clear();

            float angleDegrees = 360f / sideCount;
            float radius = 5 * SCALE_FACTOR;
            int centerX = width / 2;
            int centerY = height / 2;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
                pen = new Pen(Color.Blue, 3);

                for (int i = 0; i < sideCount; i++)
                {
                    float rad = (float)(Math.PI / 180 * (angleDegrees * i));
                    float x = centerX + (float)(radius * Math.Cos(rad));
                    float y = centerY + (float)(radius * Math.Sin(rad));
                    pointList.Add(new PointF(x, y));
                }

                for (int j = 0; j < sideCount; j++)
                {
                    PointF start = pointList[j];
                    PointF end = pointList[(j + 1) % sideCount];
                    g.DrawLine(pen, start, end);
                }
            }

            picCanvas.Image = canvas;
        }

        public async Task ScanlineFillAsync(int x, int y, PictureBox picCanvas)
        {
            this.pictureBox = picCanvas;
            if (canvas == null)
            {
                MessageBox.Show("Draw the shape first.");
                return;
            }

            Color targetColor = canvas.GetPixel(x, y);
            await Task.Run(() => ScanlineFill(x, y, targetColor));
            picCanvas.Image = canvas;
        }

        private void ScanlineFill(int x, int y, Color targetColor)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                int px = p.X;
                int py = p.Y;

                while (px >= 0 && canvas.GetPixel(px, py).ToArgb() == targetColor.ToArgb())
                    px--;
                px++;

                bool spanAbove = false;
                bool spanBelow = false;

                while (px < canvas.Width && canvas.GetPixel(px, py).ToArgb() == targetColor.ToArgb())
                {
                    canvas.SetPixel(px, py, fillColor);

                    if (py > 0)
                    {
                        Color above = canvas.GetPixel(px, py - 1);
                        if (above.ToArgb() == targetColor.ToArgb())
                        {
                            if (!spanAbove)
                            {
                                stack.Push(new Point(px, py - 1));
                                spanAbove = true;
                            }
                        }
                        else spanAbove = false;
                    }

                    if (py < canvas.Height - 1)
                    {
                        Color below = canvas.GetPixel(px, py + 1);
                        if (below.ToArgb() == targetColor.ToArgb())
                        {
                            if (!spanBelow)
                            {
                                stack.Push(new Point(px, py + 1));
                                spanBelow = true;
                            }
                        }
                        else spanBelow = false;
                    }

                    px++;
                }
            }
        }
    }
}
