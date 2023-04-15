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
    public partial class EllipsForm : Form
    {
        public EllipsForm()
        {
            InitializeComponent();
        }

        void ellipseMidpoint(int xCenter, int yCenter, int Rx, int Ry)
        {
            int Rx2 = Rx * Rx;
            int Ry2 = Ry * Ry;
            int twoRx2 = 2 * Rx2;
            int twoRy2 = 2 * Ry2;
            int p;
            int x = 0;
            int y = Ry;
            int px = 0;
            int py = twoRx2 * y;

            /* Plot the initial point in each quadrant. */
            ellipsePlotPoints(xCenter, yCenter, x, y);

            /* Region 1 */
            p = (int)Math.Round(Ry2 - (Rx2 * Ry) + (0.25 * Rx2));

            while (px < py)
            {
                x++;
                px += twoRy2;
                if (p < 0)
                    p += Ry2 + px;
                else
                {
                    y--;
                    py -= twoRx2;
                    p += Ry2 + px - py;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }

            /* Region 2 */
            p = (int)Math.Round(Ry2 * (x + 0.5) * (x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);

            while (y > 0)
            {
                y--;
                py -= twoRx2;
                if (p > 0)
                    p += Rx2 - py;
                else
                {
                    x++;
                    px += twoRy2;
                    p += Rx2 - py + px;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }
        }
    
        private void ellipsePlotPoints(int xCenter, int yCenter, int x, int y)
        {
            setPixel(xCenter + x, yCenter + y);
            setPixel(xCenter - x, yCenter + y);
            setPixel(xCenter + x, yCenter - y);
            setPixel(xCenter - x, yCenter - y);

        }

        private void setPixel(int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.FillRectangle(aBrush, x, y, 2, 2);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                int xCenter = int.Parse(x.Text);
                int yCenter = int.Parse(y.Text);
                int Rx = int.Parse(rx.Text);
                int Ry = int.Parse(ry.Text);

                Size panelSize = panel1.Size;
                int width = panelSize.Width / 2;
                int hieght = panelSize.Height / 2;


                ellipseMidpoint(xCenter + width, yCenter + hieght, Rx, Ry);

            }catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            x.Text = "";
            y.Text = "";
            rx.Text = "";
            ry.Text = "";
            panel1.Refresh();
        }

        private void EllipsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
