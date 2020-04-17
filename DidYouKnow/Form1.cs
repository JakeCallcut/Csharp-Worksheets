using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DidYouKnow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            double height = Convert.ToDouble(txtheight.Text);
            double weight = Convert.ToDouble(txtweight.Text);
            double bmi;
            double shrink;

            lstbx.Items.Add("Hello " + name + ", did you know...");
            lstbx.Items.Add("On the moon you weigh: " + weight * 0.17 + "kg");
            
            MessageBox.Show("On the sun you weigh: " + weight * 27.1 + "kg");

            bmi = weight / (height * height);
            lstbx.Items.Add("Your BMI is: " + bmi.ToString("F2"));

            shrink = height * 0.01;
            lstbx.Items.Add("You shrink by " + shrink + " per day");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
