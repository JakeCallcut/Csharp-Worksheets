using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS5_Graphics
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Graphics canvas;
        public Form1()
        {
            InitializeComponent();
            canvas = pctbx.CreateGraphics();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult response;

            response = MessageBox.Show("Are you Sure", "Exit", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            Pen linePen = new Pen(Color.DarkGreen, 2);
            canvas.DrawLine(linePen, 20, 20, 100, 100);
        }

        private void btnrec_Click(object sender, EventArgs e)
        {
            Pen RecPen = new Pen(Color.BlueViolet, 2);
            canvas.DrawRectangle(RecPen, 200, 200, 100, 50);
        }

        private void btncirc_Click(object sender, EventArgs e)
        {
            Pen CircPen = new Pen(Color.Crimson, 2);

            for (int i = 1; i <= 10; i++)
            {
            int rad = random.Next(0, 100);
            int x = random.Next(0, pctbx.Width);
            int y = random.Next(0, pctbx.Height);

            canvas.DrawEllipse(CircPen, x, y, rad, rad);
            }               
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Pen XPen = new Pen(Color.DeepPink, 2);
            canvas.DrawLine(XPen, 0, 0, pctbx.Width, pctbx.Height);
            canvas.DrawLine(XPen, pctbx.Width, 0, 0, pctbx.Width);
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Pen PlusPen = new Pen(Color.Chocolate, 2);
            canvas.DrawLine(PlusPen, (pctbx.Width / 2), 0, (pctbx.Width / 2), pctbx.Height);
            canvas.DrawLine(PlusPen, 0, (pctbx.Height / 2), pctbx.Width, (pctbx.Height / 2));
        }

        private void btndiamond_Click(object sender, EventArgs e)
        {
            Pen DiamondPen = new Pen(Color.Chocolate, 2);
            canvas.DrawLine(DiamondPen, (pctbx.Width / 2), 0, 0, (pctbx.Height / 2));
            canvas.DrawLine(DiamondPen, 0, (pctbx.Height / 2), (pctbx.Width / 2), pctbx.Height);
            canvas.DrawLine(DiamondPen, (pctbx.Width / 2), pctbx.Height, pctbx.Width, (pctbx.Width / 2));
            canvas.DrawLine(DiamondPen, (pctbx.Width / 2), 0, pctbx.Width, (pctbx.Height / 2));
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);
        }
    } 
}
