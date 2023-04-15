using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class G2D : Form
    {
        public G2D()
        {
            InitializeComponent();
        }

        void lineDDA(int x0, int y0, int xEnd, int yEnd, Brush brush)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            setPixel((int)Math.Round(x), (int)Math.Round(y), brush);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                setPixel((int)Math.Round(x), (int)Math.Round(y), brush);
            }
        }

        private void setPixel(int x, int y, Brush brush)
        {
            var g = panel1.CreateGraphics();
            g.FillRectangle(brush, x, y, 2, 2);
        }

        private int xP1, xP2, xP3, xP4, yP1, yP2, yP3, yP4;

        Brush redBrush = Brushes.Red;
        Brush blackBrush = Brushes.Black;

        private void setPoints()
        {
            try
            {
                xP1 = int.Parse(x1.Text);
                yP1 = int.Parse(y1.Text);

                xP2 = int.Parse(x2.Text);
                yP2 = int.Parse(y2.Text);

                xP3 = int.Parse(x3.Text);
                yP3 = int.Parse(y3.Text);

                xP4 = int.Parse(x4.Text);
                yP4 = int.Parse(y4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void translateToCenterOfPanel()
        {
            try
            {
                Size size = panel1.Size;

                int panelWidth = size.Width / 2;
                int panelHeight = size.Height / 2;

                xP1 += panelWidth;
                yP1 += panelHeight;

                xP2 += panelWidth;
                yP2 += panelHeight;

                xP3 += panelWidth;
                yP3 += panelHeight;

                xP4 += panelWidth;
                yP4 += panelHeight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void drawRectangle(Brush brush)
        {
            // p1 & p2
            lineDDA(xP1, yP1, xP2, yP2, brush);

            // p2 & p3
            lineDDA(xP1, yP1, xP3, yP3, brush);

            //p3 & p4
            lineDDA(xP2, yP2, xP4, yP4, brush);

            // p4 & p1
            lineDDA(xP3, yP3, xP4, yP4, brush);

        }

        private void draw_Click(object sender, EventArgs e)
        {
            setPoints();

            translateToCenterOfPanel();

            drawRectangle(blackBrush);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void setTranslatePoints()
        {
            try
            {
                int tx = int.Parse(x.Text);
                int ty = int.Parse(y.Text);

                xP1 += tx;
                yP1 += ty;

                xP2 += tx;
                yP2 += ty;

                xP3 += tx;
                yP3 += ty;

                xP4 += tx;
                yP4 += ty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void translate_Click(object sender, EventArgs e)
        {
            setPoints();

            setTranslatePoints();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void setScalePoints()
        {
            try
            {
                int sx = int.Parse(x.Text);
                int sy = int.Parse(y.Text);

                xP1 *= sx;
                yP1 *= sy;

                xP2 *= sx;
                yP2 *= sy;

                xP3 *= sx;
                yP3 *= sy;

                xP4 *= sx;
                yP4 *= sy;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void setReflectionOverX()
        {
            xP1 = -xP1;

            xP2 = -xP2;

            xP3 = -xP3;

            xP4 = -xP4;
        }

        private void reflectionOverX_Click(object sender, EventArgs e)
        {
            setPoints();

            setReflectionOverX();

            translateToCenterOfPanel();

            drawRectangle(redBrush);

        }

        private void setReflectionOverY()
        {
            yP1 = -yP1;

            yP2 = -yP2;

            yP3 = -yP3;

            yP4 = -yP4;
        }

        private void reflectionOverY_Click(object sender, EventArgs e)
        {
            setPoints();

            setReflectionOverY();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void setReflectionOverOrigin()
        {
            setReflectionOverX();

            setReflectionOverY();
        }

        private void reflectionOverOrigin_Click(object sender, EventArgs e)
        {
            setPoints();

            setReflectionOverOrigin();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void G2D_Load(object sender, EventArgs e)
        {

        }

        private void scale_Click(object sender, EventArgs e)
        {
            setPoints();

            setScalePoints();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void setShearXPoints()
        {
            try
            {
                int shX = int.Parse(x.Text);

                xP1 += (shX * yP1);

                xP2 += (shX * yP2);

                xP3 += (shX * yP3);

                xP4 += (shX * yP4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void shearX_Click(object sender, EventArgs e)
        {
            setPoints();

            setShearXPoints();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void setShearYPoints()
        {
            try
            {
                int shY = int.Parse(y.Text);

                yP1 += (shY * xP1);

                yP2 += (shY * xP2);

                yP3 += (shY * xP3);

                yP4 += (shY * xP4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void shearY_Click(object sender, EventArgs e)
        {
            setPoints();

            setShearYPoints();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }

        private void setRotationPoints()
        {
            try
            {
                double angleValue = double.Parse(angle.Text);

                int cosCeta = (int)Math.Round(Math.Cos(angleValue));
                int sinCeta = (int)Math.Round(Math.Sin(angleValue));

                int xc = (xP1 + xP2);
                int yc = yP1;

                int temp;
                temp = cosCeta * xP1 - sinCeta * yP1 + xc * (1 - cosCeta) + yc * sinCeta;
                yP1 = sinCeta * xP1 + cosCeta * yP1 + yc * (1 - cosCeta) - xc * sinCeta;
                xP1 = temp;

                temp = cosCeta * xP2 - sinCeta * yP2 + xc * (1 - cosCeta) + yc * sinCeta;
                yP2 = sinCeta * xP2 + cosCeta * yP2 + yc * (1 - cosCeta) - xc * sinCeta;
                xP2 = temp;

                temp = cosCeta * xP3 - sinCeta * yP3 + xc * (1 - cosCeta) + yc * sinCeta;
                yP3 = sinCeta * xP3 + cosCeta * yP3 + yc * (1 - cosCeta) - xc * sinCeta;
                xP3 = temp;

                temp = cosCeta * xP4 - sinCeta * yP4 + xc * (1 - cosCeta) + yc * sinCeta;
                yP4 = sinCeta * xP4 + cosCeta * yP4 + yc * (1 - cosCeta) - xc * sinCeta;
                xP4 = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

    private void rotation_Click(object sender, EventArgs e)
        {
            setPoints();

            setRotationPoints();

            translateToCenterOfPanel();

            drawRectangle(redBrush);
        }
    }
}
