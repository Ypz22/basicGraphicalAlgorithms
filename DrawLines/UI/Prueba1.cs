using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrawLines.UI
{
    public partial class Prueba1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Blue, 2);
        List<PointF> vertices = new List<PointF>();
        List<(int, int)> edges = new List<(int, int)>();
        int edgeIndex = 0;
        bool animate = false;
        Timer timer;

        public Prueba1()
        {
            InitializeComponent();
            g = picCanvas.CreateGraphics();
            comboBox1.Items.AddRange(new string[] {
    "Heptagrama", "Enneagrama", "Estrella de David", "Cruz Griega", "Trébol Estilizado", "Pentagrama"
});


            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += DrawNextEdge;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            edgeIndex = 0;
            string figura = comboBox1.SelectedItem.ToString();
            animate = checkBox1.Checked;

            if (figura == "Heptagrama") GenerarPoligonoEstrella(7, 2, 150);
            else if (figura == "Enneagrama") GenerarPoligonoEstrella(9, 2, 150);
            else if (figura == "Estrella de David") GenerarEstrellaDeDavid(100);
            else if (figura == "Cruz Griega") GenerarCruzGriega();
            else if (figura == "Trébol Estilizado") GenerarTrebolEstilizado(20);
            else if (figura == "Pentagrama") GenerarPentagrama(100);


            if (animate)
                timer.Start();
            else
                DibujarTodo();
        }

        void DibujarTodo()
        {
            foreach (var (a, b) in edges)
                g.DrawLine(pen, vertices[a], vertices[b]);
        }

        void DrawNextEdge(object sender, EventArgs e)
        {
            if (edgeIndex >= edges.Count)
            {
                timer.Stop();
                return;
            }
            var (a, b) = edges[edgeIndex++];
            g.DrawLine(pen, vertices[a], vertices[b]);
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
            for (int i = 0; i < 3; i++)
            {
                float angle = (float)(-Math.PI / 2 + 2 * Math.PI * i / 3);
                vertices.Add(new PointF(
                    cx + (float)(radio * Math.Cos(angle)),
                    cy + (float)(radio * Math.Sin(angle))
                ));
            }
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
        new PointF(cx - 3*s, cy - s),  // 0
        new PointF(cx - s, cy - s),   // 1
        new PointF(cx - s, cy - 3*s), // 2
        new PointF(cx + s, cy - 3*s), // 3
        new PointF(cx + s, cy - s),   // 4
        new PointF(cx + 3*s, cy - s), // 5
        new PointF(cx + 3*s, cy + s), // 6
        new PointF(cx + s, cy + s),   // 7
        new PointF(cx + s, cy + 3*s), // 8
        new PointF(cx - s, cy + 3*s), // 9
        new PointF(cx - s, cy + s),   //10
        new PointF(cx - 3*s, cy + s), //11
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
        new PointF(cx, cy - offset), // arriba
        new PointF(cx + offset, cy), // derecha
        new PointF(cx, cy + offset), // abajo
        new PointF(cx - offset, cy), // izquierda
            };

            int startIndex = 0;
            foreach (var c in centers)
            {
                vertices.AddRange(new PointF[]
                {
            new PointF(c.X, c.Y - size), // arriba
            new PointF(c.X + size, c.Y), // derecha
            new PointF(c.X, c.Y + size), // abajo
            new PointF(c.X - size, c.Y), // izquierda
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



    }
}

