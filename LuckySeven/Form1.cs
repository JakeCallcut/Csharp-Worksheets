using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            Random randMaster = new Random();

            int rng1 = randMaster.Next(1, 8);
            int rng2 = randMaster.Next(1, 8);
            int rng3 = randMaster.Next(1, 8);

            lbl1.Text = Convert.ToString(rng1);
            lbl2.Text = Convert.ToString(rng2);
            lbl3.Text = Convert.ToString(rng3);

            if (rng1 == 7 || rng2 == 7 || rng3 == 7)
                MessageBox.Show("You won!");

            else if (rng1 == 5 & rng2 == 5 & rng3 == 5)
                MessageBox.Show("You won!");

            else
                MessageBox.Show("Try Again?");
        }   

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
