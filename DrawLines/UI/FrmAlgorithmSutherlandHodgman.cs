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
    public partial class FrmAlgorithmSutherlandHodgman : Form
    {

        private static FrmAlgorithmSutherlandHodgman _instance;

        public static FrmAlgorithmSutherlandHodgman Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmAlgorithmSutherlandHodgman();
                }
                return _instance;
            }
        }

        private List<Point> polygon = new List<Point>();
        private Rectangle rectClip;
        private bool mostrarRecorte = false;
        private List<Point> clippedPolygon;
        public FrmAlgorithmSutherlandHodgman()
        {
            InitializeComponent();
            picCanvas.Image = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.MouseClick += picCanvas_MouseClick;

            rectClip = new Rectangle(picCanvas.Width / 4, picCanvas.Height / 4, picCanvas.Width / 2, picCanvas.Height / 2);

            RedibujarTodo();

        }

        private void FrmAlgorithmSutherlandHodgman_Load(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                polygon.Add(e.Location);
                mostrarRecorte = false;
                RedibujarTodo();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (polygon.Count < 3)
                {
                    MessageBox.Show("El polígono debe tener al menos 3 puntos.");
                    return;
                }

                clippedPolygon = SutherlandHodgmanAlgorithm.ClipPolygon(polygon, rectClip);
                mostrarRecorte = true;
                RedibujarTodo();
            }
        }

        private void RedibujarTodo()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                using (Pen penClip = new Pen(Color.DarkGreen, 2))
                {
                    g.DrawRectangle(penClip, rectClip);
                }

                if (polygon.Count > 1 && !mostrarRecorte)
                {
                    using (Pen polyPen = new Pen(Color.Blue, 2))
                    {
                        g.DrawPolygon(polyPen, polygon.ToArray());
                    }
                }
                if (mostrarRecorte && clippedPolygon != null && clippedPolygon.Count > 1)
                {
                    using (Pen clippedPen = new Pen(Color.Red, 2))
                    {
                        g.DrawPolygon(clippedPen, clippedPolygon.ToArray());
                    }
                }

                foreach (var point in polygon)
                {
                    g.FillEllipse(Brushes.Black, point.X - 2, point.Y - 2, 4, 4);
                }
            }

            if (picCanvas.Image != null)
                picCanvas.Image.Dispose();

            picCanvas.Image = bmp;
            picCanvas.Invalidate();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetCanvas();
        }

        private void ResetCanvas()
        {
            polygon.Clear();
            clippedPolygon = null;
            mostrarRecorte = false;
            RedibujarTodo();
        }


    }
}
