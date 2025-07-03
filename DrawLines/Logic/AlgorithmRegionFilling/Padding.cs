using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public class Padding
    {
        private float side;
        private const float SF = 10;
        private Pen mPen;

        private Bitmap canvas;
        private Color fillColor = Color.Red;
        private PictureBox pic;
        private DataGridView table;
        private int ordinal = 1;

        public Padding()
        {
            side = 0.0f;
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas, DataGridView dgv)
        {
            this.pic = picCanvas;
            this.table = dgv;

            if (canvas == null)
            {
                canvas = new Bitmap(pic.Width, pic.Height);
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.Clear(Color.White);
                    Pen borderPen = new Pen(Color.Black, 3);

                    float width = side * SF;
                    float height = side * SF;
                    float xPos = (pic.Width - width) / 2;
                    float yPos = (pic.Height - height) / 2;

                    g.DrawRectangle(borderPen, xPos, yPos, width, height);
                }
                pic.Image = canvas;
            }

            Color targetColor = canvas.GetPixel(x, y);
            await Task.Run(() => FloodFill(x, y, targetColor));
        }

        private void FloodFill(int x, int y, Color targetColor)
        {
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
                return;

            Color currentColor = canvas.GetPixel(x, y);
            if (currentColor.ToArgb() != targetColor.ToArgb() || currentColor.ToArgb() == fillColor.ToArgb())
                return;

            canvas.SetPixel(x, y, fillColor);

            if (pic.InvokeRequired)
            {
                pic.Invoke((MethodInvoker)(() =>
                {
                    pic.Image = canvas;
                    table.Rows.Add(ordinal++, x, y);
                }));
            }

            Thread.Sleep(10);

            FloodFill(x, y - 1, targetColor);
            FloodFill(x + 1, y, targetColor);
            FloodFill(x, y + 1, targetColor);
            FloodFill(x - 1, y, targetColor);
        }

        public void ReadData(TextBox txtSide)
        {
            if (string.IsNullOrWhiteSpace(txtSide.Text) || !float.TryParse(txtSide.Text, out side) || side <= 0)
            {
                MessageBox.Show("Invalid entry....", "Error message");
                txtSide.Focus();
                txtSide.Text = "";
                return;
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox picCanvas, DataGridView dvg)
        {
            side = 0.0f;

            txtSide.Text = "";
            txtSide.Focus();

            dvg.Rows.Clear();
            picCanvas.Image = null;
            picCanvas.Refresh();

            canvas = null;
            ordinal = 1;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
                mPen = new Pen(Color.Blue, 3);

                float width = side * SF;
                float height = side * SF;
                float xPos = (picCanvas.Width - width) / 2;
                float yPos = (picCanvas.Height - height) / 2;

                g.DrawRectangle(mPen, xPos, yPos, width, height);
            }
            picCanvas.Image = canvas;
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
