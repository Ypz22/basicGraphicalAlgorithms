using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines.Logic.AlgorithmsLinesAndCurves
{
    public class BresenhamEllipseAlgorithm
    {
        private int xc;
        private int yc;
        private int rx;
        private int ry;
        private Graphics graphics;
        private Pen pen;

        public BresenhamEllipseAlgorithm()
        {
            xc = yc = rx = ry = 0;
        }

        public void ReadData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadiusX, TextBox txtRadiusY)
        {
            if (string.IsNullOrWhiteSpace(txtCenterX.Text) || string.IsNullOrWhiteSpace(txtCenterY.Text) ||
                string.IsNullOrWhiteSpace(txtRadiusX.Text) || string.IsNullOrWhiteSpace(txtRadiusY.Text))
            {
                MessageBox.Show("All fields must be filled.", "Input Error");
                return;
            }

            bool validXc = int.TryParse(txtCenterX.Text, out xc);
            bool validYc = int.TryParse(txtCenterY.Text, out yc);
            bool validRx = int.TryParse(txtRadiusX.Text, out rx);
            bool validRy = int.TryParse(txtRadiusY.Text, out ry);

            if (!validXc || !validYc || !validRx || !validRy)
            {
                MessageBox.Show("Please enter valid numbers only.", "Input Error");
                return;
            }

            if (rx <= 0 || ry <= 0)
            {
                MessageBox.Show("Radii must be greater than zero.", "Input Error");
                return;
            }
        }

        public void InitializeData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadiusX, TextBox txtRadiusY, PictureBox canvas, DataGridView table)
        {
            xc = yc = rx = ry = 0;

            txtCenterX.Text = "";
            txtCenterY.Text = "";
            txtRadiusX.Text = "";
            txtRadiusY.Text = "";
            txtCenterX.Focus();
            canvas.Refresh();
            table.Rows.Clear();
        }

        public void ConfigureTable(DataGridView table)
        {
            table.Columns.Clear();
            table.Columns.Add("Step", "Step");
            table.Columns.Add("X", "X");
            table.Columns.Add("Y", "Y");
        }

        public void PlotShape(PictureBox canvas, DataGridView table)
        {
            graphics = canvas.CreateGraphics();
            pen = new Pen(Color.DarkGreen, 1);
            table.Rows.Clear();

            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            int x = 0;
            int y = ry;

            double rx2 = rx * rx;
            double ry2 = ry * ry;
            double twoRx2 = 2 * rx2;
            double twoRy2 = 2 * ry2;
            double px = 0;
            double py = twoRx2 * y;

            int step = 1;

            Pen axisPen = new Pen(Color.LightGray, 1);
            graphics.DrawLine(axisPen, 0, centerY, canvas.Width, centerY);
            graphics.DrawLine(axisPen, centerX, 0, centerX, canvas.Height);

            double p1 = ry2 - (rx2 * ry) + (0.25 * rx2);
            while (px < py)
            {
                DrawSymmetricPoints(x, y, centerX, centerY, table, ref step);
                x++;
                px += twoRy2;
                if (p1 < 0)
                {
                    p1 += ry2 + px;
                }
                else
                {
                    y--;
                    py -= twoRx2;
                    p1 += ry2 + px - py;
                }
            }

            // Region 2
            double p2 = ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;
            while (y >= 0)
            {
                DrawSymmetricPoints(x, y, centerX, centerY, table, ref step);
                y--;
                py -= twoRx2;
                if (p2 > 0)
                {
                    p2 += rx2 - py;
                }
                else
                {
                    x++;
                    px += twoRy2;
                    p2 += rx2 - py + px;
                }
            }

        
        }

        private void AddPoint(DataGridView table, int x, int y, int step)
        {
            table.Rows.Add(step, x, y);
        }

        private void DrawSymmetricPoints(int x, int y, int centerX, int centerY, DataGridView table, ref int step)
        {
            int cx = centerX + xc;
            int cy = centerY - yc;

            AddPoint(table, cx + x, cy + y, step++);
            AddPoint(table, cx - x, cy + y, step++);
            AddPoint(table, cx + x, cy - y, step++);
            AddPoint(table, cx - x, cy - y, step++);

            DrawPixel(cx + x, cy + y);
            DrawPixel(cx - x, cy + y);
            DrawPixel(cx + x, cy - y);
            DrawPixel(cx - x, cy - y);

            System.Threading.Thread.Sleep(50);
            Application.DoEvents();
        }

        private void DrawPixel(int x, int y)
        {
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }
    }
}
