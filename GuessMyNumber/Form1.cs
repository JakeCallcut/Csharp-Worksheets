using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random randMaster = new Random();
        int rng = randMaster.Next(1, 11);

        private void btngo_Click(object sender, EventArgs e)
        {

            int guess = Convert.ToInt32(txtguess.Text);

                if (guess == rng)
                {
                    MessageBox.Show("Well done, you guessed the number!");
                    Application.Exit();
                }

                else if (guess < rng)
                {
                    MessageBox.Show("Try a little higher");
                }
                
                else if (guess > rng)
                {
                    MessageBox.Show("Try a little lower");
                }
        }
    }
}
