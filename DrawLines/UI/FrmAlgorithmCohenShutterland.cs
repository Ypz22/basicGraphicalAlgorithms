using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawLines.Logic;

namespace DrawLines.UI
{
    public partial class FrmAlgorithmCohenShutterland : Form
    {

        private Point? startPoint = null;
        private Point? endPoint = null;

        public FrmAlgorithmCohenShutterland()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.MouseClick += pictureBox1_MouseClick;

            RedrawAll();
        }

        private void FrmAlgorithmCohenSutherland_Load(object sender, EventArgs e)
        {
        }

        private Rectangle GetCenteredClipRectangle()
        {
            int rectWidth = pictureBox1.Width / 2;
            int rectHeight = pictureBox1.Height / 2;

            int x = (pictureBox1.Width - rectWidth) / 2;
            int y = (pictureBox1.Height - rectHeight) / 2;

            return new Rectangle(x, y, rectWidth, rectHeight);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!startPoint.HasValue)
                {
                    startPoint = e.Location;
                }
                else if (!endPoint.HasValue)
                {
                    endPoint = e.Location;
                    RedrawAll();
                }
            }
            else if (e.Button == MouseButtons.Right && startPoint.HasValue && endPoint.HasValue)
            {
                ApplyClipping();
            }
        }

        private void RedrawAll()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                var clipRect = GetCenteredClipRectangle();
                g.DrawRectangle(Pens.Blue, clipRect);

                if (startPoint.HasValue && endPoint.HasValue)
                {
                    g.DrawLine(Pens.Gray, startPoint.Value, endPoint.Value);
                }
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bmp;
        }

        private void ApplyClipping()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                var clipRect = GetCenteredClipRectangle();
                g.DrawRectangle(Pens.Blue, clipRect);

                var (x1, y1) = (startPoint.Value.X, startPoint.Value.Y);
                var (x2, y2) = (endPoint.Value.X, endPoint.Value.Y);

                var handler = new AlgorithmCohenShutterland(
                    clipRect.Left,
                    clipRect.Right,
                    clipRect.Top,
                    clipRect.Bottom
                );

                bool visible = handler.clipLine(x1, y1, x2, y2);

                if (visible)
                {
                    var clipped = handler.GetClippedLine();
                    if (clipped.HasValue)
                    {
                        var (cx1, cy1, cx2, cy2) = clipped.Value;
                        g.DrawLine(Pens.Black, cx1, cy1, cx2, cy2);
                    }
                }
                else
                {
                    MessageBox.Show("The line is completely outside the area.");
                }
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bmp;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetCanvas();
        }

        private void ResetCanvas()
        {
            startPoint = null;
            endPoint = null;
            RedrawAll();
        }
    }
}
