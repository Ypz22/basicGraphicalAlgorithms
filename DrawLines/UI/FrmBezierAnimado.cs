using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawLines.Logic;

namespace DrawLines.UI
{
    public partial class FrmBezierAnimado : Form
    {
        private CurvasBezier curva = new CurvasBezier();
        private Timer animacion;

        public FrmBezierAnimado()
        {
            InitializeComponent();

            picCanvas.MouseClick += PicCanvas_MouseClick;

            animacion = new Timer();
            animacion.Interval = 50;
            animacion.Tick += Animacion_Tick;

            Redibujar();
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!curva.ListoParaAnimar())
            {
                curva.AgregarPunto(e.Location);
                Redibujar();
            }

            if (curva.ListoParaAnimar())
            {
                curva.ReiniciarAnimacion();
                animacion.Start();
            }
        }

        private void Animacion_Tick(object sender, EventArgs e)
        {
            var paso = curva.AvanzarPaso();
            if (paso.HasValue)
            {
                var (A, B, C, D, E, F) = paso.Value;
                Redibujar(A, B, C, D, E, F);
            }
            else
            {
                animacion.Stop();
            }
        }

        private void Redibujar(PointF? A = null, PointF? B = null, PointF? C = null,
                               PointF? D = null, PointF? E = null, PointF? F = null)
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Puntos de control
                foreach (var p in curva.PuntosControl)
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);

                // Líneas guía entre puntos de control
                if (curva.PuntosControl.Count == 4)
                    g.DrawLines(Pens.Gray, curva.PuntosControl.ToArray());

                // Puntos y líneas intermedias
                if (A.HasValue && B.HasValue && C.HasValue)
                {
                    g.DrawLine(Pens.Green, A.Value, B.Value);
                    g.DrawLine(Pens.Green, B.Value, C.Value);
                    g.FillEllipse(Brushes.Green, A.Value.X - 2, A.Value.Y - 2, 4, 4);
                    g.FillEllipse(Brushes.Green, B.Value.X - 2, B.Value.Y - 2, 4, 4);
                    g.FillEllipse(Brushes.Green, C.Value.X - 2, C.Value.Y - 2, 4, 4);
                }

                if (D.HasValue && E.HasValue)
                {
                    g.DrawLine(Pens.Blue, D.Value, E.Value);
                    g.FillEllipse(Brushes.Blue, D.Value.X - 2, D.Value.Y - 2, 4, 4);
                    g.FillEllipse(Brushes.Blue, E.Value.X - 2, E.Value.Y - 2, 4, 4);
                }

                if (F.HasValue)
                    g.FillEllipse(Brushes.Red, F.Value.X - 2, F.Value.Y - 2, 4, 4);

                // Curva acumulada
                if (curva.CurvaGenerada.Count > 1)
                    g.DrawLines(Pens.Red, curva.CurvaGenerada.ToArray());
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void FrmBezierAnimado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            animacion.Stop();
            curva.Reset();
            Redibujar();

        }
    }
}
