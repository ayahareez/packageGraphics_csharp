using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApmp1;

namespace WindowsFormsApp1
{
    public partial class Drawing_Algorithms : Form
    {
        public Drawing_Algorithms()
        {
            InitializeComponent();
        }

        private void Ellips_Click(object sender, EventArgs e)
        {
            EllipsForm ellips = new EllipsForm();
            ellips.Show();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            CircleForm circle = new CircleForm();
            circle.Show();
        }

        private void DDA_Click(object sender, EventArgs e)
        {
            LineWithDDA line = new LineWithDDA();
            line.Show();
        }

        private void Bresenham_Click(object sender, EventArgs e)
        {
            LineWithBresenham line2 = new LineWithBresenham();
            line2.Show();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {

        }

        private void TwoDGeometric_Click(object sender, EventArgs e)
        {
            G2D g2D = new G2D();
            g2D.Show();
        }

        //private void ThreeDGeometric_Click(object sender, EventArgs e)
        //{
        //    Form1 d = new Form1();
        //    d.Show();
        //}

        private void TwoDViewing_Click(object sender, EventArgs e)
        {

        }

       
    }

    
}
