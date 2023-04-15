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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void MidPointCircle(int xCenter ,int yCenter,int raduis)
        {
            int x = 0;
            int y = raduis;
            int p = 1 - raduis;
            circlePlotPoint(xCenter, yCenter, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                circlePlotPoint(xCenter, yCenter, x, y);
            }
        }

        private void circlePlotPoint(int xCenter, int yCenter , int x, int y)
        {
            setPixel(xCenter + x, yCenter + y);
            setPixel(xCenter - x, yCenter + y);
            setPixel(xCenter + x, yCenter - y);
            setPixel(xCenter - x, yCenter - y);
            setPixel(xCenter + y, yCenter + x);
            setPixel(xCenter - y, yCenter + x);
            setPixel(xCenter + y, yCenter - x);
            setPixel(xCenter - y, yCenter - x);

        }

        private void setPixel(int x,int y)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.FillRectangle(aBrush, x, y, 2, 2);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int xCenter = int.Parse(x.Text);
                int yCenter = int.Parse(y.Text);
                int raduis = int.Parse(r.Text);

                Size panelSize = panel1.Size;
                int width = panelSize.Width / 2;
                int hieght = panelSize.Height / 2;


                MidPointCircle(xCenter + width, yCenter + hieght, raduis);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x.Text = "";
            y.Text = "";
            r.Text = "";
            panel1.Refresh();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x_TextChanged(object sender, EventArgs e)
        {

        }

        private void r_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
