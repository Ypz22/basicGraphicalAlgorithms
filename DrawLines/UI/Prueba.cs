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
    public partial class Prueba : Form
    {
        Bitmap canvasBitmap;
        List<PointF> vertices = new List<PointF>();
        List<(int, int)> edges = new List<(int, int)>();
        int edgeIndex = 0;
        bool animate = false;
        Timer timer;

        public Prueba()
        {
            InitializeComponent();
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvasBitmap;

            comboBox1.Items.AddRange(new string[] {
                "Heptagrama", "Enneagrama", "Estrella de David",
                "Cruz Griega", "Trébol Estilizado", "Pentagrama","Cuadrícula 4x4 con Diagonales"
            });

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += DrawNextEdge;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvasBitmap;
            edgeIndex = 0;

            string figura = comboBox1.SelectedItem?.ToString();
            if (figura == null) return;

            animate = checkBox1.Checked;

            if (figura == "Heptagrama") GenerarPoligonoEstrella(7, 2, 150);
            else if (figura == "Enneagrama") GenerarPoligonoEstrella(9, 2, 150);
            else if (figura == "Estrella de David") GenerarEstrellaDeDavid(100);
            else if (figura == "Cruz Griega") GenerarCruzGriega();
            else if (figura == "Trébol Estilizado") GenerarTrebolEstilizado(20);
            else if (figura == "Pentagrama") GenerarPentagrama(100);
            else if (figura == "Cuadrícula 4x4 con Diagonales") GenerarCuadriculaConDiagonales(4, 400);


            if (animate)
                timer.Start();
            else
                DibujarTodo();
        }

        void DibujarTodo()
        {
            foreach (var (a, b) in edges)
                DibujarLineaBresenham(vertices[a], vertices[b], Color.Black);

            picCanvas.Image = canvasBitmap;
        }

        void DrawNextEdge(object sender, EventArgs e)
        {
            if (edgeIndex >= edges.Count)
            {
                timer.Stop();
                return;
            }

            var (a, b) = edges[edgeIndex++];
            DibujarLineaBresenham(vertices[a], vertices[b], Color.Black);
            picCanvas.Image = canvasBitmap;
        }

        void DibujarLineaBresenham(PointF p1, PointF p2, Color color)
        {
            int x0 = (int)p1.X;
            int y0 = (int)p1.Y;
            int x1 = (int)p2.X;
            int y1 = (int)p2.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                if (x0 >= 0 && x0 < canvasBitmap.Width && y0 >= 0 && y0 < canvasBitmap.Height)
                    canvasBitmap.SetPixel(x0, y0, color);

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }

        void GenerarPoligonoEstrella(int n, int salto, float radio)
        {
            vertices.Clear();
            edges.Clear();
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;

            for (int i = 0; i < n; i++)
            {
                float angle = (float)(2 * Math.PI * i / n);
                float x = cx + (float)(radio * Math.Cos(angle));
                float y = cy + (float)(radio * Math.Sin(angle));
                vertices.Add(new PointF(x, y));
            }

            int actual = 0;
            do
            {
                int next = (actual + salto) % n;
                edges.Add((actual, next));
                actual = next;
            } while (actual != 0);
        }

        void GenerarEstrellaDeDavid(float radio)
        {
            vertices.Clear();
            edges.Clear();
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;

            // Triángulo superior
            for (int i = 0; i < 3; i++)
            {
                float angle = (float)(-Math.PI / 2 + 2 * Math.PI * i / 3);
                vertices.Add(new PointF(
                    cx + (float)(radio * Math.Cos(angle)),
                    cy + (float)(radio * Math.Sin(angle))
                ));
            }

            // Triángulo inferior
            for (int i = 0; i < 3; i++)
            {
                float angle = (float)(Math.PI / 2 + 2 * Math.PI * i / 3);
                vertices.Add(new PointF(
                    cx + (float)(radio * Math.Cos(angle)),
                    cy + (float)(radio * Math.Sin(angle))
                ));
            }

            edges.Add((0, 1)); edges.Add((1, 2)); edges.Add((2, 0));
            edges.Add((3, 4)); edges.Add((4, 5)); edges.Add((5, 3));
        }

        void GenerarCruzGriega()
        {
            vertices.Clear();
            edges.Clear();
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;
            float s = 40;

            vertices.AddRange(new PointF[]
            {
                new PointF(cx - 3*s, cy - s),
                new PointF(cx - s, cy - s),
                new PointF(cx - s, cy - 3*s),
                new PointF(cx + s, cy - 3*s),
                new PointF(cx + s, cy - s),
                new PointF(cx + 3*s, cy - s),
                new PointF(cx + 3*s, cy + s),
                new PointF(cx + s, cy + s),
                new PointF(cx + s, cy + 3*s),
                new PointF(cx - s, cy + 3*s),
                new PointF(cx - s, cy + s),
                new PointF(cx - 3*s, cy + s),
            });

            for (int i = 0; i < vertices.Count; i++)
                edges.Add((i, (i + 1) % vertices.Count));
        }

        void GenerarTrebolEstilizado(float size)
        {
            vertices.Clear();
            edges.Clear();
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;

            float offset = size + 10;
            PointF[] centers = new PointF[]
            {
                new PointF(cx, cy - offset),
                new PointF(cx + offset, cy),
                new PointF(cx, cy + offset),
                new PointF(cx - offset, cy),
            };

            int startIndex = 0;
            foreach (var c in centers)
            {
                vertices.AddRange(new PointF[]
                {
                    new PointF(c.X, c.Y - size),
                    new PointF(c.X + size, c.Y),
                    new PointF(c.X, c.Y + size),
                    new PointF(c.X - size, c.Y),
                });

                edges.Add((startIndex, startIndex + 1));
                edges.Add((startIndex + 1, startIndex + 2));
                edges.Add((startIndex + 2, startIndex + 3));
                edges.Add((startIndex + 3, startIndex));
                startIndex += 4;
            }
        }

        void GenerarPentagrama(float radio)
        {
            vertices.Clear();
            edges.Clear();
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;

            int n = 5;
            for (int i = 0; i < n; i++)
            {
                float angle = (float)(-Math.PI / 2 + 2 * Math.PI * i / n);
                float x = cx + (float)(radio * Math.Cos(angle));
                float y = cy + (float)(radio * Math.Sin(angle));
                vertices.Add(new PointF(x, y));
            }

            for (int i = 0; i < n; i++)
                edges.Add((i, (i + 2) % n));

            for (int i = 0; i < n; i++)
                edges.Add((i, (i + 1) % n));
        }

        void GenerarCuadriculaConDiagonales(int n, float size)
        {
            vertices.Clear();
            edges.Clear();

            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;
            float cellSize = size / n;

            float startX = cx - size / 2;
            float startY = cy - size / 2;

            // Crear puntos de la rejilla
            PointF[,] puntos = new PointF[n + 1, n + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    float x = startX + j * cellSize;
                    float y = startY + i * cellSize;
                    puntos[i, j] = new PointF(x, y);
                    vertices.Add(puntos[i, j]);
                }
            }

            // Líneas horizontales y verticales
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int idx1 = i * (n + 1) + j;
                    int idx2 = idx1 + 1;
                    edges.Add((idx1, idx2)); // horizontal

                    int idx3 = j * (n + 1) + i;
                    int idx4 = idx3 + (n + 1);
                    if (i < n)
                        edges.Add((idx3, idx4)); // vertical
                }
            }

            // Diagonales en cada celda
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int topLeft = i * (n + 1) + j;
                    int topRight = topLeft + 1;
                    int bottomLeft = topLeft + (n + 1);
                    int bottomRight = bottomLeft + 1;

                    edges.Add((topLeft, bottomRight));   // Diagonal \
                    edges.Add((topRight, bottomLeft));   // Diagonal /
                }
            }
        }

    }
}

