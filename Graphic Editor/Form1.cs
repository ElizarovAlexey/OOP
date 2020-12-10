using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_grafic
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;

        int x, y = 0;
        string figure = "Pen";
        string filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";

        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Color.Black, 3);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            g = drawingPlace.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void drawEllips_Click(object sender, EventArgs e)
        {
            figure = "Ellips";
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            figure = "Line";
        }

        private void drawRectangle_Click(object sender, EventArgs e)
        {
            figure = "Rectangle";
        }

        private void drawCurve_Click(object sender, EventArgs e)
        {
            figure = "Pen";
        }

        private void colorChange_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            pen.Color = color;
        }

        private void drawingPlace_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void drawingPlace_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure == "Pen" && e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            pen.Color = drawingPlace.BackColor;
            figure = "Pen";
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            drawingPlace.BackColor = color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(drawingPlace.Width, drawingPlace.Height);
            drawingPlace.DrawToBitmap(picture, new Rectangle(0, 0, picture.Width, picture.Height));

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = filter;

            if (dialog.ShowDialog() == DialogResult.OK)
                picture.Save(dialog.FileName);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
        }

        private void drawingPlace_MouseUp(object sender, MouseEventArgs e)
        {
            int x1 = x;
            int y1 = y;

            int h = Math.Abs(e.X - x);
            int w = Math.Abs(e.Y - y);

            if (x1 > e.X)
                x1 = e.X;
            if (y1 > e.Y)
                y1 = e.Y;

            Rectangle rectangle = new Rectangle(x1, y1, h, w);

            if (figure == "Line")
                g.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
            else if (figure == "Rectangle")
                g.DrawRectangle(pen, rectangle);
            else if (figure == "Ellips")
                g.DrawEllipse(pen, rectangle);
            else if (figure == "Pen")
                drawingPlace_MouseMove(sender, e);
        }
    }
}
