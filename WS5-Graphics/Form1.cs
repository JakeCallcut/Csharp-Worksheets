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
    }
}
