using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApmp1
{
    public partial class LineWithDDA : Form
    {
        public LineWithDDA()
        {
            InitializeComponent();
            button1.MouseEnter += OnMouseEnterbutton1;
            button1.MouseLeave += OnLeavebutton1;
            button2.MouseEnter += OnMouseEnterbutton2;
            button2.MouseLeave += OnLeavebutton2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(textBox1.Text);
                int y1 = Convert.ToInt32(textBox2.Text);
                int x2 = Convert.ToInt32(textBox3.Text);
                int y2 = Convert.ToInt32(textBox4.Text);
                Point p1 = new Point(x1, -y1);
                Point p2 = new Point(x2, -y2);

                Size panelSize = pictureBox1.Size;
                int width = panelSize.Width / 2;
                int hieght = panelSize.Height / 2;

                p1.X += width;
                p1.Y += hieght;

                p2.X += width;
                p2.Y += hieght;

                DDALine(p1, p2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void DDALine(Point p1, Point p2)
        {
            int dx = p2.X - p1.X, dy = p2.Y - p1.Y, steps, k;
            float xIncrement, yIncrement, x = p1.X, y = p1.Y;
            Bitmap p = new Bitmap(this.Width, this.Height);
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            p.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                p.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
            }
            pictureBox1.Image = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            pictureBox1.Image = null;
        }
        private void OnMouseEnterbutton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }
        private void OnLeavebutton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.RosyBrown;
        }
        private void OnMouseEnterbutton1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
        private void OnLeavebutton1(object sender, EventArgs e)
        {
            button1.BackColor = Color.RosyBrown;
        }

        private void LineWithDDA_Load(object sender, EventArgs e)
        {

        }
    }
}
